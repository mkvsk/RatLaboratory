using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestDBapp;
using System.Data.Sql;
using RAT_Lab;
using static TestDBapp.FormMain;
using static RAT_Lab.DataBank;

namespace DataBaseApp
{	
	public partial class FormLogIn : Form
	{
		private int stepNumber = 1;
		private int loginAttempt = 0;

		public FormLogIn()
		{
			InitializeComponent();
		}

		private void buttonNextStep_diactivate()
		{
			buttonNextStep.Enabled = false;
			buttonNextStep.BackColor = colorButtonDiactivateBG;
		}

		private void buttonNextStep_activate()
		{
			buttonNextStep.Enabled = true;
			buttonNextStep.BackColor = colorButtonActivateBG;
		}

		private void buttonNextStep_Click(object sender, EventArgs e)
		{
			if (stepNumber == 1)
			{	
				username = textBoxDataToEnter.Text;

				if ((!(username.Equals(USERNAME_P)) || (username.Equals(INFO_ENTER_USERNAME))))
				{
					textBoxDataToEnter.Text = ERROR_TRY_AGAIN;
					textBoxDataToEnter.ForeColor = darkRed;
					buttonNextStep_diactivate();
				}
				else if (username.Equals(USERNAME_P))
				{
					textBoxDataToEnter.Text = EMPTY_STRING;
					stepNumber = 2;
					textBoxDataToEnter.Text = INFO_ENTER_PASSWORD;
					textBoxDataToEnter.ForeColor = lightGrey;
					pictureBoxPassword.Visible = true;
					buttonNextStep_diactivate();
				}
			}
			else if (stepNumber == 2)
			{
				if(loginAttempt > 0)
                {
					captcha();
				}

				if (password.Equals(PASSWORD_P))
				{
					stepNumber = 3;
					loginAttempt = 0;
					openDB();
				}
				else
				{
					textBoxDataToEnter.Text = ERROR_INCORRECT_PASSWORD;
					textBoxDataToEnter.ForeColor = darkRed;
					textBoxDataToEnter.UseSystemPasswordChar = false;
					buttonNextStep_diactivate();

					stepNumber = 2;
					loginAttempt++;
				}
			}
		}

		private async void captcha()
        {
			panelCaptcha.Visible = true;

			if (loginAttempt >= 1)
			{
				labelOneMoreStep.ForeColor = darkRed;
				labelOneMoreStep.Text = "The entrance will be unlocked after 10 seconds.";
				btnCheckCaptcha.Visible = false;
				btnRefreshCaptcha.Visible = false;
				labelCaptcha.Visible = false;
				labelMessage.Visible = false;


				/*btnCheckCaptcha.Visible = true;
				btnRefreshCaptcha.Visible = true;
				panelCaptcha.Visible = false;*/


				await Task.Run(() =>
				{
					Thread.Sleep(5000);
				});
				;

				panelCaptcha.Visible = false;
				stepNumber = 1;

				btnCheckCaptcha.Visible = true;
				btnRefreshCaptcha.Visible = true;
				labelCaptcha.Visible = true;
				labelMessage.Visible = true;

			}

			txtEnterCaptchaHere.ForeColor = lightGrey;
			txtEnterCaptchaHere.Text = ENTER_CAPTCHA_HERE;

			generateCaptcha();

			btnCheckCaptcha.Enabled = false;
			btnCheckCaptcha.BackColor = colorButtonDiactivateBG;
		}

		private void generateCaptcha()
		{
			Random rand = new Random();
			int num = rand.Next(6, 8);
			string cptch = "";
			int total = 0;
			do
			{
				int chr = rand.Next(48, 123);

				if ((chr >= 48 && chr <= 57)
					|| (chr >= 65 && chr <= 90)
					|| (chr >= 97 && chr <= 122))
				{
					cptch += (char)chr;
					total++;

					if (total == num)
					{
						break;
					}
				}
			} while (true);

			labelCaptcha.Text = cptch;
		}


		/*
				private async void showLoader()
				{
					labelLog.Visible = false;
					panelDataToEnter.Visible = false;
					buttonNextStep.Visible = false;

					await Task.Delay(1000);

					labelLog.Visible = true;
					panelDataToEnter.Visible = true;
					buttonNextStep.Visible = true;



				}*/
		/*
		 if (loginAttempt >= 1)
                {
					//MessageBox.Show("await 10 seconds to try again");
					labelLog.Text = "await 10 seconds to try again";
					textBoxDataToEnter.Enabled = false;
					buttonNextStep.Enabled = false;

					Thread.Sleep(10000);
					await Task.Delay(10000);

					labelLog.Text = "try again";
					textBoxDataToEnter.Enabled = false;
					buttonNextStep.Enabled = false;
				}
		 */

		private void openDB()
		{
			this.Hide();
			FormMain formMain = new FormMain();
			formMain.Show();
		}

		private void textBoxDataToEnter_Click(object sender, EventArgs e)
		{

			if (textBoxDataToEnter.Text.Equals(INFO_ENTER_USERNAME)
				|| textBoxDataToEnter.Text.Equals(ERROR_TRY_AGAIN)
				|| textBoxDataToEnter.Text.Equals(INFO_ENTER_PASSWORD)
				|| textBoxDataToEnter.Text.Equals(ERROR_INCORRECT_PASSWORD))
			{
				if (stepNumber == 1)
				{
					textBoxDataToEnter.Text = EMPTY_STRING;
					textBoxDataToEnter.ForeColor = colorButtonActivateBG;
				}
				else if (stepNumber == 2)
				{
					textBoxDataToEnter.Text = EMPTY_STRING;
					textBoxDataToEnter.ForeColor = colorButtonActivateBG;
					textBoxDataToEnter.UseSystemPasswordChar = true;
				}
			}

		}

		private void textBoxDataToEnter_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!((e.KeyChar >= 'A' && e.KeyChar <= 'Z') 
				|| (e.KeyChar >= 'a' && e.KeyChar <= 'z') 
				|| (e.KeyChar >= '0' && e.KeyChar <= '9') 
				|| e.KeyChar == '_' 
				|| e.KeyChar == (char)Keys.Back))
			{
				e.Handled = true;
			}
		}

		private void textBoxDataToEnter_TextChanged(object sender, EventArgs e)
		{
			username = textBoxDataToEnter.Text;
			password = textBoxDataToEnter.Text;

			if (username.Length > 2 || password.Length > 2)
			{
				buttonNextStep_activate();
			}
			else if (username.Length <= 2 || password.Length <= 2)
			{
				buttonNextStep_diactivate();
			}
		}

		private void textBoxDataToEnter_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				buttonNextStep.Focus();
				buttonNextStep_Click(sender, e);               
			}
		}

		private void FormLogIn_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void FormLogIn_Load(object sender, EventArgs e)
		{
			buttonNextStep_diactivate();
			panelCaptcha.Visible = false;
			loginAttempt = 0;
		}

		public class User
		{
			string username;
			string password;
			string access_key;

			public User(
				string username,
				string password,
				string accessKey
				)
			{
				this.username = username;
				this.password = password;
				this.access_key = accessKey;
			}

			public string getUsername()
			{
				return username;
			}

			public string getPassword()
            {
				return password;
            }

			public string getAccessKey()
            {
				return access_key;
            }

		}

        private void btnCheckCaptcha_Click(object sender, EventArgs e)
        {
			if (labelCaptcha.Text == txtEnterCaptchaHere.Text)
			{
				if (stepNumber == 3)
				{
                    FormMain formMain = new FormMain();
                    formMain.Show();
                    this.Hide();
                }
				if (stepNumber == 1 || stepNumber == 2)
				{
					stepNumber = 1;
					loginAttempt++;

					// TO DO ******************************************************

					panelCaptcha.Visible = false;
				}
			}
			if (!(labelCaptcha.Text == txtEnterCaptchaHere.Text))
			{
				labelOneMoreStep.Text = "try again";
				labelOneMoreStep.ForeColor = Color.DarkRed;
				generateCaptcha();
			}
		}

        private void btnRefreshCaptcha_Click(object sender, EventArgs e)
        {
			txtEnterCaptchaHere.ForeColor = bgGrey;
			txtEnterCaptchaHere.Text = ENTER_CAPTCHA_HERE;
			generateCaptcha();
		}

        private void txtEnterCaptchaHere_Click(object sender, EventArgs e)
        {
			txtEnterCaptchaHere.Text = "";
		}

        private void txtEnterCaptchaHere_KeyDown(object sender, KeyEventArgs e)
        {
			txtEnterCaptchaHere.ForeColor = darkGrey;

			if (e.KeyCode == Keys.Enter)
			{
				btnCheckCaptcha.Focus();
				btnCheckCaptcha_Click(sender, e);
			}
		}

        private void txtEnterCaptchaHere_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (txtEnterCaptchaHere.Text.Length >= 5)
			{
				btnCheckCaptcha.Enabled = true;
				btnCheckCaptcha.BackColor = colorButtonActivateBG;
			}
			if (txtEnterCaptchaHere.Text.Length < 5)
			{
				btnCheckCaptcha.Enabled = false;
				btnCheckCaptcha.BackColor = colorButtonDiactivateBG;
			}
		}
    }
}
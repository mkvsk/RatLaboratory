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
using static RAT_Lab.DataBank;

namespace DataBaseApp
{	
	public partial class FormLogIn : Form
	{
		FormMain formMain;
		FormCaptcha formCaptcha;

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

		private async void buttonNextStep_Click(object sender, EventArgs e)
		{	
			
			if (stepNumber == 1)
			{	
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
				if (loginAttempt >= 1)
				{
					openCaptcha();
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


		private void openDB()
		{
			this.Hide();
			FormMain formMain = new FormMain();
			formMain.Show();
		}

		private void openCaptcha()
		{
			this.Hide();
			FormCaptcha formCaptcha = new FormCaptcha();
			formCaptcha.Show();
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
			//this.Hide();
			Application.Exit();
		}

		private void FormLogIn_Load(object sender, EventArgs e)
		{
			buttonNextStep_diactivate();
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
	}
}
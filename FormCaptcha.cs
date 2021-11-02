using DataBaseApp;
using RAT_Lab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestDBapp;
using static RAT_Lab.DataBank;

namespace RAT_Lab
{
    public partial class FormCaptcha : Form
    {
        const string ENTER_CAPTCHA_HERE = "enter captcha here";
        const string EMPTY_STRING = "";

        private static readonly Color darkGrey = Color.FromArgb(73, 80, 87); //темно-серый цвет текста
        private static readonly Color basicBlue = Color.FromArgb(33, 150, 243); // голубой. осн. цвет приложения
        private static readonly Color bgGrey = Color.FromArgb(237, 237, 237); //светло-серый фон формы
        private static readonly Color lightGrey = Color.FromArgb(224, 224, 224); // светло-серый текст

        private static readonly Color colorButtonActivateBG = Color.FromArgb(33, 150, 243); // ВКЛ КНОПКА
        private static readonly Color colorButtonDiactivateBG = Color.FromArgb(108, 117, 125); // ВЫКЛ КНОПКА

        public FormCaptcha()
        {
            InitializeComponent();
        }

        private void FormCaptcha_Load(object sender, EventArgs e)
        {
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
            string captcha = "";
            int total = 0;
            do
            {
                int chr = rand.Next(48, 123);

                if ((chr >= 48 && chr <= 57)
                    || (chr >= 65 && chr <= 90)
                    || (chr >= 97 && chr <= 122))
                {
                    captcha += (char)chr;
                    total++;

                    if (total == num)
                    {
                        break;
                    }
                }
            } while (true);
            labelCaptcha.Text = captcha;
        }

        private void btnCheckCaptcha_Click(object sender, EventArgs e)
        {
            if (labelCaptcha.Text == txtEnterCaptchaHere.Text)
            {   
                if (DataBank.stepNumber == 3)
                {
                    FormMain formMain = new FormMain();
                    formMain.Show();
                    this.Hide();
                }
                if (DataBank.stepNumber == 1 || DataBank.stepNumber == 2)
                {
                    DataBank.stepNumber = 1;
                    DataBank.loginAttempt++;
                    FormLogIn formLogin = new FormLogIn();
                    formLogin.Show();
                    this.Hide();
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
        }
    }
}

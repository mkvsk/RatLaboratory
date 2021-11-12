using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAT_Lab
{
    public static class DataBank
    {
		public static string USERNAME_P = "root";
		public static string PASSWORD_P = "1339";

		public static string EMPTY_STRING = "";
		public static string ERROR_TRY_AGAIN = "try again";
		public static string ERROR_INCORRECT_PASSWORD = "incorrect password try again";
		public static string INFO_ENTER_USERNAME = "enter username";
		public static string INFO_ENTER_PASSWORD = "enter password";
		public static string ENTER_CAPTCHA_HERE = "enter captcha here";

		public static string username;
		public static string password;

		public static readonly Color darkRed = Color.FromArgb(224, 96, 85);
		public static readonly Color basicBlue = Color.FromArgb(33, 150, 243);
		public static readonly Color bgGrey = Color.FromArgb(237, 237, 237);
		public static readonly Color lightGrey = Color.FromArgb(233, 236, 239);
		public static readonly Color darkGrey = Color.FromArgb(73, 80, 87); //темно-серый цвет лейблов

		public static readonly Color colorButtonActivateBG = Color.FromArgb(33, 150, 243); 
		public static readonly Color colorButtonDiactivateBG = Color.FromArgb(108, 117, 125);
		
		public static string menuSection = "services";
	}
}

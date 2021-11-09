using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using RAT_Lab;
using static RAT_Lab.DataBank;
using DataBaseApp;
using System.Threading;
using Microsoft.EntityFrameworkCore;

namespace TestDBapp
{
	public partial class FormMain : Form
	{	
		//private int idToChange;

		Service service = new Service();

		public FormMain()
		{
			InitializeComponent();
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			labelSpeciality.Text = "Department";
			labelFullName.Text = "EmployeeFullName";
			//labelSpeciality.Text = DataBank.username;
			//labelFullName.Text = DataBank.password;

			LoadData();
		}

        private void buttonLogout_Click(object sender, EventArgs e)
        {
			this.Hide();
			FormLogIn formLogIn = new FormLogIn();
			formLogIn.Show();
		}

        private void btnClients_Click(object sender, EventArgs e)
        {
			panelMainMenu.Visible = false;
			panelBtnClients.Visible = true;
		}

		private void btnBackToMenu_Click(object sender, EventArgs e)
        {				
			panelBtnClients.Visible = false;
			panelMainMenu.Visible = true;

			if (panelAccounts.Visible)
            {
				panelAccounts.Visible = false;
				dgvAccounts.Visible = false;
			}
		}


		void LoadData()
        {
			dgvServices.AutoGenerateColumns = false;
            using (LaboratoryEntities db = new LaboratoryEntities())
            {
                dgvServices.DataSource = db.Services.ToList<Service>();
            }
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
			panelAccounts.Visible = true;
			dgvServices.Visible = false;

			dgvAccounts.Visible = true;
			dgvAccounts.AutoGenerateColumns = false;
			using (LaboratoryEntities db = new LaboratoryEntities())
			{
				dgvAccounts.DataSource = db.Accounts.ToList<Account>();
			}
		}
    }
}

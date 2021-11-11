using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using RAT_Lab;
using static RAT_Lab.DataBank;
using DataBaseApp;
using System.Threading;
using Microsoft.EntityFrameworkCore;


namespace TestDBapp
{
	public partial class FormMain : Form
	{	
		Service service = new Service();
		Account account = new Account();
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

			LoadServices();
			ClearTxt();
		}

        private void buttonLogout_Click(object sender, EventArgs e)
        {
			this.Hide();
			FormLogIn formLogIn = new FormLogIn();
			formLogIn.Show();
		}

        private void btnClients_Click(object sender, EventArgs e)
        {
			FormClients formClients = new FormClients();
			formClients.Show();			
		}

		private void btnBackToMenu_Click(object sender, EventArgs e)
        {				
			btnBackToMenu.Enabled = false;
			panelMainMenu.Visible = true;
			dgvServices.Visible = true;

			if (panelAccounts.Visible)
            {
				panelAccounts.Visible = false;
				dgvAccounts.Visible = false;
			}
		}

		private void LoadAccounts()
        {
			using (LaboratoryEntities db = new LaboratoryEntities())
			{
				dgvAccounts.DataSource = db.Accounts.ToList<Account>();
			}
		}

		private void LoadServices()
        {
			dgvServices.AutoGenerateColumns = false;
            using (LaboratoryEntities db = new LaboratoryEntities())
            {
                dgvServices.DataSource = db.Services.ToList<Service>();
            }
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
			btnBackToMenu.Enabled = true;

			panelAccounts.Visible = true;
			dgvServices.Visible = false;

			dgvAccounts.Visible = true;
			dgvAccounts.AutoGenerateColumns = false;

			LoadAccounts();
		}


		private void ClearTxt()
		{
			txtIP.Text = string.Empty;
			txtID.Text = string.Empty;
			textBox3.Text = string.Empty;
			txtLogin.Text = string.Empty;
			txtPass.Text = string.Empty;
			txtWasOnline.Text = string.Empty;
			

			btnSave.Text = "SAVE";
			account.PK_AccountId = 0;
		}

        private void btnSave_Click(object sender, EventArgs e)
        {
			account.PK_AccountId = int.Parse(txtID.Text);
			//account.tbAccessLevel = lbAccessLvl.Items;
			account.UQ_AccountLogin = txtLogin.Text;
			account.AccountPass = txtPass.Text;
			account.AccountIpAddress = txtPass.Text;
			account.AccountLastEnter = DateTime.Parse(txtWasOnline.Text);

			using (LaboratoryEntities db = new LaboratoryEntities())
			{
				if (btnSave.Text == "UPDATE")
                {
					db.Entry(account).State = (System.Data.Entity.EntityState)Microsoft.EntityFrameworkCore.EntityState.Modified;
				}
				if(btnSave.Text == "SAVE")
                {
					db.Accounts.Add(account);
				}
				db.SaveChanges();
			}
			ClearTxt();
			MessageBox.Show("SAVED");
		}

        private void dgvAccounts_DoubleClick(object sender, EventArgs e)
        {
			panelCRUD.Visible = true;
			if (dgvAccounts.CurrentRow.Index != -1)
			{
				account.PK_AccountId = Convert.ToInt32(dgvAccounts.CurrentRow.Cells["PK_AccountId"].Value);
				using (LaboratoryEntities db = new LaboratoryEntities())
				{
					account = db.Accounts.Where(x => x.PK_AccountId == account.PK_AccountId).FirstOrDefault();
					
					txtID.Text = account.PK_AccountId.ToString();
					textBox3.Text = account.FK_AccountAccessLevel.ToString();
					txtLogin.Text = account.UQ_AccountLogin;
					txtPass.Text = account.AccountPass;
					txtIP.Text = account.AccountIpAddress;
					txtWasOnline.Text = account.AccountLastEnter.ToString();
				}
				btnSave.Text = "UPDATE";
				btnDelete.Enabled = true;
			}
		}

        private void btnCloseRowAccount_Click(object sender, EventArgs e)
        {
			panelCRUD.Visible = false;
        }
    }
}

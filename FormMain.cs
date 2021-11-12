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


namespace TestDBapp
{
	public partial class FormMain : Form
	{	
		Service service = new Service();
		Account account = new Account();

		AccessLevel accessLevel = new AccessLevel();
		InsuranceСompanies insurance = new InsuranceСompanies();
		FinancialDep financial = new FinancialDep();
		Analyzer analyzer = new Analyzer();
		Order order = new Order();

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
			btnServices_Click(sender, e);
		}


		private void LoadServices()
        {
			dgvServices.AutoGenerateColumns = false;
            using (LaboratoryEntities db = new LaboratoryEntities())
            {
                dgvServices.DataSource = db.Services.ToList<Service>();
            }
        }

		private void LoadAccounts()
        {
			dgvAccounts.AutoGenerateColumns = false;
			using (LaboratoryEntities db = new LaboratoryEntities())
			{
				dgvAccounts.DataSource = db.Accounts.ToList<Account>();
			}
		}

		private void LoadAccessLevels()
		{
			//dgv.AutoGenerateColumns = false;
			using (LaboratoryEntities db = new LaboratoryEntities())
			{
				//dgv.DataSource = db.AccessLevels.ToList<AccessLevel>();
			}
		}

		private void btnAccounts_Click(object sender, EventArgs e)
        {
			menuSection = "accounts";

			btnBackToMenu.Enabled = true;
			btnAddNew.Visible = true;

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
			btnSave.Enabled = false;

			btnSave.Text = "SAVE";
		}

        private void btnSave_Click(object sender, EventArgs e)
        {
			account.PK_AccountId = int.Parse(txtID.Text);
			
			if (!(lbAccessLvl.SelectedIndex.Equals(-1)))
            {
				account.tbAccessLevel = int.Parse(lbAccessLvl.SelectedItem.ToString());
			}
			//account.tbAccessLevel = lbAccessLvl.Items;
			account.UQ_AccountLogin = txtLogin.Text;
			account.AccountPass = txtPass.Text;
			account.AccountIpAddress = txtPass.Text;
			account.AccountLastEnter = dtpWasOnline.Value;

			using (LaboratoryEntities db = new LaboratoryEntities())
			{
				if (btnSave.Text == "UPDATE")
                {
					db.Entry(account).State = EntityState.Modified;
				}
				if(btnSave.Text == "SAVE")
                {
					db.Accounts.Add(account);
				}
				db.SaveChanges();
			}
			LoadAccounts();
			ClearTxt();
			MessageBox.Show("SAVED");
			panelCRUDaccounts.Visible = false;
		}

        private void dgvAccounts_DoubleClick(object sender, EventArgs e)
        {
			btnSave.Text = "UPDATE";
			panelCRUDaccounts.Visible = true;
			if (dgvAccounts.CurrentRow.Index != -1)
			{
				account.PK_AccountId = Convert.ToInt32(dgvAccounts.CurrentRow.Cells["PK_AccountId"].Value);
				using (LaboratoryEntities db = new LaboratoryEntities())
				{
					account = db.Accounts.Where(x => x.PK_AccountId == account.PK_AccountId).FirstOrDefault();
					
					txtID.Text = account.PK_AccountId.ToString();
					lbAccessLvl.SelectedItem = account.FK_AccountAccessLevel.ToString();
					txtLogin.Text = account.UQ_AccountLogin;
					txtPass.Text = account.AccountPass;
					txtIP.Text = account.AccountIpAddress;
					dtpWasOnline.Value = (DateTime)account.AccountLastEnter;
				}
				btnDelete.Enabled = true;
			}
		}

        private void btnCloseRowAccount_Click(object sender, EventArgs e)
        {
			panelCRUDaccounts.Visible = false;
        }

        private void btnAddNewAccount_Click(object sender, EventArgs e)
        {
			ClearTxt();
			panelCRUDaccounts.Visible = true;
		}

        private void btnDelete_Click(object sender, EventArgs e)
        {
			if (MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				using (LaboratoryEntities db = new LaboratoryEntities())
				{
					var entry = db.Entry(account);
					if (entry.State == EntityState.Detached)
					{
						db.Accounts.Attach(account);
						db.Accounts.Remove(account);
						db.SaveChanges();
						LoadAccounts(); 
						ClearTxt();
						MessageBox.Show("Account deleted");
					}
				}
			}
			panelCRUDaccounts.Visible = false;
		}

        private void btnServices_Click(object sender, EventArgs e)
        {
			menuSection = "services";
			btnBackToMenu.Enabled = false;
			btnAddNew.Visible = false;
			panelMainMenu.Visible = true;
			dgvServices.Visible = true;
			LoadServices();

			if (panelAccounts.Visible)
			{
				panelAccounts.Visible = false;
				panelCRUDaccounts.Visible = false;
				dgvAccounts.Visible = false;
			}
		}

        private void btnReload_Click(object sender, EventArgs e)
        {
			if (menuSection == "services")
			{
				LoadServices();
			}
			if (menuSection == "accounts")
            {
				LoadAccounts();
			}
			if(menuSection == "access")
            {

            }
			if (menuSection == "unsurance")
			{

			}
			if (menuSection == "reports")
			{

			}
			if (menuSection == "analyzer")
			{

			}
			if (menuSection == "orders")
			{

			}
		}
    }
}

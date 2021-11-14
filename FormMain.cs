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

		private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			labelSpeciality.Text = "Department";
			labelFullName.Text = "EmployeeFullName";
			//labelSpeciality.Text = DataBank.username;
			//labelFullName.Text = DataBank.password;

			LoadServices();
			ClearAccountTxt();
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
			dgvAccessLvls.AutoGenerateColumns = false;
			using (LaboratoryEntities db = new LaboratoryEntities())
			{
				dgvAccessLvls.DataSource = db.AccessLevels.ToList<AccessLevel>();
			}
		}

		private void LoadInsuranceComp()
        {
			dgvInsurance.AutoGenerateColumns = false;
			using (LaboratoryEntities db = new LaboratoryEntities())
            {
				dgvInsurance.DataSource = db.InsuranceСompanies.ToList<InsuranceСompanies>();
            }
        }

		private void btnAccounts_Click(object sender, EventArgs e)
        {
			menuSection = "accounts";

			btnBackToMenu.Enabled = true;
			btnAddNew.Enabled = true;
			btnAddNew.Visible = true;

			panelAccounts.Visible = true;
			dgvServices.Visible = false;
			dgvInsurance.Visible = false;
			
			dgvAccounts.Visible = true;

			LoadAccounts();
		}

		private void ClearAccountTxt()
		{
			txtIP.Text = string.Empty;
			txtID.Text = string.Empty;
			lbAccessLvl.SelectedIndex = -1;
			textBox3.Text = string.Empty;
			txtLogin.Text = string.Empty;
			txtPass.Text = string.Empty;
			dtpWasOnline.Value = DateTime.Now;

			btnSaveUpdateAccount.Enabled = false;
			btnClearAccountTxt.Enabled = false; 
			btnSaveUpdateAccount.Text = "SAVE";
		}

		private void ClearInsuranceTxt()
        {
			txtPKCompName.Text = string.Empty;
			txtCompAddress.Text = string.Empty;
			txtCompINN.Text = string.Empty;
			txtCompBill.Text = string.Empty;
			txtCompBIK.Text = string.Empty;

			btnSaveUpdateComp.Enabled = false;
			btnClearCompanyTxt.Enabled = false;
			btnSaveUpdateComp.Text = "SAVE";
		}

		private void btnSave_Click(object sender, EventArgs e)
        {
			account.PK_AccountId = int.Parse(txtID.Text);
			
			if (!(lbAccessLvl.SelectedIndex.Equals(-1)))
            {
                account.FK_AccountAccessLevel = int.Parse(lbAccessLvl.SelectedItem.ToString());
			}
			account.UQ_AccountLogin = txtLogin.Text;
			account.AccountPass = txtPass.Text;
			account.AccountIpAddress = txtIP.Text;
			account.AccountLastEnter = dtpWasOnline.Value;

			using (LaboratoryEntities db = new LaboratoryEntities())
			{
				if (btnSaveUpdateAccount.Text == "UPDATE")
                {
					db.Entry(account).State = EntityState.Modified;
				}
				if(btnSaveUpdateAccount.Text == "SAVE")
                {
					db.Accounts.Add(account);
				}
				db.SaveChanges();
			}
			LoadAccounts();
			ClearAccountTxt();
			MessageBox.Show("SAVED");
			panelCRUDaccounts.Visible = false;
		}

        private void dgvAccounts_DoubleClick(object sender, EventArgs e)
        {
			btnSaveUpdateAccount.Text = "UPDATE";
			btnClearAccountTxt.Enabled = true;
			btnSaveUpdateAccount.Enabled = true;
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
				btnDeleteAccount.Enabled = true;
			}
		}

        private void btnCloseRowAccount_Click(object sender, EventArgs e)
        {
			panelCRUDaccounts.Visible = false;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {	
			if (menuSection == "accounts")
            {
				ClearAccountTxt();
				btnSaveUpdateAccount.Text = "SAVE";
				panelCRUDaccounts.Visible = true;
			}
			if (menuSection == "insurance")
			{
				ClearInsuranceTxt();
				btnSaveUpdateComp.Text = "SAVE";
				panelCRUDinsurance.Visible = true;
			}
			
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
						ClearAccountTxt();
						MessageBox.Show("Account deleted");
					}
				}
			}
			panelCRUDaccounts.Visible = false;
		}

        private void btnServices_Click(object sender, EventArgs e)
        {
			btnBackToMenu.Enabled = false;
			btnAddNew.Visible = false;
			panelMainMenu.Visible = true;
			dgvServices.Visible = true;
			LoadServices();

			if (menuSection == "accounts")
			{
				panelAccounts.Visible = false;
				panelCRUDaccounts.Visible = false;
				dgvAccounts.Visible = false;				
			}
			if (menuSection == "access")
			{
				dgvAccessLvls.Visible = false;
				txtDescriptionEdit.Visible = false;
				txtDescriptionEdit.Enabled = false;
			}
			if (menuSection == "insurance")
            {
				dgvInsurance.Visible = false;
            }
			btnAddNew.Visible = false;

			menuSection = "services";
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
				LoadAccessLevels();
            }
			if (menuSection == "insurance")
			{
				LoadInsuranceComp();
			}
			if (menuSection == "reports")
			{
				//LoadReports();
			}
			if (menuSection == "analyzer")
			{
				//LoadAnalyzer();
			}			
		}

        private void btnAccess_Click(object sender, EventArgs e)
        {
			menuSection = "access";

			btnAddNew.Enabled = false;
			btnBackToMenu.Enabled = true;
			dgvAccessLvls.Visible = true;
			
			dgvServices.Visible = false;
			dgvAccounts.Visible = false;
			dgvInsurance.Visible = false;

			txtDescriptionEdit.Enabled = false;
			txtDescriptionEdit.Visible = true;
			LoadAccessLevels();
		}

        private void dgvAccessLvls_DoubleClick(object sender, EventArgs e)
        {
			txtDescriptionEdit.Enabled = true;
			labelDecript.Visible = true;
			if (dgvAccessLvls.CurrentRow.Index != -1)
            {
				accessLevel.PK_AccessLevel = Convert.ToInt32(dgvAccessLvls.CurrentRow.Cells["PK_AccessLevel"].Value);
				using (LaboratoryEntities db = new LaboratoryEntities())
                {
					accessLevel = db.AccessLevels.Where(x => x.PK_AccessLevel == accessLevel.PK_AccessLevel).FirstOrDefault();
					txtDescriptionEdit.Text = accessLevel.AccessLevelDescription;
				}
			}
		}

        private void txtDescriptionEdit_KeyDown(object sender, KeyEventArgs e)
        {
			if (e.KeyCode == Keys.Enter)
			{
				accessLevel.AccessLevelDescription = txtDescriptionEdit.Text;
				using (LaboratoryEntities db = new LaboratoryEntities())
                {
					db.Entry(accessLevel).State = EntityState.Modified;
					db.SaveChanges();
                }
				MessageBox.Show("changes saved");
				LoadAccessLevels();
				txtDescriptionEdit.Text = string.Empty;
				txtDescriptionEdit.Enabled = false;
			}
			if(e.KeyCode == Keys.Escape)
            {
				txtDescriptionEdit.Text = string.Empty;
				txtDescriptionEdit.Enabled = false;
				MessageBox.Show("changes is not saved");
            }
            labelDecript.Visible = false;		
        }

        private void btnInsurance_Click(object sender, EventArgs e)
        {
			menuSection = "insurance";

			btnAddNew.Visible = true;
			dgvInsurance.Visible = true;
			btnBackToMenu.Enabled = true;

			dgvAccessLvls.Visible = false;
			dgvServices.Visible = false;
			dgvAccounts.Visible = false;

			LoadInsuranceComp();
		}

        private void dgvInsurance_DoubleClick(object sender, EventArgs e)
        {
			btnSaveUpdateComp.Text = "UPDATE";
			panelCRUDinsurance.Visible = true;
			btnClearCompanyTxt.Enabled = true;
			btnSaveUpdateComp.Enabled = true;
			if (dgvInsurance.CurrentRow.Index != -1)
            {
				insurance.CompanyINN = Convert.ToInt32(dgvInsurance.CurrentRow.Cells["CompanyINN"].Value);
				using(LaboratoryEntities db = new LaboratoryEntities())
                {
					insurance = db.InsuranceСompanies.Where(x => x.CompanyINN == insurance.CompanyINN).FirstOrDefault();
					txtPKCompName.Text = insurance.PK_CompanyName;
					txtCompAddress.Text = insurance.CompanyAddress;
					txtCompINN.Text = insurance.CompanyINN.ToString();
					txtCompBill.Text = insurance.CompanyBankBill;
					txtCompBIK.Text = insurance.CompanyBIK;
				}
				btnDeleteComp.Enabled = true;
			}
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
			btnClearAccountTxt.Enabled = true;
			if ((txtID.Text == string.Empty)
				&& (txtLogin.Text == string.Empty)
				&& (txtPass.Text == string.Empty) 
				&& (txtIP.Text == string.Empty))
            {
				btnClearAccountTxt.Enabled = false;
            }
        }

        private void btnPanelCompClose_Click(object sender, EventArgs e)
        {
			panelCRUDinsurance.Visible = false;

        }

        private void btnClearCompanyTxt_Click(object sender, EventArgs e)
        {
			ClearInsuranceTxt();
        }

        private void txtPKCompName_TextChanged(object sender, EventArgs e)
        {
			btnClearCompanyTxt.Enabled = true;
			if ((txtPKCompName.Text == string.Empty)
				&& (txtCompAddress.Text == string.Empty)
				&& (txtCompINN.Text == string.Empty)
				&& (txtCompBill.Text == string.Empty)
				&& (txtCompBIK.Text == string.Empty))
			{
				btnClearCompanyTxt.Enabled = false;
			}			
		}

        private void txtPKCompName_Leave(object sender, EventArgs e)
        {
			if (txtPKCompName.Text == string.Empty)
			{
				btnSaveUpdateComp.Enabled = false;
			}
			if (!(txtPKCompName.Text == string.Empty))
            {
				btnSaveUpdateComp.Enabled = true;
			}
		}

        private void btnSaveUpdateComp_Click(object sender, EventArgs e)
        {
			insurance.PK_CompanyName = txtPKCompName.Text;
			insurance.CompanyAddress = txtCompAddress.Text;
			insurance.CompanyINN = (int)long.Parse(txtCompINN.Text);
			insurance.CompanyBankBill = txtCompBill.Text;
			insurance.CompanyBIK = txtCompBIK.Text;

			using (LaboratoryEntities db = new LaboratoryEntities())
            {
				if (btnSaveUpdateComp.Text == "UPDATE")
				{
					db.Entry(insurance).State = EntityState.Modified;
				}
				if (btnSaveUpdateComp.Text == "SAVE")
				{
					db.InsuranceСompanies.Add(insurance);
				}
				db.SaveChanges();
			}
			LoadInsuranceComp();
			ClearInsuranceTxt();
			MessageBox.Show("SAVED");
			panelCRUDinsurance.Visible = false;
		}

        private void btnDeleteComp_Click(object sender, EventArgs e)
        {
			if (MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				using (LaboratoryEntities db = new LaboratoryEntities())
				{
					var entry = db.Entry(insurance);
					if (entry.State == EntityState.Detached)
					{
						db.InsuranceСompanies.Attach(insurance);
						db.InsuranceСompanies.Remove(insurance);
						db.SaveChanges();
						LoadInsuranceComp();
						ClearInsuranceTxt();
						MessageBox.Show("Company data deleted");
					}
				}
			}
			panelCRUDinsurance.Visible = false;
		}

        private void btnOrders_Click(object sender, EventArgs e)
        {
			//menuSection = "orders";
			FormOrders formOrders = new FormOrders();
			formOrders.Show();
		}
    }
}

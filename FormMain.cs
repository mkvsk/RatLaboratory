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

namespace TestDBapp
{
	public partial class FormMain : Form
	{	
		//private int idToChange;

		Service service = new Service();
		Client client = new Client();

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

		private void activeAbonentsCount()
        {
			/*int counter = 0;
			DataGridViewCheckBoxColumn activityCol = new DataGridViewCheckBoxColumn();
			activityCol.FalseValue = false;

			foreach(DataGridViewRow row in dataGridView.Rows)
            {
				object value = row.Cells[3].Value;
				
				if (value != null && (Boolean)value)
                {
					counter++;
                }
            }
			textBoxActive.Text = counter.ToString();*/
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
			panelClientsSearch.Visible = true;
			panelBtnClients.Visible = true;

			dgvClients.Visible = true;
			dgvClients.AutoGenerateColumns = false;
			using (LaboratoryEntities db = new LaboratoryEntities())
            {
				dgvClients.DataSource = db.Clients.ToList<Client>();
				textBoxTotal.Text = Convert.ToString(db.Clients.Count());
			}
		}

		private void btnBackToMenu_Click(object sender, EventArgs e)
        {				
			panelBtnClients.Visible = false;
			panelMainMenu.Visible = true;
			panelClientsSearch.Visible = false;

			dgvClients.Visible = false;

			if (panelAccounts.Visible)
            {
				panelAccounts.Visible = false;
				dgvAccounts.Visible = false;
			}
		}

        private async void btnAddNewClient_Click(object sender, EventArgs e)
        {
			await Task.Run(() => { Thread.Yield(); });
			FormViewClientData formAddNewClientData = new FormViewClientData();
			formAddNewClientData.Show();
		}

		void LoadData()
        {
			dgvClients.AutoGenerateColumns = false;
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

        public async void dgvAccounts_DoubleClick(object sender, EventArgs e)
        {	
			if(dgvClients.CurrentRow.Index != 1)
            {
				client.PK_ClientPassport = Convert.ToInt32(dgvClients.CurrentRow.Cells["PK_ClientPassport"].Value);
				using (LaboratoryEntities db = new LaboratoryEntities())
				{
					client = db.Clients.Where(x => x.PK_ClientPassport == client.PK_ClientPassport).FirstOrDefault();

					await Task.Run(() => { Thread.Yield(); });
					FormViewClientData formAddNewClientData = new FormViewClientData();
					formAddNewClientData.Show();
				}
			}
			
		}
    }
}

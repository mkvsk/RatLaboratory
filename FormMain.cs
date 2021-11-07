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

		private void totalAbonentsCount()
		{
			/*int amount_abonents = dataGridView.DisplayedRowCount(true);
			textBoxTotal.Text = amount_abonents.ToString();*/
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
			LaboratoryEntities db = new LaboratoryEntities();
			dgvClients.DataSource = db.Clients.ToList<Client>(); //---------------- TABLE CLIENTS------------------------
		}

		private void btnBackToMenu_Click(object sender, EventArgs e)
        {				
			panelBtnClients.Visible = false;
			panelMainMenu.Visible = true;
			panelClientsSearch.Visible = false;

			dgvClients.Visible = false;
		}

        private async void btnAddNewClient_Click(object sender, EventArgs e)
        {
			await Task.Run(() => { Thread.Yield(); });
			FormViewClientData formAddNewClientData = new FormViewClientData();
			formAddNewClientData.Show();
		}

		void LoadData()
        {
            LaboratoryEntities db = new LaboratoryEntities();
			dgvServices.DataSource = db.Services.ToList<Service>();


			/*using (LaboratoryEntities db = new LaboratoryEntities())
            {
                dgvServices.DataSource = db.Services.ToList<Service>();
            }*/
		}
	}
}

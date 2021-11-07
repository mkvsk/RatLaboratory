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
		//SqlConnection sqlConnection;
		//string connectionString = @"Data Source=DESKTOP-1Q2BQKB;Initial Catalog=mts_db;Integrated Security=True";

		public Boolean isRotatedFullName = false;
		public Boolean isFirstClickFullName = true;

		public Boolean isAscendingFullNameColumn = true;
		public Boolean isAscendingPhoneNumberColumn = true;
		public Boolean isAscendingRegistrationDateColumn = true;
		public Boolean isAscendingActivityColumn = true;
		public Boolean isAscendingTariffPlanColumn = true;

		private int idToChange;

		public FormMain()
		{
			InitializeComponent();
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			labelSpeciality.Text = "Department";
			labelFullName.Text = "EmployeeFullName";
			//labelSpeciality.Text = DataBank.username;
			//labelFullName.Text = DataBank.password;
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.abonents". При необходимости она может быть перемещена или удалена.

			//sqlConnection = new SqlConnection(connectionString);

			//await sqlConnection.OpenAsync();

			//totalAbonentsCount();
			//activeAbonentsCount();
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
		}

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
			panelBtnClients.Visible = false;
			panelMainMenu.Visible = true;
			panelClientsSearch.Visible = false;	
		}

        private async void btnAddNewClient_Click(object sender, EventArgs e)
        {
			await Task.Run(() => { Thread.Yield(); });
			FormViewClientData formAddNewClientData = new FormViewClientData();
			formAddNewClientData.Show();
		}
    }
}

/*
 СОРТИРОВКА
 
		private void sortAscending(DataGridViewTextBoxColumn dataColumn, PictureBox pictureBox)
		{	
			dataGridView.Sort(dataColumn, ListSortDirection.Ascending);
			//pictureBox.Image = TestDBapp.Properties.Resources.ascending;
		}

		private void sortDescending(DataGridViewTextBoxColumn dataColumn, PictureBox pictureBox)
		{
			dataGridView.Sort(dataColumn, ListSortDirection.Descending);
			//pictureBox.Image = TestDBapp.Properties.Resources.descending;
		}
 
 */

/*
		private void ButtonEditData_Click(object sender, EventArgs e)
		{
			int index, n;

			string SqlText = "UPDATE [abonents] SET ";


			string full_name2;
			string phone_number_main2;
			string tariff_plan2;
			DateTime registration_date2;
			bool activity2;

			index = dataGridView.CurrentRow.Index;
			full_name2 = dataGridView[0, index].Value.ToString();
			phone_number_main2 = dataGridView[1, index].Value.ToString();
			tariff_plan2 = dataGridView[2, index].Value.ToString();
			registration_date2 = DateTime.Parse(dataGridView[3, index].Value.ToString());
			activity2 = Boolean.Parse(dataGridView[4, index].Value.ToString());

			full_nameTextBox.Text = full_name2;
			phone_number_mainTextBox.Text = phone_number_main2;
			tariff_planTextBox.Text = tariff_plan2;
			registration_dateDateTimePicker.Value = registration_date2;
			activityCheckBox.Checked = activity2;

			if (ShowDialog() == DialogResult.OK)
			{
				full_name2 = full_nameTextBox.Text;
				phone_number_main2 = phone_number_mainTextBox.Text;
				tariff_plan2 = tariff_planTextBox.Text;
				registration_date2 = registration_dateDateTimePicker.Value;
				activity2 = activityCheckBox.Checked;

				SqlText += "full_name = \'" + full_name2 + "\', phone_number_main = \'" + phone_number_main2 + "\', tariff_plan = \'" + tariff_plan2 + "\', registration_date = \'" + registration_date2 + "\', activity = \'" + activity2 + "\'";


				MyExecuteNonQuery(SqlText);
				FillSource();
			}
		}

		private void FillSource()
		{
			string SqlText = "SELECT * FROM [abonents]";
			SqlDataAdapter da = new SqlDataAdapter(SqlText, connectionString);
			DataSet ds = new DataSet();
			da.Fill(ds, "[abonents]");
			dataGridView.DataSource = ds.Tables["[abonents]"].DefaultView;
		}

		public void MyExecuteNonQuery(string SqlText)
		{
			SqlConnection cn; // экземпляр класса типа SqlConnection
			SqlCommand cmd;

			// выделение памяти с инициализацией строки соединения с базой данных
			cn = new SqlConnection(connectionString);
			cn.Open(); // открыть источник данных
			cmd = cn.CreateCommand(); // задать SQL-команду
			cmd.CommandText = SqlText; // задать командную строку
			cmd.ExecuteNonQuery(); // выполнить SQL-команду
			cn.Close(); // закрыть источник данных
		}
*/


/*
		private void ButtonDeleteRow_Click(object sender, EventArgs e)
		{
			if (this.dataGridView.SelectedRows.Count > 0 &&
				this.dataGridView.SelectedRows[0].Index !=
				this.dataGridView.Rows.Count - 1)
			{
				this.dataGridView.Rows.RemoveAt(
				this.dataGridView.SelectedRows[0].Index);
			}
		}*/



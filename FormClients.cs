using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using RAT_Lab;
using TestDBapp;

namespace RAT_Lab
{
    public partial class FormClients : Form
    {
        Client client = new Client();

        public FormClients()
        {
            InitializeComponent();
        }

        private async void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            await Task.Run(() => { Thread.Yield(); });
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTxt();
        }

        void clearTxt()
        {
            txtPassport.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtDOB.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtClientEmail.Text = string.Empty;
            txtINN.Text = string.Empty;
            txtPolicyType.Text = string.Empty;
            txtCompName.Text = string.Empty;
            btnDeleteData.Enabled = false;
        }

        private void FormClients_Load(object sender, EventArgs e)
        {
            LoadClientsData();
        }

        private void LoadClientsData()
        {
            dgvClients.AutoGenerateColumns = false;
            using (LaboratoryEntities db = new LaboratoryEntities())
            {
                dgvClients.DataSource = db.Clients.ToList<Client>();
                textBoxTotal.Text = Convert.ToString(db.Clients.Count());
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {   
            client.PK_ClientPassport = (int)long.Parse(txtPassport.Text);
            client.FK_AccessLevel = 0;
            client.ClientFullName = txtFullName.Text.Trim();
            
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");           
            string dateDOB = txtDOB.Text;
            client.ClientDateOfBirth = DateTime.Parse(dateDOB.Trim());
            
            client.ClientPhoneNumber = txtPhoneNumber.Text.Trim();
            client.ClientEmail = txtClientEmail.Text.Trim();
            client.UQ_ClientInsurancePolicyNumb = (int)long.Parse(txtINN.Text);
            client.ClientInsurancePolicyType = txtPolicyType.Text.Trim();
            //client.FK_ClientInsuranceCompany = txtCompName.Text.Trim();
            
            using (LaboratoryEntities db = new LaboratoryEntities())
            {   
                if (client.PK_ClientPassport == 0)
                {
                    db.Clients.Add(client);
                }
                else
                {
                    db.Entry(client).State = EntityState.Modified;
                }
                db.SaveChanges();
            }
            clearTxt();
            MessageBox.Show("Submitted Successfully");
            LoadClientsData();
            panelCRUD.Visible = false;
        }

        private void dgvClients_DoubleClick(object sender, EventArgs e)
        {
            panelCRUD.Visible = true;
            if (dgvClients.CurrentRow.Index != -1)
            {   
                client.PK_ClientPassport = Convert.ToInt32(dgvClients.CurrentRow.Cells["PK_ClientPassport"].Value);
                using (LaboratoryEntities db = new LaboratoryEntities())
                {
                    client = db.Clients.Where(x => x.PK_ClientPassport == client.PK_ClientPassport).FirstOrDefault();
                    txtFullName.Text = client.ClientFullName;
                    
                    DateTime DOBtoText = (DateTime)client.ClientDateOfBirth;
                    txtDOB.Text = DOBtoText.ToString();

                    txtPhoneNumber.Text = client.ClientPhoneNumber;
                    txtClientEmail.Text = client.ClientEmail;
                    
                    long pk_ClientPassportToText = (long)client.PK_ClientPassport;
                    txtPassport.Text = pk_ClientPassportToText.ToString();
                    
                    long innToText = (long)client.UQ_ClientInsurancePolicyNumb;
                    txtINN.Text = innToText.ToString();

                    txtPolicyType.Text = client.ClientInsurancePolicyType;
                    txtCompName.Text = client.FK_ClientInsuranceCompany;
                }
                btnSaveData.Text = "UPDATE";
                btnDeleteData.Enabled = true;
            }
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            panelCRUD.Visible = true;
            clearTxt();
            btnSaveData.Text = "SAVE";
            btnDeleteData.Enabled = false;
            btnEditData.Enabled = false;
            btnClear.Enabled = false;
        }

        private void textBoxes_TextChanged(object sender, EventArgs e)
        {
            btnClear.Enabled = true;

            if (txtDOB.Text.Length == 2)
            {
                txtDOB.Text += "/";
                
            }
            if (txtDOB.Text.Length == 5)
            {
                txtDOB.Text += "/";
            }
        }

        private void btnClosePanelAdd_Click(object sender, EventArgs e)
        {
            panelCRUD.Visible = false;
        }

        private void btnReloadTable_Click(object sender, EventArgs e)
        {
            LoadClientsData();
        }
    }
}

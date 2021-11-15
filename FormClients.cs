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
        public Client client = new Client();

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
            ClearTxt();
        }

        private void ClearTxt()
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

            btnSaveData.Text = "SAVE";
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
            client.ClientFullName = txtFullName.Text;        
            client.ClientDateOfBirth = dtpDOB.Value;
            client.ClientPhoneNumber = txtPhoneNumber.Text;
            client.ClientEmail = txtClientEmail.Text;
            client.UQ_ClientInsurancePolicyNumb = (int)long.Parse(txtINN.Text);
            client.ClientInsurancePolicyType = txtPolicyType.Text;
            //client.FK_ClientInsuranceCompany = txtCompName.Text;

            using (LaboratoryEntities db = new LaboratoryEntities())
            {
                if (btnSaveData.Text == "UPDATE")
                {
                    db.Entry(client).State = EntityState.Modified;
                }
                if (btnSaveData.Text == "SAVE")
                {
                    db.Clients.Add(client);
                }
                db.SaveChanges();
            }
            LoadClientsData();
            ClearTxt();
            MessageBox.Show("Submitted Successfully");
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
                    
                    dtpDOB.Value = (DateTime)client.ClientDateOfBirth;                    

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
            ClearTxt();
            btnSaveData.Text = "SAVE";
            btnDeleteData.Enabled = false;
            btnClear.Enabled = false;
        }

        private void textBoxes_TextChanged(object sender, EventArgs e)
        {
            btnClear.Enabled = true;
        }

        private void btnClosePanelAdd_Click(object sender, EventArgs e)
        {
            panelCRUD.Visible = false;
        }

        private void btnReloadTable_Click(object sender, EventArgs e)
        {
            LoadClientsData();
        }

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (LaboratoryEntities db = new LaboratoryEntities())
                {
                    var entry = db.Entry(client);
                    if (entry.State == EntityState.Detached)
                    {
                        db.Clients.Attach(client);
                        db.Clients.Remove(client);
                        db.SaveChanges();
                        LoadClientsData();
                        ClearTxt();
                        MessageBox.Show("Client deleted");
                    }
                }
            }
            panelCRUD.Visible = false;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearsh.Focus();
                btnSearsh_Click(sender, e);
            }
        }

        private void btnSearsh_Click(object sender, EventArgs e)
        {
            string searchData = txtSearch.Text.Trim();
            using (LaboratoryEntities db = new LaboratoryEntities())
            {
                dgvClients.DataSource = db.Clients.Where(client => client.ClientFullName.Contains(searchData)).ToList();                
            }
        }

        private void txtDOB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9')
               || e.KeyChar == '/' 
               || e.KeyChar == '.'
               || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}

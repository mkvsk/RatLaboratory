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
using RAT_Lab;
using TestDBapp;

namespace RAT_Lab
{
    public partial class FormViewClientData : Form
    {
        Client model = new Client();

        public FormViewClientData()
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

        private void FormViewClientData_Load(object sender, EventArgs e)
        {
            clearTxt();

            /*txtPassport.Text = FormMain.client.PK_ClientPassport;
            txtFullName.Text;
            txtDOB.Text;
            txtPhoneNumber.Text;
            txtClientEmail.Text;
            txtINN.Text;
            txtPolicyType.Text;
            txtCompName.Text;*/

            btnDeleteData.Enabled = true;
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            model.PK_ClientPassport = (int)long.Parse(txtPassport.Text);
            model.FK_AccessLevel = 0;
            model.ClientFullName = txtFullName.Text.Trim();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
            DateTime dateDOB = DateTime.Parse(txtDOB.Text);
            model.ClientDateOfBirth = dateDOB;
            model.ClientPhoneNumber = txtPhoneNumber.Text.Trim();
            model.ClientEmail = txtClientEmail.Text.Trim();
            model.UQ_ClientInsurancePolicyNumb = (int)long.Parse(txtINN.Text);
            model.ClientInsurancePolicyType = txtPolicyType.Text.Trim();
            //model.FK_ClientInsuranceCompany = txtCompName.Text.Trim();
            
            using (LaboratoryEntities db = new LaboratoryEntities())
            {
                db.Clients.Add(model);
                db.SaveChanges();
            }
            clearTxt();
            MessageBox.Show("Submitted Successfully");
        }
    }
}

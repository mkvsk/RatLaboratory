
namespace RAT_Lab
{
    partial class FormClients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClients));
            this.txtPassport = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClientEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtINN = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPolicyType = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCompName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDOB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeleteData = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveData = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.dgvClients = new Guna.UI2.WinForms.Guna2DataGridView();
            this.FK_AccessLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientDateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PK_ClientPassport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UQ_ClientInsurancePolicyNumb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientInsurancePolicyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FK_ClientInsuranceCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelClientsSearch = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnSearsh = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddNewClient = new Guna.UI2.WinForms.Guna2Button();
            this.ShadowPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panelCRUD = new Guna.UI2.WinForms.Guna2Panel();
            this.dtpDOB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnClosePanelAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnReloadTable = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.panelClientsSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.ShadowPanel.SuspendLayout();
            this.panelCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPassport
            // 
            this.txtPassport.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassport.DefaultText = "";
            this.txtPassport.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassport.DisabledState.Parent = this.txtPassport;
            this.txtPassport.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassport.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassport.FocusedState.Parent = this.txtPassport;
            this.txtPassport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.txtPassport.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassport.HoverState.Parent = this.txtPassport;
            this.txtPassport.Location = new System.Drawing.Point(192, 220);
            this.txtPassport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.PasswordChar = '\0';
            this.txtPassport.PlaceholderText = "";
            this.txtPassport.SelectedText = "";
            this.txtPassport.ShadowDecoration.Parent = this.txtPassport;
            this.txtPassport.Size = new System.Drawing.Size(339, 36);
            this.txtPassport.TabIndex = 5;
            this.txtPassport.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            this.txtPassport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDOB_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(31, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Passport:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label3.Location = new System.Drawing.Point(31, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "FullName:";
            // 
            // txtFullName
            // 
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.DefaultText = "";
            this.txtFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.DisabledState.Parent = this.txtFullName;
            this.txtFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.FocusedState.Parent = this.txtFullName;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.txtFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.HoverState.Parent = this.txtFullName;
            this.txtFullName.Location = new System.Drawing.Point(192, 80);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.PlaceholderText = "";
            this.txtFullName.SelectedText = "";
            this.txtFullName.ShadowDecoration.Parent = this.txtFullName;
            this.txtFullName.Size = new System.Drawing.Size(339, 36);
            this.txtFullName.TabIndex = 1;
            this.txtFullName.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label4.Location = new System.Drawing.Point(31, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone number:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.DefaultText = "";
            this.txtPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.DisabledState.Parent = this.txtPhoneNumber;
            this.txtPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.FocusedState.Parent = this.txtPhoneNumber;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.txtPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.HoverState.Parent = this.txtPhoneNumber;
            this.txtPhoneNumber.Location = new System.Drawing.Point(192, 150);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.PlaceholderText = "";
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.ShadowDecoration.Parent = this.txtPhoneNumber;
            this.txtPhoneNumber.Size = new System.Drawing.Size(339, 36);
            this.txtPhoneNumber.TabIndex = 3;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label5.Location = new System.Drawing.Point(31, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email:";
            // 
            // txtClientEmail
            // 
            this.txtClientEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClientEmail.DefaultText = "";
            this.txtClientEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClientEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClientEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClientEmail.DisabledState.Parent = this.txtClientEmail;
            this.txtClientEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClientEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClientEmail.FocusedState.Parent = this.txtClientEmail;
            this.txtClientEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtClientEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.txtClientEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClientEmail.HoverState.Parent = this.txtClientEmail;
            this.txtClientEmail.Location = new System.Drawing.Point(192, 185);
            this.txtClientEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClientEmail.Name = "txtClientEmail";
            this.txtClientEmail.PasswordChar = '\0';
            this.txtClientEmail.PlaceholderText = "";
            this.txtClientEmail.SelectedText = "";
            this.txtClientEmail.ShadowDecoration.Parent = this.txtClientEmail;
            this.txtClientEmail.Size = new System.Drawing.Size(339, 36);
            this.txtClientEmail.TabIndex = 4;
            this.txtClientEmail.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label6.Location = new System.Drawing.Point(31, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "INN:";
            // 
            // txtINN
            // 
            this.txtINN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtINN.DefaultText = "";
            this.txtINN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtINN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtINN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtINN.DisabledState.Parent = this.txtINN;
            this.txtINN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtINN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtINN.FocusedState.Parent = this.txtINN;
            this.txtINN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtINN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.txtINN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtINN.HoverState.Parent = this.txtINN;
            this.txtINN.Location = new System.Drawing.Point(192, 255);
            this.txtINN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtINN.Name = "txtINN";
            this.txtINN.PasswordChar = '\0';
            this.txtINN.PlaceholderText = "";
            this.txtINN.SelectedText = "";
            this.txtINN.ShadowDecoration.Parent = this.txtINN;
            this.txtINN.Size = new System.Drawing.Size(339, 36);
            this.txtINN.TabIndex = 6;
            this.txtINN.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            this.txtINN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDOB_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label7.Location = new System.Drawing.Point(31, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Policy type:";
            // 
            // txtPolicyType
            // 
            this.txtPolicyType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPolicyType.DefaultText = "";
            this.txtPolicyType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPolicyType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPolicyType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPolicyType.DisabledState.Parent = this.txtPolicyType;
            this.txtPolicyType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPolicyType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPolicyType.FocusedState.Parent = this.txtPolicyType;
            this.txtPolicyType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPolicyType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.txtPolicyType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPolicyType.HoverState.Parent = this.txtPolicyType;
            this.txtPolicyType.Location = new System.Drawing.Point(192, 290);
            this.txtPolicyType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPolicyType.Name = "txtPolicyType";
            this.txtPolicyType.PasswordChar = '\0';
            this.txtPolicyType.PlaceholderText = "";
            this.txtPolicyType.SelectedText = "";
            this.txtPolicyType.ShadowDecoration.Parent = this.txtPolicyType;
            this.txtPolicyType.Size = new System.Drawing.Size(339, 36);
            this.txtPolicyType.TabIndex = 7;
            this.txtPolicyType.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label8.Location = new System.Drawing.Point(31, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Insurance company:";
            // 
            // txtCompName
            // 
            this.txtCompName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompName.DefaultText = "";
            this.txtCompName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCompName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCompName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCompName.DisabledState.Parent = this.txtCompName;
            this.txtCompName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCompName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCompName.FocusedState.Parent = this.txtCompName;
            this.txtCompName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCompName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.txtCompName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCompName.HoverState.Parent = this.txtCompName;
            this.txtCompName.Location = new System.Drawing.Point(192, 325);
            this.txtCompName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCompName.Name = "txtCompName";
            this.txtCompName.PasswordChar = '\0';
            this.txtCompName.PlaceholderText = "";
            this.txtCompName.SelectedText = "";
            this.txtCompName.ShadowDecoration.Parent = this.txtCompName;
            this.txtCompName.Size = new System.Drawing.Size(339, 36);
            this.txtCompName.TabIndex = 8;
            this.txtCompName.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // txtDOB
            // 
            this.txtDOB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDOB.DefaultText = "";
            this.txtDOB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDOB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDOB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDOB.DisabledState.Parent = this.txtDOB;
            this.txtDOB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDOB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDOB.FocusedState.Parent = this.txtDOB;
            this.txtDOB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.txtDOB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDOB.HoverState.Parent = this.txtDOB;
            this.txtDOB.Location = new System.Drawing.Point(192, 115);
            this.txtDOB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.PasswordChar = '\0';
            this.txtDOB.PlaceholderText = "";
            this.txtDOB.SelectedText = "";
            this.txtDOB.ShadowDecoration.Parent = this.txtDOB;
            this.txtDOB.Size = new System.Drawing.Size(339, 36);
            this.txtDOB.TabIndex = 2;
            this.txtDOB.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            this.txtDOB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDOB_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label9.Location = new System.Drawing.Point(31, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Date of birth:";
            // 
            // btnDeleteData
            // 
            this.btnDeleteData.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteData.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteData.BorderRadius = 6;
            this.btnDeleteData.CheckedState.Parent = this.btnDeleteData;
            this.btnDeleteData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteData.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteData.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnDeleteData.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDeleteData.CustomImages.Parent = this.btnDeleteData;
            this.btnDeleteData.DisabledState.Parent = this.btnDeleteData;
            this.btnDeleteData.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnDeleteData.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDeleteData.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteData.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteData.HoverState.Parent = this.btnDeleteData;
            this.btnDeleteData.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteData.Location = new System.Drawing.Point(309, 386);
            this.btnDeleteData.Name = "btnDeleteData";
            this.btnDeleteData.PressedColor = System.Drawing.Color.Red;
            this.btnDeleteData.ShadowDecoration.Parent = this.btnDeleteData;
            this.btnDeleteData.Size = new System.Drawing.Size(105, 36);
            this.btnDeleteData.TabIndex = 66;
            this.btnDeleteData.Tag = "";
            this.btnDeleteData.Text = "DELETE";
            this.btnDeleteData.Click += new System.EventHandler(this.btnDeleteData_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveData.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaveData.BorderRadius = 6;
            this.btnSaveData.CheckedState.Parent = this.btnSaveData;
            this.btnSaveData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveData.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveData.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnSaveData.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSaveData.CustomImages.Parent = this.btnSaveData;
            this.btnSaveData.DisabledState.Parent = this.btnSaveData;
            this.btnSaveData.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSaveData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaveData.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.btnSaveData.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSaveData.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaveData.HoverState.Parent = this.btnSaveData;
            this.btnSaveData.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSaveData.Location = new System.Drawing.Point(426, 386);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.PressedColor = System.Drawing.Color.Green;
            this.btnSaveData.ShadowDecoration.Parent = this.btnSaveData;
            this.btnSaveData.Size = new System.Drawing.Size(105, 36);
            this.btnSaveData.TabIndex = 67;
            this.btnSaveData.Tag = "";
            this.btnSaveData.Text = "SAVE";
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.BorderColor = System.Drawing.Color.Silver;
            this.btnClear.BorderRadius = 6;
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClear.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnClear.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.DisabledState.Parent = this.btnClear;
            this.btnClear.Enabled = false;
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnClear.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnClear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnClear.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClear.Location = new System.Drawing.Point(192, 386);
            this.btnClear.Name = "btnClear";
            this.btnClear.PressedColor = System.Drawing.Color.White;
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(105, 36);
            this.btnClear.TabIndex = 69;
            this.btnClear.Tag = "";
            this.btnClear.Text = "CLEAR";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AllowUserToResizeColumns = false;
            this.dgvClients.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClients.BackgroundColor = System.Drawing.Color.White;
            this.dgvClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClients.ColumnHeadersHeight = 60;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FK_AccessLevel,
            this.ClientFullName,
            this.ClientDateOfBirth,
            this.ClientPhoneNumber,
            this.ClientEmail,
            this.PK_ClientPassport,
            this.UQ_ClientInsurancePolicyNumb,
            this.ClientInsurancePolicyType,
            this.FK_ClientInsuranceCompany});
            this.dgvClients.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClients.EnableHeadersVisualStyles = false;
            this.dgvClients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvClients.Location = new System.Drawing.Point(20, 59);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClients.RowHeadersVisible = false;
            this.dgvClients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvClients.RowTemplate.Height = 40;
            this.dgvClients.RowTemplate.ReadOnly = true;
            this.dgvClients.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(1323, 589);
            this.dgvClients.TabIndex = 0;
            this.dgvClients.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.dgvClients.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvClients.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvClients.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvClients.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvClients.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvClients.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvClients.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvClients.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvClients.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClients.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dgvClients.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvClients.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClients.ThemeStyle.HeaderStyle.Height = 60;
            this.dgvClients.ThemeStyle.ReadOnly = true;
            this.dgvClients.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgvClients.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClients.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgvClients.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvClients.ThemeStyle.RowsStyle.Height = 40;
            this.dgvClients.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvClients.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvClients.DoubleClick += new System.EventHandler(this.dgvClients_DoubleClick);
            // 
            // FK_AccessLevel
            // 
            this.FK_AccessLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FK_AccessLevel.DataPropertyName = "FK_AccessLevel";
            this.FK_AccessLevel.FillWeight = 5F;
            this.FK_AccessLevel.HeaderText = "FK_AccessLevel";
            this.FK_AccessLevel.Name = "FK_AccessLevel";
            this.FK_AccessLevel.ReadOnly = true;
            this.FK_AccessLevel.Visible = false;
            this.FK_AccessLevel.Width = 162;
            // 
            // ClientFullName
            // 
            this.ClientFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientFullName.DataPropertyName = "ClientFullName";
            this.ClientFullName.HeaderText = "FULL NAME";
            this.ClientFullName.Name = "ClientFullName";
            this.ClientFullName.ReadOnly = true;
            // 
            // ClientDateOfBirth
            // 
            this.ClientDateOfBirth.DataPropertyName = "ClientDateOfBirth";
            this.ClientDateOfBirth.HeaderText = "DOB";
            this.ClientDateOfBirth.Name = "ClientDateOfBirth";
            this.ClientDateOfBirth.ReadOnly = true;
            // 
            // ClientPhoneNumber
            // 
            this.ClientPhoneNumber.DataPropertyName = "ClientPhoneNumber";
            this.ClientPhoneNumber.HeaderText = "PHONE NUMBER";
            this.ClientPhoneNumber.Name = "ClientPhoneNumber";
            this.ClientPhoneNumber.ReadOnly = true;
            // 
            // ClientEmail
            // 
            this.ClientEmail.DataPropertyName = "ClientEmail";
            this.ClientEmail.HeaderText = "EMAIL";
            this.ClientEmail.Name = "ClientEmail";
            this.ClientEmail.ReadOnly = true;
            // 
            // PK_ClientPassport
            // 
            this.PK_ClientPassport.DataPropertyName = "PK_ClientPassport";
            this.PK_ClientPassport.HeaderText = "PASSPORT";
            this.PK_ClientPassport.Name = "PK_ClientPassport";
            this.PK_ClientPassport.ReadOnly = true;
            // 
            // UQ_ClientInsurancePolicyNumb
            // 
            this.UQ_ClientInsurancePolicyNumb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UQ_ClientInsurancePolicyNumb.DataPropertyName = "UQ_ClientInsurancePolicyNumb";
            this.UQ_ClientInsurancePolicyNumb.HeaderText = "INN";
            this.UQ_ClientInsurancePolicyNumb.Name = "UQ_ClientInsurancePolicyNumb";
            this.UQ_ClientInsurancePolicyNumb.ReadOnly = true;
            // 
            // ClientInsurancePolicyType
            // 
            this.ClientInsurancePolicyType.DataPropertyName = "ClientInsurancePolicyType";
            this.ClientInsurancePolicyType.HeaderText = "POLICY TYPE";
            this.ClientInsurancePolicyType.Name = "ClientInsurancePolicyType";
            this.ClientInsurancePolicyType.ReadOnly = true;
            // 
            // FK_ClientInsuranceCompany
            // 
            this.FK_ClientInsuranceCompany.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FK_ClientInsuranceCompany.DataPropertyName = "FK_ClientInsuranceCompany";
            this.FK_ClientInsuranceCompany.HeaderText = "INSURANCE";
            this.FK_ClientInsuranceCompany.Name = "FK_ClientInsuranceCompany";
            this.FK_ClientInsuranceCompany.ReadOnly = true;
            // 
            // panelClientsSearch
            // 
            this.panelClientsSearch.BackColor = System.Drawing.Color.Transparent;
            this.panelClientsSearch.Controls.Add(this.btnSearsh);
            this.panelClientsSearch.Controls.Add(this.txtSearch);
            this.panelClientsSearch.Controls.Add(this.label2);
            this.panelClientsSearch.Controls.Add(this.labelTotal);
            this.panelClientsSearch.Controls.Add(this.textBoxTotal);
            this.panelClientsSearch.Controls.Add(this.pictureBox6);
            this.panelClientsSearch.Controls.Add(this.label10);
            this.panelClientsSearch.FillColor = System.Drawing.Color.White;
            this.panelClientsSearch.Location = new System.Drawing.Point(13, 12);
            this.panelClientsSearch.Name = "panelClientsSearch";
            this.panelClientsSearch.Radius = 3;
            this.panelClientsSearch.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.panelClientsSearch.ShadowDepth = 50;
            this.panelClientsSearch.ShadowShift = 6;
            this.panelClientsSearch.Size = new System.Drawing.Size(1362, 156);
            this.panelClientsSearch.TabIndex = 71;
            // 
            // btnSearsh
            // 
            this.btnSearsh.BackColor = System.Drawing.Color.Transparent;
            this.btnSearsh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearsh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSearsh.BorderRadius = 6;
            this.btnSearsh.CheckedState.Parent = this.btnSearsh;
            this.btnSearsh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearsh.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearsh.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnSearsh.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSearsh.CustomImages.Parent = this.btnSearsh;
            this.btnSearsh.DisabledState.Parent = this.btnSearsh;
            this.btnSearsh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearsh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearsh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnSearsh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSearsh.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSearsh.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSearsh.HoverState.Parent = this.btnSearsh;
            this.btnSearsh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSearsh.Location = new System.Drawing.Point(1206, 101);
            this.btnSearsh.Name = "btnSearsh";
            this.btnSearsh.PressedColor = System.Drawing.Color.Aqua;
            this.btnSearsh.ShadowDecoration.Parent = this.btnSearsh;
            this.btnSearsh.Size = new System.Drawing.Size(137, 32);
            this.btnSearsh.TabIndex = 68;
            this.btnSearsh.Tag = "";
            this.btnSearsh.Text = "SEARCH";
            this.btnSearsh.Click += new System.EventHandler(this.btnSearsh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtSearch.BorderRadius = 3;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(133, 101);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(1067, 32);
            this.txtSearch.TabIndex = 57;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label2.Location = new System.Drawing.Point(193, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 32);
            this.label2.TabIndex = 50;
            this.label2.Text = "CLIENTS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.labelTotal.Location = new System.Drawing.Point(128, 73);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(63, 25);
            this.labelTotal.TabIndex = 37;
            this.labelTotal.Text = "Total: ";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.AutoSize = true;
            this.textBoxTotal.BackColor = System.Drawing.Color.Transparent;
            this.textBoxTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.textBoxTotal.Location = new System.Drawing.Point(194, 73);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(144, 25);
            this.textBoxTotal.TabIndex = 38;
            this.textBoxTotal.Text = "amount in base";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(21, 41);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 100);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 49;
            this.pictureBox6.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label10.Location = new System.Drawing.Point(126, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 40);
            this.label10.TabIndex = 39;
            this.label10.Text = "N20";
            // 
            // btnAddNewClient
            // 
            this.btnAddNewClient.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewClient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddNewClient.BorderRadius = 6;
            this.btnAddNewClient.CheckedState.Parent = this.btnAddNewClient;
            this.btnAddNewClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewClient.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddNewClient.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnAddNewClient.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddNewClient.CustomImages.Parent = this.btnAddNewClient;
            this.btnAddNewClient.DisabledState.Parent = this.btnAddNewClient;
            this.btnAddNewClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddNewClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNewClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddNewClient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddNewClient.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddNewClient.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddNewClient.HoverState.Parent = this.btnAddNewClient;
            this.btnAddNewClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewClient.Location = new System.Drawing.Point(63, 17);
            this.btnAddNewClient.Name = "btnAddNewClient";
            this.btnAddNewClient.PressedColor = System.Drawing.Color.Lime;
            this.btnAddNewClient.ShadowDecoration.Parent = this.btnAddNewClient;
            this.btnAddNewClient.Size = new System.Drawing.Size(206, 36);
            this.btnAddNewClient.TabIndex = 65;
            this.btnAddNewClient.Tag = "";
            this.btnAddNewClient.Text = "ADD NEW";
            this.btnAddNewClient.Click += new System.EventHandler(this.btnAddNewClient_Click);
            // 
            // ShadowPanel
            // 
            this.ShadowPanel.BackColor = System.Drawing.Color.Transparent;
            this.ShadowPanel.Controls.Add(this.panelCRUD);
            this.ShadowPanel.Controls.Add(this.btnAddNewClient);
            this.ShadowPanel.Controls.Add(this.dgvClients);
            this.ShadowPanel.Controls.Add(this.btnReloadTable);
            this.ShadowPanel.FillColor = System.Drawing.Color.White;
            this.ShadowPanel.Location = new System.Drawing.Point(13, 171);
            this.ShadowPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ShadowPanel.Name = "ShadowPanel";
            this.ShadowPanel.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.ShadowPanel.Radius = 3;
            this.ShadowPanel.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.ShadowPanel.ShadowShift = 6;
            this.ShadowPanel.Size = new System.Drawing.Size(1362, 662);
            this.ShadowPanel.TabIndex = 72;
            // 
            // panelCRUD
            // 
            this.panelCRUD.BackColor = System.Drawing.Color.White;
            this.panelCRUD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelCRUD.BorderThickness = 3;
            this.panelCRUD.Controls.Add(this.dtpDOB);
            this.panelCRUD.Controls.Add(this.btnClosePanelAdd);
            this.panelCRUD.Controls.Add(this.btnSaveData);
            this.panelCRUD.Controls.Add(this.btnDeleteData);
            this.panelCRUD.Controls.Add(this.txtPolicyType);
            this.panelCRUD.Controls.Add(this.btnClear);
            this.panelCRUD.Controls.Add(this.label9);
            this.panelCRUD.Controls.Add(this.txtPassport);
            this.panelCRUD.Controls.Add(this.txtDOB);
            this.panelCRUD.Controls.Add(this.label1);
            this.panelCRUD.Controls.Add(this.label8);
            this.panelCRUD.Controls.Add(this.txtFullName);
            this.panelCRUD.Controls.Add(this.txtCompName);
            this.panelCRUD.Controls.Add(this.label3);
            this.panelCRUD.Controls.Add(this.label7);
            this.panelCRUD.Controls.Add(this.txtPhoneNumber);
            this.panelCRUD.Controls.Add(this.label4);
            this.panelCRUD.Controls.Add(this.label6);
            this.panelCRUD.Controls.Add(this.txtClientEmail);
            this.panelCRUD.Controls.Add(this.txtINN);
            this.panelCRUD.Controls.Add(this.label5);
            this.panelCRUD.Location = new System.Drawing.Point(394, 4);
            this.panelCRUD.Name = "panelCRUD";
            this.panelCRUD.ShadowDecoration.Parent = this.panelCRUD;
            this.panelCRUD.Size = new System.Drawing.Size(564, 447);
            this.panelCRUD.TabIndex = 71;
            this.panelCRUD.Visible = false;
            // 
            // dtpDOB
            // 
            this.dtpDOB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtpDOB.Checked = true;
            this.dtpDOB.CheckedState.Parent = this.dtpDOB;
            this.dtpDOB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDOB.FillColor = System.Drawing.Color.White;
            this.dtpDOB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.HoverState.Parent = this.dtpDOB;
            this.dtpDOB.Location = new System.Drawing.Point(193, 115);
            this.dtpDOB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDOB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.ShadowDecoration.Parent = this.dtpDOB;
            this.dtpDOB.Size = new System.Drawing.Size(337, 36);
            this.dtpDOB.TabIndex = 74;
            this.dtpDOB.Value = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            // 
            // btnClosePanelAdd
            // 
            this.btnClosePanelAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnClosePanelAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClosePanelAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClosePanelAdd.BorderRadius = 6;
            this.btnClosePanelAdd.CheckedState.Parent = this.btnClosePanelAdd;
            this.btnClosePanelAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosePanelAdd.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClosePanelAdd.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnClosePanelAdd.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnClosePanelAdd.CustomImages.Parent = this.btnClosePanelAdd;
            this.btnClosePanelAdd.DisabledState.Parent = this.btnClosePanelAdd;
            this.btnClosePanelAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClosePanelAdd.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClosePanelAdd.ForeColor = System.Drawing.Color.Red;
            this.btnClosePanelAdd.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.btnClosePanelAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClosePanelAdd.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClosePanelAdd.HoverState.Parent = this.btnClosePanelAdd;
            this.btnClosePanelAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClosePanelAdd.Location = new System.Drawing.Point(528, 0);
            this.btnClosePanelAdd.Name = "btnClosePanelAdd";
            this.btnClosePanelAdd.PressedColor = System.Drawing.Color.Red;
            this.btnClosePanelAdd.ShadowDecoration.Parent = this.btnClosePanelAdd;
            this.btnClosePanelAdd.Size = new System.Drawing.Size(36, 36);
            this.btnClosePanelAdd.TabIndex = 70;
            this.btnClosePanelAdd.Tag = "";
            this.btnClosePanelAdd.Text = "🗙";
            this.btnClosePanelAdd.TextOffset = new System.Drawing.Point(1, -1);
            this.btnClosePanelAdd.Click += new System.EventHandler(this.btnClosePanelAdd_Click);
            // 
            // btnReloadTable
            // 
            this.btnReloadTable.BackColor = System.Drawing.Color.Transparent;
            this.btnReloadTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReloadTable.BorderColor = System.Drawing.Color.Transparent;
            this.btnReloadTable.BorderRadius = 6;
            this.btnReloadTable.BorderThickness = 3;
            this.btnReloadTable.CheckedState.Parent = this.btnReloadTable;
            this.btnReloadTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReloadTable.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReloadTable.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnReloadTable.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnReloadTable.CustomImages.Parent = this.btnReloadTable;
            this.btnReloadTable.DisabledState.Parent = this.btnReloadTable;
            this.btnReloadTable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnReloadTable.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReloadTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnReloadTable.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnReloadTable.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnReloadTable.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnReloadTable.HoverState.Parent = this.btnReloadTable;
            this.btnReloadTable.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReloadTable.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnReloadTable.Location = new System.Drawing.Point(21, 17);
            this.btnReloadTable.Name = "btnReloadTable";
            this.btnReloadTable.PressedColor = System.Drawing.Color.Aqua;
            this.btnReloadTable.ShadowDecoration.Parent = this.btnReloadTable;
            this.btnReloadTable.Size = new System.Drawing.Size(36, 36);
            this.btnReloadTable.TabIndex = 67;
            this.btnReloadTable.Tag = "";
            this.btnReloadTable.Text = "⟲";
            this.btnReloadTable.TextOffset = new System.Drawing.Point(0, -2);
            this.btnReloadTable.Click += new System.EventHandler(this.btnReloadTable_Click);
            // 
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1388, 842);
            this.Controls.Add(this.panelClientsSearch);
            this.Controls.Add(this.ShadowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.FormClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.panelClientsSearch.ResumeLayout(false);
            this.panelClientsSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ShadowPanel.ResumeLayout(false);
            this.panelCRUD.ResumeLayout(false);
            this.panelCRUD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtPassport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtClientEmail;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtINN;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtPolicyType;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtCompName;
        private Guna.UI2.WinForms.Guna2TextBox txtDOB;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btnDeleteData;
        private Guna.UI2.WinForms.Guna2Button btnSaveData;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2DataGridView dgvClients;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelClientsSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label textBoxTotal;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ShadowPanel ShadowPanel;
        private Guna.UI2.WinForms.Guna2Button btnReloadTable;
        private Guna.UI2.WinForms.Guna2Button btnAddNewClient;
        private Guna.UI2.WinForms.Guna2Panel panelCRUD;
        private Guna.UI2.WinForms.Guna2Button btnSearsh;
        private Guna.UI2.WinForms.Guna2Button btnClosePanelAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn FK_AccessLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientDateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_ClientPassport;
        private System.Windows.Forms.DataGridViewTextBoxColumn UQ_ClientInsurancePolicyNumb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientInsurancePolicyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FK_ClientInsuranceCompany;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDOB;
    }
}
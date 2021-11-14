
namespace TestDBapp
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle65 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle66 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle67 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle68 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle69 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle70 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle71 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle72 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle73 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle74 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle75 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle76 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle77 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle78 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle79 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle80 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ShadowPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panelCRUDinsurance = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPanelCompClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveUpdateComp = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteComp = new Guna.UI2.WinForms.Guna2Button();
            this.btnClearCompanyTxt = new Guna.UI2.WinForms.Guna2Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCompBIK = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCompAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPKCompName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCompINN = new Guna.UI2.WinForms.Guna2TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCompBill = new Guna.UI2.WinForms.Guna2TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.labelDecript = new System.Windows.Forms.Label();
            this.txtDescriptionEdit = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvInsurance = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvAccessLvls = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PK_AccessLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UQ_AccessLevelType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessLevelDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAccounts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PK_AccountId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FK_AccountAccessLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UQ_AccountLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountIpAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountLastEnter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvServices = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ServiceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceDeadlineInDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceAverageDeviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCRUDaccounts = new Guna.UI2.WinForms.Guna2Panel();
            this.lbAccessLvl = new System.Windows.Forms.ListBox();
            this.btnCloseRowAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveUpdateAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnClearAccountTxt = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIP = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpWasOnline = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panelEmpProfile = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.buttonLogout = new Guna.UI2.WinForms.Guna2Button();
            this.labelSpeciality = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxUserPhoto = new System.Windows.Forms.PictureBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panelMainMenu = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnAccess = new Guna.UI2.WinForms.Guna2Button();
            this.btnInsurance = new Guna.UI2.WinForms.Guna2Button();
            this.btnAccounts = new Guna.UI2.WinForms.Guna2Button();
            this.btnReports = new Guna.UI2.WinForms.Guna2Button();
            this.btnClients = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAnalyzer = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrders = new Guna.UI2.WinForms.Guna2Button();
            this.btnServices = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPotatoCorp = new System.Windows.Forms.Label();
            this.btnBackToMenu = new Guna.UI2.WinForms.Guna2Button();
            this.panelAccounts = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddNew = new Guna.UI2.WinForms.Guna2Button();
            this.btnReload = new Guna.UI2.WinForms.Guna2Button();
            this.PK_CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyINN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyBankBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyBIK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShadowPanel.SuspendLayout();
            this.panelCRUDinsurance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsurance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccessLvls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.panelCRUDaccounts.SuspendLayout();
            this.panelEmpProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPhoto)).BeginInit();
            this.panelMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // ShadowPanel
            // 
            this.ShadowPanel.BackColor = System.Drawing.Color.Transparent;
            this.ShadowPanel.Controls.Add(this.panelCRUDinsurance);
            this.ShadowPanel.Controls.Add(this.labelDecript);
            this.ShadowPanel.Controls.Add(this.txtDescriptionEdit);
            this.ShadowPanel.Controls.Add(this.dgvInsurance);
            this.ShadowPanel.Controls.Add(this.dgvAccessLvls);
            this.ShadowPanel.Controls.Add(this.dgvAccounts);
            this.ShadowPanel.Controls.Add(this.dgvServices);
            this.ShadowPanel.Controls.Add(this.panelCRUDaccounts);
            this.ShadowPanel.FillColor = System.Drawing.Color.White;
            this.ShadowPanel.Location = new System.Drawing.Point(29, 213);
            this.ShadowPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ShadowPanel.Name = "ShadowPanel";
            this.ShadowPanel.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.ShadowPanel.Radius = 3;
            this.ShadowPanel.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.ShadowPanel.ShadowShift = 6;
            this.ShadowPanel.Size = new System.Drawing.Size(1362, 776);
            this.ShadowPanel.TabIndex = 11;
            // 
            // panelCRUDinsurance
            // 
            this.panelCRUDinsurance.BackColor = System.Drawing.Color.White;
            this.panelCRUDinsurance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelCRUDinsurance.BorderThickness = 3;
            this.panelCRUDinsurance.Controls.Add(this.btnPanelCompClose);
            this.panelCRUDinsurance.Controls.Add(this.btnSaveUpdateComp);
            this.panelCRUDinsurance.Controls.Add(this.btnDeleteComp);
            this.panelCRUDinsurance.Controls.Add(this.btnClearCompanyTxt);
            this.panelCRUDinsurance.Controls.Add(this.label10);
            this.panelCRUDinsurance.Controls.Add(this.txtCompBIK);
            this.panelCRUDinsurance.Controls.Add(this.txtCompAddress);
            this.panelCRUDinsurance.Controls.Add(this.label15);
            this.panelCRUDinsurance.Controls.Add(this.txtPKCompName);
            this.panelCRUDinsurance.Controls.Add(this.label16);
            this.panelCRUDinsurance.Controls.Add(this.txtCompINN);
            this.panelCRUDinsurance.Controls.Add(this.label17);
            this.panelCRUDinsurance.Controls.Add(this.txtCompBill);
            this.panelCRUDinsurance.Controls.Add(this.label19);
            this.panelCRUDinsurance.Location = new System.Drawing.Point(402, 170);
            this.panelCRUDinsurance.Name = "panelCRUDinsurance";
            this.panelCRUDinsurance.ShadowDecoration.Parent = this.panelCRUDinsurance;
            this.panelCRUDinsurance.Size = new System.Drawing.Size(564, 422);
            this.panelCRUDinsurance.TabIndex = 74;
            this.panelCRUDinsurance.Visible = false;
            // 
            // btnPanelCompClose
            // 
            this.btnPanelCompClose.BackColor = System.Drawing.Color.Transparent;
            this.btnPanelCompClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPanelCompClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPanelCompClose.BorderRadius = 6;
            this.btnPanelCompClose.CheckedState.Parent = this.btnPanelCompClose;
            this.btnPanelCompClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPanelCompClose.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPanelCompClose.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnPanelCompClose.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPanelCompClose.CustomImages.Parent = this.btnPanelCompClose;
            this.btnPanelCompClose.DisabledState.Parent = this.btnPanelCompClose;
            this.btnPanelCompClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPanelCompClose.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPanelCompClose.ForeColor = System.Drawing.Color.Red;
            this.btnPanelCompClose.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.btnPanelCompClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPanelCompClose.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPanelCompClose.HoverState.Parent = this.btnPanelCompClose;
            this.btnPanelCompClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPanelCompClose.Location = new System.Drawing.Point(528, 0);
            this.btnPanelCompClose.Name = "btnPanelCompClose";
            this.btnPanelCompClose.PressedColor = System.Drawing.Color.Red;
            this.btnPanelCompClose.ShadowDecoration.Parent = this.btnPanelCompClose;
            this.btnPanelCompClose.Size = new System.Drawing.Size(36, 36);
            this.btnPanelCompClose.TabIndex = 70;
            this.btnPanelCompClose.Tag = "";
            this.btnPanelCompClose.Text = "🗙";
            this.btnPanelCompClose.TextOffset = new System.Drawing.Point(1, -1);
            this.btnPanelCompClose.Click += new System.EventHandler(this.btnPanelCompClose_Click);
            // 
            // btnSaveUpdateComp
            // 
            this.btnSaveUpdateComp.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveUpdateComp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveUpdateComp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaveUpdateComp.BorderRadius = 6;
            this.btnSaveUpdateComp.CheckedState.Parent = this.btnSaveUpdateComp;
            this.btnSaveUpdateComp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveUpdateComp.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveUpdateComp.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnSaveUpdateComp.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSaveUpdateComp.CustomImages.Parent = this.btnSaveUpdateComp;
            this.btnSaveUpdateComp.DisabledState.Parent = this.btnSaveUpdateComp;
            this.btnSaveUpdateComp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSaveUpdateComp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveUpdateComp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaveUpdateComp.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.btnSaveUpdateComp.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSaveUpdateComp.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaveUpdateComp.HoverState.Parent = this.btnSaveUpdateComp;
            this.btnSaveUpdateComp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSaveUpdateComp.Location = new System.Drawing.Point(426, 359);
            this.btnSaveUpdateComp.Name = "btnSaveUpdateComp";
            this.btnSaveUpdateComp.PressedColor = System.Drawing.Color.Green;
            this.btnSaveUpdateComp.ShadowDecoration.Parent = this.btnSaveUpdateComp;
            this.btnSaveUpdateComp.Size = new System.Drawing.Size(105, 36);
            this.btnSaveUpdateComp.TabIndex = 67;
            this.btnSaveUpdateComp.Tag = "";
            this.btnSaveUpdateComp.Text = "SAVE";
            this.btnSaveUpdateComp.Click += new System.EventHandler(this.btnSaveUpdateComp_Click);
            // 
            // btnDeleteComp
            // 
            this.btnDeleteComp.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteComp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteComp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteComp.BorderRadius = 6;
            this.btnDeleteComp.CheckedState.Parent = this.btnDeleteComp;
            this.btnDeleteComp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteComp.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteComp.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnDeleteComp.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDeleteComp.CustomImages.Parent = this.btnDeleteComp;
            this.btnDeleteComp.DisabledState.Parent = this.btnDeleteComp;
            this.btnDeleteComp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteComp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteComp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnDeleteComp.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDeleteComp.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteComp.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteComp.HoverState.Parent = this.btnDeleteComp;
            this.btnDeleteComp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteComp.Location = new System.Drawing.Point(309, 359);
            this.btnDeleteComp.Name = "btnDeleteComp";
            this.btnDeleteComp.PressedColor = System.Drawing.Color.Red;
            this.btnDeleteComp.ShadowDecoration.Parent = this.btnDeleteComp;
            this.btnDeleteComp.Size = new System.Drawing.Size(105, 36);
            this.btnDeleteComp.TabIndex = 66;
            this.btnDeleteComp.Tag = "";
            this.btnDeleteComp.Text = "DELETE";
            this.btnDeleteComp.Click += new System.EventHandler(this.btnDeleteComp_Click);
            // 
            // btnClearCompanyTxt
            // 
            this.btnClearCompanyTxt.BackColor = System.Drawing.Color.Transparent;
            this.btnClearCompanyTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClearCompanyTxt.BorderColor = System.Drawing.Color.Silver;
            this.btnClearCompanyTxt.BorderRadius = 6;
            this.btnClearCompanyTxt.CheckedState.Parent = this.btnClearCompanyTxt;
            this.btnClearCompanyTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearCompanyTxt.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClearCompanyTxt.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnClearCompanyTxt.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnClearCompanyTxt.CustomImages.Parent = this.btnClearCompanyTxt;
            this.btnClearCompanyTxt.DisabledState.Parent = this.btnClearCompanyTxt;
            this.btnClearCompanyTxt.Enabled = false;
            this.btnClearCompanyTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClearCompanyTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearCompanyTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnClearCompanyTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnClearCompanyTxt.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnClearCompanyTxt.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnClearCompanyTxt.HoverState.Parent = this.btnClearCompanyTxt;
            this.btnClearCompanyTxt.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClearCompanyTxt.Location = new System.Drawing.Point(192, 359);
            this.btnClearCompanyTxt.Name = "btnClearCompanyTxt";
            this.btnClearCompanyTxt.PressedColor = System.Drawing.Color.White;
            this.btnClearCompanyTxt.ShadowDecoration.Parent = this.btnClearCompanyTxt;
            this.btnClearCompanyTxt.Size = new System.Drawing.Size(105, 36);
            this.btnClearCompanyTxt.TabIndex = 69;
            this.btnClearCompanyTxt.Tag = "";
            this.btnClearCompanyTxt.Text = "CLEAR";
            this.btnClearCompanyTxt.Click += new System.EventHandler(this.btnClearCompanyTxt_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label10.Location = new System.Drawing.Point(31, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "Address:";
            // 
            // txtCompBIK
            // 
            this.txtCompBIK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompBIK.DefaultText = "";
            this.txtCompBIK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCompBIK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCompBIK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCompBIK.DisabledState.Parent = this.txtCompBIK;
            this.txtCompBIK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCompBIK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCompBIK.FocusedState.Parent = this.txtCompBIK;
            this.txtCompBIK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCompBIK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.txtCompBIK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCompBIK.HoverState.Parent = this.txtCompBIK;
            this.txtCompBIK.Location = new System.Drawing.Point(192, 264);
            this.txtCompBIK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCompBIK.Name = "txtCompBIK";
            this.txtCompBIK.PasswordChar = '\0';
            this.txtCompBIK.PlaceholderText = "";
            this.txtCompBIK.SelectedText = "";
            this.txtCompBIK.ShadowDecoration.Parent = this.txtCompBIK;
            this.txtCompBIK.Size = new System.Drawing.Size(339, 36);
            this.txtCompBIK.TabIndex = 5;
            this.txtCompBIK.TextChanged += new System.EventHandler(this.txtPKCompName_TextChanged);
            // 
            // txtCompAddress
            // 
            this.txtCompAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompAddress.DefaultText = "";
            this.txtCompAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCompAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCompAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCompAddress.DisabledState.Parent = this.txtCompAddress;
            this.txtCompAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCompAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCompAddress.FocusedState.Parent = this.txtCompAddress;
            this.txtCompAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCompAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.txtCompAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCompAddress.HoverState.Parent = this.txtCompAddress;
            this.txtCompAddress.Location = new System.Drawing.Point(192, 115);
            this.txtCompAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCompAddress.Multiline = true;
            this.txtCompAddress.Name = "txtCompAddress";
            this.txtCompAddress.PasswordChar = '\0';
            this.txtCompAddress.PlaceholderText = "";
            this.txtCompAddress.SelectedText = "";
            this.txtCompAddress.ShadowDecoration.Parent = this.txtCompAddress;
            this.txtCompAddress.Size = new System.Drawing.Size(339, 80);
            this.txtCompAddress.TabIndex = 2;
            this.txtCompAddress.TextChanged += new System.EventHandler(this.txtPKCompName_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label15.Location = new System.Drawing.Point(31, 274);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 21);
            this.label15.TabIndex = 1;
            this.label15.Text = "BIK:";
            // 
            // txtPKCompName
            // 
            this.txtPKCompName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPKCompName.DefaultText = "";
            this.txtPKCompName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPKCompName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPKCompName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPKCompName.DisabledState.Parent = this.txtPKCompName;
            this.txtPKCompName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPKCompName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPKCompName.FocusedState.Parent = this.txtPKCompName;
            this.txtPKCompName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPKCompName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.txtPKCompName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPKCompName.HoverState.Parent = this.txtPKCompName;
            this.txtPKCompName.Location = new System.Drawing.Point(192, 80);
            this.txtPKCompName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPKCompName.Name = "txtPKCompName";
            this.txtPKCompName.PasswordChar = '\0';
            this.txtPKCompName.PlaceholderText = "";
            this.txtPKCompName.SelectedText = "";
            this.txtPKCompName.ShadowDecoration.Parent = this.txtPKCompName;
            this.txtPKCompName.Size = new System.Drawing.Size(339, 36);
            this.txtPKCompName.TabIndex = 1;
            this.txtPKCompName.TextChanged += new System.EventHandler(this.txtPKCompName_TextChanged);
            this.txtPKCompName.Leave += new System.EventHandler(this.txtPKCompName_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label16.Location = new System.Drawing.Point(31, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 21);
            this.label16.TabIndex = 5;
            this.label16.Text = "Company name:";
            // 
            // txtCompINN
            // 
            this.txtCompINN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompINN.DefaultText = "";
            this.txtCompINN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCompINN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCompINN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCompINN.DisabledState.Parent = this.txtCompINN;
            this.txtCompINN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCompINN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCompINN.FocusedState.Parent = this.txtCompINN;
            this.txtCompINN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCompINN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.txtCompINN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCompINN.HoverState.Parent = this.txtCompINN;
            this.txtCompINN.Location = new System.Drawing.Point(192, 194);
            this.txtCompINN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCompINN.Name = "txtCompINN";
            this.txtCompINN.PasswordChar = '\0';
            this.txtCompINN.PlaceholderText = "";
            this.txtCompINN.SelectedText = "";
            this.txtCompINN.ShadowDecoration.Parent = this.txtCompINN;
            this.txtCompINN.Size = new System.Drawing.Size(339, 36);
            this.txtCompINN.TabIndex = 3;
            this.txtCompINN.TextChanged += new System.EventHandler(this.txtPKCompName_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label17.Location = new System.Drawing.Point(31, 204);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 21);
            this.label17.TabIndex = 7;
            this.label17.Text = "INN:";
            // 
            // txtCompBill
            // 
            this.txtCompBill.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompBill.DefaultText = "";
            this.txtCompBill.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCompBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCompBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCompBill.DisabledState.Parent = this.txtCompBill;
            this.txtCompBill.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCompBill.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCompBill.FocusedState.Parent = this.txtCompBill;
            this.txtCompBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCompBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.txtCompBill.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCompBill.HoverState.Parent = this.txtCompBill;
            this.txtCompBill.Location = new System.Drawing.Point(192, 229);
            this.txtCompBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCompBill.Name = "txtCompBill";
            this.txtCompBill.PasswordChar = '\0';
            this.txtCompBill.PlaceholderText = "";
            this.txtCompBill.SelectedText = "";
            this.txtCompBill.ShadowDecoration.Parent = this.txtCompBill;
            this.txtCompBill.Size = new System.Drawing.Size(339, 36);
            this.txtCompBill.TabIndex = 4;
            this.txtCompBill.TextChanged += new System.EventHandler(this.txtPKCompName_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label19.Location = new System.Drawing.Point(31, 239);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 21);
            this.label19.TabIndex = 9;
            this.label19.Text = "Bank bill:";
            // 
            // labelDecript
            // 
            this.labelDecript.AutoSize = true;
            this.labelDecript.BackColor = System.Drawing.Color.Transparent;
            this.labelDecript.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDecript.ForeColor = System.Drawing.Color.Silver;
            this.labelDecript.Location = new System.Drawing.Point(165, 249);
            this.labelDecript.Name = "labelDecript";
            this.labelDecript.Size = new System.Drawing.Size(209, 63);
            this.labelDecript.TabIndex = 61;
            this.labelDecript.Text = "CLICK:\r\nESC - TO STOP EDITION\r\nENTER - TO SAVE CHANGES\r\n";
            this.labelDecript.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelDecript.Visible = false;
            // 
            // txtDescriptionEdit
            // 
            this.txtDescriptionEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtDescriptionEdit.BorderRadius = 3;
            this.txtDescriptionEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescriptionEdit.DefaultText = "";
            this.txtDescriptionEdit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescriptionEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescriptionEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescriptionEdit.DisabledState.Parent = this.txtDescriptionEdit;
            this.txtDescriptionEdit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescriptionEdit.Enabled = false;
            this.txtDescriptionEdit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescriptionEdit.FocusedState.Parent = this.txtDescriptionEdit;
            this.txtDescriptionEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDescriptionEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.txtDescriptionEdit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescriptionEdit.HoverState.Parent = this.txtDescriptionEdit;
            this.txtDescriptionEdit.Location = new System.Drawing.Point(387, 230);
            this.txtDescriptionEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescriptionEdit.Multiline = true;
            this.txtDescriptionEdit.Name = "txtDescriptionEdit";
            this.txtDescriptionEdit.PasswordChar = '\0';
            this.txtDescriptionEdit.PlaceholderText = "";
            this.txtDescriptionEdit.SelectedText = "";
            this.txtDescriptionEdit.ShadowDecoration.Parent = this.txtDescriptionEdit;
            this.txtDescriptionEdit.Size = new System.Drawing.Size(954, 111);
            this.txtDescriptionEdit.TabIndex = 76;
            this.txtDescriptionEdit.Visible = false;
            this.txtDescriptionEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescriptionEdit_KeyDown);
            // 
            // dgvInsurance
            // 
            this.dgvInsurance.AllowUserToAddRows = false;
            this.dgvInsurance.AllowUserToDeleteRows = false;
            this.dgvInsurance.AllowUserToResizeColumns = false;
            this.dgvInsurance.AllowUserToResizeRows = false;
            dataGridViewCellStyle65.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle65.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle65.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle65.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle65.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInsurance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle65;
            this.dgvInsurance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInsurance.BackgroundColor = System.Drawing.Color.White;
            this.dgvInsurance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInsurance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInsurance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle66.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle66.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle66.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle66.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle66.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle66.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle66.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInsurance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle66;
            this.dgvInsurance.ColumnHeadersHeight = 40;
            this.dgvInsurance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInsurance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_CompanyName,
            this.CompanyAddress,
            this.CompanyINN,
            this.CompanyBankBill,
            this.CompanyBIK});
            dataGridViewCellStyle67.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle67.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle67.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle67.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle67.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle67.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle67.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInsurance.DefaultCellStyle = dataGridViewCellStyle67;
            this.dgvInsurance.EnableHeadersVisualStyles = false;
            this.dgvInsurance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvInsurance.Location = new System.Drawing.Point(20, 20);
            this.dgvInsurance.Name = "dgvInsurance";
            this.dgvInsurance.ReadOnly = true;
            this.dgvInsurance.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle68.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle68.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle68.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle68.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle68.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle68.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle68.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInsurance.RowHeadersDefaultCellStyle = dataGridViewCellStyle68;
            this.dgvInsurance.RowHeadersVisible = false;
            this.dgvInsurance.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInsurance.RowTemplate.Height = 30;
            this.dgvInsurance.RowTemplate.ReadOnly = true;
            this.dgvInsurance.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInsurance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInsurance.Size = new System.Drawing.Size(1321, 744);
            this.dgvInsurance.TabIndex = 77;
            this.dgvInsurance.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.dgvInsurance.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvInsurance.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvInsurance.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvInsurance.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvInsurance.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInsurance.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvInsurance.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvInsurance.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvInsurance.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInsurance.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dgvInsurance.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInsurance.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInsurance.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvInsurance.ThemeStyle.ReadOnly = true;
            this.dgvInsurance.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgvInsurance.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInsurance.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgvInsurance.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvInsurance.ThemeStyle.RowsStyle.Height = 30;
            this.dgvInsurance.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvInsurance.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInsurance.Visible = false;
            this.dgvInsurance.DoubleClick += new System.EventHandler(this.dgvInsurance_DoubleClick);
            // 
            // dgvAccessLvls
            // 
            this.dgvAccessLvls.AllowUserToAddRows = false;
            this.dgvAccessLvls.AllowUserToDeleteRows = false;
            this.dgvAccessLvls.AllowUserToResizeColumns = false;
            this.dgvAccessLvls.AllowUserToResizeRows = false;
            dataGridViewCellStyle69.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle69.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle69.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle69.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle69.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAccessLvls.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle69;
            this.dgvAccessLvls.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccessLvls.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccessLvls.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAccessLvls.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAccessLvls.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle70.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle70.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle70.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle70.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle70.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle70.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle70.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccessLvls.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle70;
            this.dgvAccessLvls.ColumnHeadersHeight = 40;
            this.dgvAccessLvls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAccessLvls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_AccessLevel,
            this.UQ_AccessLevelType,
            this.AccessLevelDescription});
            dataGridViewCellStyle71.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle71.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle71.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle71.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle71.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle71.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle71.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccessLvls.DefaultCellStyle = dataGridViewCellStyle71;
            this.dgvAccessLvls.EnableHeadersVisualStyles = false;
            this.dgvAccessLvls.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvAccessLvls.Location = new System.Drawing.Point(20, 20);
            this.dgvAccessLvls.Name = "dgvAccessLvls";
            this.dgvAccessLvls.ReadOnly = true;
            this.dgvAccessLvls.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle72.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle72.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle72.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle72.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle72.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle72.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle72.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccessLvls.RowHeadersDefaultCellStyle = dataGridViewCellStyle72;
            this.dgvAccessLvls.RowHeadersVisible = false;
            this.dgvAccessLvls.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAccessLvls.RowTemplate.Height = 30;
            this.dgvAccessLvls.RowTemplate.ReadOnly = true;
            this.dgvAccessLvls.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccessLvls.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccessLvls.Size = new System.Drawing.Size(1321, 371);
            this.dgvAccessLvls.TabIndex = 73;
            this.dgvAccessLvls.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.dgvAccessLvls.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvAccessLvls.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvAccessLvls.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvAccessLvls.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvAccessLvls.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAccessLvls.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAccessLvls.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvAccessLvls.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvAccessLvls.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAccessLvls.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dgvAccessLvls.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAccessLvls.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAccessLvls.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvAccessLvls.ThemeStyle.ReadOnly = true;
            this.dgvAccessLvls.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgvAccessLvls.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAccessLvls.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgvAccessLvls.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAccessLvls.ThemeStyle.RowsStyle.Height = 30;
            this.dgvAccessLvls.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvAccessLvls.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAccessLvls.Visible = false;
            this.dgvAccessLvls.DoubleClick += new System.EventHandler(this.dgvAccessLvls_DoubleClick);
            // 
            // PK_AccessLevel
            // 
            this.PK_AccessLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PK_AccessLevel.DataPropertyName = "PK_AccessLevel";
            this.PK_AccessLevel.HeaderText = "ACCESS LVL";
            this.PK_AccessLevel.Name = "PK_AccessLevel";
            this.PK_AccessLevel.ReadOnly = true;
            this.PK_AccessLevel.Width = 134;
            // 
            // UQ_AccessLevelType
            // 
            this.UQ_AccessLevelType.DataPropertyName = "UQ_AccessLevelType";
            this.UQ_AccessLevelType.FillWeight = 10F;
            this.UQ_AccessLevelType.HeaderText = "TYPE";
            this.UQ_AccessLevelType.Name = "UQ_AccessLevelType";
            this.UQ_AccessLevelType.ReadOnly = true;
            // 
            // AccessLevelDescription
            // 
            this.AccessLevelDescription.DataPropertyName = "AccessLevelDescription";
            this.AccessLevelDescription.FillWeight = 40F;
            this.AccessLevelDescription.HeaderText = "DESCRIPTION";
            this.AccessLevelDescription.Name = "AccessLevelDescription";
            this.AccessLevelDescription.ReadOnly = true;
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AllowUserToDeleteRows = false;
            this.dgvAccounts.AllowUserToResizeColumns = false;
            this.dgvAccounts.AllowUserToResizeRows = false;
            dataGridViewCellStyle73.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle73.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle73.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle73.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle73.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAccounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle73;
            this.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccounts.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAccounts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAccounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle74.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle74.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle74.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle74.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle74.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle74.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle74.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle74;
            this.dgvAccounts.ColumnHeadersHeight = 40;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_AccountId,
            this.FK_AccountAccessLevel,
            this.UQ_AccountLogin,
            this.AccountPass,
            this.AccountIpAddress,
            this.AccountLastEnter});
            dataGridViewCellStyle75.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle75.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle75.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle75.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle75.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle75.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle75.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccounts.DefaultCellStyle = dataGridViewCellStyle75;
            this.dgvAccounts.EnableHeadersVisualStyles = false;
            this.dgvAccounts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvAccounts.Location = new System.Drawing.Point(20, 20);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle76.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle76.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle76.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle76.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle76.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle76.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle76.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccounts.RowHeadersDefaultCellStyle = dataGridViewCellStyle76;
            this.dgvAccounts.RowHeadersVisible = false;
            this.dgvAccounts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAccounts.RowTemplate.Height = 30;
            this.dgvAccounts.RowTemplate.ReadOnly = true;
            this.dgvAccounts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounts.Size = new System.Drawing.Size(1321, 744);
            this.dgvAccounts.TabIndex = 2;
            this.dgvAccounts.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.dgvAccounts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvAccounts.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvAccounts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvAccounts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvAccounts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAccounts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAccounts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvAccounts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvAccounts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAccounts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dgvAccounts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAccounts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAccounts.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvAccounts.ThemeStyle.ReadOnly = true;
            this.dgvAccounts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgvAccounts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAccounts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgvAccounts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAccounts.ThemeStyle.RowsStyle.Height = 30;
            this.dgvAccounts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvAccounts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAccounts.Visible = false;
            this.dgvAccounts.DoubleClick += new System.EventHandler(this.dgvAccounts_DoubleClick);
            // 
            // PK_AccountId
            // 
            this.PK_AccountId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PK_AccountId.DataPropertyName = "PK_AccountId";
            this.PK_AccountId.HeaderText = "ID";
            this.PK_AccountId.Name = "PK_AccountId";
            this.PK_AccountId.ReadOnly = true;
            this.PK_AccountId.Width = 53;
            // 
            // FK_AccountAccessLevel
            // 
            this.FK_AccountAccessLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FK_AccountAccessLevel.DataPropertyName = "FK_AccountAccessLevel";
            this.FK_AccountAccessLevel.HeaderText = "ACCESS CODE";
            this.FK_AccountAccessLevel.Name = "FK_AccountAccessLevel";
            this.FK_AccountAccessLevel.ReadOnly = true;
            this.FK_AccountAccessLevel.Width = 153;
            // 
            // UQ_AccountLogin
            // 
            this.UQ_AccountLogin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UQ_AccountLogin.DataPropertyName = "UQ_AccountLogin";
            this.UQ_AccountLogin.HeaderText = "LOGIN";
            this.UQ_AccountLogin.Name = "UQ_AccountLogin";
            this.UQ_AccountLogin.ReadOnly = true;
            // 
            // AccountPass
            // 
            this.AccountPass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AccountPass.DataPropertyName = "AccountPass";
            this.AccountPass.HeaderText = "PASS";
            this.AccountPass.Name = "AccountPass";
            this.AccountPass.ReadOnly = true;
            // 
            // AccountIpAddress
            // 
            this.AccountIpAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AccountIpAddress.DataPropertyName = "AccountIpAddress";
            this.AccountIpAddress.HeaderText = "IP";
            this.AccountIpAddress.Name = "AccountIpAddress";
            this.AccountIpAddress.ReadOnly = true;
            // 
            // AccountLastEnter
            // 
            this.AccountLastEnter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.AccountLastEnter.DataPropertyName = "AccountLastEnter";
            this.AccountLastEnter.HeaderText = "WAS ONLINE";
            this.AccountLastEnter.Name = "AccountLastEnter";
            this.AccountLastEnter.ReadOnly = true;
            this.AccountLastEnter.Width = 145;
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.AllowUserToResizeColumns = false;
            this.dgvServices.AllowUserToResizeRows = false;
            dataGridViewCellStyle77.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle77.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle77.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle77.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle77.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvServices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle77;
            this.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServices.BackgroundColor = System.Drawing.Color.White;
            this.dgvServices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvServices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvServices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle78.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle78.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle78.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle78.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle78.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle78.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle78.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle78;
            this.dgvServices.ColumnHeadersHeight = 40;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceCode,
            this.ServiceName,
            this.ServicePrice,
            this.ServiceDeadlineInDays,
            this.ServiceAverageDeviation,
            this.Column1});
            dataGridViewCellStyle79.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle79.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle79.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle79.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle79.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle79.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle79.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServices.DefaultCellStyle = dataGridViewCellStyle79;
            this.dgvServices.EnableHeadersVisualStyles = false;
            this.dgvServices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvServices.Location = new System.Drawing.Point(20, 20);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle80.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle80.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle80.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle80.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle80.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle80.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle80.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServices.RowHeadersDefaultCellStyle = dataGridViewCellStyle80;
            this.dgvServices.RowHeadersVisible = false;
            this.dgvServices.RowTemplate.Height = 30;
            this.dgvServices.RowTemplate.ReadOnly = true;
            this.dgvServices.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(1321, 744);
            this.dgvServices.TabIndex = 0;
            this.dgvServices.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.dgvServices.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvServices.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvServices.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvServices.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvServices.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvServices.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvServices.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvServices.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvServices.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvServices.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dgvServices.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvServices.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvServices.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvServices.ThemeStyle.ReadOnly = true;
            this.dgvServices.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgvServices.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvServices.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgvServices.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvServices.ThemeStyle.RowsStyle.Height = 30;
            this.dgvServices.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvServices.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // ServiceCode
            // 
            this.ServiceCode.DataPropertyName = "PK_ServiceCode";
            this.ServiceCode.HeaderText = "CODE";
            this.ServiceCode.Name = "ServiceCode";
            this.ServiceCode.ReadOnly = true;
            // 
            // ServiceName
            // 
            this.ServiceName.DataPropertyName = "UQ_ServiceName";
            this.ServiceName.HeaderText = "NAME";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            // 
            // ServicePrice
            // 
            this.ServicePrice.DataPropertyName = "ServicePrice";
            this.ServicePrice.HeaderText = "PRICE";
            this.ServicePrice.Name = "ServicePrice";
            this.ServicePrice.ReadOnly = true;
            // 
            // ServiceDeadlineInDays
            // 
            this.ServiceDeadlineInDays.DataPropertyName = "ServiceDeadlineInDays";
            this.ServiceDeadlineInDays.HeaderText = "DAYS";
            this.ServiceDeadlineInDays.Name = "ServiceDeadlineInDays";
            this.ServiceDeadlineInDays.ReadOnly = true;
            // 
            // ServiceAverageDeviation
            // 
            this.ServiceAverageDeviation.DataPropertyName = "ServiceAverageDeviation";
            this.ServiceAverageDeviation.HeaderText = "AVERAGE DEVIATION";
            this.ServiceAverageDeviation.Name = "ServiceAverageDeviation";
            this.ServiceAverageDeviation.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tbOrders";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // panelCRUDaccounts
            // 
            this.panelCRUDaccounts.BackColor = System.Drawing.Color.White;
            this.panelCRUDaccounts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelCRUDaccounts.BorderThickness = 3;
            this.panelCRUDaccounts.Controls.Add(this.lbAccessLvl);
            this.panelCRUDaccounts.Controls.Add(this.btnCloseRowAccount);
            this.panelCRUDaccounts.Controls.Add(this.btnSaveUpdateAccount);
            this.panelCRUDaccounts.Controls.Add(this.btnDeleteAccount);
            this.panelCRUDaccounts.Controls.Add(this.btnClearAccountTxt);
            this.panelCRUDaccounts.Controls.Add(this.label5);
            this.panelCRUDaccounts.Controls.Add(this.txtIP);
            this.panelCRUDaccounts.Controls.Add(this.textBox3);
            this.panelCRUDaccounts.Controls.Add(this.label6);
            this.panelCRUDaccounts.Controls.Add(this.txtID);
            this.panelCRUDaccounts.Controls.Add(this.label7);
            this.panelCRUDaccounts.Controls.Add(this.txtLogin);
            this.panelCRUDaccounts.Controls.Add(this.label12);
            this.panelCRUDaccounts.Controls.Add(this.label13);
            this.panelCRUDaccounts.Controls.Add(this.txtPass);
            this.panelCRUDaccounts.Controls.Add(this.label14);
            this.panelCRUDaccounts.Controls.Add(this.dtpWasOnline);
            this.panelCRUDaccounts.Location = new System.Drawing.Point(402, 170);
            this.panelCRUDaccounts.Name = "panelCRUDaccounts";
            this.panelCRUDaccounts.ShadowDecoration.Parent = this.panelCRUDaccounts;
            this.panelCRUDaccounts.Size = new System.Drawing.Size(564, 447);
            this.panelCRUDaccounts.TabIndex = 72;
            this.panelCRUDaccounts.Visible = false;
            // 
            // lbAccessLvl
            // 
            this.lbAccessLvl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbAccessLvl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbAccessLvl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAccessLvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.lbAccessLvl.FormattingEnabled = true;
            this.lbAccessLvl.ItemHeight = 21;
            this.lbAccessLvl.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.lbAccessLvl.Location = new System.Drawing.Point(193, 121);
            this.lbAccessLvl.Name = "lbAccessLvl";
            this.lbAccessLvl.Size = new System.Drawing.Size(337, 21);
            this.lbAccessLvl.TabIndex = 72;
            // 
            // btnCloseRowAccount
            // 
            this.btnCloseRowAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseRowAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCloseRowAccount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCloseRowAccount.BorderRadius = 6;
            this.btnCloseRowAccount.CheckedState.Parent = this.btnCloseRowAccount;
            this.btnCloseRowAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseRowAccount.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCloseRowAccount.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnCloseRowAccount.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCloseRowAccount.CustomImages.Parent = this.btnCloseRowAccount;
            this.btnCloseRowAccount.DisabledState.Parent = this.btnCloseRowAccount;
            this.btnCloseRowAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCloseRowAccount.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCloseRowAccount.ForeColor = System.Drawing.Color.Red;
            this.btnCloseRowAccount.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.btnCloseRowAccount.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCloseRowAccount.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCloseRowAccount.HoverState.Parent = this.btnCloseRowAccount;
            this.btnCloseRowAccount.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCloseRowAccount.Location = new System.Drawing.Point(528, 0);
            this.btnCloseRowAccount.Name = "btnCloseRowAccount";
            this.btnCloseRowAccount.PressedColor = System.Drawing.Color.Red;
            this.btnCloseRowAccount.ShadowDecoration.Parent = this.btnCloseRowAccount;
            this.btnCloseRowAccount.Size = new System.Drawing.Size(36, 36);
            this.btnCloseRowAccount.TabIndex = 70;
            this.btnCloseRowAccount.Tag = "";
            this.btnCloseRowAccount.Text = "🗙";
            this.btnCloseRowAccount.TextOffset = new System.Drawing.Point(1, -1);
            this.btnCloseRowAccount.Click += new System.EventHandler(this.btnCloseRowAccount_Click);
            // 
            // btnSaveUpdateAccount
            // 
            this.btnSaveUpdateAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveUpdateAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveUpdateAccount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaveUpdateAccount.BorderRadius = 6;
            this.btnSaveUpdateAccount.CheckedState.Parent = this.btnSaveUpdateAccount;
            this.btnSaveUpdateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveUpdateAccount.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveUpdateAccount.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnSaveUpdateAccount.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSaveUpdateAccount.CustomImages.Parent = this.btnSaveUpdateAccount;
            this.btnSaveUpdateAccount.DisabledState.Parent = this.btnSaveUpdateAccount;
            this.btnSaveUpdateAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSaveUpdateAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveUpdateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaveUpdateAccount.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.btnSaveUpdateAccount.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSaveUpdateAccount.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaveUpdateAccount.HoverState.Parent = this.btnSaveUpdateAccount;
            this.btnSaveUpdateAccount.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSaveUpdateAccount.Location = new System.Drawing.Point(426, 386);
            this.btnSaveUpdateAccount.Name = "btnSaveUpdateAccount";
            this.btnSaveUpdateAccount.PressedColor = System.Drawing.Color.Green;
            this.btnSaveUpdateAccount.ShadowDecoration.Parent = this.btnSaveUpdateAccount;
            this.btnSaveUpdateAccount.Size = new System.Drawing.Size(105, 36);
            this.btnSaveUpdateAccount.TabIndex = 67;
            this.btnSaveUpdateAccount.Tag = "";
            this.btnSaveUpdateAccount.Text = "SAVE";
            this.btnSaveUpdateAccount.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteAccount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteAccount.BorderRadius = 6;
            this.btnDeleteAccount.CheckedState.Parent = this.btnDeleteAccount;
            this.btnDeleteAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAccount.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteAccount.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnDeleteAccount.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDeleteAccount.CustomImages.Parent = this.btnDeleteAccount;
            this.btnDeleteAccount.DisabledState.Parent = this.btnDeleteAccount;
            this.btnDeleteAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnDeleteAccount.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDeleteAccount.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteAccount.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteAccount.HoverState.Parent = this.btnDeleteAccount;
            this.btnDeleteAccount.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteAccount.Location = new System.Drawing.Point(309, 386);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.PressedColor = System.Drawing.Color.Red;
            this.btnDeleteAccount.ShadowDecoration.Parent = this.btnDeleteAccount;
            this.btnDeleteAccount.Size = new System.Drawing.Size(105, 36);
            this.btnDeleteAccount.TabIndex = 66;
            this.btnDeleteAccount.Tag = "";
            this.btnDeleteAccount.Text = "DELETE";
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClearAccountTxt
            // 
            this.btnClearAccountTxt.BackColor = System.Drawing.Color.Transparent;
            this.btnClearAccountTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClearAccountTxt.BorderColor = System.Drawing.Color.Silver;
            this.btnClearAccountTxt.BorderRadius = 6;
            this.btnClearAccountTxt.CheckedState.Parent = this.btnClearAccountTxt;
            this.btnClearAccountTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearAccountTxt.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClearAccountTxt.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnClearAccountTxt.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnClearAccountTxt.CustomImages.Parent = this.btnClearAccountTxt;
            this.btnClearAccountTxt.DisabledState.Parent = this.btnClearAccountTxt;
            this.btnClearAccountTxt.Enabled = false;
            this.btnClearAccountTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClearAccountTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearAccountTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnClearAccountTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnClearAccountTxt.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnClearAccountTxt.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnClearAccountTxt.HoverState.Parent = this.btnClearAccountTxt;
            this.btnClearAccountTxt.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClearAccountTxt.Location = new System.Drawing.Point(192, 386);
            this.btnClearAccountTxt.Name = "btnClearAccountTxt";
            this.btnClearAccountTxt.PressedColor = System.Drawing.Color.White;
            this.btnClearAccountTxt.ShadowDecoration.Parent = this.btnClearAccountTxt;
            this.btnClearAccountTxt.Size = new System.Drawing.Size(105, 36);
            this.btnClearAccountTxt.TabIndex = 69;
            this.btnClearAccountTxt.Tag = "";
            this.btnClearAccountTxt.Text = "CLEAR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label5.Location = new System.Drawing.Point(31, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Access code:";
            // 
            // txtIP
            // 
            this.txtIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIP.DefaultText = "";
            this.txtIP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIP.DisabledState.Parent = this.txtIP;
            this.txtIP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIP.FocusedState.Parent = this.txtIP;
            this.txtIP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.txtIP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIP.HoverState.Parent = this.txtIP;
            this.txtIP.Location = new System.Drawing.Point(192, 220);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIP.Name = "txtIP";
            this.txtIP.PasswordChar = '\0';
            this.txtIP.PlaceholderText = "";
            this.txtIP.SelectedText = "";
            this.txtIP.ShadowDecoration.Parent = this.txtIP;
            this.txtIP.Size = new System.Drawing.Size(339, 36);
            this.txtIP.TabIndex = 5;
            this.txtIP.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox3.DefaultText = "";
            this.textBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox3.DisabledState.Parent = this.textBox3;
            this.textBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox3.FocusedState.Parent = this.textBox3;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.textBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox3.HoverState.Parent = this.textBox3;
            this.textBox3.Location = new System.Drawing.Point(192, 115);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '\0';
            this.textBox3.PlaceholderText = "";
            this.textBox3.SelectedText = "";
            this.textBox3.ShadowDecoration.Parent = this.textBox3;
            this.textBox3.Size = new System.Drawing.Size(339, 36);
            this.textBox3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label6.Location = new System.Drawing.Point(31, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "IP:";
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.Parent = this.txtID;
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.FocusedState.Parent = this.txtID;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.HoverState.Parent = this.txtID;
            this.txtID.Location = new System.Drawing.Point(192, 80);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderText = "";
            this.txtID.SelectedText = "";
            this.txtID.ShadowDecoration.Parent = this.txtID;
            this.txtID.Size = new System.Drawing.Size(339, 36);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label7.Location = new System.Drawing.Point(31, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "ID:";
            // 
            // txtLogin
            // 
            this.txtLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogin.DefaultText = "";
            this.txtLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLogin.DisabledState.Parent = this.txtLogin;
            this.txtLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLogin.FocusedState.Parent = this.txtLogin;
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.txtLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLogin.HoverState.Parent = this.txtLogin;
            this.txtLogin.Location = new System.Drawing.Point(192, 150);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.PlaceholderText = "";
            this.txtLogin.SelectedText = "";
            this.txtLogin.ShadowDecoration.Parent = this.txtLogin;
            this.txtLogin.Size = new System.Drawing.Size(339, 36);
            this.txtLogin.TabIndex = 3;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label12.Location = new System.Drawing.Point(31, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 21);
            this.label12.TabIndex = 7;
            this.label12.Text = "Login:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label13.Location = new System.Drawing.Point(31, 265);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 21);
            this.label13.TabIndex = 11;
            this.label13.Text = "Was online:";
            // 
            // txtPass
            // 
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultText = "";
            this.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.DisabledState.Parent = this.txtPass;
            this.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass.FocusedState.Parent = this.txtPass;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.txtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass.HoverState.Parent = this.txtPass;
            this.txtPass.Location = new System.Drawing.Point(192, 185);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.PlaceholderText = "";
            this.txtPass.SelectedText = "";
            this.txtPass.ShadowDecoration.Parent = this.txtPass;
            this.txtPass.Size = new System.Drawing.Size(339, 36);
            this.txtPass.TabIndex = 4;
            this.txtPass.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label14.Location = new System.Drawing.Point(31, 195);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 21);
            this.label14.TabIndex = 9;
            this.label14.Text = "Pass:";
            // 
            // dtpWasOnline
            // 
            this.dtpWasOnline.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtpWasOnline.Checked = true;
            this.dtpWasOnline.CheckedState.Parent = this.dtpWasOnline;
            this.dtpWasOnline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpWasOnline.FillColor = System.Drawing.Color.White;
            this.dtpWasOnline.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpWasOnline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.dtpWasOnline.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWasOnline.HoverState.Parent = this.dtpWasOnline;
            this.dtpWasOnline.Location = new System.Drawing.Point(192, 255);
            this.dtpWasOnline.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpWasOnline.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpWasOnline.Name = "dtpWasOnline";
            this.dtpWasOnline.ShadowDecoration.Parent = this.dtpWasOnline;
            this.dtpWasOnline.Size = new System.Drawing.Size(339, 36);
            this.dtpWasOnline.TabIndex = 73;
            this.dtpWasOnline.Value = new System.DateTime(2021, 11, 10, 22, 57, 46, 617);
            // 
            // panelEmpProfile
            // 
            this.panelEmpProfile.BackColor = System.Drawing.Color.Transparent;
            this.panelEmpProfile.Controls.Add(this.guna2Button1);
            this.panelEmpProfile.Controls.Add(this.buttonLogout);
            this.panelEmpProfile.Controls.Add(this.labelSpeciality);
            this.panelEmpProfile.Controls.Add(this.label1);
            this.panelEmpProfile.Controls.Add(this.pictureBoxUserPhoto);
            this.panelEmpProfile.Controls.Add(this.labelFullName);
            this.panelEmpProfile.Controls.Add(this.label2);
            this.panelEmpProfile.FillColor = System.Drawing.Color.White;
            this.panelEmpProfile.Location = new System.Drawing.Point(916, 12);
            this.panelEmpProfile.Name = "panelEmpProfile";
            this.panelEmpProfile.Radius = 3;
            this.panelEmpProfile.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.panelEmpProfile.ShadowDepth = 40;
            this.panelEmpProfile.ShadowShift = 6;
            this.panelEmpProfile.Size = new System.Drawing.Size(475, 156);
            this.panelEmpProfile.TabIndex = 13;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.guna2Button1.BorderRadius = 6;
            this.guna2Button1.BorderThickness = 3;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2Button1.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.guna2Button1.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(133, 27);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.Aqua;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(181, 35);
            this.guna2Button1.TabIndex = 49;
            this.guna2Button1.Tag = "";
            this.guna2Button1.Text = "My Profile";
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLogout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonLogout.BorderRadius = 6;
            this.buttonLogout.CheckedState.Parent = this.buttonLogout;
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonLogout.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.buttonLogout.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonLogout.CustomImages.Parent = this.buttonLogout;
            this.buttonLogout.DisabledState.Parent = this.buttonLogout;
            this.buttonLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.buttonLogout.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.buttonLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonLogout.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonLogout.HoverState.Parent = this.buttonLogout;
            this.buttonLogout.Location = new System.Drawing.Point(339, 27);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.PressedColor = System.Drawing.Color.Red;
            this.buttonLogout.ShadowDecoration.Parent = this.buttonLogout;
            this.buttonLogout.Size = new System.Drawing.Size(115, 35);
            this.buttonLogout.TabIndex = 34;
            this.buttonLogout.Tag = "";
            this.buttonLogout.Text = "LOGOUT";
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelSpeciality
            // 
            this.labelSpeciality.AutoSize = true;
            this.labelSpeciality.BackColor = System.Drawing.Color.Transparent;
            this.labelSpeciality.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpeciality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.labelSpeciality.Location = new System.Drawing.Point(213, 75);
            this.labelSpeciality.Name = "labelSpeciality";
            this.labelSpeciality.Size = new System.Drawing.Size(76, 21);
            this.labelSpeciality.TabIndex = 48;
            this.labelSpeciality.Text = "UserRole";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(129, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 47;
            this.label1.Text = "Speciality: ";
            // 
            // pictureBoxUserPhoto
            // 
            this.pictureBoxUserPhoto.BackColor = System.Drawing.Color.White;
            this.pictureBoxUserPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxUserPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUserPhoto.Image")));
            this.pictureBoxUserPhoto.Location = new System.Drawing.Point(22, 27);
            this.pictureBoxUserPhoto.Name = "pictureBoxUserPhoto";
            this.pictureBoxUserPhoto.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxUserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUserPhoto.TabIndex = 13;
            this.pictureBoxUserPhoto.TabStop = false;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.BackColor = System.Drawing.Color.Transparent;
            this.labelFullName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.labelFullName.Location = new System.Drawing.Point(213, 108);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(72, 21);
            this.labelFullName.TabIndex = 45;
            this.labelFullName.Text = "surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label2.Location = new System.Drawing.Point(129, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 43;
            this.label2.Text = "Full name: ";
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.labelHeader.Location = new System.Drawing.Point(190, 27);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(160, 32);
            this.labelHeader.TabIndex = 14;
            this.labelHeader.Text = "St.Petersburg";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMainMenu.Controls.Add(this.btnAccess);
            this.panelMainMenu.Controls.Add(this.btnInsurance);
            this.panelMainMenu.Controls.Add(this.btnAccounts);
            this.panelMainMenu.Controls.Add(this.btnReports);
            this.panelMainMenu.Controls.Add(this.btnClients);
            this.panelMainMenu.Controls.Add(this.pictureBox5);
            this.panelMainMenu.Controls.Add(this.pictureBox4);
            this.panelMainMenu.Controls.Add(this.pictureBox3);
            this.panelMainMenu.Controls.Add(this.pictureBox2);
            this.panelMainMenu.Controls.Add(this.btnAnalyzer);
            this.panelMainMenu.Controls.Add(this.btnOrders);
            this.panelMainMenu.Controls.Add(this.btnServices);
            this.panelMainMenu.Controls.Add(this.labelHeader);
            this.panelMainMenu.Controls.Add(this.pictureBox1);
            this.panelMainMenu.Controls.Add(this.label3);
            this.panelMainMenu.FillColor = System.Drawing.Color.White;
            this.panelMainMenu.Location = new System.Drawing.Point(29, 12);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Radius = 3;
            this.panelMainMenu.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.panelMainMenu.ShadowDepth = 50;
            this.panelMainMenu.ShadowShift = 6;
            this.panelMainMenu.Size = new System.Drawing.Size(881, 156);
            this.panelMainMenu.TabIndex = 14;
            // 
            // btnAccess
            // 
            this.btnAccess.BackColor = System.Drawing.Color.Transparent;
            this.btnAccess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAccess.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnAccess.BorderRadius = 6;
            this.btnAccess.BorderThickness = 3;
            this.btnAccess.CheckedState.Parent = this.btnAccess;
            this.btnAccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccess.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAccess.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnAccess.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAccess.CustomImages.Parent = this.btnAccess;
            this.btnAccess.DisabledState.Parent = this.btnAccess;
            this.btnAccess.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnAccess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnAccess.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAccess.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAccess.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAccess.HoverState.Parent = this.btnAccess;
            this.btnAccess.Location = new System.Drawing.Point(266, 69);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.PressedColor = System.Drawing.Color.Aqua;
            this.btnAccess.ShadowDecoration.Parent = this.btnAccess;
            this.btnAccess.Size = new System.Drawing.Size(115, 30);
            this.btnAccess.TabIndex = 60;
            this.btnAccess.Tag = "";
            this.btnAccess.Text = "ACCESS";
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // btnInsurance
            // 
            this.btnInsurance.BackColor = System.Drawing.Color.Transparent;
            this.btnInsurance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInsurance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnInsurance.BorderRadius = 6;
            this.btnInsurance.BorderThickness = 3;
            this.btnInsurance.CheckedState.Parent = this.btnInsurance;
            this.btnInsurance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsurance.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnInsurance.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnInsurance.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnInsurance.CustomImages.Parent = this.btnInsurance;
            this.btnInsurance.DisabledState.Parent = this.btnInsurance;
            this.btnInsurance.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnInsurance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnInsurance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnInsurance.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnInsurance.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnInsurance.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnInsurance.HoverState.Parent = this.btnInsurance;
            this.btnInsurance.Location = new System.Drawing.Point(133, 112);
            this.btnInsurance.Name = "btnInsurance";
            this.btnInsurance.PressedColor = System.Drawing.Color.Aqua;
            this.btnInsurance.ShadowDecoration.Parent = this.btnInsurance;
            this.btnInsurance.Size = new System.Drawing.Size(127, 30);
            this.btnInsurance.TabIndex = 59;
            this.btnInsurance.Tag = "";
            this.btnInsurance.Text = "INSURANCE";
            this.btnInsurance.Click += new System.EventHandler(this.btnInsurance_Click);
            // 
            // btnAccounts
            // 
            this.btnAccounts.BackColor = System.Drawing.Color.Transparent;
            this.btnAccounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAccounts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnAccounts.BorderRadius = 6;
            this.btnAccounts.BorderThickness = 3;
            this.btnAccounts.CheckedState.Parent = this.btnAccounts;
            this.btnAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccounts.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAccounts.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnAccounts.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAccounts.CustomImages.Parent = this.btnAccounts;
            this.btnAccounts.DisabledState.Parent = this.btnAccounts;
            this.btnAccounts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnAccounts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAccounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnAccounts.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAccounts.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAccounts.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAccounts.HoverState.Parent = this.btnAccounts;
            this.btnAccounts.Location = new System.Drawing.Point(133, 69);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.PressedColor = System.Drawing.Color.Aqua;
            this.btnAccounts.ShadowDecoration.Parent = this.btnAccounts;
            this.btnAccounts.Size = new System.Drawing.Size(127, 30);
            this.btnAccounts.TabIndex = 59;
            this.btnAccounts.Tag = "";
            this.btnAccounts.Text = "ACCOUNTS";
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Transparent;
            this.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReports.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnReports.BorderRadius = 6;
            this.btnReports.BorderThickness = 3;
            this.btnReports.CheckedState.Parent = this.btnReports;
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReports.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnReports.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnReports.CustomImages.Parent = this.btnReports;
            this.btnReports.DisabledState.Parent = this.btnReports;
            this.btnReports.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnReports.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnReports.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnReports.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnReports.HoverState.Parent = this.btnReports;
            this.btnReports.Location = new System.Drawing.Point(266, 112);
            this.btnReports.Name = "btnReports";
            this.btnReports.PressedColor = System.Drawing.Color.Aqua;
            this.btnReports.ShadowDecoration.Parent = this.btnReports;
            this.btnReports.Size = new System.Drawing.Size(115, 30);
            this.btnReports.TabIndex = 58;
            this.btnReports.Tag = "";
            this.btnReports.Text = "REPORTS";
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.Color.Transparent;
            this.btnClients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClients.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnClients.BorderRadius = 6;
            this.btnClients.BorderThickness = 3;
            this.btnClients.CheckedState.Parent = this.btnClients;
            this.btnClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClients.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClients.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnClients.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnClients.CustomImages.Parent = this.btnClients;
            this.btnClients.DisabledState.Parent = this.btnClients;
            this.btnClients.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnClients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnClients.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnClients.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnClients.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnClients.HoverState.Parent = this.btnClients;
            this.btnClients.Location = new System.Drawing.Point(387, 112);
            this.btnClients.Name = "btnClients";
            this.btnClients.PressedColor = System.Drawing.Color.Aqua;
            this.btnClients.ShadowDecoration.Parent = this.btnClients;
            this.btnClients.Size = new System.Drawing.Size(115, 30);
            this.btnClients.TabIndex = 56;
            this.btnClients.Tag = "";
            this.btnClients.Text = "CLIENTS";
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(402, 27);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(83, 85);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 57;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(523, 27);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(83, 79);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 55;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(642, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(83, 79);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 54;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(764, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // btnAnalyzer
            // 
            this.btnAnalyzer.BackColor = System.Drawing.Color.Transparent;
            this.btnAnalyzer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnalyzer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnAnalyzer.BorderRadius = 6;
            this.btnAnalyzer.BorderThickness = 3;
            this.btnAnalyzer.CheckedState.Parent = this.btnAnalyzer;
            this.btnAnalyzer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnalyzer.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAnalyzer.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnAnalyzer.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAnalyzer.CustomImages.Parent = this.btnAnalyzer;
            this.btnAnalyzer.DisabledState.Parent = this.btnAnalyzer;
            this.btnAnalyzer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnAnalyzer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnalyzer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnAnalyzer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAnalyzer.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAnalyzer.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAnalyzer.HoverState.Parent = this.btnAnalyzer;
            this.btnAnalyzer.Location = new System.Drawing.Point(629, 112);
            this.btnAnalyzer.Name = "btnAnalyzer";
            this.btnAnalyzer.PressedColor = System.Drawing.Color.Aqua;
            this.btnAnalyzer.ShadowDecoration.Parent = this.btnAnalyzer;
            this.btnAnalyzer.Size = new System.Drawing.Size(115, 30);
            this.btnAnalyzer.TabIndex = 52;
            this.btnAnalyzer.Tag = "";
            this.btnAnalyzer.Text = "ANALYZER";
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.Transparent;
            this.btnOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOrders.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnOrders.BorderRadius = 6;
            this.btnOrders.BorderThickness = 3;
            this.btnOrders.CheckedState.Parent = this.btnOrders;
            this.btnOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrders.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOrders.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnOrders.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnOrders.CustomImages.Parent = this.btnOrders;
            this.btnOrders.DisabledState.Parent = this.btnOrders;
            this.btnOrders.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnOrders.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnOrders.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnOrders.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnOrders.HoverState.Parent = this.btnOrders;
            this.btnOrders.Location = new System.Drawing.Point(750, 111);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.PressedColor = System.Drawing.Color.Aqua;
            this.btnOrders.ShadowDecoration.Parent = this.btnOrders;
            this.btnOrders.Size = new System.Drawing.Size(115, 30);
            this.btnOrders.TabIndex = 51;
            this.btnOrders.Tag = "";
            this.btnOrders.Text = "ORDERS";
            // 
            // btnServices
            // 
            this.btnServices.BackColor = System.Drawing.Color.Transparent;
            this.btnServices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnServices.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnServices.BorderRadius = 6;
            this.btnServices.BorderThickness = 3;
            this.btnServices.CheckedState.Parent = this.btnServices;
            this.btnServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServices.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnServices.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnServices.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnServices.CustomImages.Parent = this.btnServices;
            this.btnServices.DisabledState.Parent = this.btnServices;
            this.btnServices.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnServices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnServices.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnServices.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnServices.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnServices.HoverState.Parent = this.btnServices;
            this.btnServices.Location = new System.Drawing.Point(508, 112);
            this.btnServices.Name = "btnServices";
            this.btnServices.PressedColor = System.Drawing.Color.Aqua;
            this.btnServices.ShadowDecoration.Parent = this.btnServices;
            this.btnServices.Size = new System.Drawing.Size(115, 30);
            this.btnServices.TabIndex = 50;
            this.btnServices.Tag = "";
            this.btnServices.Text = "SERVICES";
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label3.Location = new System.Drawing.Point(126, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 40);
            this.label3.TabIndex = 39;
            this.label3.Text = "N20";
            // 
            // labelPotatoCorp
            // 
            this.labelPotatoCorp.AutoSize = true;
            this.labelPotatoCorp.BackColor = System.Drawing.Color.Transparent;
            this.labelPotatoCorp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPotatoCorp.ForeColor = System.Drawing.Color.Gray;
            this.labelPotatoCorp.Location = new System.Drawing.Point(1156, 995);
            this.labelPotatoCorp.Name = "labelPotatoCorp";
            this.labelPotatoCorp.Size = new System.Drawing.Size(235, 15);
            this.labelPotatoCorp.TabIndex = 42;
            this.labelPotatoCorp.Text = "v13.39 Potato Corp, 2021, all rights reserved\r\n";
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnBackToMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBackToMenu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnBackToMenu.BorderRadius = 6;
            this.btnBackToMenu.BorderThickness = 3;
            this.btnBackToMenu.CheckedState.Parent = this.btnBackToMenu;
            this.btnBackToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToMenu.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBackToMenu.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnBackToMenu.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBackToMenu.CustomImages.Parent = this.btnBackToMenu;
            this.btnBackToMenu.DisabledState.Parent = this.btnBackToMenu;
            this.btnBackToMenu.Enabled = false;
            this.btnBackToMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnBackToMenu.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackToMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnBackToMenu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnBackToMenu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnBackToMenu.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnBackToMenu.HoverState.Parent = this.btnBackToMenu;
            this.btnBackToMenu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBackToMenu.Location = new System.Drawing.Point(49, 174);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.PressedColor = System.Drawing.Color.Aqua;
            this.btnBackToMenu.ShadowDecoration.Parent = this.btnBackToMenu;
            this.btnBackToMenu.Size = new System.Drawing.Size(101, 36);
            this.btnBackToMenu.TabIndex = 66;
            this.btnBackToMenu.Tag = "";
            this.btnBackToMenu.Text = "🠔 ";
            this.btnBackToMenu.TextOffset = new System.Drawing.Point(0, -8);
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // panelAccounts
            // 
            this.panelAccounts.BackColor = System.Drawing.Color.Transparent;
            this.panelAccounts.Controls.Add(this.guna2TextBox2);
            this.panelAccounts.Controls.Add(this.label4);
            this.panelAccounts.Controls.Add(this.pictureBox7);
            this.panelAccounts.Controls.Add(this.label9);
            this.panelAccounts.FillColor = System.Drawing.Color.White;
            this.panelAccounts.Location = new System.Drawing.Point(29, 12);
            this.panelAccounts.Name = "panelAccounts";
            this.panelAccounts.Radius = 3;
            this.panelAccounts.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.panelAccounts.ShadowDepth = 50;
            this.panelAccounts.ShadowShift = 6;
            this.panelAccounts.Size = new System.Drawing.Size(881, 156);
            this.panelAccounts.TabIndex = 62;
            this.panelAccounts.Visible = false;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.guna2TextBox2.BorderRadius = 3;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.FocusedState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.HoverState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Location = new System.Drawing.Point(133, 101);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(730, 32);
            this.guna2TextBox2.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label4.Location = new System.Drawing.Point(190, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 32);
            this.label4.TabIndex = 50;
            this.label4.Text = "ACCOUNTS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(21, 41);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 100);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 49;
            this.pictureBox7.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label9.Location = new System.Drawing.Point(126, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 40);
            this.label9.TabIndex = 39;
            this.label9.Text = "N20";
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNew.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddNew.BorderRadius = 6;
            this.btnAddNew.CheckedState.Parent = this.btnAddNew;
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddNew.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnAddNew.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddNew.CustomImages.Parent = this.btnAddNew;
            this.btnAddNew.DisabledState.Parent = this.btnAddNew;
            this.btnAddNew.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddNew.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddNew.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddNew.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.HoverState.Parent = this.btnAddNew;
            this.btnAddNew.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNew.Location = new System.Drawing.Point(198, 174);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.PressedColor = System.Drawing.Color.Lime;
            this.btnAddNew.ShadowDecoration.Parent = this.btnAddNew;
            this.btnAddNew.Size = new System.Drawing.Size(206, 36);
            this.btnAddNew.TabIndex = 74;
            this.btnAddNew.Tag = "";
            this.btnAddNew.Text = "ADD NEW";
            this.btnAddNew.Visible = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReload.BorderColor = System.Drawing.Color.Transparent;
            this.btnReload.BorderRadius = 6;
            this.btnReload.BorderThickness = 3;
            this.btnReload.CheckedState.Parent = this.btnReload;
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReload.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnReload.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnReload.CustomImages.Parent = this.btnReload;
            this.btnReload.DisabledState.Parent = this.btnReload;
            this.btnReload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnReload.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnReload.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnReload.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnReload.HoverState.Parent = this.btnReload;
            this.btnReload.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReload.Location = new System.Drawing.Point(156, 174);
            this.btnReload.Name = "btnReload";
            this.btnReload.PressedColor = System.Drawing.Color.Aqua;
            this.btnReload.ShadowDecoration.Parent = this.btnReload;
            this.btnReload.Size = new System.Drawing.Size(36, 36);
            this.btnReload.TabIndex = 75;
            this.btnReload.Tag = "";
            this.btnReload.Text = "⟲";
            this.btnReload.TextOffset = new System.Drawing.Point(0, -2);
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // PK_CompanyName
            // 
            this.PK_CompanyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PK_CompanyName.DataPropertyName = "PK_CompanyName";
            this.PK_CompanyName.FillWeight = 45F;
            this.PK_CompanyName.HeaderText = "COMPANY NAME";
            this.PK_CompanyName.Name = "PK_CompanyName";
            this.PK_CompanyName.ReadOnly = true;
            // 
            // CompanyAddress
            // 
            this.CompanyAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CompanyAddress.DataPropertyName = "CompanyAddress";
            this.CompanyAddress.HeaderText = "ADDRESS";
            this.CompanyAddress.Name = "CompanyAddress";
            this.CompanyAddress.ReadOnly = true;
            // 
            // CompanyINN
            // 
            this.CompanyINN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CompanyINN.DataPropertyName = "CompanyINN";
            this.CompanyINN.FillWeight = 25F;
            this.CompanyINN.HeaderText = "INN";
            this.CompanyINN.Name = "CompanyINN";
            this.CompanyINN.ReadOnly = true;
            // 
            // CompanyBankBill
            // 
            this.CompanyBankBill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CompanyBankBill.DataPropertyName = "CompanyBankBill";
            this.CompanyBankBill.FillWeight = 25F;
            this.CompanyBankBill.HeaderText = "BANK BILL";
            this.CompanyBankBill.Name = "CompanyBankBill";
            this.CompanyBankBill.ReadOnly = true;
            // 
            // CompanyBIK
            // 
            this.CompanyBIK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CompanyBIK.DataPropertyName = "CompanyBIK";
            this.CompanyBIK.FillWeight = 25F;
            this.CompanyBIK.HeaderText = "BIK";
            this.CompanyBIK.Name = "CompanyBIK";
            this.CompanyBIK.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1424, 1019);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.labelPotatoCorp);
            this.Controls.Add(this.panelEmpProfile);
            this.Controls.Add(this.ShadowPanel);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.panelAccounts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1440, 1058);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "N20 Lab";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ShadowPanel.ResumeLayout(false);
            this.ShadowPanel.PerformLayout();
            this.panelCRUDinsurance.ResumeLayout(false);
            this.panelCRUDinsurance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsurance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccessLvls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.panelCRUDaccounts.ResumeLayout(false);
            this.panelCRUDaccounts.PerformLayout();
            this.panelEmpProfile.ResumeLayout(false);
            this.panelEmpProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPhoto)).EndInit();
            this.panelMainMenu.ResumeLayout(false);
            this.panelMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelAccounts.ResumeLayout(false);
            this.panelAccounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private Guna.UI2.WinForms.Guna2ShadowPanel ShadowPanel;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelEmpProfile;
        private System.Windows.Forms.PictureBox pictureBoxUserPhoto;
        private System.Windows.Forms.Label labelHeader;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelMainMenu;
        private System.Windows.Forms.Label labelPotatoCorp;
        private System.Windows.Forms.Label labelSpeciality;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button buttonLogout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button btnAnalyzer;
        private Guna.UI2.WinForms.Guna2Button btnOrders;
        private Guna.UI2.WinForms.Guna2Button btnServices;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2Button btnClients;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Guna.UI2.WinForms.Guna2Button btnAccess;
        private Guna.UI2.WinForms.Guna2Button btnInsurance;
        private Guna.UI2.WinForms.Guna2Button btnAccounts;
        private Guna.UI2.WinForms.Guna2Button btnReports;
        private Guna.UI2.WinForms.Guna2Button btnBackToMenu;
        private Guna.UI2.WinForms.Guna2DataGridView dgvServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceDeadlineInDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceAverageDeviation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelAccounts;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Panel panelCRUDaccounts;
        private Guna.UI2.WinForms.Guna2Button btnCloseRowAccount;
        private Guna.UI2.WinForms.Guna2Button btnSaveUpdateAccount;
        private Guna.UI2.WinForms.Guna2Button btnDeleteAccount;
        private Guna.UI2.WinForms.Guna2Button btnClearAccountTxt;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtIP;
        private Guna.UI2.WinForms.Guna2TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtLogin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox txtPass;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox lbAccessLvl;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpWasOnline;
        private Guna.UI2.WinForms.Guna2Button btnAddNew;
        private Guna.UI2.WinForms.Guna2Button btnReload;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAccounts;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAccessLvls;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_AccessLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn UQ_AccessLevelType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessLevelDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtDescriptionEdit;
        private System.Windows.Forms.Label labelDecript;
        private Guna.UI2.WinForms.Guna2DataGridView dgvInsurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_AccountId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FK_AccountAccessLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn UQ_AccountLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountIpAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountLastEnter;
        private Guna.UI2.WinForms.Guna2Panel panelCRUDinsurance;
        private Guna.UI2.WinForms.Guna2Button btnPanelCompClose;
        private Guna.UI2.WinForms.Guna2Button btnSaveUpdateComp;
        private Guna.UI2.WinForms.Guna2Button btnDeleteComp;
        private Guna.UI2.WinForms.Guna2Button btnClearCompanyTxt;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtCompBIK;
        private Guna.UI2.WinForms.Guna2TextBox txtCompAddress;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2TextBox txtPKCompName;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2TextBox txtCompINN;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2TextBox txtCompBill;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyINN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyBankBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyBIK;
    }
}


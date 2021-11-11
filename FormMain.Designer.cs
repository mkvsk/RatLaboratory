
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ShadowPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panelCRUD = new Guna.UI2.WinForms.Guna2Panel();
            this.dtpWasOnline = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbAccessLvl = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCloseRowAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
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
            this.txtWasOnline = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
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
            this.panelAccount = new Guna.UI2.WinForms.Guna2ShadowPanel();
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
            this.btnAddNewClient = new Guna.UI2.WinForms.Guna2Button();
            this.btnReloadTable = new Guna.UI2.WinForms.Guna2Button();
            this.ShadowPanel.SuspendLayout();
            this.panelCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.panelAccount.SuspendLayout();
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
            this.ShadowPanel.Controls.Add(this.panelCRUD);
            this.ShadowPanel.Controls.Add(this.dgvAccounts);
            this.ShadowPanel.Controls.Add(this.dgvServices);
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
            // panelCRUD
            // 
            this.panelCRUD.BackColor = System.Drawing.Color.White;
            this.panelCRUD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelCRUD.BorderThickness = 3;
            this.panelCRUD.Controls.Add(this.dtpWasOnline);
            this.panelCRUD.Controls.Add(this.lbAccessLvl);
            this.panelCRUD.Controls.Add(this.label11);
            this.panelCRUD.Controls.Add(this.btnCloseRowAccount);
            this.panelCRUD.Controls.Add(this.btnSave);
            this.panelCRUD.Controls.Add(this.btnDelete);
            this.panelCRUD.Controls.Add(this.btnClear);
            this.panelCRUD.Controls.Add(this.label5);
            this.panelCRUD.Controls.Add(this.txtIP);
            this.panelCRUD.Controls.Add(this.textBox3);
            this.panelCRUD.Controls.Add(this.label6);
            this.panelCRUD.Controls.Add(this.txtID);
            this.panelCRUD.Controls.Add(this.label7);
            this.panelCRUD.Controls.Add(this.txtLogin);
            this.panelCRUD.Controls.Add(this.label12);
            this.panelCRUD.Controls.Add(this.label13);
            this.panelCRUD.Controls.Add(this.txtPass);
            this.panelCRUD.Controls.Add(this.txtWasOnline);
            this.panelCRUD.Controls.Add(this.label14);
            this.panelCRUD.Location = new System.Drawing.Point(402, 170);
            this.panelCRUD.Name = "panelCRUD";
            this.panelCRUD.ShadowDecoration.Parent = this.panelCRUD;
            this.panelCRUD.Size = new System.Drawing.Size(564, 447);
            this.panelCRUD.TabIndex = 72;
            this.panelCRUD.Visible = false;
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
            this.dtpWasOnline.Location = new System.Drawing.Point(193, 255);
            this.dtpWasOnline.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpWasOnline.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpWasOnline.Name = "dtpWasOnline";
            this.dtpWasOnline.ShadowDecoration.Parent = this.dtpWasOnline;
            this.dtpWasOnline.Size = new System.Drawing.Size(337, 36);
            this.dtpWasOnline.TabIndex = 73;
            this.dtpWasOnline.Value = new System.DateTime(2021, 11, 10, 22, 57, 46, 617);
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Location = new System.Drawing.Point(422, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 21);
            this.label11.TabIndex = 71;
            this.label11.Text = "MM/dd/yyyy";
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
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.BorderRadius = 6;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnSave.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.DisabledState.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSave.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.Location = new System.Drawing.Point(426, 386);
            this.btnSave.Name = "btnSave";
            this.btnSave.PressedColor = System.Drawing.Color.Green;
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(105, 36);
            this.btnSave.TabIndex = 67;
            this.btnSave.Tag = "";
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.BorderRadius = 6;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnDelete.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.DisabledState.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnDelete.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDelete.Location = new System.Drawing.Point(309, 386);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PressedColor = System.Drawing.Color.Red;
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(105, 36);
            this.btnDelete.TabIndex = 66;
            this.btnDelete.Tag = "";
            this.btnDelete.Text = "DELETE";
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
            // 
            // txtWasOnline
            // 
            this.txtWasOnline.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWasOnline.DefaultText = "";
            this.txtWasOnline.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWasOnline.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtWasOnline.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWasOnline.DisabledState.Parent = this.txtWasOnline;
            this.txtWasOnline.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWasOnline.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWasOnline.FocusedState.Parent = this.txtWasOnline;
            this.txtWasOnline.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtWasOnline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.txtWasOnline.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWasOnline.HoverState.Parent = this.txtWasOnline;
            this.txtWasOnline.Location = new System.Drawing.Point(192, 255);
            this.txtWasOnline.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWasOnline.Name = "txtWasOnline";
            this.txtWasOnline.PasswordChar = '\0';
            this.txtWasOnline.PlaceholderText = "";
            this.txtWasOnline.SelectedText = "";
            this.txtWasOnline.ShadowDecoration.Parent = this.txtWasOnline;
            this.txtWasOnline.Size = new System.Drawing.Size(339, 36);
            this.txtWasOnline.TabIndex = 6;
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
            // dgvAccounts
            // 
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AllowUserToDeleteRows = false;
            this.dgvAccounts.AllowUserToResizeColumns = false;
            this.dgvAccounts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAccounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccounts.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAccounts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAccounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAccounts.ColumnHeadersHeight = 60;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_AccountId,
            this.FK_AccountAccessLevel,
            this.UQ_AccountLogin,
            this.AccountPass,
            this.AccountIpAddress,
            this.AccountLastEnter});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccounts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAccounts.EnableHeadersVisualStyles = false;
            this.dgvAccounts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvAccounts.Location = new System.Drawing.Point(20, 20);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccounts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            this.dgvAccounts.ThemeStyle.HeaderStyle.Height = 60;
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
            this.PK_AccountId.DataPropertyName = "PK_AccountId";
            this.PK_AccountId.HeaderText = "ID";
            this.PK_AccountId.Name = "PK_AccountId";
            this.PK_AccountId.ReadOnly = true;
            // 
            // FK_AccountAccessLevel
            // 
            this.FK_AccountAccessLevel.DataPropertyName = "FK_AccountAccessLevel";
            this.FK_AccountAccessLevel.HeaderText = "ACCESS CODE";
            this.FK_AccountAccessLevel.Name = "FK_AccountAccessLevel";
            this.FK_AccountAccessLevel.ReadOnly = true;
            // 
            // UQ_AccountLogin
            // 
            this.UQ_AccountLogin.DataPropertyName = "UQ_AccountLogin";
            this.UQ_AccountLogin.HeaderText = "LOGIN";
            this.UQ_AccountLogin.Name = "UQ_AccountLogin";
            this.UQ_AccountLogin.ReadOnly = true;
            // 
            // AccountPass
            // 
            this.AccountPass.DataPropertyName = "AccountPass";
            this.AccountPass.HeaderText = "PASS";
            this.AccountPass.Name = "AccountPass";
            this.AccountPass.ReadOnly = true;
            // 
            // AccountIpAddress
            // 
            this.AccountIpAddress.DataPropertyName = "AccountIpAddress";
            this.AccountIpAddress.HeaderText = "IP";
            this.AccountIpAddress.Name = "AccountIpAddress";
            this.AccountIpAddress.ReadOnly = true;
            // 
            // AccountLastEnter
            // 
            this.AccountLastEnter.DataPropertyName = "AccountLastEnter";
            this.AccountLastEnter.HeaderText = "WAS ONLINE";
            this.AccountLastEnter.Name = "AccountLastEnter";
            this.AccountLastEnter.ReadOnly = true;
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.AllowUserToResizeColumns = false;
            this.dgvServices.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvServices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServices.BackgroundColor = System.Drawing.Color.White;
            this.dgvServices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvServices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvServices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvServices.ColumnHeadersHeight = 40;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceCode,
            this.ServiceName,
            this.ServicePrice,
            this.ServiceDeadlineInDays,
            this.ServiceAverageDeviation,
            this.Column1});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServices.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvServices.EnableHeadersVisualStyles = false;
            this.dgvServices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvServices.Location = new System.Drawing.Point(20, 20);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServices.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
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
            // panelAccount
            // 
            this.panelAccount.BackColor = System.Drawing.Color.Transparent;
            this.panelAccount.Controls.Add(this.guna2Button1);
            this.panelAccount.Controls.Add(this.buttonLogout);
            this.panelAccount.Controls.Add(this.labelSpeciality);
            this.panelAccount.Controls.Add(this.label1);
            this.panelAccount.Controls.Add(this.pictureBoxUserPhoto);
            this.panelAccount.Controls.Add(this.labelFullName);
            this.panelAccount.Controls.Add(this.label2);
            this.panelAccount.FillColor = System.Drawing.Color.White;
            this.panelAccount.Location = new System.Drawing.Point(916, 12);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Radius = 3;
            this.panelAccount.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.panelAccount.ShadowDepth = 40;
            this.panelAccount.ShadowShift = 6;
            this.panelAccount.Size = new System.Drawing.Size(475, 156);
            this.panelAccount.TabIndex = 13;
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
            this.btnAddNewClient.Location = new System.Drawing.Point(198, 174);
            this.btnAddNewClient.Name = "btnAddNewClient";
            this.btnAddNewClient.PressedColor = System.Drawing.Color.Lime;
            this.btnAddNewClient.ShadowDecoration.Parent = this.btnAddNewClient;
            this.btnAddNewClient.Size = new System.Drawing.Size(206, 36);
            this.btnAddNewClient.TabIndex = 74;
            this.btnAddNewClient.Tag = "";
            this.btnAddNewClient.Text = "ADD NEW";
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
            this.btnReloadTable.Location = new System.Drawing.Point(156, 174);
            this.btnReloadTable.Name = "btnReloadTable";
            this.btnReloadTable.PressedColor = System.Drawing.Color.Aqua;
            this.btnReloadTable.ShadowDecoration.Parent = this.btnReloadTable;
            this.btnReloadTable.Size = new System.Drawing.Size(36, 36);
            this.btnReloadTable.TabIndex = 75;
            this.btnReloadTable.Tag = "";
            this.btnReloadTable.Text = "⟲";
            this.btnReloadTable.TextOffset = new System.Drawing.Point(0, -2);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1424, 1019);
            this.Controls.Add(this.btnReloadTable);
            this.Controls.Add(this.btnAddNewClient);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.labelPotatoCorp);
            this.Controls.Add(this.panelAccount);
            this.Controls.Add(this.ShadowPanel);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.panelAccounts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1440, 1058);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "N20 Lab";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ShadowPanel.ResumeLayout(false);
            this.panelCRUD.ResumeLayout(false);
            this.panelCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.panelAccount.ResumeLayout(false);
            this.panelAccount.PerformLayout();
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
        private Guna.UI2.WinForms.Guna2ShadowPanel panelAccount;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_AccountId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FK_AccountAccessLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn UQ_AccountLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountIpAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountLastEnter;
        private Guna.UI2.WinForms.Guna2Panel panelCRUD;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2Button btnCloseRowAccount;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnClear;
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
        private Guna.UI2.WinForms.Guna2TextBox txtWasOnline;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox lbAccessLvl;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpWasOnline;
        private Guna.UI2.WinForms.Guna2Button btnAddNewClient;
        private Guna.UI2.WinForms.Guna2Button btnReloadTable;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAccounts;
    }
}


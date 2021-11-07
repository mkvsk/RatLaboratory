
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ShadowPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dgvServices = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PK_ServiceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UQ_ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceDeadlineInDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceAverageDeviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panelClientsSearch = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReloadTable = new Guna.UI2.WinForms.Guna2Button();
            this.btnBackToMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewClient = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditData = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveData = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteData = new Guna.UI2.WinForms.Guna2Button();
            this.panelBtnClients = new Guna.UI2.WinForms.Guna2Panel();
            this.ShadowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.panelAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPhoto)).BeginInit();
            this.panelMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelClientsSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panelBtnClients.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShadowPanel
            // 
            this.ShadowPanel.BackColor = System.Drawing.Color.Transparent;
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
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.AllowUserToResizeColumns = false;
            this.dgvServices.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvServices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServices.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvServices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvServices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvServices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvServices.ColumnHeadersHeight = 21;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_ServiceCode,
            this.UQ_ServiceName,
            this.ServicePrice,
            this.ServiceDeadlineInDays,
            this.ServiceAverageDeviation});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServices.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvServices.EnableHeadersVisualStyles = false;
            this.dgvServices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvServices.Location = new System.Drawing.Point(20, 20);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RowHeadersVisible = false;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(1321, 744);
            this.dgvServices.TabIndex = 0;
            this.dgvServices.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvServices.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvServices.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvServices.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvServices.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvServices.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvServices.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvServices.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvServices.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvServices.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvServices.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvServices.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvServices.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvServices.ThemeStyle.ReadOnly = true;
            this.dgvServices.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvServices.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvServices.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvServices.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvServices.ThemeStyle.RowsStyle.Height = 22;
            this.dgvServices.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvServices.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // PK_ServiceCode
            // 
            this.PK_ServiceCode.DataPropertyName = "PK_ServiceCode";
            this.PK_ServiceCode.HeaderText = "CODE";
            this.PK_ServiceCode.Name = "PK_ServiceCode";
            this.PK_ServiceCode.ReadOnly = true;
            // 
            // UQ_ServiceName
            // 
            this.UQ_ServiceName.DataPropertyName = "UQ_ServiceName";
            this.UQ_ServiceName.HeaderText = "NAME";
            this.UQ_ServiceName.Name = "UQ_ServiceName";
            this.UQ_ServiceName.ReadOnly = true;
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
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(133, 27);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.Red;
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
            this.buttonLogout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.buttonLogout.BorderRadius = 6;
            this.buttonLogout.BorderThickness = 3;
            this.buttonLogout.CheckedState.Parent = this.buttonLogout;
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonLogout.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.buttonLogout.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonLogout.CustomImages.Parent = this.buttonLogout;
            this.buttonLogout.DisabledState.Parent = this.buttonLogout;
            this.buttonLogout.FillColor = System.Drawing.Color.Transparent;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
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
            this.buttonLogout.Text = "LogOut";
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
            this.btnAccess.FillColor = System.Drawing.Color.Transparent;
            this.btnAccess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnAccess.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.btnAccess.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAccess.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAccess.HoverState.Parent = this.btnAccess;
            this.btnAccess.Location = new System.Drawing.Point(266, 64);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.PressedColor = System.Drawing.Color.Red;
            this.btnAccess.ShadowDecoration.Parent = this.btnAccess;
            this.btnAccess.Size = new System.Drawing.Size(115, 35);
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
            this.btnInsurance.FillColor = System.Drawing.Color.Transparent;
            this.btnInsurance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnInsurance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnInsurance.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.btnInsurance.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnInsurance.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInsurance.HoverState.Parent = this.btnInsurance;
            this.btnInsurance.Location = new System.Drawing.Point(133, 107);
            this.btnInsurance.Name = "btnInsurance";
            this.btnInsurance.PressedColor = System.Drawing.Color.Red;
            this.btnInsurance.ShadowDecoration.Parent = this.btnInsurance;
            this.btnInsurance.Size = new System.Drawing.Size(127, 35);
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
            this.btnAccounts.FillColor = System.Drawing.Color.Transparent;
            this.btnAccounts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAccounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnAccounts.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.btnAccounts.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAccounts.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAccounts.HoverState.Parent = this.btnAccounts;
            this.btnAccounts.Location = new System.Drawing.Point(133, 64);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.PressedColor = System.Drawing.Color.Red;
            this.btnAccounts.ShadowDecoration.Parent = this.btnAccounts;
            this.btnAccounts.Size = new System.Drawing.Size(127, 35);
            this.btnAccounts.TabIndex = 59;
            this.btnAccounts.Tag = "";
            this.btnAccounts.Text = "ACCOUNTS";
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
            this.btnReports.FillColor = System.Drawing.Color.Transparent;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnReports.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.btnReports.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnReports.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReports.HoverState.Parent = this.btnReports;
            this.btnReports.Location = new System.Drawing.Point(266, 107);
            this.btnReports.Name = "btnReports";
            this.btnReports.PressedColor = System.Drawing.Color.Red;
            this.btnReports.ShadowDecoration.Parent = this.btnReports;
            this.btnReports.Size = new System.Drawing.Size(115, 35);
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
            this.btnClients.FillColor = System.Drawing.Color.Transparent;
            this.btnClients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnClients.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.btnClients.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClients.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClients.HoverState.Parent = this.btnClients;
            this.btnClients.Location = new System.Drawing.Point(387, 107);
            this.btnClients.Name = "btnClients";
            this.btnClients.PressedColor = System.Drawing.Color.Red;
            this.btnClients.ShadowDecoration.Parent = this.btnClients;
            this.btnClients.Size = new System.Drawing.Size(115, 35);
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
            this.btnAnalyzer.FillColor = System.Drawing.Color.Transparent;
            this.btnAnalyzer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnalyzer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnAnalyzer.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.btnAnalyzer.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAnalyzer.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAnalyzer.HoverState.Parent = this.btnAnalyzer;
            this.btnAnalyzer.Location = new System.Drawing.Point(629, 107);
            this.btnAnalyzer.Name = "btnAnalyzer";
            this.btnAnalyzer.PressedColor = System.Drawing.Color.Red;
            this.btnAnalyzer.ShadowDecoration.Parent = this.btnAnalyzer;
            this.btnAnalyzer.Size = new System.Drawing.Size(115, 35);
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
            this.btnOrders.FillColor = System.Drawing.Color.Transparent;
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnOrders.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.btnOrders.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnOrders.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOrders.HoverState.Parent = this.btnOrders;
            this.btnOrders.Location = new System.Drawing.Point(750, 106);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.PressedColor = System.Drawing.Color.Red;
            this.btnOrders.ShadowDecoration.Parent = this.btnOrders;
            this.btnOrders.Size = new System.Drawing.Size(115, 35);
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
            this.btnServices.FillColor = System.Drawing.Color.Transparent;
            this.btnServices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnServices.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.btnServices.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnServices.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnServices.HoverState.Parent = this.btnServices;
            this.btnServices.Location = new System.Drawing.Point(508, 107);
            this.btnServices.Name = "btnServices";
            this.btnServices.PressedColor = System.Drawing.Color.Red;
            this.btnServices.ShadowDecoration.Parent = this.btnServices;
            this.btnServices.Size = new System.Drawing.Size(115, 35);
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
            // panelClientsSearch
            // 
            this.panelClientsSearch.BackColor = System.Drawing.Color.Transparent;
            this.panelClientsSearch.Controls.Add(this.guna2TextBox1);
            this.panelClientsSearch.Controls.Add(this.label5);
            this.panelClientsSearch.Controls.Add(this.labelTotal);
            this.panelClientsSearch.Controls.Add(this.textBoxTotal);
            this.panelClientsSearch.Controls.Add(this.pictureBox6);
            this.panelClientsSearch.Controls.Add(this.label6);
            this.panelClientsSearch.FillColor = System.Drawing.Color.White;
            this.panelClientsSearch.Location = new System.Drawing.Point(29, 12);
            this.panelClientsSearch.Name = "panelClientsSearch";
            this.panelClientsSearch.Radius = 3;
            this.panelClientsSearch.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.panelClientsSearch.ShadowDepth = 50;
            this.panelClientsSearch.ShadowShift = 6;
            this.panelClientsSearch.Size = new System.Drawing.Size(881, 156);
            this.panelClientsSearch.TabIndex = 61;
            this.panelClientsSearch.Visible = false;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.guna2TextBox1.BorderRadius = 3;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(133, 101);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(730, 32);
            this.guna2TextBox1.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label5.Location = new System.Drawing.Point(190, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 32);
            this.label5.TabIndex = 50;
            this.label5.Text = "CLIENTS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label6.Location = new System.Drawing.Point(126, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 40);
            this.label6.TabIndex = 39;
            this.label6.Text = "N20";
            // 
            // btnReloadTable
            // 
            this.btnReloadTable.BackColor = System.Drawing.Color.Transparent;
            this.btnReloadTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReloadTable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnReloadTable.BorderRadius = 6;
            this.btnReloadTable.BorderThickness = 3;
            this.btnReloadTable.CheckedState.Parent = this.btnReloadTable;
            this.btnReloadTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReloadTable.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReloadTable.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnReloadTable.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnReloadTable.CustomImages.Parent = this.btnReloadTable;
            this.btnReloadTable.DisabledState.Parent = this.btnReloadTable;
            this.btnReloadTable.FillColor = System.Drawing.Color.White;
            this.btnReloadTable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReloadTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnReloadTable.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.btnReloadTable.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnReloadTable.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReloadTable.HoverState.Parent = this.btnReloadTable;
            this.btnReloadTable.Image = ((System.Drawing.Image)(resources.GetObject("btnReloadTable.Image")));
            this.btnReloadTable.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReloadTable.Location = new System.Drawing.Point(205, 3);
            this.btnReloadTable.Name = "btnReloadTable";
            this.btnReloadTable.PressedColor = System.Drawing.Color.Red;
            this.btnReloadTable.ShadowDecoration.Parent = this.btnReloadTable;
            this.btnReloadTable.Size = new System.Drawing.Size(178, 36);
            this.btnReloadTable.TabIndex = 67;
            this.btnReloadTable.Tag = "";
            this.btnReloadTable.Text = "RELOAD PAGE";
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnBackToMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBackToMenu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnBackToMenu.BorderRadius = 6;
            this.btnBackToMenu.BorderThickness = 3;
            this.btnBackToMenu.CheckedState.Parent = this.btnBackToMenu;
            this.btnBackToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToMenu.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBackToMenu.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnBackToMenu.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBackToMenu.CustomImages.Parent = this.btnBackToMenu;
            this.btnBackToMenu.DisabledState.Parent = this.btnBackToMenu;
            this.btnBackToMenu.FillColor = System.Drawing.Color.White;
            this.btnBackToMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBackToMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnBackToMenu.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.btnBackToMenu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBackToMenu.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBackToMenu.HoverState.Parent = this.btnBackToMenu;
            this.btnBackToMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnBackToMenu.Image")));
            this.btnBackToMenu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBackToMenu.Location = new System.Drawing.Point(21, 3);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.PressedColor = System.Drawing.Color.Red;
            this.btnBackToMenu.ShadowDecoration.Parent = this.btnBackToMenu;
            this.btnBackToMenu.Size = new System.Drawing.Size(178, 36);
            this.btnBackToMenu.TabIndex = 66;
            this.btnBackToMenu.Tag = "";
            this.btnBackToMenu.Text = "BACK";
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // btnAddNewClient
            // 
            this.btnAddNewClient.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewClient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddNewClient.BorderRadius = 6;
            this.btnAddNewClient.BorderThickness = 3;
            this.btnAddNewClient.CheckedState.Parent = this.btnAddNewClient;
            this.btnAddNewClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewClient.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddNewClient.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnAddNewClient.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddNewClient.CustomImages.Parent = this.btnAddNewClient;
            this.btnAddNewClient.DisabledState.Parent = this.btnAddNewClient;
            this.btnAddNewClient.FillColor = System.Drawing.Color.White;
            this.btnAddNewClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddNewClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnAddNewClient.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.btnAddNewClient.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddNewClient.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddNewClient.HoverState.Parent = this.btnAddNewClient;
            this.btnAddNewClient.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewClient.Image")));
            this.btnAddNewClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewClient.Location = new System.Drawing.Point(389, 3);
            this.btnAddNewClient.Name = "btnAddNewClient";
            this.btnAddNewClient.PressedColor = System.Drawing.Color.Red;
            this.btnAddNewClient.ShadowDecoration.Parent = this.btnAddNewClient;
            this.btnAddNewClient.Size = new System.Drawing.Size(206, 36);
            this.btnAddNewClient.TabIndex = 65;
            this.btnAddNewClient.Tag = "";
            this.btnAddNewClient.Text = "ADD NEW";
            this.btnAddNewClient.Click += new System.EventHandler(this.btnAddNewClient_Click);
            // 
            // btnEditData
            // 
            this.btnEditData.BackColor = System.Drawing.Color.Transparent;
            this.btnEditData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditData.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnEditData.BorderRadius = 6;
            this.btnEditData.BorderThickness = 3;
            this.btnEditData.CheckedState.Parent = this.btnEditData;
            this.btnEditData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditData.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditData.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnEditData.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEditData.CustomImages.Parent = this.btnEditData;
            this.btnEditData.DisabledState.Parent = this.btnEditData;
            this.btnEditData.Enabled = false;
            this.btnEditData.FillColor = System.Drawing.Color.White;
            this.btnEditData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnEditData.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.btnEditData.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEditData.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditData.HoverState.Parent = this.btnEditData;
            this.btnEditData.Image = ((System.Drawing.Image)(resources.GetObject("btnEditData.Image")));
            this.btnEditData.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEditData.Location = new System.Drawing.Point(711, 3);
            this.btnEditData.Name = "btnEditData";
            this.btnEditData.PressedColor = System.Drawing.Color.Red;
            this.btnEditData.ShadowDecoration.Parent = this.btnEditData;
            this.btnEditData.Size = new System.Drawing.Size(206, 36);
            this.btnEditData.TabIndex = 62;
            this.btnEditData.Tag = "";
            this.btnEditData.Text = "EDIT";
            // 
            // btnSaveData
            // 
            this.btnSaveData.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveData.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSaveData.BorderRadius = 6;
            this.btnSaveData.BorderThickness = 3;
            this.btnSaveData.CheckedState.Parent = this.btnSaveData;
            this.btnSaveData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveData.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveData.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnSaveData.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSaveData.CustomImages.Parent = this.btnSaveData;
            this.btnSaveData.DisabledState.Parent = this.btnSaveData;
            this.btnSaveData.Enabled = false;
            this.btnSaveData.FillColor = System.Drawing.Color.White;
            this.btnSaveData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnSaveData.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.btnSaveData.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSaveData.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaveData.HoverState.Parent = this.btnSaveData;
            this.btnSaveData.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveData.Image")));
            this.btnSaveData.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSaveData.Location = new System.Drawing.Point(923, 2);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.PressedColor = System.Drawing.Color.Red;
            this.btnSaveData.ShadowDecoration.Parent = this.btnSaveData;
            this.btnSaveData.Size = new System.Drawing.Size(206, 36);
            this.btnSaveData.TabIndex = 64;
            this.btnSaveData.Tag = "";
            this.btnSaveData.Text = "SAVE";
            // 
            // btnDeleteData
            // 
            this.btnDeleteData.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteData.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteData.BorderRadius = 6;
            this.btnDeleteData.BorderThickness = 3;
            this.btnDeleteData.CheckedState.Parent = this.btnDeleteData;
            this.btnDeleteData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteData.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteData.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnDeleteData.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDeleteData.CustomImages.Parent = this.btnDeleteData;
            this.btnDeleteData.DisabledState.Parent = this.btnDeleteData;
            this.btnDeleteData.FillColor = System.Drawing.Color.White;
            this.btnDeleteData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnDeleteData.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDeleteData.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteData.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteData.HoverState.Parent = this.btnDeleteData;
            this.btnDeleteData.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteData.Image")));
            this.btnDeleteData.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteData.Location = new System.Drawing.Point(1135, 2);
            this.btnDeleteData.Name = "btnDeleteData";
            this.btnDeleteData.PressedColor = System.Drawing.Color.Red;
            this.btnDeleteData.ShadowDecoration.Parent = this.btnDeleteData;
            this.btnDeleteData.Size = new System.Drawing.Size(206, 36);
            this.btnDeleteData.TabIndex = 63;
            this.btnDeleteData.Tag = "";
            this.btnDeleteData.Text = "DELETE";
            // 
            // panelBtnClients
            // 
            this.panelBtnClients.Controls.Add(this.btnReloadTable);
            this.panelBtnClients.Controls.Add(this.btnDeleteData);
            this.panelBtnClients.Controls.Add(this.btnBackToMenu);
            this.panelBtnClients.Controls.Add(this.btnAddNewClient);
            this.panelBtnClients.Controls.Add(this.btnEditData);
            this.panelBtnClients.Controls.Add(this.btnSaveData);
            this.panelBtnClients.Location = new System.Drawing.Point(29, 174);
            this.panelBtnClients.Name = "panelBtnClients";
            this.panelBtnClients.ShadowDecoration.Parent = this.panelBtnClients;
            this.panelBtnClients.Size = new System.Drawing.Size(1362, 38);
            this.panelBtnClients.TabIndex = 68;
            this.panelBtnClients.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1424, 1019);
            this.Controls.Add(this.panelClientsSearch);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.labelPotatoCorp);
            this.Controls.Add(this.panelAccount);
            this.Controls.Add(this.ShadowPanel);
            this.Controls.Add(this.panelBtnClients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1440, 1058);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "N20 Lab";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ShadowPanel.ResumeLayout(false);
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
            this.panelClientsSearch.ResumeLayout(false);
            this.panelClientsSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panelBtnClients.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2ShadowPanel panelClientsSearch;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label textBoxTotal;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnReloadTable;
        private Guna.UI2.WinForms.Guna2Button btnBackToMenu;
        private Guna.UI2.WinForms.Guna2Button btnDeleteData;
        private Guna.UI2.WinForms.Guna2Button btnAddNewClient;
        private Guna.UI2.WinForms.Guna2Button btnSaveData;
        private Guna.UI2.WinForms.Guna2Button btnEditData;
        private Guna.UI2.WinForms.Guna2Panel panelBtnClients;
        private Guna.UI2.WinForms.Guna2DataGridView dgvServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_ServiceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn UQ_ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceDeadlineInDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceAverageDeviation;
    }
}


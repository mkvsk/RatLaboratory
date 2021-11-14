
namespace RAT_Lab
{
    partial class FormOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrders));
            this.ShadowPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnSaveUpdateOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnClearOrderTxt = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewOrder = new Guna.UI2.WinForms.Guna2Button();
            this.dgvOrders = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnReloadTable = new Guna.UI2.WinForms.Guna2Button();
            this.PK_OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FK_OrderServices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FK_ClientPassport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbSearchBy = new System.Windows.Forms.ListBox();
            this.ShadowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // ShadowPanel
            // 
            this.ShadowPanel.BackColor = System.Drawing.Color.Transparent;
            this.ShadowPanel.Controls.Add(this.lbSearchBy);
            this.ShadowPanel.Controls.Add(this.txtSearch);
            this.ShadowPanel.Controls.Add(this.btnNewOrder);
            this.ShadowPanel.Controls.Add(this.btnClearOrderTxt);
            this.ShadowPanel.Controls.Add(this.dgvOrders);
            this.ShadowPanel.Controls.Add(this.btnSaveUpdateOrder);
            this.ShadowPanel.Controls.Add(this.btnDeleteOrder);
            this.ShadowPanel.Controls.Add(this.btnReloadTable);
            this.ShadowPanel.FillColor = System.Drawing.Color.White;
            this.ShadowPanel.Location = new System.Drawing.Point(13, 9);
            this.ShadowPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ShadowPanel.Name = "ShadowPanel";
            this.ShadowPanel.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.ShadowPanel.Radius = 3;
            this.ShadowPanel.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.ShadowPanel.ShadowShift = 6;
            this.ShadowPanel.Size = new System.Drawing.Size(1362, 824);
            this.ShadowPanel.TabIndex = 73;
            // 
            // btnSaveUpdateOrder
            // 
            this.btnSaveUpdateOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveUpdateOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveUpdateOrder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaveUpdateOrder.BorderRadius = 6;
            this.btnSaveUpdateOrder.CheckedState.Parent = this.btnSaveUpdateOrder;
            this.btnSaveUpdateOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveUpdateOrder.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveUpdateOrder.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnSaveUpdateOrder.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSaveUpdateOrder.CustomImages.Parent = this.btnSaveUpdateOrder;
            this.btnSaveUpdateOrder.DisabledState.Parent = this.btnSaveUpdateOrder;
            this.btnSaveUpdateOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSaveUpdateOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveUpdateOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaveUpdateOrder.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.btnSaveUpdateOrder.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSaveUpdateOrder.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaveUpdateOrder.HoverState.Parent = this.btnSaveUpdateOrder;
            this.btnSaveUpdateOrder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSaveUpdateOrder.Location = new System.Drawing.Point(1238, 767);
            this.btnSaveUpdateOrder.Name = "btnSaveUpdateOrder";
            this.btnSaveUpdateOrder.PressedColor = System.Drawing.Color.Green;
            this.btnSaveUpdateOrder.ShadowDecoration.Parent = this.btnSaveUpdateOrder;
            this.btnSaveUpdateOrder.Size = new System.Drawing.Size(105, 36);
            this.btnSaveUpdateOrder.TabIndex = 67;
            this.btnSaveUpdateOrder.Tag = "";
            this.btnSaveUpdateOrder.Text = "SAVE";
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteOrder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteOrder.BorderRadius = 6;
            this.btnDeleteOrder.CheckedState.Parent = this.btnDeleteOrder;
            this.btnDeleteOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteOrder.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteOrder.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnDeleteOrder.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDeleteOrder.CustomImages.Parent = this.btnDeleteOrder;
            this.btnDeleteOrder.DisabledState.Parent = this.btnDeleteOrder;
            this.btnDeleteOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnDeleteOrder.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDeleteOrder.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteOrder.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteOrder.HoverState.Parent = this.btnDeleteOrder;
            this.btnDeleteOrder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteOrder.Location = new System.Drawing.Point(1121, 767);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.PressedColor = System.Drawing.Color.Red;
            this.btnDeleteOrder.ShadowDecoration.Parent = this.btnDeleteOrder;
            this.btnDeleteOrder.Size = new System.Drawing.Size(105, 36);
            this.btnDeleteOrder.TabIndex = 66;
            this.btnDeleteOrder.Tag = "";
            this.btnDeleteOrder.Text = "DELETE";
            // 
            // btnClearOrderTxt
            // 
            this.btnClearOrderTxt.BackColor = System.Drawing.Color.Transparent;
            this.btnClearOrderTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClearOrderTxt.BorderColor = System.Drawing.Color.Silver;
            this.btnClearOrderTxt.BorderRadius = 6;
            this.btnClearOrderTxt.CheckedState.Parent = this.btnClearOrderTxt;
            this.btnClearOrderTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearOrderTxt.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClearOrderTxt.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnClearOrderTxt.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnClearOrderTxt.CustomImages.Parent = this.btnClearOrderTxt;
            this.btnClearOrderTxt.DisabledState.Parent = this.btnClearOrderTxt;
            this.btnClearOrderTxt.Enabled = false;
            this.btnClearOrderTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClearOrderTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearOrderTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnClearOrderTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnClearOrderTxt.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnClearOrderTxt.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnClearOrderTxt.HoverState.Parent = this.btnClearOrderTxt;
            this.btnClearOrderTxt.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClearOrderTxt.Location = new System.Drawing.Point(1004, 767);
            this.btnClearOrderTxt.Name = "btnClearOrderTxt";
            this.btnClearOrderTxt.PressedColor = System.Drawing.Color.White;
            this.btnClearOrderTxt.ShadowDecoration.Parent = this.btnClearOrderTxt;
            this.btnClearOrderTxt.Size = new System.Drawing.Size(105, 36);
            this.btnClearOrderTxt.TabIndex = 69;
            this.btnClearOrderTxt.Tag = "";
            this.btnClearOrderTxt.Text = "CLEAR";
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnNewOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNewOrder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNewOrder.BorderRadius = 6;
            this.btnNewOrder.CheckedState.Parent = this.btnNewOrder;
            this.btnNewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewOrder.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNewOrder.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.btnNewOrder.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btnNewOrder.CustomImages.Parent = this.btnNewOrder;
            this.btnNewOrder.DisabledState.Parent = this.btnNewOrder;
            this.btnNewOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNewOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNewOrder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNewOrder.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNewOrder.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnNewOrder.HoverState.Parent = this.btnNewOrder;
            this.btnNewOrder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNewOrder.Location = new System.Drawing.Point(63, 17);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.PressedColor = System.Drawing.Color.Lime;
            this.btnNewOrder.ShadowDecoration.Parent = this.btnNewOrder;
            this.btnNewOrder.Size = new System.Drawing.Size(206, 36);
            this.btnNewOrder.TabIndex = 65;
            this.btnNewOrder.Tag = "";
            this.btnNewOrder.Text = "NEW ORDER";
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AllowUserToResizeColumns = false;
            this.dgvOrders.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrders.ColumnHeadersHeight = 40;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_OrderId,
            this.OrderDate,
            this.OrderState,
            this.FK_OrderServices,
            this.FK_ClientPassport});
            this.dgvOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrders.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrders.EnableHeadersVisualStyles = false;
            this.dgvOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvOrders.Location = new System.Drawing.Point(21, 59);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOrders.RowTemplate.Height = 40;
            this.dgvOrders.RowTemplate.ReadOnly = true;
            this.dgvOrders.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(1322, 395);
            this.dgvOrders.TabIndex = 0;
            this.dgvOrders.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.dgvOrders.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvOrders.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvOrders.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvOrders.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvOrders.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvOrders.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrders.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvOrders.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvOrders.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOrders.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dgvOrders.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOrders.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrders.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvOrders.ThemeStyle.ReadOnly = true;
            this.dgvOrders.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgvOrders.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrders.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgvOrders.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvOrders.ThemeStyle.RowsStyle.Height = 40;
            this.dgvOrders.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvOrders.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
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
            // PK_OrderId
            // 
            this.PK_OrderId.HeaderText = "ORDER ID";
            this.PK_OrderId.Name = "PK_OrderId";
            this.PK_OrderId.ReadOnly = true;
            // 
            // OrderDate
            // 
            this.OrderDate.HeaderText = "DATE";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // OrderState
            // 
            this.OrderState.HeaderText = "STATE";
            this.OrderState.Name = "OrderState";
            this.OrderState.ReadOnly = true;
            // 
            // FK_OrderServices
            // 
            this.FK_OrderServices.HeaderText = "SERVICES";
            this.FK_OrderServices.Name = "FK_OrderServices";
            this.FK_OrderServices.ReadOnly = true;
            // 
            // FK_ClientPassport
            // 
            this.FK_ClientPassport.HeaderText = "ClientPassport";
            this.FK_ClientPassport.Name = "FK_ClientPassport";
            this.FK_ClientPassport.ReadOnly = true;
            this.FK_ClientPassport.Visible = false;
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
            this.txtSearch.Location = new System.Drawing.Point(520, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(491, 32);
            this.txtSearch.TabIndex = 70;
            // 
            // lbSearchBy
            // 
            this.lbSearchBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbSearchBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSearchBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSearchBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.lbSearchBy.FormattingEnabled = true;
            this.lbSearchBy.ItemHeight = 21;
            this.lbSearchBy.Items.AddRange(new object[] {
            "ID",
            "DATE",
            "STATE",
            "SERVICE",
            "CLIENT PASSPORT"});
            this.lbSearchBy.Location = new System.Drawing.Point(326, 32);
            this.lbSearchBy.Name = "lbSearchBy";
            this.lbSearchBy.Size = new System.Drawing.Size(188, 21);
            this.lbSearchBy.TabIndex = 73;
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 842);
            this.Controls.Add(this.ShadowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.ShadowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel ShadowPanel;
        private Guna.UI2.WinForms.Guna2Button btnSaveUpdateOrder;
        private Guna.UI2.WinForms.Guna2Button btnDeleteOrder;
        private Guna.UI2.WinForms.Guna2Button btnClearOrderTxt;
        private Guna.UI2.WinForms.Guna2Button btnNewOrder;
        private Guna.UI2.WinForms.Guna2DataGridView dgvOrders;
        private Guna.UI2.WinForms.Guna2Button btnReloadTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderState;
        private System.Windows.Forms.DataGridViewTextBoxColumn FK_OrderServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn FK_ClientPassport;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.ListBox lbSearchBy;
    }
}
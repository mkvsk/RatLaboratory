
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ShadowPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panelAccount = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.buttonLogout = new Guna.UI2.WinForms.Guna2Button();
            this.labelSpeciality = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxUserPhoto = new System.Windows.Forms.PictureBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxActive = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.Label();
            this.labelActive = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panelHeaderRight = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.labelPotatoCorp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPhoto)).BeginInit();
            this.panelHeaderRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShadowPanel
            // 
            this.ShadowPanel.BackColor = System.Drawing.Color.Transparent;
            this.ShadowPanel.FillColor = System.Drawing.Color.White;
            this.ShadowPanel.Location = new System.Drawing.Point(29, 200);
            this.ShadowPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ShadowPanel.Name = "ShadowPanel";
            this.ShadowPanel.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.ShadowPanel.Radius = 3;
            this.ShadowPanel.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.ShadowPanel.ShadowShift = 6;
            this.ShadowPanel.Size = new System.Drawing.Size(1362, 789);
            this.ShadowPanel.TabIndex = 11;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.labelTotal.Location = new System.Drawing.Point(128, 62);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(63, 25);
            this.labelTotal.TabIndex = 12;
            this.labelTotal.Text = "Total: ";
            // 
            // panelAccount
            // 
            this.panelAccount.BackColor = System.Drawing.Color.Transparent;
            this.panelAccount.Controls.Add(this.buttonLogout);
            this.panelAccount.Controls.Add(this.labelSpeciality);
            this.panelAccount.Controls.Add(this.label1);
            this.panelAccount.Controls.Add(this.pictureBoxUserPhoto);
            this.panelAccount.Controls.Add(this.labelFullName);
            this.panelAccount.Controls.Add(this.label2);
            this.panelAccount.FillColor = System.Drawing.Color.White;
            this.panelAccount.Location = new System.Drawing.Point(29, 23);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Radius = 3;
            this.panelAccount.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.panelAccount.ShadowDepth = 40;
            this.panelAccount.ShadowShift = 6;
            this.panelAccount.Size = new System.Drawing.Size(475, 156);
            this.panelAccount.TabIndex = 13;
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
            this.buttonLogout.Location = new System.Drawing.Point(358, 105);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.PressedColor = System.Drawing.Color.Red;
            this.buttonLogout.ShadowDecoration.Parent = this.buttonLogout;
            this.buttonLogout.Size = new System.Drawing.Size(104, 40);
            this.buttonLogout.TabIndex = 34;
            this.buttonLogout.Tag = "";
            this.buttonLogout.Text = "LogOut";
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelSpeciality
            // 
            this.labelSpeciality.AutoSize = true;
            this.labelSpeciality.BackColor = System.Drawing.Color.Transparent;
            this.labelSpeciality.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpeciality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.labelSpeciality.Location = new System.Drawing.Point(233, 27);
            this.labelSpeciality.Name = "labelSpeciality";
            this.labelSpeciality.Size = new System.Drawing.Size(87, 25);
            this.labelSpeciality.TabIndex = 48;
            this.labelSpeciality.Text = "UserRole";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(134, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Speciality: ";
            // 
            // pictureBoxUserPhoto
            // 
            this.pictureBoxUserPhoto.BackColor = System.Drawing.Color.White;
            this.pictureBoxUserPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxUserPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUserPhoto.Image")));
            this.pictureBoxUserPhoto.Location = new System.Drawing.Point(24, 27);
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
            this.labelFullName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.labelFullName.Location = new System.Drawing.Point(234, 62);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(86, 25);
            this.labelFullName.TabIndex = 45;
            this.labelFullName.Text = "surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label2.Location = new System.Drawing.Point(134, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Full name: ";
            // 
            // textBoxActive
            // 
            this.textBoxActive.AutoSize = true;
            this.textBoxActive.BackColor = System.Drawing.Color.Transparent;
            this.textBoxActive.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.textBoxActive.Location = new System.Drawing.Point(196, 93);
            this.textBoxActive.Name = "textBoxActive";
            this.textBoxActive.Size = new System.Drawing.Size(63, 25);
            this.textBoxActive.TabIndex = 37;
            this.textBoxActive.Text = "active";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.AutoSize = true;
            this.textBoxTotal.BackColor = System.Drawing.Color.Transparent;
            this.textBoxTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.textBoxTotal.Location = new System.Drawing.Point(183, 62);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(52, 25);
            this.textBoxTotal.TabIndex = 36;
            this.textBoxTotal.Text = "total";
            // 
            // labelActive
            // 
            this.labelActive.AutoSize = true;
            this.labelActive.BackColor = System.Drawing.Color.Transparent;
            this.labelActive.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.labelActive.Location = new System.Drawing.Point(128, 93);
            this.labelActive.Name = "labelActive";
            this.labelActive.Size = new System.Drawing.Size(76, 25);
            this.labelActive.TabIndex = 35;
            this.labelActive.Text = "Active: ";
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
            // panelHeaderRight
            // 
            this.panelHeaderRight.BackColor = System.Drawing.Color.Transparent;
            this.panelHeaderRight.Controls.Add(this.labelHeader);
            this.panelHeaderRight.Controls.Add(this.pictureBox1);
            this.panelHeaderRight.Controls.Add(this.label3);
            this.panelHeaderRight.Controls.Add(this.textBoxActive);
            this.panelHeaderRight.Controls.Add(this.textBoxTotal);
            this.panelHeaderRight.Controls.Add(this.labelActive);
            this.panelHeaderRight.Controls.Add(this.labelTotal);
            this.panelHeaderRight.FillColor = System.Drawing.Color.White;
            this.panelHeaderRight.Location = new System.Drawing.Point(510, 23);
            this.panelHeaderRight.Name = "panelHeaderRight";
            this.panelHeaderRight.Radius = 3;
            this.panelHeaderRight.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.panelHeaderRight.ShadowDepth = 50;
            this.panelHeaderRight.ShadowShift = 6;
            this.panelHeaderRight.Size = new System.Drawing.Size(881, 156);
            this.panelHeaderRight.TabIndex = 14;
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1424, 1019);
            this.Controls.Add(this.labelPotatoCorp);
            this.Controls.Add(this.panelHeaderRight);
            this.Controls.Add(this.panelAccount);
            this.Controls.Add(this.ShadowPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1440, 1058);
            this.MinimumSize = new System.Drawing.Size(1440, 1058);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "N20 Lab";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelAccount.ResumeLayout(false);
            this.panelAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPhoto)).EndInit();
            this.panelHeaderRight.ResumeLayout(false);
            this.panelHeaderRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private Guna.UI2.WinForms.Guna2ShadowPanel ShadowPanel;
        private System.Windows.Forms.Label labelTotal;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelAccount;
        private System.Windows.Forms.PictureBox pictureBoxUserPhoto;
        private System.Windows.Forms.Label labelHeader;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelHeaderRight;
        private System.Windows.Forms.Label labelActive;
        private System.Windows.Forms.Label textBoxActive;
        private System.Windows.Forms.Label textBoxTotal;
        private System.Windows.Forms.Label labelPotatoCorp;
        private System.Windows.Forms.Label labelSpeciality;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button buttonLogout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


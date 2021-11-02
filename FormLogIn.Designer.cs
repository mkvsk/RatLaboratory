
namespace DataBaseApp
{
    partial class FormLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            this.labelLog = new System.Windows.Forms.Label();
            this.panelAllElements = new System.Windows.Forms.Panel();
            this.panelCaptcha = new System.Windows.Forms.Panel();
            this.btnCheckCaptcha = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefreshCaptcha = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtEnterCaptchaHere = new System.Windows.Forms.TextBox();
            this.labelCaptcha = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelOneMoreStep = new System.Windows.Forms.Label();
            this.buttonNextStep = new System.Windows.Forms.Button();
            this.panelDataToEnter = new System.Windows.Forms.Panel();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.textBoxDataToEnter = new System.Windows.Forms.TextBox();
            this.panelAllElements.SuspendLayout();
            this.panelCaptcha.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDataToEnter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.labelLog.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelLog.Location = new System.Drawing.Point(56, 42);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(97, 37);
            this.labelLog.TabIndex = 0;
            this.labelLog.Text = "LOGIN";
            this.labelLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelAllElements
            // 
            this.panelAllElements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelAllElements.Controls.Add(this.panelCaptcha);
            this.panelAllElements.Controls.Add(this.labelLog);
            this.panelAllElements.Controls.Add(this.buttonNextStep);
            this.panelAllElements.Controls.Add(this.panelDataToEnter);
            this.panelAllElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAllElements.Location = new System.Drawing.Point(0, 0);
            this.panelAllElements.Name = "panelAllElements";
            this.panelAllElements.Size = new System.Drawing.Size(509, 286);
            this.panelAllElements.TabIndex = 0;
            // 
            // panelCaptcha
            // 
            this.panelCaptcha.Controls.Add(this.btnCheckCaptcha);
            this.panelCaptcha.Controls.Add(this.panel1);
            this.panelCaptcha.Controls.Add(this.labelCaptcha);
            this.panelCaptcha.Controls.Add(this.labelMessage);
            this.panelCaptcha.Controls.Add(this.labelOneMoreStep);
            this.panelCaptcha.Location = new System.Drawing.Point(0, 0);
            this.panelCaptcha.Name = "panelCaptcha";
            this.panelCaptcha.Size = new System.Drawing.Size(509, 286);
            this.panelCaptcha.TabIndex = 9;
            this.panelCaptcha.Visible = false;
            // 
            // btnCheckCaptcha
            // 
            this.btnCheckCaptcha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckCaptcha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnCheckCaptcha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckCaptcha.Enabled = false;
            this.btnCheckCaptcha.FlatAppearance.BorderSize = 0;
            this.btnCheckCaptcha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(84)))), ((int)(((byte)(149)))));
            this.btnCheckCaptcha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnCheckCaptcha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckCaptcha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheckCaptcha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnCheckCaptcha.Location = new System.Drawing.Point(116, 227);
            this.btnCheckCaptcha.Name = "btnCheckCaptcha";
            this.btnCheckCaptcha.Size = new System.Drawing.Size(280, 38);
            this.btnCheckCaptcha.TabIndex = 8;
            this.btnCheckCaptcha.Text = "complete";
            this.btnCheckCaptcha.UseVisualStyleBackColor = false;
            this.btnCheckCaptcha.Click += new System.EventHandler(this.btnCheckCaptcha_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnRefreshCaptcha);
            this.panel1.Controls.Add(this.txtEnterCaptchaHere);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(116, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 58);
            this.panel1.TabIndex = 9;
            // 
            // btnRefreshCaptcha
            // 
            this.btnRefreshCaptcha.BackColor = System.Drawing.Color.Transparent;
            this.btnRefreshCaptcha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshCaptcha.BackgroundImage")));
            this.btnRefreshCaptcha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefreshCaptcha.CheckedState.Parent = this.btnRefreshCaptcha;
            this.btnRefreshCaptcha.CustomImages.Parent = this.btnRefreshCaptcha;
            this.btnRefreshCaptcha.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshCaptcha.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshCaptcha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefreshCaptcha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefreshCaptcha.DisabledState.Parent = this.btnRefreshCaptcha;
            this.btnRefreshCaptcha.FillColor = System.Drawing.Color.Transparent;
            this.btnRefreshCaptcha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshCaptcha.ForeColor = System.Drawing.Color.White;
            this.btnRefreshCaptcha.HoverState.Parent = this.btnRefreshCaptcha;
            this.btnRefreshCaptcha.Location = new System.Drawing.Point(228, 8);
            this.btnRefreshCaptcha.Name = "btnRefreshCaptcha";
            this.btnRefreshCaptcha.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnRefreshCaptcha.ShadowDecoration.Parent = this.btnRefreshCaptcha;
            this.btnRefreshCaptcha.Size = new System.Drawing.Size(40, 40);
            this.btnRefreshCaptcha.TabIndex = 7;
            this.btnRefreshCaptcha.Click += new System.EventHandler(this.btnRefreshCaptcha_Click);
            // 
            // txtEnterCaptchaHere
            // 
            this.txtEnterCaptchaHere.BackColor = System.Drawing.Color.White;
            this.txtEnterCaptchaHere.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEnterCaptchaHere.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEnterCaptchaHere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEnterCaptchaHere.Location = new System.Drawing.Point(17, 13);
            this.txtEnterCaptchaHere.Name = "txtEnterCaptchaHere";
            this.txtEnterCaptchaHere.Size = new System.Drawing.Size(178, 28);
            this.txtEnterCaptchaHere.TabIndex = 0;
            this.txtEnterCaptchaHere.TabStop = false;
            this.txtEnterCaptchaHere.Text = "enter captcha here";
            this.txtEnterCaptchaHere.Click += new System.EventHandler(this.txtEnterCaptchaHere_Click);
            this.txtEnterCaptchaHere.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEnterCaptchaHere_KeyDown);
            this.txtEnterCaptchaHere.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnterCaptchaHere_KeyPress);
            // 
            // labelCaptcha
            // 
            this.labelCaptcha.AutoSize = true;
            this.labelCaptcha.BackColor = System.Drawing.Color.White;
            this.labelCaptcha.Font = new System.Drawing.Font("Chiller", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaptcha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.labelCaptcha.Image = ((System.Drawing.Image)(resources.GetObject("labelCaptcha.Image")));
            this.labelCaptcha.Location = new System.Drawing.Point(116, 102);
            this.labelCaptcha.MaximumSize = new System.Drawing.Size(280, 58);
            this.labelCaptcha.MinimumSize = new System.Drawing.Size(280, 58);
            this.labelCaptcha.Name = "labelCaptcha";
            this.labelCaptcha.Size = new System.Drawing.Size(280, 58);
            this.labelCaptcha.TabIndex = 8;
            this.labelCaptcha.Text = "CAPTCHA";
            this.labelCaptcha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.labelMessage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelMessage.Location = new System.Drawing.Point(56, 46);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(403, 42);
            this.labelMessage.TabIndex = 4;
            this.labelMessage.Text = "You entered incorrect data again.\r\nPlease complete the security check to access R" +
    "atLaboratory";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelOneMoreStep
            // 
            this.labelOneMoreStep.AutoSize = true;
            this.labelOneMoreStep.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOneMoreStep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.labelOneMoreStep.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelOneMoreStep.Location = new System.Drawing.Point(53, 9);
            this.labelOneMoreStep.Name = "labelOneMoreStep";
            this.labelOneMoreStep.Size = new System.Drawing.Size(222, 37);
            this.labelOneMoreStep.TabIndex = 3;
            this.labelOneMoreStep.Text = "ONE MORE STEP";
            this.labelOneMoreStep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonNextStep
            // 
            this.buttonNextStep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNextStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonNextStep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNextStep.Enabled = false;
            this.buttonNextStep.FlatAppearance.BorderSize = 0;
            this.buttonNextStep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(84)))), ((int)(((byte)(149)))));
            this.buttonNextStep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonNextStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextStep.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNextStep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.buttonNextStep.Location = new System.Drawing.Point(62, 200);
            this.buttonNextStep.Name = "buttonNextStep";
            this.buttonNextStep.Size = new System.Drawing.Size(388, 56);
            this.buttonNextStep.TabIndex = 1;
            this.buttonNextStep.Text = "password";
            this.buttonNextStep.UseVisualStyleBackColor = false;
            this.buttonNextStep.Click += new System.EventHandler(this.buttonNextStep_Click);
            // 
            // panelDataToEnter
            // 
            this.panelDataToEnter.BackColor = System.Drawing.Color.White;
            this.panelDataToEnter.Controls.Add(this.pictureBoxPassword);
            this.panelDataToEnter.Controls.Add(this.pictureBoxUser);
            this.panelDataToEnter.Controls.Add(this.textBoxDataToEnter);
            this.panelDataToEnter.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelDataToEnter.Location = new System.Drawing.Point(62, 119);
            this.panelDataToEnter.Name = "panelDataToEnter";
            this.panelDataToEnter.Size = new System.Drawing.Size(388, 56);
            this.panelDataToEnter.TabIndex = 0;
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPassword.Image")));
            this.pictureBoxPassword.Location = new System.Drawing.Point(15, 10);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(36, 36);
            this.pictureBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPassword.TabIndex = 2;
            this.pictureBoxPassword.TabStop = false;
            this.pictureBoxPassword.Visible = false;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUser.Image")));
            this.pictureBoxUser.Location = new System.Drawing.Point(15, 10);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(36, 36);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUser.TabIndex = 1;
            this.pictureBoxUser.TabStop = false;
            // 
            // textBoxDataToEnter
            // 
            this.textBoxDataToEnter.BackColor = System.Drawing.Color.White;
            this.textBoxDataToEnter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDataToEnter.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDataToEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxDataToEnter.Location = new System.Drawing.Point(62, 11);
            this.textBoxDataToEnter.Name = "textBoxDataToEnter";
            this.textBoxDataToEnter.Size = new System.Drawing.Size(312, 32);
            this.textBoxDataToEnter.TabIndex = 0;
            this.textBoxDataToEnter.TabStop = false;
            this.textBoxDataToEnter.Text = "enter username";
            this.textBoxDataToEnter.Click += new System.EventHandler(this.textBoxDataToEnter_Click);
            this.textBoxDataToEnter.TextChanged += new System.EventHandler(this.textBoxDataToEnter_TextChanged);
            this.textBoxDataToEnter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDataToEnter_KeyDown);
            this.textBoxDataToEnter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDataToEnter_KeyPress);
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(509, 286);
            this.Controls.Add(this.panelAllElements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(525, 325);
            this.MinimumSize = new System.Drawing.Size(525, 325);
            this.Name = "FormLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogIn_FormClosed);
            this.Load += new System.EventHandler(this.FormLogIn_Load);
            this.panelAllElements.ResumeLayout(false);
            this.panelAllElements.PerformLayout();
            this.panelCaptcha.ResumeLayout(false);
            this.panelCaptcha.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDataToEnter.ResumeLayout(false);
            this.panelDataToEnter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Panel panelAllElements;
        private System.Windows.Forms.Panel panelDataToEnter;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.TextBox textBoxDataToEnter;
        private System.Windows.Forms.Button buttonNextStep;
        private System.Windows.Forms.Panel panelCaptcha;
        private System.Windows.Forms.Label labelOneMoreStep;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelCaptcha;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnRefreshCaptcha;
        private System.Windows.Forms.TextBox txtEnterCaptchaHere;
        private System.Windows.Forms.Button btnCheckCaptcha;
    }
}


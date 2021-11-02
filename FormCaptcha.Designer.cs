
namespace RAT_Lab
{
    partial class FormCaptcha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCaptcha));
            this.labelOneMoreStep = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.btnCheckCaptcha = new System.Windows.Forms.Button();
            this.panelDataToEnter = new System.Windows.Forms.Panel();
            this.btnRefreshCaptcha = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtEnterCaptchaHere = new System.Windows.Forms.TextBox();
            this.labelCaptcha = new System.Windows.Forms.Label();
            this.panelDataToEnter.SuspendLayout();
            this.SuspendLayout();
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
            this.labelOneMoreStep.TabIndex = 2;
            this.labelOneMoreStep.Text = "ONE MORE STEP";
            this.labelOneMoreStep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.labelMessage.TabIndex = 3;
            this.labelMessage.Text = "You entered incorrect data again.\r\nPlease complete the security check to access R" +
    "atLaboratory";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnCheckCaptcha.Location = new System.Drawing.Point(116, 219);
            this.btnCheckCaptcha.Name = "btnCheckCaptcha";
            this.btnCheckCaptcha.Size = new System.Drawing.Size(280, 38);
            this.btnCheckCaptcha.TabIndex = 5;
            this.btnCheckCaptcha.Text = "complete";
            this.btnCheckCaptcha.UseVisualStyleBackColor = false;
            this.btnCheckCaptcha.Click += new System.EventHandler(this.btnCheckCaptcha_Click);
            // 
            // panelDataToEnter
            // 
            this.panelDataToEnter.BackColor = System.Drawing.Color.White;
            this.panelDataToEnter.Controls.Add(this.btnRefreshCaptcha);
            this.panelDataToEnter.Controls.Add(this.txtEnterCaptchaHere);
            this.panelDataToEnter.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelDataToEnter.Location = new System.Drawing.Point(116, 155);
            this.panelDataToEnter.Name = "panelDataToEnter";
            this.panelDataToEnter.Size = new System.Drawing.Size(280, 58);
            this.panelDataToEnter.TabIndex = 6;
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
            this.labelCaptcha.TabIndex = 7;
            this.labelCaptcha.Text = "CAPTCHA";
            this.labelCaptcha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCaptcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 286);
            this.Controls.Add(this.labelCaptcha);
            this.Controls.Add(this.panelDataToEnter);
            this.Controls.Add(this.btnCheckCaptcha);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelOneMoreStep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCaptcha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCaptcha";
            this.Load += new System.EventHandler(this.FormCaptcha_Load);
            this.panelDataToEnter.ResumeLayout(false);
            this.panelDataToEnter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelOneMoreStep;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button btnCheckCaptcha;
        private System.Windows.Forms.Panel panelDataToEnter;
        private System.Windows.Forms.TextBox txtEnterCaptchaHere;
        private Guna.UI2.WinForms.Guna2CircleButton btnRefreshCaptcha;
        private System.Windows.Forms.Label labelCaptcha;
    }
}
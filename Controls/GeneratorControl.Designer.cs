namespace Password_Manager_WF.Controls
{
    partial class GeneratorControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSite = new System.Windows.Forms.Panel();
            this.lblSite = new System.Windows.Forms.Label();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.lblPasswordLength = new System.Windows.Forms.Label();
            this.pnlPasswordLength = new System.Windows.Forms.Panel();
            this.passwordLengthBox = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.toastWindowsNotification = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastWindowsNotification)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Roboto Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(254, 238);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(794, 77);
            this.lblTitle.TabIndex = 36;
            this.lblTitle.Text = "GENERATE YOUR PASSWORD!";
            // 
            // pnlSite
            // 
            this.pnlSite.BackColor = System.Drawing.Color.Black;
            this.pnlSite.Location = new System.Drawing.Point(627, 32);
            this.pnlSite.Name = "pnlSite";
            this.pnlSite.Size = new System.Drawing.Size(1, 72);
            this.pnlSite.TabIndex = 35;
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.lblSite.Location = new System.Drawing.Point(644, 47);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(156, 38);
            this.lblSite.TabIndex = 34;
            this.lblSite.Text = "GENERATE";
            // 
            // pbAvatar
            // 
            this.pbAvatar.Image = global::Password_Manager_WF.Properties.Resources.pngegg;
            this.pbAvatar.Location = new System.Drawing.Point(523, 32);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(87, 71);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 33;
            this.pbAvatar.TabStop = false;
            // 
            // lblPasswordLength
            // 
            this.lblPasswordLength.AutoSize = true;
            this.lblPasswordLength.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordLength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.lblPasswordLength.Location = new System.Drawing.Point(399, 324);
            this.lblPasswordLength.Name = "lblPasswordLength";
            this.lblPasswordLength.Size = new System.Drawing.Size(487, 38);
            this.lblPasswordLength.TabIndex = 37;
            this.lblPasswordLength.Text = "Put in your desired password length:";
            // 
            // pnlPasswordLength
            // 
            this.pnlPasswordLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.pnlPasswordLength.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlPasswordLength.Location = new System.Drawing.Point(403, 519);
            this.pnlPasswordLength.Name = "pnlPasswordLength";
            this.pnlPasswordLength.Size = new System.Drawing.Size(500, 1);
            this.pnlPasswordLength.TabIndex = 38;
            // 
            // passwordLengthBox
            // 
            this.passwordLengthBox.AccessibleName = "txtMasterPassword";
            this.passwordLengthBox.BackColor = System.Drawing.Color.White;
            this.passwordLengthBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordLengthBox.Font = new System.Drawing.Font("Roboto Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLengthBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.passwordLengthBox.Location = new System.Drawing.Point(403, 449);
            this.passwordLengthBox.MaxLength = 25;
            this.passwordLengthBox.Name = "passwordLengthBox";
            this.passwordLengthBox.Size = new System.Drawing.Size(497, 45);
            this.passwordLengthBox.TabIndex = 39;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(593, 586);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(101, 32);
            this.btnGenerate.TabIndex = 40;
            this.btnGenerate.Text = "GENERATE";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.PwGeneratorOnClick);
            // 
            // toastWindowsNotification
            // 
            this.toastWindowsNotification.ApplicationId = "Password Manager";
            this.toastWindowsNotification.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("093666e6-9f19-4f0c-a567-09a8e3c4eb69", global::Password_Manager_WF.Properties.Resources.success_svgrepo_com, "Successfull generated a random password!", "Click on the button right to the generated password to copy it to the clipboard.", "", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText02),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("fecb214d-7c99-441b-8eff-17b736f10735", global::Password_Manager_WF.Properties.Resources.error_svgrepo_com, "Couldn\'t generate a random password!", "Please fill in numbers or try a lower number.", "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor i" +
                    "ncididunt ut labore et dolore magna aliqua.", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText02),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("5eb34141-af71-4dc9-8c29-8088d241e3f0", global::Password_Manager_WF.Properties.Resources.warning_svgrepo_com, "The field is empty!", "Please type in the length of the random password.", "", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText02)});
            // 
            // GeneratorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.passwordLengthBox);
            this.Controls.Add(this.pnlPasswordLength);
            this.Controls.Add(this.lblPasswordLength);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlSite);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.pbAvatar);
            this.Name = "GeneratorControl";
            this.Size = new System.Drawing.Size(1124, 697);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastWindowsNotification)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlSite;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Label lblPasswordLength;
        private System.Windows.Forms.Panel pnlPasswordLength;
        private System.Windows.Forms.TextBox passwordLengthBox;
        private System.Windows.Forms.Button btnGenerate;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastWindowsNotification;
    }
}

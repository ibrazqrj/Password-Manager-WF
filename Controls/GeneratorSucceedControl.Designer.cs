namespace Password_Manager_WF.Controls
{
    partial class GeneratorSucceedControl
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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSite = new System.Windows.Forms.Panel();
            this.lblSite = new System.Windows.Forms.Label();
            this.pbCopy = new System.Windows.Forms.PictureBox();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.toastWindowsNotification = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastWindowsNotification)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.AccessibleName = "txtMasterPassword";
            this.tbPassword.BackColor = System.Drawing.Color.White;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Roboto Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.tbPassword.Location = new System.Drawing.Point(450, 409);
            this.tbPassword.MaxLength = 25;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(305, 45);
            this.tbPassword.TabIndex = 47;
            this.tbPassword.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.lblPassword.Location = new System.Drawing.Point(488, 324);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(289, 38);
            this.lblPassword.TabIndex = 45;
            this.lblPassword.Text = "Generated password:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Roboto Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(254, 238);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(794, 77);
            this.lblTitle.TabIndex = 44;
            this.lblTitle.Text = "GENERATE YOUR PASSWORD!";
            // 
            // pnlSite
            // 
            this.pnlSite.BackColor = System.Drawing.Color.Black;
            this.pnlSite.Location = new System.Drawing.Point(627, 32);
            this.pnlSite.Name = "pnlSite";
            this.pnlSite.Size = new System.Drawing.Size(1, 72);
            this.pnlSite.TabIndex = 43;
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.lblSite.Location = new System.Drawing.Point(644, 47);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(156, 38);
            this.lblSite.TabIndex = 42;
            this.lblSite.Text = "GENERATE";
            // 
            // pbCopy
            // 
            this.pbCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCopy.Image = global::Password_Manager_WF.Properties.Resources.copy_svgrepo_com__1_;
            this.pbCopy.Location = new System.Drawing.Point(771, 418);
            this.pbCopy.Name = "pbCopy";
            this.pbCopy.Size = new System.Drawing.Size(28, 27);
            this.pbCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCopy.TabIndex = 48;
            this.pbCopy.TabStop = false;
            this.pbCopy.Click += new System.EventHandler(this.CopyToClipboard);
            // 
            // pbAvatar
            // 
            this.pbAvatar.Image = global::Password_Manager_WF.Properties.Resources.pngegg;
            this.pbAvatar.Location = new System.Drawing.Point(523, 32);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(87, 71);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 41;
            this.pbAvatar.TabStop = false;
            // 
            // toastWindowsNotification
            // 
            this.toastWindowsNotification.ApplicationId = "80b7b249-fc71-4d26-9536-358ec80e458b";
            this.toastWindowsNotification.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("a5a040b7-e4d6-4682-8ed2-9b49b008c996", global::Password_Manager_WF.Properties.Resources.success_svgrepo_com, "Password copied!", "copied to your clipboard.", "", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText02)});
            // 
            // GeneratorSucceedControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pbCopy);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlSite);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.pbAvatar);
            this.Name = "GeneratorSucceedControl";
            this.Size = new System.Drawing.Size(1124, 697);
            ((System.ComponentModel.ISupportInitialize)(this.pbCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastWindowsNotification)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlSite;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.PictureBox pbCopy;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastWindowsNotification;
    }
}

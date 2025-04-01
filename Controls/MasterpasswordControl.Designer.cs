namespace Password_Manager_WF.Controls
{
    partial class MasterpasswordControl
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
            this.btnSave = new System.Windows.Forms.Button();
            this.tbOldPassword = new System.Windows.Forms.TextBox();
            this.pnlOldPassword = new System.Windows.Forms.Panel();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.lblMasterpasswordTitle = new System.Windows.Forms.Label();
            this.pnlSite = new System.Windows.Forms.Panel();
            this.lblSite = new System.Windows.Forms.Label();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.pnlNewPassword = new System.Windows.Forms.Panel();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.tbNewPasswordConfirm = new System.Windows.Forms.TextBox();
            this.pnlNewPasswordConfirm = new System.Windows.Forms.Panel();
            this.lblNewPasswordRepeat = new System.Windows.Forms.Label();
            this.toastWindowsNotification = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastWindowsNotification)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(614, 806);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 32);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.MpChangedOnClick);
            // 
            // tbOldPassword
            // 
            this.tbOldPassword.AccessibleName = "txtMasterPassword";
            this.tbOldPassword.BackColor = System.Drawing.Color.White;
            this.tbOldPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOldPassword.Font = new System.Drawing.Font("Roboto Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOldPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.tbOldPassword.Location = new System.Drawing.Point(403, 346);
            this.tbOldPassword.MaxLength = 25;
            this.tbOldPassword.Name = "tbOldPassword";
            this.tbOldPassword.Size = new System.Drawing.Size(497, 45);
            this.tbOldPassword.TabIndex = 47;
            // 
            // pnlOldPassword
            // 
            this.pnlOldPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.pnlOldPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlOldPassword.Location = new System.Drawing.Point(403, 399);
            this.pnlOldPassword.Name = "pnlOldPassword";
            this.pnlOldPassword.Size = new System.Drawing.Size(500, 1);
            this.pnlOldPassword.TabIndex = 46;
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.lblOldPassword.Location = new System.Drawing.Point(498, 273);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(297, 38);
            this.lblOldPassword.TabIndex = 45;
            this.lblOldPassword.Text = "Old master password:";
            this.lblOldPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMasterpasswordTitle
            // 
            this.lblMasterpasswordTitle.AutoSize = true;
            this.lblMasterpasswordTitle.Font = new System.Drawing.Font("Roboto Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasterpasswordTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.lblMasterpasswordTitle.Location = new System.Drawing.Point(158, 164);
            this.lblMasterpasswordTitle.Name = "lblMasterpasswordTitle";
            this.lblMasterpasswordTitle.Size = new System.Drawing.Size(965, 77);
            this.lblMasterpasswordTitle.TabIndex = 44;
            this.lblMasterpasswordTitle.Text = "CHANGE YOUR MASTER PASSWORD";
            // 
            // pnlSite
            // 
            this.pnlSite.BackColor = System.Drawing.Color.Black;
            this.pnlSite.Location = new System.Drawing.Point(546, 32);
            this.pnlSite.Name = "pnlSite";
            this.pnlSite.Size = new System.Drawing.Size(1, 72);
            this.pnlSite.TabIndex = 43;
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.lblSite.Location = new System.Drawing.Point(563, 47);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(282, 38);
            this.lblSite.TabIndex = 42;
            this.lblSite.Text = "MASTER PASSWORD";
            // 
            // pbAvatar
            // 
            this.pbAvatar.Image = global::Password_Manager_WF.Properties.Resources.pngegg;
            this.pbAvatar.Location = new System.Drawing.Point(442, 32);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(87, 71);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 41;
            this.pbAvatar.TabStop = false;
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.AccessibleName = "txtMasterPassword";
            this.tbNewPassword.BackColor = System.Drawing.Color.White;
            this.tbNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNewPassword.Font = new System.Drawing.Font("Roboto Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.tbNewPassword.Location = new System.Drawing.Point(403, 526);
            this.tbNewPassword.MaxLength = 25;
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(497, 45);
            this.tbNewPassword.TabIndex = 50;
            // 
            // pnlNewPassword
            // 
            this.pnlNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.pnlNewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlNewPassword.Location = new System.Drawing.Point(403, 579);
            this.pnlNewPassword.Name = "pnlNewPassword";
            this.pnlNewPassword.Size = new System.Drawing.Size(500, 1);
            this.pnlNewPassword.TabIndex = 49;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.lblNewPassword.Location = new System.Drawing.Point(498, 453);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(309, 38);
            this.lblNewPassword.TabIndex = 48;
            this.lblNewPassword.Text = "New master password:";
            this.lblNewPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbNewPasswordConfirm
            // 
            this.tbNewPasswordConfirm.AccessibleName = "txtMasterPassword";
            this.tbNewPasswordConfirm.BackColor = System.Drawing.Color.White;
            this.tbNewPasswordConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNewPasswordConfirm.Font = new System.Drawing.Font("Roboto Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPasswordConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.tbNewPasswordConfirm.Location = new System.Drawing.Point(406, 707);
            this.tbNewPasswordConfirm.MaxLength = 25;
            this.tbNewPasswordConfirm.Name = "tbNewPasswordConfirm";
            this.tbNewPasswordConfirm.Size = new System.Drawing.Size(497, 45);
            this.tbNewPasswordConfirm.TabIndex = 53;
            // 
            // pnlNewPasswordConfirm
            // 
            this.pnlNewPasswordConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.pnlNewPasswordConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlNewPasswordConfirm.Location = new System.Drawing.Point(406, 760);
            this.pnlNewPasswordConfirm.Name = "pnlNewPasswordConfirm";
            this.pnlNewPasswordConfirm.Size = new System.Drawing.Size(500, 1);
            this.pnlNewPasswordConfirm.TabIndex = 52;
            // 
            // lblNewPasswordRepeat
            // 
            this.lblNewPasswordRepeat.AutoSize = true;
            this.lblNewPasswordRepeat.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPasswordRepeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.lblNewPasswordRepeat.Location = new System.Drawing.Point(459, 634);
            this.lblNewPasswordRepeat.Name = "lblNewPasswordRepeat";
            this.lblNewPasswordRepeat.Size = new System.Drawing.Size(401, 38);
            this.lblNewPasswordRepeat.TabIndex = 51;
            this.lblNewPasswordRepeat.Text = "Repeat new master password:";
            this.lblNewPasswordRepeat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toastWindowsNotification
            // 
            this.toastWindowsNotification.ApplicationId = "Password Manager";
            this.toastWindowsNotification.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("345efb63-9e01-443c-b0cf-755278c4832d", global::Password_Manager_WF.Properties.Resources.warning_svgrepo_com, "Fields can\'t be empty!", "Please fill in all fields.", "", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText02),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("4a211faf-9d32-4cce-bcaf-4c8ade2cd07c", global::Password_Manager_WF.Properties.Resources.success_svgrepo_com, "Successfully changed master password!", "Please login again.", "", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText02),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("f419951b-a23d-4e9b-a3ca-cc0f32486652", global::Password_Manager_WF.Properties.Resources.error_svgrepo_com, "Incorrect current master password!", "Please try again.", "", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText02),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("7f6a8153-3d9e-4d74-be66-2f13b6d196f0", global::Password_Manager_WF.Properties.Resources.error_svgrepo_com, "Passwords do not match!", "Please try again.", "", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText02)});
            // 
            // MasterpasswordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tbNewPasswordConfirm);
            this.Controls.Add(this.pnlNewPasswordConfirm);
            this.Controls.Add(this.lblNewPasswordRepeat);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.pnlNewPassword);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.tbOldPassword);
            this.Controls.Add(this.pnlOldPassword);
            this.Controls.Add(this.lblOldPassword);
            this.Controls.Add(this.lblMasterpasswordTitle);
            this.Controls.Add(this.pnlSite);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.pbAvatar);
            this.Name = "MasterpasswordControl";
            this.Size = new System.Drawing.Size(1131, 922);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastWindowsNotification)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbOldPassword;
        private System.Windows.Forms.Panel pnlOldPassword;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.Label lblMasterpasswordTitle;
        private System.Windows.Forms.Panel pnlSite;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Panel pnlNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox tbNewPasswordConfirm;
        private System.Windows.Forms.Panel pnlNewPasswordConfirm;
        private System.Windows.Forms.Label lblNewPasswordRepeat;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastWindowsNotification;
    }
}

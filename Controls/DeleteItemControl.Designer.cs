namespace Password_Manager_WF.Controls
{
    partial class DeleteItemControl
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
            this.allItems = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Website = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel12 = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.passwordServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbTitle = new System.Windows.Forms.Label();
            this.tbIdInput = new System.Windows.Forms.TextBox();
            this.pnlIdInput = new System.Windows.Forms.Panel();
            this.tbId = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // allItems
            // 
            this.allItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Website,
            this.Username,
            this.Password,
            this.Category});
            this.allItems.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold);
            this.allItems.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.allItems.HideSelection = false;
            this.allItems.Location = new System.Drawing.Point(43, 157);
            this.allItems.Name = "allItems";
            this.allItems.Size = new System.Drawing.Size(1149, 246);
            this.allItems.TabIndex = 37;
            this.allItems.UseCompatibleStateImageBehavior = false;
            this.allItems.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "Id";
            this.ID.Width = 73;
            // 
            // Website
            // 
            this.Website.Text = "Website";
            this.Website.Width = 281;
            // 
            // Username
            // 
            this.Username.Text = "Username";
            this.Username.Width = 282;
            // 
            // Password
            // 
            this.Password.Text = "Password";
            this.Password.Width = 351;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 129;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.Location = new System.Drawing.Point(548, 15);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1, 72);
            this.panel12.TabIndex = 40;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label29.Location = new System.Drawing.Point(565, 30);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(188, 38);
            this.label29.TabIndex = 39;
            this.label29.Text = "DELETE ITEM";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Password_Manager_WF.Properties.Resources.pngegg;
            this.pictureBox6.Location = new System.Drawing.Point(444, 15);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(87, 71);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 38;
            this.pictureBox6.TabStop = false;
            // 
            // passwordServiceBindingSource
            // 
            this.passwordServiceBindingSource.DataSource = typeof(PasswordManager.Services.PasswordService);
            // 
            // tbTitle
            // 
            this.tbTitle.AutoSize = true;
            this.tbTitle.Font = new System.Drawing.Font("Roboto Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.tbTitle.Location = new System.Drawing.Point(385, 459);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(467, 77);
            this.tbTitle.TabIndex = 58;
            this.tbTitle.Text = "DELETE AN ITEM";
            // 
            // tbIdInput
            // 
            this.tbIdInput.AccessibleName = "txtIdInput";
            this.tbIdInput.BackColor = System.Drawing.Color.White;
            this.tbIdInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIdInput.Font = new System.Drawing.Font("Roboto Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.tbIdInput.Location = new System.Drawing.Point(371, 635);
            this.tbIdInput.MaxLength = 25;
            this.tbIdInput.Name = "tbIdInput";
            this.tbIdInput.Size = new System.Drawing.Size(497, 45);
            this.tbIdInput.TabIndex = 63;
            // 
            // pnlIdInput
            // 
            this.pnlIdInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.pnlIdInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlIdInput.Location = new System.Drawing.Point(371, 688);
            this.pnlIdInput.Name = "pnlIdInput";
            this.pnlIdInput.Size = new System.Drawing.Size(500, 1);
            this.pnlIdInput.TabIndex = 62;
            // 
            // tbId
            // 
            this.tbId.AutoSize = true;
            this.tbId.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.tbId.Location = new System.Drawing.Point(599, 562);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(42, 38);
            this.tbId.TabIndex = 61;
            this.tbId.Text = "Id";
            this.tbId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(567, 795);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 32);
            this.btnDelete.TabIndex = 64;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.DeleteOnClick);
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "80b7b249-fc71-4d26-9536-358ec80e458b";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("df6a9ad8-7ad2-41f1-b8aa-1610c00c13ae", global::Password_Manager_WF.Properties.Resources.success_svgrepo_com, "Successfull deleted Item!", "The entry won\'t be in the list anymore.", "", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText02),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("78696c86-325f-42cc-83e2-1db09312d82c", global::Password_Manager_WF.Properties.Resources.warning_svgrepo_com, "Empty fields are not allowed!", "Please fill out all fields.", "", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText02),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("4c22e3fd-4146-4a1f-84f7-189275a7fbd3", global::Password_Manager_WF.Properties.Resources.error_svgrepo_com, "Id not found!", "Please check your input again.", "", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText02)});
            // 
            // DeleteItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbIdInput);
            this.Controls.Add(this.pnlIdInput);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.allItems);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.pictureBox6);
            this.Name = "DeleteItemControl";
            this.Size = new System.Drawing.Size(1235, 836);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView allItems;
        private System.Windows.Forms.ColumnHeader Website;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.BindingSource passwordServiceBindingSource;
        private System.Windows.Forms.Label tbTitle;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.TextBox tbIdInput;
        private System.Windows.Forms.Panel pnlIdInput;
        private System.Windows.Forms.Label tbId;
        private System.Windows.Forms.Button btnDelete;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
    }
}

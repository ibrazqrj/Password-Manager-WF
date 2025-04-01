namespace Password_Manager_WF
{
    partial class MainMenuScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuScreen));
            this.flpSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlAvatar = new System.Windows.Forms.Panel();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlAllItems = new System.Windows.Forms.Panel();
            this.btnAllItems = new System.Windows.Forms.Button();
            this.pnlGenerator = new System.Windows.Forms.Panel();
            this.btnGenerator = new System.Windows.Forms.Button();
            this.pnlMasterPassword = new System.Windows.Forms.Panel();
            this.btnMasterPassword = new System.Windows.Forms.Button();
            this.pnlThemeSwitch = new System.Windows.Forms.Panel();
            this.lblTheme = new System.Windows.Forms.Label();
            this.tsTheme = new DevExpress.XtraEditors.ToggleSwitch();
            this.tmrSidebar = new System.Windows.Forms.Timer(this.components);
            this.contentPanel = new System.Windows.Forms.Panel();
            this.icnClose = new System.Windows.Forms.PictureBox();
            this.flpSidebar.SuspendLayout();
            this.pnlAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.pnlHome.SuspendLayout();
            this.pnlAllItems.SuspendLayout();
            this.pnlGenerator.SuspendLayout();
            this.pnlMasterPassword.SuspendLayout();
            this.pnlThemeSwitch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsTheme.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // flpSidebar
            // 
            this.flpSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.flpSidebar.Controls.Add(this.pnlAvatar);
            this.flpSidebar.Controls.Add(this.pnlHome);
            this.flpSidebar.Controls.Add(this.pnlAllItems);
            this.flpSidebar.Controls.Add(this.pnlGenerator);
            this.flpSidebar.Controls.Add(this.pnlMasterPassword);
            this.flpSidebar.Controls.Add(this.pnlThemeSwitch);
            this.flpSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpSidebar.Location = new System.Drawing.Point(0, 0);
            this.flpSidebar.MaximumSize = new System.Drawing.Size(382, 900);
            this.flpSidebar.MinimumSize = new System.Drawing.Size(80, 900);
            this.flpSidebar.Name = "flpSidebar";
            this.flpSidebar.Size = new System.Drawing.Size(382, 900);
            this.flpSidebar.TabIndex = 6;
            // 
            // pnlAvatar
            // 
            this.pnlAvatar.Controls.Add(this.pbAvatar);
            this.pnlAvatar.Location = new System.Drawing.Point(3, 3);
            this.pnlAvatar.Name = "pnlAvatar";
            this.pnlAvatar.Size = new System.Drawing.Size(379, 178);
            this.pnlAvatar.TabIndex = 0;
            // 
            // pbAvatar
            // 
            this.pbAvatar.Image = global::Password_Manager_WF.Properties.Resources.pngegg;
            this.pbAvatar.Location = new System.Drawing.Point(129, 34);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(116, 96);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 30;
            this.pbAvatar.TabStop = false;
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.btnHome);
            this.pnlHome.Location = new System.Drawing.Point(3, 187);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(379, 62);
            this.pnlHome.TabIndex = 8;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::Password_Manager_WF.Properties.Resources.home_svgrepo_com__2_;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-9, -13);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(419, 86);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "     HOME";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.HomeButtonClick);
            // 
            // pnlAllItems
            // 
            this.pnlAllItems.Controls.Add(this.btnAllItems);
            this.pnlAllItems.Location = new System.Drawing.Point(3, 255);
            this.pnlAllItems.Name = "pnlAllItems";
            this.pnlAllItems.Size = new System.Drawing.Size(379, 62);
            this.pnlAllItems.TabIndex = 9;
            // 
            // btnAllItems
            // 
            this.btnAllItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnAllItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAllItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllItems.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold);
            this.btnAllItems.ForeColor = System.Drawing.Color.White;
            this.btnAllItems.Image = global::Password_Manager_WF.Properties.Resources.password_minimalistic_input_svgrepo_com__1_;
            this.btnAllItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllItems.Location = new System.Drawing.Point(-9, -13);
            this.btnAllItems.Name = "btnAllItems";
            this.btnAllItems.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAllItems.Size = new System.Drawing.Size(419, 86);
            this.btnAllItems.TabIndex = 7;
            this.btnAllItems.Text = "     ALL ITEMS";
            this.btnAllItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllItems.UseVisualStyleBackColor = false;
            this.btnAllItems.Click += new System.EventHandler(this.AllItemsButtonClick);
            // 
            // pnlGenerator
            // 
            this.pnlGenerator.Controls.Add(this.btnGenerator);
            this.pnlGenerator.Location = new System.Drawing.Point(3, 323);
            this.pnlGenerator.Name = "pnlGenerator";
            this.pnlGenerator.Size = new System.Drawing.Size(379, 62);
            this.pnlGenerator.TabIndex = 10;
            // 
            // btnGenerator
            // 
            this.btnGenerator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnGenerator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGenerator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerator.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold);
            this.btnGenerator.ForeColor = System.Drawing.Color.White;
            this.btnGenerator.Image = global::Password_Manager_WF.Properties.Resources.test_tube_minimalistic_svgrepo_com__1_;
            this.btnGenerator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerator.Location = new System.Drawing.Point(-9, -13);
            this.btnGenerator.Name = "btnGenerator";
            this.btnGenerator.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGenerator.Size = new System.Drawing.Size(419, 86);
            this.btnGenerator.TabIndex = 7;
            this.btnGenerator.Text = "     GENERATOR";
            this.btnGenerator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerator.UseVisualStyleBackColor = false;
            this.btnGenerator.Click += new System.EventHandler(this.GeneratorButtonClick);
            // 
            // pnlMasterPassword
            // 
            this.pnlMasterPassword.Controls.Add(this.btnMasterPassword);
            this.pnlMasterPassword.Location = new System.Drawing.Point(3, 391);
            this.pnlMasterPassword.Name = "pnlMasterPassword";
            this.pnlMasterPassword.Size = new System.Drawing.Size(379, 62);
            this.pnlMasterPassword.TabIndex = 11;
            // 
            // btnMasterPassword
            // 
            this.btnMasterPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnMasterPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMasterPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMasterPassword.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold);
            this.btnMasterPassword.ForeColor = System.Drawing.Color.White;
            this.btnMasterPassword.Image = global::Password_Manager_WF.Properties.Resources.key_minimalistic_square_3_svgrepo_com__1_;
            this.btnMasterPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasterPassword.Location = new System.Drawing.Point(-9, -13);
            this.btnMasterPassword.Name = "btnMasterPassword";
            this.btnMasterPassword.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMasterPassword.Size = new System.Drawing.Size(419, 86);
            this.btnMasterPassword.TabIndex = 7;
            this.btnMasterPassword.Text = "     MASTERPASSWORD";
            this.btnMasterPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasterPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMasterPassword.UseVisualStyleBackColor = false;
            this.btnMasterPassword.Click += new System.EventHandler(this.MasterpasswordButtonClick);
            // 
            // pnlThemeSwitch
            // 
            this.pnlThemeSwitch.Controls.Add(this.lblTheme);
            this.pnlThemeSwitch.Controls.Add(this.tsTheme);
            this.pnlThemeSwitch.Location = new System.Drawing.Point(3, 459);
            this.pnlThemeSwitch.Name = "pnlThemeSwitch";
            this.pnlThemeSwitch.Size = new System.Drawing.Size(379, 441);
            this.pnlThemeSwitch.TabIndex = 14;
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.lblTheme.ForeColor = System.Drawing.Color.White;
            this.lblTheme.Location = new System.Drawing.Point(167, 388);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(56, 19);
            this.lblTheme.TabIndex = 13;
            this.lblTheme.Text = "THEME";
            // 
            // tsTheme
            // 
            this.tsTheme.Location = new System.Drawing.Point(169, 410);
            this.tsTheme.Name = "tsTheme";
            this.tsTheme.Properties.OffText = "";
            this.tsTheme.Properties.OnText = "";
            this.tsTheme.Properties.ShowText = false;
            this.tsTheme.Size = new System.Drawing.Size(52, 18);
            this.tsTheme.TabIndex = 12;
            this.tsTheme.Toggled += new System.EventHandler(this.ThemeSwitch_Toggled);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(382, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1218, 900);
            this.contentPanel.TabIndex = 23;
            // 
            // icnClose
            // 
            this.icnClose.BackColor = System.Drawing.Color.White;
            this.icnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icnClose.Image = global::Password_Manager_WF.Properties.Resources.close_square_svgrepo_com__2_;
            this.icnClose.Location = new System.Drawing.Point(1540, 8);
            this.icnClose.Name = "icnClose";
            this.icnClose.Size = new System.Drawing.Size(51, 53);
            this.icnClose.TabIndex = 29;
            this.icnClose.TabStop = false;
            this.icnClose.Click += new System.EventHandler(this.CloseClick);
            // 
            // MainMenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.icnClose);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.flpSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenuScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Manager";
            this.flpSidebar.ResumeLayout(false);
            this.pnlAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.pnlHome.ResumeLayout(false);
            this.pnlAllItems.ResumeLayout(false);
            this.pnlGenerator.ResumeLayout(false);
            this.pnlMasterPassword.ResumeLayout(false);
            this.pnlThemeSwitch.ResumeLayout(false);
            this.pnlThemeSwitch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsTheme.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpSidebar;
        private System.Windows.Forms.Panel pnlAvatar;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Panel pnlAllItems;
        private System.Windows.Forms.Button btnAllItems;
        private System.Windows.Forms.Panel pnlGenerator;
        private System.Windows.Forms.Button btnGenerator;
        private System.Windows.Forms.Panel pnlMasterPassword;
        private System.Windows.Forms.Button btnMasterPassword;
        private System.Windows.Forms.Timer tmrSidebar;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.PictureBox icnClose;
        private System.Windows.Forms.PictureBox pbAvatar;
        private DevExpress.XtraEditors.ToggleSwitch tsTheme;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.Panel pnlThemeSwitch;
    }
}
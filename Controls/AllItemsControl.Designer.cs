namespace Password_Manager_WF.Controls
{
    partial class AllItemsControl
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
            this.lvItems = new System.Windows.Forms.ListView();
            this.Website = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlSite = new System.Windows.Forms.Panel();
            this.lblSite = new System.Windows.Forms.Label();
            this.tbSearchbar = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pbRemoveItem = new System.Windows.Forms.PictureBox();
            this.pbAddItem = new System.Windows.Forms.PictureBox();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.passwordServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbRemoveItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordServiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lvItems
            // 
            this.lvItems.AccessibleName = "textListView";
            this.lvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Website,
            this.Username,
            this.Password,
            this.Category});
            this.lvItems.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold);
            this.lvItems.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lvItems.FullRowSelect = true;
            this.lvItems.HideSelection = false;
            this.lvItems.Location = new System.Drawing.Point(54, 198);
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(1178, 591);
            this.lvItems.TabIndex = 0;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            // 
            // Website
            // 
            this.Website.Text = "Website";
            this.Website.Width = 252;
            // 
            // Username
            // 
            this.Username.Text = "Username";
            this.Username.Width = 331;
            // 
            // Password
            // 
            this.Password.Text = "Password";
            this.Password.Width = 297;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 264;
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
            this.lblSite.Size = new System.Drawing.Size(100, 38);
            this.lblSite.TabIndex = 34;
            this.lblSite.Text = "ITEMS";
            // 
            // tbSearchbar
            // 
            this.tbSearchbar.AccessibleName = "searchBar";
            this.tbSearchbar.Location = new System.Drawing.Point(457, 133);
            this.tbSearchbar.Name = "tbSearchbar";
            this.tbSearchbar.Size = new System.Drawing.Size(231, 20);
            this.tbSearchbar.TabIndex = 38;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(703, 127);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 32);
            this.btnSearch.TabIndex = 65;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.SearchOnClick);
            // 
            // pbRemoveItem
            // 
            this.pbRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRemoveItem.Image = global::Password_Manager_WF.Properties.Resources.delete_note_svgrepo_com__1_;
            this.pbRemoveItem.Location = new System.Drawing.Point(645, 795);
            this.pbRemoveItem.Name = "pbRemoveItem";
            this.pbRemoveItem.Size = new System.Drawing.Size(41, 43);
            this.pbRemoveItem.TabIndex = 66;
            this.pbRemoveItem.TabStop = false;
            this.pbRemoveItem.Click += new System.EventHandler(this.DeleteItemOnClick);
            // 
            // pbAddItem
            // 
            this.pbAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddItem.Image = global::Password_Manager_WF.Properties.Resources.add_circle_svgrepo_com__1_;
            this.pbAddItem.Location = new System.Drawing.Point(598, 795);
            this.pbAddItem.Name = "pbAddItem";
            this.pbAddItem.Size = new System.Drawing.Size(41, 43);
            this.pbAddItem.TabIndex = 36;
            this.pbAddItem.TabStop = false;
            this.pbAddItem.Click += new System.EventHandler(this.AddButtonOnClick);
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
            // passwordServiceBindingSource
            // 
            this.passwordServiceBindingSource.DataSource = typeof(PasswordManager.Services.PasswordService);
            // 
            // AllItemsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pbRemoveItem);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearchbar);
            this.Controls.Add(this.pbAddItem);
            this.Controls.Add(this.pnlSite);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.lvItems);
            this.Name = "AllItemsControl";
            this.Size = new System.Drawing.Size(1235, 836);
            ((System.ComponentModel.ISupportInitialize)(this.pbRemoveItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordServiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.Panel pnlSite;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.ColumnHeader Website;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.BindingSource passwordServiceBindingSource;
        private System.Windows.Forms.PictureBox pbAddItem;
        private System.Windows.Forms.TextBox tbSearchbar;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pbRemoveItem;
    }
}

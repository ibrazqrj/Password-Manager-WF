using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordManager.Model;
using PasswordManager.Services;
using DevExpress.XtraBars.Alerter;
using System.Web.Services.Description;

namespace Password_Manager_WF.Controls
{
    public partial class AllItemsControl: UserControl
    {
        private byte[] _aesKey;
        private List<ListViewItem> originalItems = new List<ListViewItem>();

        public AllItemsControl(byte[] aesKey)
        {
            InitializeComponent();
            InitializeContextMenu();
            _aesKey = aesKey;
            LoadEntries();
        }

        private void LoadEntries()
        {
            PasswordService service = new PasswordService();
            var passwordList = service.GetPasswords(_aesKey);

            ActualizeView(passwordList);
        }

        private void ActualizeView(List<PasswordEntry> passwordList)
        {
            lvItems.Items.Clear();
            originalItems.Clear();

            foreach (var entry in passwordList)
            {
                ListViewItem item = new ListViewItem(entry.Website);
                item.SubItems.Add(entry.Username);
                item.SubItems.Add(entry.EncryptedPassword);
                item.SubItems.Add(entry.Category); 

                lvItems.Items.Add(item);
                originalItems.Add((ListViewItem)item.Clone());
            }
        }

        private void AddButtonOnClick(object sender, EventArgs e)
        {
            ShowControl(new AddItemControl(_aesKey));
        }

        private void ShowControl(UserControl newControl)
        {
            Controls.Clear();
            newControl.Dock = DockStyle.Fill;
            Controls.Add(newControl);
        }

        private void CopySelectedItems()
        {
            if (lvItems.SelectedItems.Count > 0)
            {
                StringBuilder sb = new StringBuilder();

                foreach (ListViewItem item in lvItems.SelectedItems)
                {
                    for (int i = 0; i < item.SubItems.Count; i++)
                    {
                        sb.Append(item.SubItems[i].Text);
                        if (i < item.SubItems.Count - 1) sb.Append("\t");
                    }
                    sb.AppendLine();
                }

                Clipboard.SetText(sb.ToString());
            }
        }

        private void InitializeContextMenu()
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();

            ToolStripMenuItem copyItem = new ToolStripMenuItem("Copy");
            copyItem.Click += (sender, e) => CopySelectedItems();

            contextMenu.Items.Add(copyItem);

            lvItems.ContextMenuStrip = contextMenu;
        }

        private void DeleteItemOnClick(object sender, EventArgs e)
        {
            ShowControl(new DeleteItemControl(_aesKey));
        }

        private void FormLoad(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvItems.Items)
            {
                originalItems.Add((ListViewItem)item.Clone());
            }
        }

        private void SearchOnClick(object sender, EventArgs e)
        {
            string searchText = tbSearchbar.Text.ToLower();
            lvItems.Items.Clear();

            foreach (var item in originalItems)
            {
                bool match = item.Text.ToLower().Contains(searchText);

                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    if (subItem.Text.ToLower().Contains(searchText))
                    {
                        match = true;
                        break; 
                    }
                }

                if (match)
                {
                    lvItems.Items.Add((ListViewItem)item.Clone());
                }
            }
        }
    }
}

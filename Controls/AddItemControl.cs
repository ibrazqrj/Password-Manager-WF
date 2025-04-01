using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordManager.Services;
using Password_Manager_WF.Components;

namespace Password_Manager_WF.Controls
{
    public partial class AddItemControl : UserControl
    {
        private readonly byte[] _aesKey;
        private readonly PasswordService _passwordService;

        public AddItemControl(byte[] aesKey)
        {
            InitializeComponent();
            _aesKey = aesKey;
            _passwordService = new PasswordService();
            ThemeManager.ApplyTheme(this);
        }

        private void AddNewItemOnClick(object sender, EventArgs e)
        {
            if(tbWebsite.Text == "" || tbUsername.Text == "" || tbPassword.Text == "")
            {
                toastWindowsNotification.ShowNotification("e995d5b6-2454-4240-95ad-0c17cd14f948");
                return;
            } else if (GetSelectedCategory() == string.Empty)
            {
                toastWindowsNotification.ShowNotification("4fe2dba8-b7e6-4e73-95f7-3d18e9d85bae");
                return;
            } else
            {
                int newId = _passwordService.GetNextId();
                string website = tbWebsite.Text;
                string username = tbUsername.Text;
                string password = tbPassword.Text;
                string category = GetSelectedCategory();

                _passwordService.AddPassword(newId, website, username, password, category, _aesKey);
                toastWindowsNotification.ShowNotification("e32a33ac-9493-4aac-9502-71f3d5d106fc");
                ShowControl(new AllItemsControl(_aesKey));
                ThemeManager.ApplyTheme(this);
            }
        }

        private string GetSelectedCategory()
        {
            var radioButtons = this.Controls.OfType<RadioButton>();
            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }
            return string.Empty;
        }

        private void ShowControl(UserControl newControl)
        {
            Controls.Clear();
            newControl.Dock = DockStyle.Fill;
            Controls.Add(newControl);
        }
    }
}

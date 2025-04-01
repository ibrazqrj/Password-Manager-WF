using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Password_Manager_WF.Components;

namespace Password_Manager_WF.Controls
{
    public partial class GeneratorSucceedControl: UserControl
    {
        public GeneratorSucceedControl(byte[] aesKey, string generatedPassword)
        {
            InitializeComponent();
            tbPassword.Text = generatedPassword;
            ThemeManager.ApplyTheme(this);
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            // ignored
        }

        public void SetGeneratedPassword(string password)
        {
            tbPassword.Text = password;
        }

        private void CopyToClipboard(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbPassword.Text))
            {
                Clipboard.SetText(tbPassword.Text);
                toastWindowsNotification.ShowNotification("a5a040b7-e4d6-4682-8ed2-9b49b008c996");
            }
        }
    }
}

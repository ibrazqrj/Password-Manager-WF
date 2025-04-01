using Password_Manager_WF.Components;
using Password_Manager_WF.Controls;
using Password_Manager_WF.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager_WF
{
    public partial class MainMenuScreen : Form
    {
        private byte[] _aesKey;
        public MainMenuScreen(byte[] aesKey)
        {
            InitializeComponent();

            tsTheme.IsOn = Settings.Theme == Theme.Dark;

            this._aesKey = aesKey;
            ShowControl(new HomeControl(_aesKey));
            ApplyConfiguration();
        }

        private const int DisplayParams = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= DisplayParams;
                return cp;
            }
        }

        private void CloseClick(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void HomeButtonClick(object sender, EventArgs e)
        {
            ShowControl(new HomeControl(_aesKey));
        }

        private void AllItemsButtonClick(object sender, EventArgs e)
        {
            ShowControl(new AllItemsControl(_aesKey));
        }

        private void GeneratorButtonClick(object sender, EventArgs e)
        {
            ShowControl(new GeneratorControl(_aesKey));
        }

        private void MasterpasswordButtonClick(object sender, EventArgs e)
        {
            ShowControl(new MasterpasswordControl(_aesKey));
        }

        private void ShowControl(UserControl control)
        {
            contentPanel.Controls.Clear();
            ThemeManager.ApplyTheme(control);
            contentPanel.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }

        private void ApplyConfiguration()
        {
            if (Settings.Theme == Theme.Dark)
            {
                this.BackColor = Color.FromArgb(32, 33, 36);
                this.ForeColor = Color.White;
            }
            else if (Settings.Theme == Theme.Light)
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.FromArgb(32, 33, 36);
            }

            lblTheme.Text = Settings.Theme.ToString().ToUpper();

            foreach (var control in Controls.Cast<Control>().Except([flpSidebar]))
            {
                ThemeManager.ApplyTheme(control);
            }

            if (tsTheme.IsOn)
            {
                BackColor = Color.FromArgb(32, 33, 36);
                ForeColor = Color.White;
                contentPanel.BackColor = Color.FromArgb(32, 33, 36);
                pnlThemeSwitch.BackColor = Color.FromArgb(32, 33, 36);
                pnlAvatar.BackColor = Color.FromArgb(32, 33, 36);
                btnHome.BackColor = Color.FromArgb(32, 33, 36);
                btnAllItems.BackColor = Color.FromArgb(32, 33, 36);
                btnGenerator.BackColor = Color.FromArgb(32, 33, 36);
                btnMasterPassword.BackColor = Color.FromArgb(32, 33, 36);
                flpSidebar.BackColor = Color.FromArgb(32, 33, 36);
                contentPanel.BackColor = Color.FromArgb(40, 41, 45);
                icnClose.BackColor = Color.FromArgb(40, 41, 45);

            }
            else
            {
                BackColor = Color.White;
                ForeColor = Color.FromArgb(32, 33, 36);
                contentPanel.BackColor = Color.FromArgb(0, 123, 255);
                pnlThemeSwitch.BackColor = Color.FromArgb(0, 123, 255);
                pnlAvatar.BackColor = Color.FromArgb(0, 123, 255);
                btnHome.BackColor = Color.FromArgb(0, 123, 255);
                btnAllItems.BackColor = Color.FromArgb(0, 123, 255);
                btnGenerator.BackColor = Color.FromArgb(0, 123, 255);
                btnMasterPassword.BackColor = Color.FromArgb(0, 123, 255);
                flpSidebar.BackColor = Color.FromArgb(0, 123, 255);
                contentPanel.BackColor = Color.White;
                icnClose.BackColor = Color.White;

                icnClose.Image = Resources.close_square_svgrepo_com__2_;
                icnClose.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void ThemeSwitch_Toggled(object sender, EventArgs e)
        {
            Settings.Theme = tsTheme.IsOn ? Theme.Dark : Theme.Light;
            ApplyConfiguration();
        }
    }
}

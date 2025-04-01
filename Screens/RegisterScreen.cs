using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PasswordManager.Helper;
using System.Windows.Forms;
using PasswordManager.Components;
using Password_Manager_WF.Controls;
using System.Runtime.InteropServices;
using Password_Manager_WF.Components;

namespace Password_Manager_WF
{
    public partial class RegisterScreen : Form
    {
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private readonly MasterPasswordHelper _masterPasswordHelper;
        private readonly AesEncryptionHelper _aesKey;
        private bool _isRegistred = false;
        private const int dp = 0x00020000;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        public RegisterScreen()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(Form_MouseDown);
            _masterPasswordHelper = new MasterPasswordHelper();

            if (File.Exists(ConstantsCustom.MasterFilePath))
            {
                _isRegistred = true;
                ChangeScreen();
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= dp;
                return cp;
            }
        }

        private void btnRegisterClick(object sender, EventArgs e)
        {
            string masterpassword = MpRegistrationField.Text;
            if (string.IsNullOrWhiteSpace(masterpassword))
            {
                toastNotificationsManager1.ShowNotification("65793557-68d7-454c-a5a5-ee6208c02e87");
                return;
            }

            _masterPasswordHelper.HashPassword(masterpassword);
            _isRegistred = true;
            toastNotificationsManager1.ShowNotification("174d61fe-cfb8-4936-ad32-2d84d56350c0");
            Hide();
            ChangeScreen();
        }

        private void ChangeScreen()
        {
            if (_isRegistred == true)
            {
                LoginScreen loginForm = new LoginScreen();
                loginForm.ShowDialog();
            }
        }

        private void closeOnClick(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void tsTheme_Toggled(object sender, EventArgs e)
        {
            Settings.Theme = tsTheme.IsOn ? Theme.Dark : Theme.Light;
            ApplyConfiguration();
        }

        private void ApplyConfiguration()
        {
            if (Settings.Theme == Theme.Dark)
            {
                this.BackColor = Color.FromArgb(40, 41, 45);
                this.ForeColor = Color.White;
            }
            else if (Settings.Theme == Theme.Light)
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.FromArgb(40, 41, 45);
            }

            lblTheme.Text = Settings.Theme.ToString().ToUpper();

            foreach (var control in Controls.Cast<Control>())
            {
                ThemeManager.ApplyTheme(control);
            }
        }
    }
}

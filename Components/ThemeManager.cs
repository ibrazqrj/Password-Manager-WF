using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager_WF.Components
{
    public static class ThemeManager
    {
        public static bool IsDarkTheme => Settings.Theme == Theme.Dark;

        public static void ApplyTheme(Control control)
        {
            Color backColor = IsDarkTheme ? Color.FromArgb(40, 41, 45) : Color.White;
            Color foreColor = IsDarkTheme ? Color.White : Color.FromArgb(0, 123, 255);
            Color panelBackColor = IsDarkTheme ? Color.White : Color.FromArgb(0, 123, 255);
            Color buttonBackColor = IsDarkTheme ? Color.FromArgb(0, 123, 255) : Color.FromArgb(0, 123, 255);
            ApplyThemeToControl(control, backColor, foreColor, panelBackColor, buttonBackColor);
        }

        private static void ApplyThemeToControl(Control control, Color backColor, Color foreColor, Color panelBackColor, Color buttonBackColor)
        {
            if (control is Panel)
            {
                control.BackColor = panelBackColor;
            }
            else if (control is Button button)
            {
                button.BackColor = buttonBackColor;
                button.ForeColor = Color.White;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
            } else if (control is PictureBox)
            {
                control.BackColor = backColor;
            }
            else
            {
                control.BackColor = backColor;
                control.ForeColor = foreColor;
            }

            foreach (Control childControl in control.Controls)
            {
                ApplyThemeToControl(childControl, backColor, foreColor, panelBackColor, buttonBackColor);
            }
        }
    }
}

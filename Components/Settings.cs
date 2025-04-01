using PasswordManager.Components;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Password_Manager_WF
{
    public enum Theme
    {
        Light,
        Dark
    }

    public static class Settings
    {
        private static string _themePath = ConstantsCustom.ThemePath;

        private static Theme _theme;
        public static Theme Theme
        {
            get => _theme; set
            {
                if (value != _theme)
                {
                    WriteValue("Layout", "ThemeMode", value.ToString());
                    _theme = value;
                }
            }
        }

        static Settings()
        {
            LoadSettings();
        }

        public static void LoadSettings()
        {
            bool success = Enum.TryParse<Theme>(ReadValue("Layout", "ThemeMode", "light"), out var result);
            if (success)
            {
                Theme = result;
            }
        }

        private static string ReadValue(string section, string key, string defaultValue)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(section, key, defaultValue, temp, 255, _themePath);
            return temp.ToString();
        }

        private static void WriteValue(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, _themePath);
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        private static extern int GetPrivateProfileString(string section, string key, string defaultValue, StringBuilder retVal, int size, string filePath);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        private static extern long WritePrivateProfileString(string section, string key, string value, string filePath);
    }
}

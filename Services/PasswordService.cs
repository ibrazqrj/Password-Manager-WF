
using PasswordManager.Components;
using PasswordManager.Format;
using PasswordManager.Helper;
using PasswordManager.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.Services
{
    class PasswordService
    {
        private string filePath = ConstantsCustom.PasswordFilePath;

        public void AddPassword(int id, string website, string username, string password, string category, byte[] aesKey)
        {
            int entryId = id;
            string encryptedUsername = AesEncryptionHelper.EncryptPassword(username, aesKey);
            string encryptedPassword = AesEncryptionHelper.EncryptPassword(password, aesKey);
            string encryptedCategory = AesEncryptionHelper.EncryptPassword(category, aesKey);

            if (!File.Exists(ConstantsCustom.PasswordFilePath))
            {
                File.Create(ConstantsCustom.PasswordFilePath).Close();
            }

            File.AppendAllText(ConstantsCustom.PasswordFilePath, entryId + " | " + website + " | " + encryptedUsername + " | " + encryptedPassword + " | " + encryptedCategory + Environment.NewLine);
        }

        public List<PasswordEntry> GetPasswords(byte[] aesKey)
        {
            var passwordList = new List<PasswordEntry>();

            if (File.Exists(filePath))
            {
                var savedPasswords = File.ReadAllLines(filePath);
                foreach (var line in savedPasswords)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 5)
                    {
                        string decryptedUsername = AesEncryptionHelper.DecryptPassword(parts[2].Trim(), aesKey);
                        string decryptedPassword = AesEncryptionHelper.DecryptPassword(parts[3].Trim(), aesKey);
                        string decryptedCategory = AesEncryptionHelper.DecryptPassword(parts[4].Trim(), aesKey);
                        passwordList.Add(new PasswordEntry
                        {
                            Id = parts[0].Trim(),
                            Website = parts[1].Trim(),
                            Username = decryptedUsername,
                            EncryptedPassword = decryptedPassword,
                            Category = decryptedCategory
                        });
                    }
                }
            }

            return passwordList;
        }

        public int GetNextId()
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                if (lines.Length > 0)
                {
                    int maxId = lines.Select(line => int.Parse(line.Split('|')[0])).Max();
                    return maxId + 1;
                }
            }
            return 1;
        }

        public void DeletePassword(byte[] aesKey, int id)
        {
            var validPasswords = new List<string>();
            var partCount = 1;

            if (File.Exists(filePath))
            {
                var savedPasswords = File.ReadAllLines(filePath);

                foreach (string savedpws in savedPasswords)
                {
                    var parts = savedpws.Split('|');
                    if (parts.Length == 5 && int.TryParse(parts[0].Trim(), out int parsedId) && parsedId != id)
                    {   
                        validPasswords.Add(savedpws);
                        File.WriteAllLines(filePath, validPasswords);
                    }
                }
            }
        }

        public string GeneratePassword(int length)
        {
            const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lower = "abcdefghijklmnopqrstuvwxyz";
            const string digits = "0123456789";
            const string special = "!@#$/&";

            string allChars = upper + lower + digits + special;
            Random random = new Random();
            char[] password = new char[length];

            for (int i = 0; i < length; i++)
            {
                password[i] = allChars[random.Next(allChars.Length)];
            }

            return new string(password);
        }

        public List<PasswordEntry> SearchPassword(string searchTerm, byte[] aesKey)
        {
            var matchingEntries = new List<PasswordEntry>();

            if (File.Exists(filePath))
            {
                var savedPasswords = File.ReadAllLines(filePath);

                foreach (string savedpws in savedPasswords)
                {
                    var parts = savedpws.Split('|');
                    if (parts.Length == 4)
                    {
                        try
                        {
                            string decryptedUsername = AesEncryptionHelper.DecryptPassword(parts[1].Trim(), aesKey);
                            string decryptedPassword = AesEncryptionHelper.DecryptPassword(parts[2].Trim(), aesKey);
                            string decryptedCategory = AesEncryptionHelper.DecryptPassword(parts[3].Trim(), aesKey);

                            if (parts[0].IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                decryptedUsername.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                decryptedPassword.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                parts[3].IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                            {
                                matchingEntries.Add(new PasswordEntry
                                {
                                    Website = parts[0].Trim(),
                                    Username = decryptedUsername,
                                    EncryptedPassword = decryptedPassword,
                                    Category = decryptedCategory
                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error decrypting entry: {ex.Message}");
                        }
                    }
                }
            }
            return matchingEntries;
        }

        public bool RenewMasterPassword(string oldPassword, string newPassword, byte[] oldAesKey)
        {
            string filePath = ConstantsCustom.MasterFilePath;
            string passwordsFile = ConstantsCustom.PasswordFilePath;

            if (!File.Exists(filePath))
            {
                MessageBox.Show("No master password set yet. Please set one first.");
                return false;
            }

            List<string> decryptedPasswords = new List<string>();

            if (File.Exists(passwordsFile))
            {
                var savedPasswords = File.ReadAllLines(passwordsFile);

                foreach (string line in savedPasswords)
                {
                    var passwordParts = line.Split('|');

                    if (passwordParts.Length != 4)
                    {
                        MessageBox.Show("Passwords file manipulated. Password manager is going to shut down...");
                        Environment.Exit(0);
                    }
                    else
                    {
                        string decryptedWebsite = passwordParts[0];
                        string decryptedUsername = AesEncryptionHelper.DecryptPassword(passwordParts[1].Trim(), oldAesKey);
                        string decryptedPassword = AesEncryptionHelper.DecryptPassword(passwordParts[2].Trim(), oldAesKey);
                        string decryptedCategory = AesEncryptionHelper.DecryptPassword(passwordParts[3].Trim(), oldAesKey);

                        decryptedPasswords.Add($"{decryptedWebsite}|{decryptedUsername}|{decryptedPassword}|{decryptedCategory}");
                    }
                }
            }

            string hashedPassword = File.ReadAllText(filePath);
            string[] parts = hashedPassword.Split(':');
            if (parts.Length != 2)
            {
                return false;
            }

            byte[] storedSalt = Convert.FromBase64String(parts[0]);
            string storedHash = parts[1];

            Pbkdf2 pbkdf2 = new Pbkdf2();
            string computedHash = pbkdf2.Hash(oldPassword, storedSalt);

            if (storedHash != computedHash)
            {
                return false;
            }

            byte[] newSalt = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(newSalt);
            }
            string newSaltBase64 = Convert.ToBase64String(newSalt);
            string newHash = pbkdf2.Hash(newPassword, newSalt);
            string newHashCombined = $"{newSaltBase64}:{newHash}";

            File.WriteAllText(filePath, newHashCombined);

            byte[] newAesKey = AesEncryptionHelper.DeriveKeyFromPassword(newPassword);

            if (File.Exists(passwordsFile))
            {
                List<string> reEncryptedPasswords = new List<string>();

                foreach (string decryptedEntry in decryptedPasswords)
                {
                    var passwordParts = decryptedEntry.Split('|');

                    string encryptedUsername = AesEncryptionHelper.EncryptPassword(passwordParts[1], newAesKey);
                    string encryptedPassword = AesEncryptionHelper.EncryptPassword(passwordParts[2], newAesKey);
                    string encryptedCategory = AesEncryptionHelper.EncryptPassword(passwordParts[3], newAesKey);

                    reEncryptedPasswords.Add($"{passwordParts[0]}|{encryptedUsername}|{encryptedPassword}|{encryptedCategory}");
                }

                File.WriteAllLines(passwordsFile, reEncryptedPasswords);
            }

            MessageBox.Show("Master password updated successfully, and all passwords have been re-encrypted. Please login again.");
            return true;
        }
    }
}
 
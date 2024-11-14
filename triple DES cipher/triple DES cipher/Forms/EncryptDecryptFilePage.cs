using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using triple_DES_cipher.Services;

namespace triple_DES_cipher.Forms
{
    public partial class EncryptDecryptFilePage : Form
    {
        private TripleDESEncryption _tripleDes;
        private OpenFileDialog openFileDialog;
        private User _currentUser;

        public EncryptDecryptFilePage(User currentUser)
        {
            InitializeComponent();
            _tripleDes = new TripleDESEncryption("SecretKey012345678901234"); // ключ довжиною 24 символи
            _currentUser = currentUser;
            // ініціалізація OpenFileDialog
            openFileDialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Виберіть файл для шифрування або розшифрування"
            };
        }

        private void encryptFileButton_Click(object sender, EventArgs e)
        {
            string filePath = filePathTextBox.Text;
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                MessageBox.Show("Будь ласка, виберіть правильний файл");
                return;
            }
            string fileName = Path.GetFileName(filePath);
            if (!AccessControl.HasAccess(_currentUser.Department, fileName))
            {
                MessageBox.Show("У вас немає доступу до цього файлу");
                return;
            }
            try
            {
                string fileContent = File.ReadAllText(filePath);
                string encryptedContent = _tripleDes.Encrypt(fileContent);
                File.WriteAllText(filePath + ".enc", encryptedContent);
                MessageBox.Show("Файл зашифровано успішно");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при шифруванні: " + ex.Message);
            }
        }

        private void decryptFileButton_Click(object sender, EventArgs e)
        {
            string filePath = filePathTextBox.Text;
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                MessageBox.Show("Будь ласка, виберіть правильний файл");
                return;
            }

            string fileName = Path.GetFileName(filePath);
            if (!AccessControl.HasAccess(_currentUser.Department, fileName))
            {
                MessageBox.Show("У вас немає доступу до цього файлу");
                return;
            }

            try
            {
                string encryptedContent = File.ReadAllText(filePath);
                string decryptedContent = _tripleDes.Decrypt(encryptedContent);
                string decryptedFilePath = filePath.Replace(".enc", "");

                File.WriteAllText(decryptedFilePath, decryptedContent);
                MessageBox.Show("Файл розшифровано успішно");

                // відкриття розшифрованого файлу
                Process.Start(new ProcessStartInfo
                {
                    FileName = decryptedFilePath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при розшифруванні: " + ex.Message);
            }
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            // діалогове вікно для вибору файлу
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePathTextBox.Text = openFileDialog.FileName; // запис шляху до вибраного файлу в TextBox
            }
        }
    }
}

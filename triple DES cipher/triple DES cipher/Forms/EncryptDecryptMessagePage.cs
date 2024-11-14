using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using triple_DES_cipher.Services;

namespace triple_DES_cipher.Forms
{
    public partial class EncryptDecryptMessagePage : Form
    {
        private TripleDESEncryption _tripleDes;

        public EncryptDecryptMessagePage()
        {
            InitializeComponent();
            _tripleDes = new TripleDESEncryption("SecretKey012345678901234"); // ключ довжиною 24 символи
        }

        private void encryptMessageButton_Click(object sender, EventArgs e)
        {
            string plaintext = messageTextBox.Text;
            string ciphertext = _tripleDes.Encrypt(plaintext);
            resultTextBox.Text = ciphertext;
        }

        private void decryptMessageButton_Click(object sender, EventArgs e)
        {
            string ciphertext = messageTextBox.Text;
            string plaintext = _tripleDes.Decrypt(ciphertext);
            resultTextBox.Text = plaintext;
        }
    }
}

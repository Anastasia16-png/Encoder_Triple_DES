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
    public partial class MainPage : Form
    {
        private User _currentUser;
        public MainPage(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
        }
        private void encryptDecryptMessageButton_Click(object sender, EventArgs e)
        {
            var messagePage = new EncryptDecryptMessagePage();
            messagePage.Show();
        }

        private void encryptDecryptFileButton_Click(object sender, EventArgs e)
        {

            var filePage = new EncryptDecryptFilePage(_currentUser);
            filePage.Show();
        }
    }
}

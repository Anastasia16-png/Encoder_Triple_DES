using System;
using System.Windows.Forms;
using triple_DES_cipher.Forms;
using triple_DES_cipher.Services;

namespace triple_DES_cipher
{
    public partial class LoginPage : Form
    {
        private readonly LoginService _loginService;

        public LoginPage()
        {
            InitializeComponent();
            _loginService = new LoginService();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            var user = _loginService.Authenticate(username, password);
            if (user != null)
            {
                MessageBox.Show("Ви увійшли");
                Hide();

                var mainPage = new MainPage(user); // передач екземпляру користувача
                mainPage.Show();
            }
            else
            {
                MessageBox.Show("Неправильний логін чи пароль");
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}

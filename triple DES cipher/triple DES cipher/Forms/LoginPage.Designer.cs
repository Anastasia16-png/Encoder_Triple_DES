
using triple_DES_cipher.Forms;
using triple_DES_cipher.Services;

namespace triple_DES_cipher
{
    public partial class LoginPage : Form
    {
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label label1;
        private Label label2;
        private Button loginButton;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            loginButton = new Button();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.White;
            usernameTextBox.Location = new Point(40, 59);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(206, 27);
            usernameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.White;
            passwordTextBox.Location = new Point(40, 136);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(206, 27);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DarkViolet;
            label1.Location = new Point(40, 27);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 2;
            label1.Text = "Логін:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.DarkViolet;
            label2.Location = new Point(40, 103);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 3;
            label2.Text = "Пароль:";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.White;
            loginButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginButton.ForeColor = Color.DarkViolet;
            loginButton.Location = new Point(71, 195);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(140, 30);
            loginButton.TabIndex = 4;
            loginButton.Text = "Увійти";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // LoginPage
            // 
            BackColor = Color.White;
            ClientSize = new Size(285, 264);
            Controls.Add(loginButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginPage";
            Text = " ";
            Load += LoginPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

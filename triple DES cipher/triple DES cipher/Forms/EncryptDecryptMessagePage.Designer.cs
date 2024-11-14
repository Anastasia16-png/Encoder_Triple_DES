using System.Drawing;
using System.Windows.Forms;

namespace triple_DES_cipher.Forms
{
    partial class EncryptDecryptMessagePage
    {
        private TextBox messageTextBox;
        private Button encryptMessageButton;
        private Button decryptMessageButton;
        private TextBox resultTextBox;
        private Label labelMessage;
        private Label labelResult;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptDecryptMessagePage));
            messageTextBox = new TextBox();
            encryptMessageButton = new Button();
            decryptMessageButton = new Button();
            resultTextBox = new TextBox();
            labelMessage = new Label();
            labelResult = new Label();
            SuspendLayout();
            // 
            // messageTextBox
            // 
            messageTextBox.BackColor = Color.White;
            messageTextBox.Location = new Point(33, 56);
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(372, 27);
            messageTextBox.TabIndex = 0;
            // 
            // encryptMessageButton
            // 
            encryptMessageButton.BackColor = Color.White;
            encryptMessageButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            encryptMessageButton.ForeColor = Color.DarkViolet;
            encryptMessageButton.Location = new Point(33, 111);
            encryptMessageButton.Name = "encryptMessageButton";
            encryptMessageButton.Size = new Size(140, 30);
            encryptMessageButton.TabIndex = 2;
            encryptMessageButton.Text = "Зашифрувати";
            encryptMessageButton.UseVisualStyleBackColor = false;
            encryptMessageButton.Click += encryptMessageButton_Click;
            // 
            // decryptMessageButton
            // 
            decryptMessageButton.BackColor = Color.White;
            decryptMessageButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            decryptMessageButton.ForeColor = Color.DarkViolet;
            decryptMessageButton.Location = new Point(190, 111);
            decryptMessageButton.Name = "decryptMessageButton";
            decryptMessageButton.Size = new Size(140, 30);
            decryptMessageButton.TabIndex = 3;
            decryptMessageButton.Text = "Розшифрувати";
            decryptMessageButton.UseVisualStyleBackColor = false;
            decryptMessageButton.Click += decryptMessageButton_Click;
            // 
            // resultTextBox
            // 
            resultTextBox.BackColor = Color.White;
            resultTextBox.Location = new Point(33, 196);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.Size = new Size(372, 27);
            resultTextBox.TabIndex = 4;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelMessage.ForeColor = Color.DarkViolet;
            labelMessage.Location = new Point(35, 25);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(177, 20);
            labelMessage.TabIndex = 1;
            labelMessage.Text = "Введіть повідомлення:";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelResult.ForeColor = Color.DarkViolet;
            labelResult.Location = new Point(33, 166);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(83, 20);
            labelResult.TabIndex = 5;
            labelResult.Text = "Результат:";
            // 
            // EncryptDecryptMessagePage
            // 
            BackColor = Color.White;
            ClientSize = new Size(442, 263);
            Controls.Add(labelMessage);
            Controls.Add(messageTextBox);
            Controls.Add(encryptMessageButton);
            Controls.Add(decryptMessageButton);
            Controls.Add(labelResult);
            Controls.Add(resultTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EncryptDecryptMessagePage";
            Text = "Шифрування повідомлення";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
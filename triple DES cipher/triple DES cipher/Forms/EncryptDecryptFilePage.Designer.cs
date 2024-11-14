namespace triple_DES_cipher.Forms
{
    partial class EncryptDecryptFilePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptDecryptFilePage));
            selectFileButton = new Button();
            encryptFileButton = new Button();
            decryptFileButton = new Button();
            filePathTextBox = new TextBox();
            labelFilePath = new Label();
            SuspendLayout();
            // 
            // selectFileButton
            // 
            selectFileButton.BackColor = Color.White;
            selectFileButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            selectFileButton.ForeColor = Color.DarkViolet;
            selectFileButton.Location = new Point(35, 35);
            selectFileButton.Name = "selectFileButton";
            selectFileButton.Size = new Size(140, 30);
            selectFileButton.TabIndex = 0;
            selectFileButton.Text = "Обрати файл";
            selectFileButton.UseVisualStyleBackColor = false;
            selectFileButton.Click += selectFileButton_Click;
            // 
            // encryptFileButton
            // 
            encryptFileButton.BackColor = Color.White;
            encryptFileButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            encryptFileButton.ForeColor = Color.DarkViolet;
            encryptFileButton.Location = new Point(35, 184);
            encryptFileButton.Name = "encryptFileButton";
            encryptFileButton.Size = new Size(140, 30);
            encryptFileButton.TabIndex = 1;
            encryptFileButton.Text = "Зашифрувати";
            encryptFileButton.UseVisualStyleBackColor = false;
            encryptFileButton.Click += encryptFileButton_Click;
            // 
            // decryptFileButton
            // 
            decryptFileButton.BackColor = Color.White;
            decryptFileButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            decryptFileButton.ForeColor = Color.DarkViolet;
            decryptFileButton.Location = new Point(190, 184);
            decryptFileButton.Name = "decryptFileButton";
            decryptFileButton.Size = new Size(140, 30);
            decryptFileButton.TabIndex = 2;
            decryptFileButton.Text = "Розшифрувати";
            decryptFileButton.UseVisualStyleBackColor = false;
            decryptFileButton.Click += decryptFileButton_Click;
            // 
            // filePathTextBox
            // 
            filePathTextBox.BackColor = Color.White;
            filePathTextBox.Location = new Point(190, 97);
            filePathTextBox.Name = "filePathTextBox";
            filePathTextBox.Size = new Size(210, 27);
            filePathTextBox.TabIndex = 3;
            // 
            // labelFilePath
            // 
            labelFilePath.AutoSize = true;
            labelFilePath.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelFilePath.ForeColor = Color.DarkViolet;
            labelFilePath.Location = new Point(35, 100);
            labelFilePath.Name = "labelFilePath";
            labelFilePath.Size = new Size(126, 20);
            labelFilePath.TabIndex = 4;
            labelFilePath.Text = "Шлях до файлу:";
            // 
            // EncryptDecryptFilePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(442, 263);
            Controls.Add(labelFilePath);
            Controls.Add(filePathTextBox);
            Controls.Add(decryptFileButton);
            Controls.Add(encryptFileButton);
            Controls.Add(selectFileButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EncryptDecryptFilePage";
            Text = "Шифрування файлу";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button selectFileButton;
        private Button encryptFileButton;
        private Button decryptFileButton;
        private TextBox filePathTextBox;
        private Label labelFilePath;
    }
}
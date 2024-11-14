namespace triple_DES_cipher.Forms
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            encryptDecryptMessageButton = new Button();
            encryptDecryptFileButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // encryptDecryptMessageButton
            // 
            encryptDecryptMessageButton.BackColor = Color.White;
            encryptDecryptMessageButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            encryptDecryptMessageButton.ForeColor = Color.DarkViolet;
            encryptDecryptMessageButton.Location = new Point(120, 136);
            encryptDecryptMessageButton.Name = "encryptDecryptMessageButton";
            encryptDecryptMessageButton.Size = new Size(140, 30);
            encryptDecryptMessageButton.TabIndex = 0;
            encryptDecryptMessageButton.Text = "Повідомлення";
            encryptDecryptMessageButton.UseVisualStyleBackColor = false;
            encryptDecryptMessageButton.Click += encryptDecryptMessageButton_Click;
            // 
            // encryptDecryptFileButton
            // 
            encryptDecryptFileButton.BackColor = Color.White;
            encryptDecryptFileButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            encryptDecryptFileButton.ForeColor = Color.DarkViolet;
            encryptDecryptFileButton.Location = new Point(290, 136);
            encryptDecryptFileButton.Name = "encryptDecryptFileButton";
            encryptDecryptFileButton.Size = new Size(140, 30);
            encryptDecryptFileButton.TabIndex = 1;
            encryptDecryptFileButton.Text = "Файл";
            encryptDecryptFileButton.UseVisualStyleBackColor = false;
            encryptDecryptFileButton.Click += encryptDecryptFileButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DarkViolet;
            label1.Location = new Point(76, 59);
            label1.Name = "label1";
            label1.Size = new Size(395, 20);
            label1.TabIndex = 2;
            label1.Text = "Оберіть що Ви хочете зашифрувати / розшифрувати";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(548, 232);
            Controls.Add(label1);
            Controls.Add(encryptDecryptFileButton);
            Controls.Add(encryptDecryptMessageButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainPage";
            Text = "Головна";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button encryptDecryptMessageButton;
        private Button encryptDecryptFileButton;
        private Label label1;
    }
}
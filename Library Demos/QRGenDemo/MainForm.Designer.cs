namespace QRGenDemo
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            QRCodeTextBox = new TextBox();
            QRCodePictureBox = new PictureBox();
            GenerateQRButton = new Button();
            ((System.ComponentModel.ISupportInitialize)QRCodePictureBox).BeginInit();
            SuspendLayout();
            // 
            // QRCodeTextBox
            // 
            QRCodeTextBox.Location = new Point(12, 12);
            QRCodeTextBox.Name = "QRCodeTextBox";
            QRCodeTextBox.Size = new Size(378, 27);
            QRCodeTextBox.TabIndex = 0;
            // 
            // QRCodePictureBox
            // 
            QRCodePictureBox.Location = new Point(12, 45);
            QRCodePictureBox.Name = "QRCodePictureBox";
            QRCodePictureBox.Size = new Size(378, 353);
            QRCodePictureBox.TabIndex = 1;
            QRCodePictureBox.TabStop = false;
            // 
            // GenerateQRButton
            // 
            GenerateQRButton.Location = new Point(169, 409);
            GenerateQRButton.Name = "GenerateQRButton";
            GenerateQRButton.Size = new Size(221, 29);
            GenerateQRButton.TabIndex = 2;
            GenerateQRButton.Text = "Generate QR Code";
            GenerateQRButton.UseVisualStyleBackColor = true;
            GenerateQRButton.Click += GenerateQRButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 450);
            Controls.Add(GenerateQRButton);
            Controls.Add(QRCodePictureBox);
            Controls.Add(QRCodeTextBox);
            Name = "MainForm";
            Text = "QRGenDemo";
            ((System.ComponentModel.ISupportInitialize)QRCodePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox QRCodeTextBox;
        private PictureBox QRCodePictureBox;
        private Button GenerateQRButton;
    }
}
namespace File_Encryption
{
    partial class MainForm
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
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnOpenAgain = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnOpenOneMoreTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(13, 13);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(161, 28);
            this.btnCreateFile.TabIndex = 0;
            this.btnCreateFile.Text = "1. Create a file";
            this.btnCreateFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(13, 47);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(161, 28);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "2. Open";
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(13, 81);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(161, 28);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "3. Encrypt";
            this.btnEncrypt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnOpenAgain
            // 
            this.btnOpenAgain.Location = new System.Drawing.Point(13, 115);
            this.btnOpenAgain.Name = "btnOpenAgain";
            this.btnOpenAgain.Size = new System.Drawing.Size(161, 28);
            this.btnOpenAgain.TabIndex = 3;
            this.btnOpenAgain.Text = "4. Open";
            this.btnOpenAgain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenAgain.UseVisualStyleBackColor = true;
            this.btnOpenAgain.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(13, 149);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(161, 28);
            this.btnDecrypt.TabIndex = 4;
            this.btnDecrypt.Text = "5. Decrypt";
            this.btnDecrypt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnOpenOneMoreTime
            // 
            this.btnOpenOneMoreTime.Location = new System.Drawing.Point(13, 183);
            this.btnOpenOneMoreTime.Name = "btnOpenOneMoreTime";
            this.btnOpenOneMoreTime.Size = new System.Drawing.Size(161, 28);
            this.btnOpenOneMoreTime.TabIndex = 5;
            this.btnOpenOneMoreTime.Text = "6. Open";
            this.btnOpenOneMoreTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenOneMoreTime.UseVisualStyleBackColor = true;
            this.btnOpenOneMoreTime.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 363);
            this.Controls.Add(this.btnOpenOneMoreTime);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnOpenAgain);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnCreateFile);
            this.Name = "MainForm";
            this.Text = "File Encryption";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnOpenAgain;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnOpenOneMoreTime;
    }
}


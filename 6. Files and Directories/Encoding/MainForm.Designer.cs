namespace Encoding
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnASCII = new System.Windows.Forms.Button();
            this.btnUTF8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(307, 22);
            this.txtInput.TabIndex = 5;
            this.txtInput.Text = "٠١٢٣٤٥٦٧٨٩";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(12, 82);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(20, 17);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "...";
            // 
            // btnASCII
            // 
            this.btnASCII.Location = new System.Drawing.Point(12, 40);
            this.btnASCII.Name = "btnASCII";
            this.btnASCII.Size = new System.Drawing.Size(75, 23);
            this.btnASCII.TabIndex = 3;
            this.btnASCII.Text = "ASCII";
            this.btnASCII.UseVisualStyleBackColor = true;
            this.btnASCII.Click += new System.EventHandler(this.btnASCII_Click);
            // 
            // btnUTF8
            // 
            this.btnUTF8.Location = new System.Drawing.Point(93, 40);
            this.btnUTF8.Name = "btnUTF8";
            this.btnUTF8.Size = new System.Drawing.Size(75, 23);
            this.btnUTF8.TabIndex = 6;
            this.btnUTF8.Text = "UTF-8";
            this.btnUTF8.UseVisualStyleBackColor = true;
            this.btnUTF8.Click += new System.EventHandler(this.btnUTF8_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 207);
            this.Controls.Add(this.btnUTF8);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnASCII);
            this.Name = "MainForm";
            this.Text = "Encoding";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnASCII;
        private System.Windows.Forms.Button btnUTF8;
    }
}


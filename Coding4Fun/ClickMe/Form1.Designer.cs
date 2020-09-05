namespace ClickMe
{
    partial class Form1
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
            this.btnClickMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClickMe
            // 
            this.btnClickMe.Location = new System.Drawing.Point(306, 178);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(89, 42);
            this.btnClickMe.TabIndex = 0;
            this.btnClickMe.Text = "ClickMe!";
            this.btnClickMe.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 433);
            this.Controls.Add(this.btnClickMe);
            this.Name = "Form1";
            this.Text = "ClickMe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClickMe;
    }
}


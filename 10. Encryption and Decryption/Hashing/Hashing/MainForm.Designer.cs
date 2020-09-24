namespace Hashing
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
            this.btnHash = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblOutput1 = new System.Windows.Forms.Label();
            this.lblOutput2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHash
            // 
            this.btnHash.Location = new System.Drawing.Point(22, 70);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(75, 23);
            this.btnHash.TabIndex = 0;
            this.btnHash.Text = "Hash";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(22, 42);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(361, 22);
            this.txtInput.TabIndex = 1;
            // 
            // lblOutput1
            // 
            this.lblOutput1.AutoSize = true;
            this.lblOutput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput1.Location = new System.Drawing.Point(19, 133);
            this.lblOutput1.Name = "lblOutput1";
            this.lblOutput1.Size = new System.Drawing.Size(23, 17);
            this.lblOutput1.TabIndex = 2;
            this.lblOutput1.Text = "...";
            this.lblOutput1.Click += new System.EventHandler(this.lblOutput1_Click);
            // 
            // lblOutput2
            // 
            this.lblOutput2.AutoSize = true;
            this.lblOutput2.Location = new System.Drawing.Point(19, 159);
            this.lblOutput2.Name = "lblOutput2";
            this.lblOutput2.Size = new System.Drawing.Size(20, 17);
            this.lblOutput2.TabIndex = 3;
            this.lblOutput2.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Salt";
            // 
            // txtSalt
            // 
            this.txtSalt.Location = new System.Drawing.Point(393, 42);
            this.txtSalt.Name = "txtSalt";
            this.txtSalt.Size = new System.Drawing.Size(100, 22);
            this.txtSalt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Click on code to copy it.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 210);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOutput2);
            this.Controls.Add(this.lblOutput1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnHash);
            this.Name = "MainForm";
            this.Text = "Hashing";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblOutput1;
        private System.Windows.Forms.Label lblOutput2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalt;
        private System.Windows.Forms.Label label2;
    }
}


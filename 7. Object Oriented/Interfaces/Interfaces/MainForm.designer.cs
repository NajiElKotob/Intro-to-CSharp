namespace Interfaces
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
            this.btnIDisposable = new System.Windows.Forms.Button();
            this.btnGC = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIDisposable
            // 
            this.btnIDisposable.Location = new System.Drawing.Point(12, 12);
            this.btnIDisposable.Name = "btnIDisposable";
            this.btnIDisposable.Size = new System.Drawing.Size(175, 61);
            this.btnIDisposable.TabIndex = 0;
            this.btnIDisposable.Text = "IDisposable";
            this.btnIDisposable.UseVisualStyleBackColor = true;
            this.btnIDisposable.Click += new System.EventHandler(this.btnIDisposable_Click);
            // 
            // btnGC
            // 
            this.btnGC.Location = new System.Drawing.Point(12, 146);
            this.btnGC.Name = "btnGC";
            this.btnGC.Size = new System.Drawing.Size(175, 56);
            this.btnGC.TabIndex = 1;
            this.btnGC.Text = "GC";
            this.btnGC.UseVisualStyleBackColor = true;
            this.btnGC.Click += new System.EventHandler(this.btnGC_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "IEnumerable";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblOutput.Location = new System.Drawing.Point(0, 233);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(369, 75);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 308);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGC);
            this.Controls.Add(this.btnIDisposable);
            this.Name = "Form1";
            this.Text = "Common Interfaces";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIDisposable;
        private System.Windows.Forms.Button btnGC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblOutput;
    }
}


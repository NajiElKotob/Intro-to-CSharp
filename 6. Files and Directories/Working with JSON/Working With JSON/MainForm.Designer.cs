namespace Working_With_JSON
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
            this.btnSample1 = new System.Windows.Forms.Button();
            this.btnSample2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSample1
            // 
            this.btnSample1.Location = new System.Drawing.Point(12, 27);
            this.btnSample1.Name = "btnSample1";
            this.btnSample1.Size = new System.Drawing.Size(290, 33);
            this.btnSample1.TabIndex = 0;
            this.btnSample1.Text = "Sample 1";
            this.btnSample1.UseVisualStyleBackColor = true;
            this.btnSample1.Click += new System.EventHandler(this.btnSample1_Click);
            // 
            // btnSample2
            // 
            this.btnSample2.Location = new System.Drawing.Point(12, 66);
            this.btnSample2.Name = "btnSample2";
            this.btnSample2.Size = new System.Drawing.Size(290, 33);
            this.btnSample2.TabIndex = 1;
            this.btnSample2.Text = "Sample2";
            this.btnSample2.UseVisualStyleBackColor = true;
            this.btnSample2.Click += new System.EventHandler(this.btnSample2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 127);
            this.Controls.Add(this.btnSample2);
            this.Controls.Add(this.btnSample1);
            this.Name = "MainForm";
            this.Text = "Working with JSON";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSample1;
        private System.Windows.Forms.Button btnSample2;
    }
}
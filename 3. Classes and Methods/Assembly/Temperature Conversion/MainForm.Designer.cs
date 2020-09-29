namespace Temperature_Conversion
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
            this.txtTemperatureC = new System.Windows.Forms.TextBox();
            this.btnConvertToTemperatureF = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTemperatureC
            // 
            this.txtTemperatureC.Location = new System.Drawing.Point(12, 25);
            this.txtTemperatureC.Name = "txtTemperatureC";
            this.txtTemperatureC.Size = new System.Drawing.Size(93, 22);
            this.txtTemperatureC.TabIndex = 0;
            // 
            // btnConvertToTemperatureF
            // 
            this.btnConvertToTemperatureF.Location = new System.Drawing.Point(12, 53);
            this.btnConvertToTemperatureF.Name = "btnConvertToTemperatureF";
            this.btnConvertToTemperatureF.Size = new System.Drawing.Size(188, 23);
            this.btnConvertToTemperatureF.TabIndex = 1;
            this.btnConvertToTemperatureF.Text = "Convert to Fahrenheit ";
            this.btnConvertToTemperatureF.UseVisualStyleBackColor = true;
            this.btnConvertToTemperatureF.Click += new System.EventHandler(this.btnConvertToTemperatureF_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(12, 91);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(20, 17);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 264);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnConvertToTemperatureF);
            this.Controls.Add(this.txtTemperatureC);
            this.Name = "MainForm";
            this.Text = "Temperature Conversion";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTemperatureC;
        private System.Windows.Forms.Button btnConvertToTemperatureF;
        private System.Windows.Forms.Label lblOutput;
    }
}


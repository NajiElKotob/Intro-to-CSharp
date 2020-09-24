namespace Methods
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
            this.btnVAT11Prct = new System.Windows.Forms.Button();
            this.btnCalcVATTax = new System.Windows.Forms.Button();
            this.btnCalcVATTaxMargin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVAT11Prct
            // 
            this.btnVAT11Prct.Location = new System.Drawing.Point(24, 38);
            this.btnVAT11Prct.Name = "btnVAT11Prct";
            this.btnVAT11Prct.Size = new System.Drawing.Size(198, 23);
            this.btnVAT11Prct.TabIndex = 0;
            this.btnVAT11Prct.Text = "Calc VAT 11%";
            this.btnVAT11Prct.UseVisualStyleBackColor = true;
            this.btnVAT11Prct.Click += new System.EventHandler(this.btnVAT11Prct_Click);
            // 
            // btnCalcVATTax
            // 
            this.btnCalcVATTax.Location = new System.Drawing.Point(24, 78);
            this.btnCalcVATTax.Name = "btnCalcVATTax";
            this.btnCalcVATTax.Size = new System.Drawing.Size(198, 23);
            this.btnCalcVATTax.TabIndex = 1;
            this.btnCalcVATTax.Text = "Calc VAT + Tax";
            this.btnCalcVATTax.UseVisualStyleBackColor = true;
            this.btnCalcVATTax.Click += new System.EventHandler(this.btnCalcVATTax_Click);
            // 
            // btnCalcVATTaxMargin
            // 
            this.btnCalcVATTaxMargin.Location = new System.Drawing.Point(24, 117);
            this.btnCalcVATTaxMargin.Name = "btnCalcVATTaxMargin";
            this.btnCalcVATTaxMargin.Size = new System.Drawing.Size(198, 23);
            this.btnCalcVATTaxMargin.TabIndex = 2;
            this.btnCalcVATTaxMargin.Text = "Calc VAT + Tax + Margin";
            this.btnCalcVATTaxMargin.UseVisualStyleBackColor = true;
            this.btnCalcVATTaxMargin.Click += new System.EventHandler(this.btnCalcVATTaxMargin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Overloading";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 464);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcVATTaxMargin);
            this.Controls.Add(this.btnCalcVATTax);
            this.Controls.Add(this.btnVAT11Prct);
            this.Name = "MainForm";
            this.Text = "Methods";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVAT11Prct;
        private System.Windows.Forms.Button btnCalcVATTax;
        private System.Windows.Forms.Button btnCalcVATTaxMargin;
        private System.Windows.Forms.Label label1;
    }
}


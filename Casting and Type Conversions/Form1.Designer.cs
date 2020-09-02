namespace Casting_and_Type_Conversions
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkConvertWithSymbols = new System.Windows.Forms.CheckBox();
            this.btnParseWithNumberStyle = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnTryParse = new System.Windows.Forms.Button();
            this.btnParse = new System.Windows.Forms.Button();
            this.btnRemoveSpace = new System.Windows.Forms.Button();
            this.btnConvertClass = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkConvertWithSymbols);
            this.groupBox1.Controls.Add(this.btnParseWithNumberStyle);
            this.groupBox1.Controls.Add(this.lblOutput);
            this.groupBox1.Controls.Add(this.btnTryParse);
            this.groupBox1.Controls.Add(this.btnParse);
            this.groupBox1.Controls.Add(this.btnRemoveSpace);
            this.groupBox1.Controls.Add(this.btnConvertClass);
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 409);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convert a String to a Number ";
            // 
            // chkConvertWithSymbols
            // 
            this.chkConvertWithSymbols.AutoSize = true;
            this.chkConvertWithSymbols.Checked = true;
            this.chkConvertWithSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConvertWithSymbols.Location = new System.Drawing.Point(210, 219);
            this.chkConvertWithSymbols.Name = "chkConvertWithSymbols";
            this.chkConvertWithSymbols.Size = new System.Drawing.Size(18, 17);
            this.chkConvertWithSymbols.TabIndex = 4;
            this.chkConvertWithSymbols.UseVisualStyleBackColor = true;
            // 
            // btnParseWithNumberStyle
            // 
            this.btnParseWithNumberStyle.Location = new System.Drawing.Point(7, 205);
            this.btnParseWithNumberStyle.Name = "btnParseWithNumberStyle";
            this.btnParseWithNumberStyle.Size = new System.Drawing.Size(197, 42);
            this.btnParseWithNumberStyle.TabIndex = 3;
            this.btnParseWithNumberStyle.Text = "Parse with NumberStyle";
            this.btnParseWithNumberStyle.UseVisualStyleBackColor = true;
            this.btnParseWithNumberStyle.Click += new System.EventHandler(this.btnParseWithNumberStyle_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(85, 37);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(16, 17);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "0";
            // 
            // btnTryParse
            // 
            this.btnTryParse.Location = new System.Drawing.Point(7, 157);
            this.btnTryParse.Name = "btnTryParse";
            this.btnTryParse.Size = new System.Drawing.Size(197, 42);
            this.btnTryParse.TabIndex = 1;
            this.btnTryParse.Text = "TryParse";
            this.btnTryParse.UseVisualStyleBackColor = true;
            this.btnTryParse.Click += new System.EventHandler(this.btnTryParse_Click);
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(7, 109);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(197, 42);
            this.btnParse.TabIndex = 1;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // btnRemoveSpace
            // 
            this.btnRemoveSpace.Location = new System.Drawing.Point(7, 280);
            this.btnRemoveSpace.Name = "btnRemoveSpace";
            this.btnRemoveSpace.Size = new System.Drawing.Size(197, 42);
            this.btnRemoveSpace.TabIndex = 1;
            this.btnRemoveSpace.Text = "Remove Spaces";
            this.btnRemoveSpace.UseVisualStyleBackColor = true;
            // 
            // btnConvertClass
            // 
            this.btnConvertClass.Location = new System.Drawing.Point(7, 61);
            this.btnConvertClass.Name = "btnConvertClass";
            this.btnConvertClass.Size = new System.Drawing.Size(197, 42);
            this.btnConvertClass.TabIndex = 1;
            this.btnConvertClass.Text = "Convert class methods";
            this.btnConvertClass.UseVisualStyleBackColor = true;
            this.btnConvertClass.Click += new System.EventHandler(this.btnConvertClass_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(7, 33);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(70, 22);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "50";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 433);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Casting and Type Conversions";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkConvertWithSymbols;
        private System.Windows.Forms.Button btnParseWithNumberStyle;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnTryParse;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.Button btnRemoveSpace;
        private System.Windows.Forms.Button btnConvertClass;
        private System.Windows.Forms.TextBox txtInput;
    }
}


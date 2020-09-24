namespace Language_INtegrated_Query
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
            this.btnIEnumerable = new System.Windows.Forms.Button();
            this.lblOutputIEnumrable = new System.Windows.Forms.Label();
            this.btnObject = new System.Windows.Forms.Button();
            this.lblOutputObject = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIEnumerable
            // 
            this.btnIEnumerable.Location = new System.Drawing.Point(23, 23);
            this.btnIEnumerable.Name = "btnIEnumerable";
            this.btnIEnumerable.Size = new System.Drawing.Size(179, 23);
            this.btnIEnumerable.TabIndex = 0;
            this.btnIEnumerable.Text = "IEnumerable";
            this.btnIEnumerable.UseVisualStyleBackColor = true;
            this.btnIEnumerable.Click += new System.EventHandler(this.btnIEnumerable_Click);
            // 
            // lblOutputIEnumrable
            // 
            this.lblOutputIEnumrable.AutoSize = true;
            this.lblOutputIEnumrable.Location = new System.Drawing.Point(234, 28);
            this.lblOutputIEnumrable.Name = "lblOutputIEnumrable";
            this.lblOutputIEnumrable.Size = new System.Drawing.Size(20, 17);
            this.lblOutputIEnumrable.TabIndex = 1;
            this.lblOutputIEnumrable.Text = "...";
            // 
            // btnObject
            // 
            this.btnObject.Location = new System.Drawing.Point(23, 63);
            this.btnObject.Name = "btnObject";
            this.btnObject.Size = new System.Drawing.Size(179, 23);
            this.btnObject.TabIndex = 2;
            this.btnObject.Text = "Object";
            this.btnObject.UseVisualStyleBackColor = true;
            this.btnObject.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // lblOutputObject
            // 
            this.lblOutputObject.AutoSize = true;
            this.lblOutputObject.Location = new System.Drawing.Point(234, 66);
            this.lblOutputObject.Name = "lblOutputObject";
            this.lblOutputObject.Size = new System.Drawing.Size(20, 17);
            this.lblOutputObject.TabIndex = 3;
            this.lblOutputObject.Text = "...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 224);
            this.Controls.Add(this.lblOutputObject);
            this.Controls.Add(this.btnObject);
            this.Controls.Add(this.lblOutputIEnumrable);
            this.Controls.Add(this.btnIEnumerable);
            this.Name = "MainForm";
            this.Text = "LINQ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIEnumerable;
        private System.Windows.Forms.Label lblOutputIEnumrable;
        private System.Windows.Forms.Button btnObject;
        private System.Windows.Forms.Label lblOutputObject;
    }
}


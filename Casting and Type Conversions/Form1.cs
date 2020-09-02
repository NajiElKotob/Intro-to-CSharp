using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casting_and_Type_Conversions
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConvertClass_Click(object sender, EventArgs e)
        {
            //sbyte numtest = txtInput.Text; //Implicit
            //sbyte numtest = (sbyte)txtInput.Text; //Explicit
            //sbyte num = Convert.ToSByte(txtInput.Text);
            //lblOutput1.Text = num.ToString();


            try
            {
                sbyte num = Convert.ToSByte(txtInput.Text);
                lblOutput.Text = num.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Formate Exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
            }
        }
    }
}

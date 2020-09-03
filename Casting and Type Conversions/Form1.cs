using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
                MessageBox.Show($"Format Exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
            }
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            // If the string is not in a valid format, Parse throws an exception 
            sbyte num = sbyte.Parse(txtInput.Text);
            lblOutput.Text = num.ToString();
        }

        private void btnTryParse_Click(object sender, EventArgs e)
        {
            // TryParse returns true if the conversion succeeded 
            // and stores the result in the specified variable. 
            int num;
            bool result = Int32.TryParse(txtInput.Text, out num);
            if (result == true)
                lblOutput.Text = num.ToString();
            else
                lblOutput.Text = "Ooops!";
        }

        private void btnParseWithNumberStyle_Click(object sender, EventArgs e)
        {
            //Source: MCSD Cert. Toolkit / 70-483

            decimal amount;

            if (chkConvertWithSymbols.Checked == false)
            {
                amount = decimal.Parse("$123,456.78");
            }
            else
            {
                amount = decimal.Parse("$123,456.78",
                   NumberStyles.AllowCurrencySymbol |
                   NumberStyles.AllowThousands |
                   NumberStyles.AllowDecimalPoint);

                //amount = decimal.Parse("123,456.78"); // This will work
            }


            MessageBox.Show(this, amount.ToString());
        }

        private void btnRemoveSpace_Click(object sender, EventArgs e)
        {
            // NOT Recommended
            //Conversion.Val https://msdn.microsoft.com/en-us/library/9da280t0%28v=vs.110%29.aspx
            //int num = Convert.ToInt32(Microsoft.VisualBasic.Conversion.Val(txtInput.Text));
            //lblOutput.Text = num.ToString();
            
            //Or
            //IsDigit: Indicates whether the specified Unicode character is categorized as a decimal digit.
            //https://msdn.microsoft.com/en-us/library/System.Char_methods(v=vs.110).aspx
            var formattedNum = new string(txtInput.Text.Where(c => char.IsDigit(c) || c == '.').ToArray());
            lblOutput.Text = formattedNum;

            //Or
            //string unformattedNum = txtInput.Text.Replace(" ", string.Empty);
            //lblOutput.Text = unformattedNum;
        }

        private void lnkHelp1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions");
        }
    }
}

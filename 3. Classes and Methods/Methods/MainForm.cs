using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 

Methods (C# Programming Guide)
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods

Named and Optional Arguments (C# Programming Guide)
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/named-and-optional-arguments

*/

namespace Methods
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnVAT11Prct_Click(object sender, EventArgs e)
        {
            VAT vat = new VAT();
            MessageBox.Show(vat.CalculateVAT(1000m).ToString());
        }

        private void btnCalcVATTax_Click(object sender, EventArgs e)
        {
            VAT vat = new VAT();
            MessageBox.Show(vat.CalculateVAT(1000m, 0.10m).ToString());
        }

        private void btnCalcVATTaxMargin_Click(object sender, EventArgs e)
        {
            VAT vat = new VAT();
            MessageBox.Show(vat.CalculateVAT(1000m, 0.10m, .5m).ToString());
        }

    }


}

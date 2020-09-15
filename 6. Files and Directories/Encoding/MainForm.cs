using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;


namespace Encoding
{
    public partial class MainForm : Form
    {

        /* 
         How to use character encoding classes in .NET
         https://docs.microsoft.com/en-us/dotnet/standard/base-types/character-encoding
        */

        enum EncodeTypes
        {
            ASCII,
            UTF8
        }

        public MainForm()
        {
            InitializeComponent();
        }




        private string Encode(string value, EncodeTypes encodeTypes)
        {
            //٠١٢٣٤٥٦٧٨٩

            string encodedValue;

            switch (encodeTypes)
            {
                case EncodeTypes.ASCII:
                    encodedValue = System.Text.Encoding.ASCII.GetString(System.Text.Encoding.ASCII.GetBytes(value));
                    break;
                case EncodeTypes.UTF8:
                    encodedValue = System.Text.Encoding.UTF8.GetString(System.Text.Encoding.UTF8.GetBytes(value));
                    break;
                default:
                    encodedValue = "NA";
                    break;
            }

            return encodedValue;
        }



        private void btnASCII_Click(object sender, EventArgs e)
        {

            lblOutput.Text = this.Encode(txtInput.Text, EncodeTypes.ASCII);

        }

        private void btnUTF8_Click(object sender, EventArgs e)
        {
            lblOutput.Text = this.Encode(txtInput.Text, EncodeTypes.UTF8);

        }
    }
}

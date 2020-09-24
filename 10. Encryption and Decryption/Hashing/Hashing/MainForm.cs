using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Use Visual C# to compute and compare hash values
https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/compute-hash-values
https://codeshare.co.uk/blog/sha-256-and-sha-512-hash-examples/
*/
namespace Hashing
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

        private void btnHash_Click(object sender, EventArgs e)
        {
            var sha256 = SHA256Managed.Create();
           
            byte[] bytes = Encoding.UTF8.GetBytes(txtSalt.Text + "_" + txtInput.Text);
            byte[] hash = sha256.ComputeHash(bytes);
            lblOutput1.Text = GetStringFromHash(hash);
            lblOutput2.Text = lblOutput1.Text.Length.ToString() + " characters \n\r Note: A SHA256 is always 256 bits long, equivalent to 32 bytes, or 64 bytes in an hexadecimal string format.";
        }

        private static string GetStringFromHash(byte[] hash)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();     
        }

        private void lblOutput1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblOutput1.Text);
        }
    }
}

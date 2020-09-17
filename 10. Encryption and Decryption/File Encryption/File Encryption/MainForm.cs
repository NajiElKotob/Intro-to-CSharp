using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace File_Encryption
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            var content = "Hello C#! (Secret message)";

            var sw = File.CreateText("Hello_CSharp.txt");
            sw.WriteLine(content);
            sw.Close();



        }
    }
}

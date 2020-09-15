using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Files_and_Directories
{
    public partial class MainForm : Form
    {
        private string folder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\";
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //var file = folder + GetTempFile();
            // or
            var file = folder + Utilities.GetTempFile();

            // Open the stream and write to it.
            using (StreamWriter sw = new StreamWriter(file))
            {
                sw.Write(txtInput.Text);
            }
        }


        private string GetTempFile()
        {
            return DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".txt";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Challenge
            //Implement auto refresh https://docs.microsoft.com/en-us/dotnet/api/system.io.filesystemwatcher?view=netcore-3.1

            // Process the list of files found in the directory.
            // https://docs.microsoft.com/en-us/dotnet/api/system.io.directory.getfiles
            string[] fileEntries = Directory.GetFiles(this.folder,"*.txt");


            var i = 0;

            foreach (string fileName in fileEntries)
            {
                i++;
                lstFiles.Items.Add(new ItemList { 
                    DisplayValue = $"{i:00} - {Path.GetFileName(fileName)}", 
                    ObjectValue = fileName
                });
            }
               
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtInput.Text = string.Empty; //or ""
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (lstFiles.SelectedItem != null)
            {
                var fileName = ((ItemList)lstFiles.SelectedItem).ObjectValue.ToString();

                using (StreamReader sr = new StreamReader(fileName))
                {
                    txtInput.Text = sr.ReadToEnd();
                }
            }
        }
    }


}

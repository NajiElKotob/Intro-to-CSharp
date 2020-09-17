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
using System.Windows.Forms.VisualStyles;
using System.Diagnostics;

/*
File.Encrypt(String) Method
Encrypts a file so that only the account used to encrypt the file can decrypt it.
https://docs.microsoft.com/en-us/dotnet/api/system.io.file.encrypt
*/

namespace File_Encryption
{
    public partial class MainForm : Form
    {

        const string fileName = "Hello_CSharp.txt";
        string applicationPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\";

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            var content = "Hello C#! (Secret message)";

            var sw = File.CreateText(fileName);
            sw.WriteLine(content);
            sw.Close();
        }

        // Encrypt a file.
        public static void AddEncryption(string fileName)
        {

            File.Encrypt(fileName);
        }

        // Decrypt a file.
        public static void RemoveEncryption(string fileName)
        {
            File.Decrypt(fileName);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFile(applicationPath + fileName);
        }

        private void OpenFile(string fileName)
        {
            Process.Start("notepad", fileName);
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            AddEncryption(applicationPath + fileName);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            RemoveEncryption(applicationPath + fileName);
        }
    }
}

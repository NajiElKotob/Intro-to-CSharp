using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwaitDEMO
{
    public partial class MainForm : Form
    {

        int startCharCode = 88;
        int endCharCode = 90;

        public MainForm()
        {
            InitializeComponent();
        }


        private List<string> PrepareFilesList()
        {
            List<string> listOfFiles = new List<string>();

            listOfFiles.Add("c:\\file1.pdf");
            listOfFiles.Add("c:\\file2.pdf");
            listOfFiles.Add("c:\\file3.pdf");

            return listOfFiles;
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Sync -----------------");

            Stopwatch stopWatch = new Stopwatch(); //https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.stopwatch?redirectedfrom=MSDN&view=netframework-4.7.2
            stopWatch.Start();

            List<string> files = PrepareFilesList();
            foreach (var file in files)
            {
                listBox1.Items.Add(ScanFile(file));
            }


            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed; // Get the elapsed time as a TimeSpan value.
            listBox1.Items.Add(ts.ToString());
            listBox1.Items.Add("=======================");
        }

        private async void btnAsync_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Async -----------------");

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            List<string> files = PrepareFilesList();
            foreach (var file in files)
            {
                var r = await Task.Run(() => ScanFile(file));
                listBox1.Items.Add(r);
            }

            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;
            listBox1.Items.Add(ts.ToString());
            listBox1.Items.Add("=======================");
        }

        private async void btnParallel_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Parallel -----------------");

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            await RunTasksParallelAsync();

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed; // Get the elapsed time as a TimeSpan value.
            listBox1.Items.Add(ts.ToString());
            listBox1.Items.Add("=======================");
        }


        private async Task RunTasksParallelAsync()
        {
            List<Task<string>> tasks = new List<Task<string>>();


            List<string> files = PrepareFilesList();
            foreach (var file in files)
            {
                tasks.Add(Task.Run(() => ScanFile(file)));
            }


            var results = await Task.WhenAll(tasks);


            foreach (var r in results)
            {
                listBox1.Items.Add(r);
            }
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }


        private string ScanFile(string fileName)
        {
            System.Threading.Thread.Sleep(2000);
            return fileName + " scanned on " + DateTime.Now.ToString();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

    
    }


}

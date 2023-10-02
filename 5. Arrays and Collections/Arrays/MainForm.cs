using System;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace Arrays
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var min = 1;
            var max = 42;

            int r1;
            int r2;
            int r3;
            int r4;
            int r5;
            int r6;


            var r = new Random();
            r1 = r.Next(min, max);
            r2 = r.Next(min, max);
            r3 = r.Next(min, max);
            r4 = r.Next(min, max);
            r5 = r.Next(min, max);
            r6 = r.Next(min, max);


            lblOutput.Text = r1.ToString() + ", " + r2.ToString()
                    + ", " + r3.ToString() + ", " + r4.ToString()
                    + ", " + r5.ToString() + ", " + r6.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            var min = 1;
            var max = 42;

            var r = new Random();

            int[] array = new int[9];

            /*
            for (int i = 0; i < 6; i++) // how to make "6" dynamic.
            {
                array[i] = r.Next(min, max);
            }
            */
   
            for (int i = 0; i < array.Length; i++) // how to make "6" dynamic.
            {
                array[i] = r.Next(min, max);
            }


            // label1.Text = string.Empty;  //string.empty = ""

            lblOutput.Text = string.Empty; // reset
            var randomNumbers = 6;
            for (int i = 0; i < randomNumbers; i++) // how to make "6" dynamic.
            {
                lblOutput.Text += array[i].ToString() + (i < randomNumbers-1? ", ":"");
            }
            return;



            /*
            for (int i = 0; i < array.Length; i++)
            {
                label1.Text += array[i].ToString();

                if(i < array.Length - 1)
                {
                    label1.Text += ", ";
                }    
            }
            */


            //A better way

           lblOutput.Text = string.Join(", ", array);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

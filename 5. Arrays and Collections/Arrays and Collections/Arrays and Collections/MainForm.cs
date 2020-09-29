using System;
using System.Collections;
using System.Windows.Forms;

namespace Arrays_and_Collections
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/single-dimensional-arrays
            // Declare a single-dimensional array  
            int[] array1 = new int[6] { 10, 15, 22, 28, 31, 40 };
            MessageBox.Show(array1.Length.ToString());
            MessageBox.Show(array1[0].ToString());

            var s = string.Empty;
            foreach (var item in array1)
            {
                s += item + " ";
            }

            lblOutput.Text = s;


            return;

            // Declare and set array element values 
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };

            // Alternative syntax 
            int[] array3 = { 1, 2, 3, 4, 5, 6 };

            // Declare a two dimensional array 
            int[,] multiDimensionalArray1 = new int[2, 3];

            // Declare and set array element values 
            int[,] multiDimensionalArray3 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };


            // A jagged array is an array whose elements are arrays. https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/jagged-arrays
            // Declare a jagged array 
            int[][] jaggedArray = new int[6][];

            // Set the values of the first array in the jagged array structure
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Queue Class https://msdn.microsoft.com/en-us/library/system.collections.queue(v=vs.110).aspx
            // Creates and initializes a new Queue.

            System.Collections.Queue queue = new System.Collections.Queue();
            queue.Enqueue("Hello");
            queue.Enqueue("World");
            queue.Enqueue("!");

            // Displays the properties and values of the Queue.
            lblOutput.Text = string.Empty;
            lblOutput.Text += string.Format("Count: {0}", queue.Count);
            lblOutput.Text += (", Values:");

            //foreach (Object obj in myQ)
            //{
            //    lblOutput.Text += string.Format(" {0}", obj);
            //}

            while (queue.Count > 0)
            {
                lblOutput.Text += string.Format(" {0}", queue.Dequeue().ToString());
            }

            

       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Collections.Generic.Queue<string> queue = new System.Collections.Generic.Queue<string>();
            queue.Enqueue("Hello");
            queue.Enqueue("World");
            queue.Enqueue("!");


            // Displays the properties and values of the Queue.
            lblOutput.Text = string.Empty;
            lblOutput.Text += string.Format("Count: {0}", queue.Count);
            lblOutput.Text += (", Values:");

            foreach (string s in queue)
            {
                lblOutput.Text += string.Format(" {0}", s);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Implements the IList interface using an array whose size is dynamically increased as required.
            //https://docs.microsoft.com/en-us/dotnet/api/system.collections.arraylist?view=netframework-4.8

            // Creates and initializes a new ArrayList.
            ArrayList myAL = new ArrayList();
            myAL.Add("Hello");
            myAL.Add("World");
            myAL.Add("!");

            // Displays the properties and values of the ArrayList.
            lblOutput.Text = string.Format("Count: {0}", myAL.Count);
            lblOutput.Text += "\r\n";
            lblOutput.Text += string.Format("Capacity: {0}", myAL.Capacity);
        }



        private void button5_Click(object sender, EventArgs e)
        {
        //Stack Class https://docs.microsoft.com/en-us/dotnet/api/system.collections.stack?view=netcore-3.1

           
            // Creates and initializes a new Stack.
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("!");

            // Displays the properties and values of the Queue.
            lblOutput.Text = string.Empty;
            lblOutput.Text += string.Format("Count: {0}", myStack.Count);
            lblOutput.Text += (", Values:");

            foreach (string s in myStack)
            {
                lblOutput.Text += string.Format(" {0}", s);
            }

        }



        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

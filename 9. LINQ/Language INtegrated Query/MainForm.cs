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
Language Integrated Query (LINQ)
Language-Integrated Query (LINQ) is the name for a set of technologies based on 
the integration of query capabilities directly into the C# language. 
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/



*/
namespace Language_INtegrated_Query
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

        private void btnIEnumerable_Click(object sender, EventArgs e)
        {
            // Language Integrated Query (LINQ) https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/


            /* 
                // Define the query expression.
                // Specify the data source.
                int[] scores = new int[] { 97, 92, 81, 60 };

                // Define the query expression.
                IEnumerable<int> scoreQuery =
                    from score in scores
                    where score > 80
                    select score;

                // Execute the query.
                foreach (int i in scoreQuery)
                {
                    Console.Write(i + " ");
                }
            */

            // Specify the data source.
            var scores = new int[] { 97, 92, 81, 60 };

            var scoreQuery = scores.Where(s => s > 80);
            lblOutputIEnumrable.Text = string.Join(", ", scoreQuery);

            
        }

        private void btnObject_Click(object sender, EventArgs e)
        {

        }
    }
}

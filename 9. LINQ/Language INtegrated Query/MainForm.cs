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
            // Walkthrough: Writing Queries in C# (LINQ) https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/walkthrough-writing-queries-linq

            var studentsCount = StudentManagement.GetStudents().Count().ToString();
            lblOutputObject.Text = $"{studentsCount} students";

            //First or Default
            var firstStudent = StudentManagement.GetStudents().Where(s => s.ID == 111).FirstOrDefault();
            var firstStudentNotExist = StudentManagement.GetStudents().Where(s => s.ID == 000).FirstOrDefault();

            MessageBox.Show(firstStudent.First ?? "Not Found"); //?? https://www.c-sharpcorner.com/blogs/what-is-double-question-mark-operator-in-c-sharp1
            MessageBox.Show($"{firstStudent.First}, {string.Join(", ", firstStudent.Scores)}");
            MessageBox.Show($"{firstStudent.First}, Average: {firstStudent.Scores.Average()}");

           
            MessageBox.Show(firstStudentNotExist?.First ?? "Not Found");

     

            // List
            var studentsWithHighAverage = StudentManagement.GetStudents().
                                Where(s => s.Scores.Average() > 85);

            var studentList1 = "";
            foreach (var student in studentsWithHighAverage)
            {
                studentList1 += $"{student.First}, {student.Scores.Average().ToString()} \r\n";
            }
            MessageBox.Show(studentList1);

            //Update
            var studentsWithUpperCase = StudentManagement.GetStudents().
                    Select(
                            s => { s.First = s.First.ToUpper(); return s; }
                           );

            var studentList2 = "";
            foreach (var student in studentsWithUpperCase)
            {
                studentList2 += $"{student.First} \r\n";
            }
            MessageBox.Show(studentList2);

            // New
            var studentsNew = StudentManagement.GetStudents().
                                      Where(s => s.Scores.Average() > 85).Select(s =>
                                      new
                                      {
                                          FullName = s.First + " " + s.Last,
                                          ScoresAverage = s.Scores.Average()
                                      }
                                      );

            var studentList3 = "";
            foreach (var student in studentsNew)
            {
                studentList3 += $"{student.FullName}, {student.ScoresAverage} \r\n";
            }
            MessageBox.Show(studentList3);

        }

        private void BtnIEnumerable_ContextMenuChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

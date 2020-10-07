using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

/*
Lambda expressions (C# reference)
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions
*/

namespace Anonymous_Lambda_DEMO
{
    public partial class MainForm : Form
    {
       public MainForm()
        {
            InitializeComponent();
        }


        #region AnonymousType   

        private void button1_Click(object sender, EventArgs e)
        {
            var num = new { a = 1, b = 2, c = 3 };
            var num2 = new { a = 1, b = 2, c = 3 }; //1 and 2 are the same
            var num3 = new { a = 1, b = 2, z = 3 }; //1 and 3 diff. name (z)
            var num4 = new { a = 1, b = 2, c = 3, z = 4 }; //1 and 4 diff. count (4)
            var num5 = new { a = 1, b = 2, c = 3.20 }; //1 and 5 diff. data type
            var num6 = new { a = 1, c = 3, b = 2 }; //1 and 6 diff. order


            MessageBox.Show(num.ToString());

            //num.a = 100; //Error: Property or indexer 'AnonymousType#1.a' cannot be assigned to -- it is read only	


            MessageBox.Show("Same (Name, Type, Count and Order): " + num.Equals(num2).ToString()); // same names, types, count, and order
            MessageBox.Show("Different Names: " + num.Equals(num3).ToString()); // Different names
            MessageBox.Show("Different Count: " + num.Equals(num4).ToString()); // Different count
            MessageBox.Show("Different Type: " + num.Equals(num5).ToString()); // Different data type
            MessageBox.Show("Different Order: " + num.Equals(num6).ToString()); // Different order


            //Equals() or GetHashCode() for comparison
            //MessageBox.Show((num.GetHashCode() == num3.GetHashCode()).ToString());
        }
        #endregion

        #region AnonymousMethod



        delegate void AnonymousMethod(int x);

        AnonymousMethod am = delegate (int x)
       {
           MessageBox.Show($"Anonymous Method: {x}");
       };

        private void button2_Click(object sender, EventArgs e)
        {
            am(100);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Results from the anonymous delegate call.
            pt("The delegate using the anonymous method is called.");

            // The delegate instantiation using a named method
            pt = new PrintTextDel(PrintText);

            // Results from the old style delegate call.
            pt("The delegate using the named method is called.");


            pt = new PrintTextDel(PrintText2);

            // Results from the old style delegate call.
            pt("The delegate using the named method is called.");
        }

        // Declare a delegate. 
        delegate void PrintTextDel(string s);

        // Instantiate the delegate type using an anonymous method.
        PrintTextDel pt = delegate (string t)
        {
            MessageBox.Show("Anony method: " + t);
        };

        // The method associated with the named delegate. 
        void PrintText(string t)
        {
            MessageBox.Show("Named method: " + t);
        }


        void PrintText2(string t)
        {
            MessageBox.Show("Named method2: " + t);
        }

        #endregion

        #region LambdaExpression
        class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

        List<Employee> employees = new List<Employee>()
            {
                new Employee{ ID=1, Name = "Tima"},
                new Employee{ ID=2, Name = "Rayan"},
                new Employee{ ID=3, Name = "Aya"},
            };

        //Using method 
        private int empID = 0;


        private void button8_Click(object sender, EventArgs e)
        {
            //Using foreach

            empID = 2;
            Employee myEmployee = null;
            foreach (var emp in employees)
            {

                if (emp.ID == empID)
                {
                    myEmployee = emp;
                    break;
                }
            }
            //          if (myEmployee != null)
            //          {
            //MessageBox.Show(myEmployee.Name);
            //          }else
            //          {
            //              MessageBox.Show("Not Found");
            //          }

            MessageBox.Show(myEmployee?.Name);

            //if (myEmployee != null)
            //{
            //    MessageBox.Show(myEmployee.Name);
            //}
        }


        private void button7_Click(object sender, EventArgs e)
        {
            // Using bool method
            empID = 2;
            Employee myEmployee = employees.Find(SearchByID);
            MessageBox.Show(myEmployee?.Name);
        }

        bool SearchByID(Employee emp)
        {
            if (emp.ID == empID)
                return true;
            else
                return false;
        }


        //Using Predicates 
        private void button6_Click(object sender, EventArgs e)
        {
            Employee myEmployee = employees.Find(ByID(2));
            MessageBox.Show(myEmployee.Name);
        }

        static Predicate<Employee> ByID(int id)
        {
            return delegate (Employee employee)
            {
                return employee.ID == id;
            };
        }



        //Using Delegate 
        private void button5_Click(object sender, EventArgs e)
        {
            int searchForId = 2;
            Employee myEmployee = employees.Find(delegate (Employee emp) { return emp.ID == searchForId; });
            MessageBox.Show(myEmployee?.Name);
        }

        //Using Lambda 
        private void button4_Click(object sender, EventArgs e)
        {
            int searchForId = 2;
           // Employee myEmployee = employees.Find(emp => emp.ID == searchForId);
            Employee myEmployee = employees.Where(emp => emp.ID == searchForId).SingleOrDefault();
            //var emp = employees.Where((em) => emp.ID == searchForId).SingleOrDefault();

            /*
            bool SearchByID(Employee emp)
            {
                if (emp.ID == empID)
                    return true;
                else
                    return false;
            }

            1 line:
            (Employee emp) => if (emp.ID == empID)
                    return true;
                else
                    return false;

            cont'd
            (Employee emp) => emp.ID == empID;
                   
              cont'd
              (emp) => emp.ID == empID;


              cont'd
              emp => emp.ID == empID;

            */





            MessageBox.Show(myEmployee?.Name);
            
        }

       




        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}

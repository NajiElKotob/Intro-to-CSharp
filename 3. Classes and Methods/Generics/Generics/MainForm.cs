using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generics_DEMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Generics
        //https://msdn.microsoft.com/en-us/library/512aeb7t.aspx

        private void button1_Click(object sender, EventArgs e)
        {
            // Use the generic type Test with an int type parameter.
            GenericTest<int> test1 = new GenericTest<int>(10);
            // Call the GetValue method.
            MessageBox.Show(test1.GetValue().ToString());

            // Use the generic type Test with an int type parameter.
            GenericTest<string> test2 = new GenericTest<string>("Num#10");
            // Call the GetValue method.
            MessageBox.Show(test2.GetValue());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NonGenericClass test = new NonGenericClass(10);
            MessageBox.Show(test.GetValue().ToString());

            //Test testString = new Test("Num#10"); //Error: Cannot convert from string to integer
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

           // GenericConstraints<int> gc1 = new GenericConstraints<int>(); //Error: The type 'int' must be a reference type in order to use it as parameter 'T' 
            GenericConstraints<string> gc2 = new GenericConstraints<string>(); 
            GenericConstraints<Person> gc3 = new GenericConstraints<Person>();

            //GenericConstraintsPerson<Person> gc4 = new GenericConstraintsPerson<Person>(); //Error




        }
    }
}

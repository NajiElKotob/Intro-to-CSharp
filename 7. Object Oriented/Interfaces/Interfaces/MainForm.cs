using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnIDisposable_Click(object sender, EventArgs e)
        {

            using (BaseClassIDisposable disposable = new BaseClassIDisposable()){

            }


        }

        private void btnGC_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }

        #region IEnumrable
        private void button1_Click(object sender, EventArgs e)
        {
            //https://msdn.microsoft.com/en-us/library/System.Collections.IEnumerable(v=vs.110).aspx
            Person[] peopleArray = new Person[3]
        {
            new Person("John", "Smith"),
            new Person("Jim", "Johnson"),
            new Person("Sue", "Rabon"),
        };

            People peopleList = new People(peopleArray);

            lblOutput.Text = string.Empty; //Reset

            foreach (Person p in peopleList)
               lblOutput.Text += (p.firstName + " " + p.lastName + "\r\n");
        }


        // Simple business object. 
        public class Person
        {
            public Person(string fName, string lName)
            {
                this.firstName = fName;
                this.lastName = lName;
            }

            public string firstName;
            public string lastName;
        }

        // Collection of Person objects. This class 
        // implements IEnumerable so that it can be used 
        // with ForEach syntax. 
        public class People : IEnumerable
        {
            private Person[] _people;
            public People(Person[] pArray)
            {
                _people = new Person[pArray.Length];

                for (int i = 0; i < pArray.Length; i++)
                {
                    _people[i] = pArray[i];
                }
            }

            // Implementation for the GetEnumerator method.
            IEnumerator IEnumerable.GetEnumerator()
            {
                return (IEnumerator)GetEnumerator();
            }

            public PeopleEnum GetEnumerator()
            {
                return new PeopleEnum(_people);
            }
        }

        // When you implement IEnumerable, you must also implement IEnumerator. 
        public class PeopleEnum : IEnumerator
        {
            public Person[] _people;

            // Enumerators are positioned before the first element 
            // until the first MoveNext() call. 
            int position = -1;

            public PeopleEnum(Person[] list)
            {
                _people = list;
            }

            public bool MoveNext()
            {
                position++;
                return (position < _people.Length);
            }

            public void Reset()
            {
                position = -1;
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public Person Current
            {
                get
                {
                    try
                    {
                        return _people[position];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
        }




        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

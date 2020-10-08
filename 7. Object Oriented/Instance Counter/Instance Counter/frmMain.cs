using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Instance Counter Demo by Naji El Kotob | naji@dotnetheroes.com

namespace InstanceCounter
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10000; i++)
            {
                MyClass ic = new MyClass();
            }
        }
   

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblOutput.Text = MyClass.Counter.ToString();
            lblLastRefresh.Text = "Last Refresh: " + DateTime.Now.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}

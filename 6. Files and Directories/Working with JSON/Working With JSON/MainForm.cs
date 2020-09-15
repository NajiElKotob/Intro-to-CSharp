using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Working_With_JSON
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSample1_Click(object sender, EventArgs e)
        {
            Example1Form example1Form = new Example1Form();
            example1Form.ShowDialog();
        }

        private void btnSample2_Click(object sender, EventArgs e)
        {
            Example2Form example2Form = new Example2Form();
            example2Form.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickMe
{
    public partial class MainForm : Form
    {
        private int maxHeight;
        private int maxWidth;
        private int margin = 15;
        private int count = 0;

        private Random r = new Random();
        private Point p = new Point(0, 0);

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClickMe_MouseEnter(object sender, EventArgs e)
        {

            p.X = r.Next(1, maxWidth);
            p.Y = r.Next(1, maxHeight);
            btnClickMe.Location = p;
            //btnClickMe.BackColor = ...;

            count += 1;
            lblOutput.Text = $"{count.ToString()}";
        }

        private void btnClickMe_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            Reinitialize();


        }

        private void Reinitialize()
        {
            maxHeight = this.ClientSize.Height - btnClickMe.Height - margin;
            maxWidth = this.ClientSize.Width - btnClickMe.Width - margin;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Reinitialize();
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"ClickMe - X:{e.Location.X}, Y:{ e.Location.Y}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AuthorForm authorForm = new AuthorForm();


            //Edit or New
            if (!string.IsNullOrEmpty(txtAuthor.Text.Trim()))
            {
                var tmp = txtAuthor.Text.Trim();
                if (tmp.Substring(tmp.Length - 1,1) == ";")
                {
                    tmp = tmp.Substring(0, tmp.Length - 1);
                }

                var tmpArray = tmp.Split(',');
                authorForm.txtFirstName.Text = tmpArray[1].Trim();
                authorForm.txtLastName.Text = tmpArray[0].Trim();
            }

            if (authorForm.ShowDialog() == DialogResult.OK)
            {
                // MessageBox.Show("Ok");

                txtAuthor.Text = $"{authorForm.txtLastName.Text}, {authorForm.txtFirstName.Text};";           
            }
        }
    }
}

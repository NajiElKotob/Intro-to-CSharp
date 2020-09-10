using Basic_CRUD_with_EF.Data;
using Basic_CRUD_with_EF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_CRUD_with_EF
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

 

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new CrmContext())
            {
                context.Customers.Add(new Model.Customer { Name = txtCustomer.Text.Trim() });
                context.SaveChanges();
                MessageBox.Show("Save successfully!");
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            lstCustomers.Items.Clear();

            using (var context = new CrmContext())
            {
                var customers = context.Customers.ToList();
                foreach (var c in customers)
                {
                    lstCustomers.Items.Add(c);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (lstCustomers.SelectedItem != null)
            {
                using (var context = new CrmContext())
                {
                    var customerId = ((Customer)lstCustomers.SelectedItem).Id;
                    var customer = context.Customers.FirstOrDefault(c => c.Id == customerId);

                    if (customer != null)
                    {
                        context.Customers.Remove(customer);
                        context.SaveChanges();

                        //remove from list
                        lstCustomers.Items.Remove(lstCustomers.SelectedItem);
                    }

                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstCustomers.SelectedItem != null)
            {
                using (var context = new CrmContext())
                {
                    var customerId = ((Customer)lstCustomers.SelectedItem).Id;
                    var customer = context.Customers.FirstOrDefault(c => c.Id == customerId);

                    if (customer != null)
                    {
                        customer.Name = customer.Name + " (Updated)";
                        context.SaveChanges();

                        //refresh
                        btnRead.PerformClick();
                    }

                }
            }
        }
    }
}

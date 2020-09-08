using PizzaWow.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaWow
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] pizzaTypes = { "Pepperoni", "Margherita", "BBQ Chicken" };
            decimal[] pizzaPrices = { 9.5m, 10, 11 };

            for (int i = 0; i < pizzaTypes.Length; i++)
            {
                //Item item = new Item();
                //item.Id = i + 1;
                //item.Name = pizzaTypes[i];
                //item.Price = pizzaPrices[i];
                //or

                var item = new Item { Id = i + 1, Name = pizzaTypes[i], Price = pizzaPrices[i] };
                cboPizza.Items.Add(item);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (cboPizza.SelectedItem == null)
            {
                MessageBox.Show("Please select a Pizza");
                cboPizza.Focus();
                return;
            }

            var o = new Order
            {
                Id = lstOrders.Items.Count + 1,
                Item = cboPizza.SelectedItem as Item,
                Customer = new Customer(),
                OrderDate = DateTime.Now,
                OrderNumber = "",
                Quantity = (int)numQty.Value
            };

            lstOrders.Items.Add(o);
        }

        private void cboPizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = !(cboPizza.SelectedItem == null);
        }
    }
}

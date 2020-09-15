using Newtonsoft.Json;
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
    public partial class Example1Form : Form
    {
        public Example1Form()
        {
            InitializeComponent();
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = "Apple";
            product.Expiry = new DateTime(2008, 12, 28);
            product.Sizes = new string[] { "Small" , "Medium" };

            string json = JsonConvert.SerializeObject(product);

            MessageBox.Show(json);
            //{
            //    "Name": "Apple",
            //   "Expiry": "2008-12-28T00:00:00",
            //   "Sizes": [
            //     "Small"
            //   ]
            // }
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            string json = @"{
                'Name': 'Orange',
               'Expiry': '2008-12-28T00:00:00',
               'Sizes': [
                 'Small'
               ]
             }";

            Product p = JsonConvert.DeserializeObject<Product>(json);
            p.Name = "Pineapple";

            MessageBox.Show(p.Name);
        }
    }

    class Product
    {
        public string Name { get; set; }
        public DateTime Expiry { get; set; }
        public string[] Sizes { get; set; }
    }

}

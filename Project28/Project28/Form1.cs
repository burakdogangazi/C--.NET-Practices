using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project28
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ListProducts();
        }

        private void ListProducts()
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                dgwProduct.DataSource = northwindContext.Products.ToList();
                //Dbset içine gider dbset product döner product özellikleri de entities de bellidir.
            }
        }

        private void lnklblHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("You are directing to microsoft support hold on a second.");
            Thread.Sleep(2000);
            System.Diagnostics.Process.Start("https://support.microsoft.com/");
        }

        private void ListProductsByProductName(string key)
        {

            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                dgwProduct.DataSource = northwindContext.Products.Where(p => p.ProductName.ToLower().Contains(key.ToLower())).ToList();
                //Dbset içine gider dbset product döner product özellikleri de entities de bellidir.
            }


        }

        private void tbxSearchProduct_TextChanged(object sender, EventArgs e)
        {
            string key = tbxSearchProduct.Text;
            
            if (string.IsNullOrEmpty(key))
            {
                ListProducts();

            }

            else
            {
                ListProductsByProductName(key);
            }


            

        }
    }
}

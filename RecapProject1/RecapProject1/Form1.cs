using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {// garbage colletor beklemeden silmede kullanılır performans amaçlı

            ListCategories();
            ListProducts();

        }

        private void ListProducts()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.ToList();
            }
        }
        private void ListCategories()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                cbxCategory.DataSource = context.Categories.ToList();
                cbxCategory.DisplayMember = "CategoryName";// Category Name göster ama
                cbxCategory.ValueMember = "CategoryId";// kullanıcı seçerken filtreleme işlemini ıdye göre yap
            }
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {// eleman eklenirken ilkte değer bulunamıyor form yüklenince
            try
            {
                ListProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {

               
            }
            
            
            
           
        }

        private void ListProductsByCategory(int categoryId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.Where(p => p.CategoryId == categoryId).ToList();
            }

        }
        private void ListProductsByProductName(string key)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.Where(p => p.ProductName.ToLower().Contains(key.ToLower())).ToList();
            }

        }
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string key = tbxSearch.Text;
            if (string.IsNullOrEmpty(key))
            {
                ListProducts();
            }

            else
            {
                ListProductsByProductName(tbxSearch.Text);
            }
           
        }
    }
}

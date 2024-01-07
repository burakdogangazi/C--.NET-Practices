using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
        }
        IProductService _productService;
        private void Form2_Load(object sender, EventArgs e)
        {
            //ProductManager productManager = new ProductManager(new EfProductDal());
           
            dgwProduct.DataSource = _productService.GetAll();
        }
    }
}

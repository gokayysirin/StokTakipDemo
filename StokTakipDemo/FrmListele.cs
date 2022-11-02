using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipDemo
{
    public partial class FrmListele : Form
    {
        public FrmListele()
        {
            InitializeComponent();
        }
        ProductDal _productDal=new ProductDal();
        private void FrmListele_Load(object sender, EventArgs e)
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }
        private void SearchProducts(string key)
        {
            var result = _productDal.GetbyName(key);
            dgwProducts.DataSource = result;
        }

        private void tbxSearchbyCode_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearchbyName.Text);
        }
    }
}

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
    public partial class FrmSil : Form
    {
        ProductDal _productDal = new ProductDal();
        public FrmSil()
        {
            InitializeComponent();
        }

        private void FrmSil_Load(object sender, EventArgs e)
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }


        private void SearchProducts(string key)
        {
            var result = _productDal.GetbyName(key);
            dgwProducts.DataSource = result;
        }

        private void tbxSearchbyName_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearchbyName.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                UrunKodu = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });
            dgwProducts.DataSource = _productDal.GetAll();
        }
    }
}

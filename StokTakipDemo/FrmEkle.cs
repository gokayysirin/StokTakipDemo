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
    public partial class FrmEkle : Form
    {
        public FrmEkle()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                
                UrunAdi = tbxName.Text,
                UrunSayisi = Convert.ToInt32(tbxStock.Text)
            });
            MessageBox.Show("Ürün Eklendi!");
        }
    }
}

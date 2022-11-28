using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Bu form ekranı ürünleri listele özelliği için yapılmıştır. Datayı sqlden çeker ve kullanıcıya datagridview üzerinden gösterir.Kullanıcı ürünadı üzerinden arama yapabilir.
/*
 * 
 *      |------------------------------|
 *      |       GÖKAY ŞİRİN-2022       |
 *      |       | @gokayysirin |       |   
 *      |                              |
 *      |------------------------------|
 *      
 *                                               */
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
        }//form yüklendiğinde tabloya veriyi çeker.
        private void SearchProducts(string key)
        {
            var result = _productDal.GetbyName(key);
            dgwProducts.DataSource = result;
        }//ürünler içinde ilgili harf/kelimenin geçtiği ürünleri arar

        private void tbxSearchbyCode_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearchbyName.Text);
        }//textbox değiştikçe searchproducts fonksiyonuna girdi yapar.
    }
}

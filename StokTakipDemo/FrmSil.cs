using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Bu form ekranı Ürün Silme işlemi için yapılmıştır. Kullanıcıdan sileceği ürünü tablodan seçmesini ister. Butona basıldığında siler. Harf ile arama özelliği barınıdırır.
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
        } //form yüklendiğinde verileri data grid view'a aktarır.


        private void SearchProducts(string key)
        {
            var result = _productDal.GetbyName(key);
            dgwProducts.DataSource = result;
        } //Harflerle ile ürün arama fonksiyonu

        private void tbxSearchbyName_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearchbyName.Text);
        }//Textbox içeriği değiştikçe SearchProducts fonksiyonunu çalıştırır.

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                UrunKodu = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });
            dgwProducts.DataSource = _productDal.GetAll();
        }//Ürün kodu üzerinden silme işlemi yapar.
    }
}

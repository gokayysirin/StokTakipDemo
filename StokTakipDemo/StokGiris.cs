using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Bu form ekranı Stok Giriş için yapılmıştır. Kullanıcı tablodan ürünü seçer, stok artırım miktarı yazar.
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
    public partial class StokGiris : Form
    {
        public StokGiris()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();

        private void btnStokArtir_Click(object sender, EventArgs e)
        {
            //stok miktarı yerine rakamlar hariç karakter girilmesini önler. 
            try
            {
                _productDal.Update(new Product
                {
                    UrunKodu = Convert.ToInt32(tbxUrunKodu.Text),
                    UrunAdi = dgwProducts.CurrentRow.Cells[1].Value.ToString(),
                    UrunSayisi = Convert.ToInt32(tbxEklenecekStok.Text) + Convert.ToInt32(dgwProducts.CurrentRow.Cells[2].Value)
                });
                dgwProducts.DataSource = _productDal.GetAll();
            }
            catch (Exception)
            {
                MessageBox.Show("Stok ekleme sayfasında stok değişim miktarı özel karakter veya harf içeremez. Değeri kontrol edin ve tekrar deneyin.","Değer hatası!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }//Tıklandığında eklenmek istenen stok ile mevcut stoğu toplar ve kaydeder.

        private void StokGiris_Load(object sender, EventArgs e)
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }//tablonun otomatik yüklenmesi için 

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            tbxUrunKodu.Text = dgwProducts.CurrentRow.Cells[0].Value.ToString();
        }//tablodan ürün seçimi için kullanılır. 
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Bu form ekranı Stok Çıkış için yapılmıştır. Kullanıcı tablodan ürünü seçer, stok azaltım miktarı yazar.
 *Stok miktarı negatif olamaz. Dolayısıyla program (mevcut stok-çıkarılacak stok)>=0 şartını sağlamazsa hata verir.*/
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
    public partial class StokAzalt : Form
    {
        ProductDal _productDal = new ProductDal();
        public StokAzalt()
        {
            InitializeComponent();
        }

        private void StokAzalt_Load(object sender, EventArgs e)
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }//form açıldığında tabloya verileri çeker.

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUrunKodu.Text = dgwProducts.CurrentRow.Cells[0].Value.ToString();
        }//tablodan seçim yapıldığında ürünkodu değerini ilgili textbox'a çeker.

        private void btnStokAzalt_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(dgwProducts.CurrentRow.Cells[2].Value) - Convert.ToInt32(tbxCikisStok.Text) > 0) {//yeni stok negatif olamaz.
                    _productDal.Update(new Product
                    {
                        UrunKodu = Convert.ToInt32(tbxUrunKodu.Text),
                        UrunAdi = dgwProducts.CurrentRow.Cells[1].Value.ToString(),
                        UrunSayisi = Convert.ToInt32(dgwProducts.CurrentRow.Cells[2].Value) - Convert.ToInt32(tbxCikisStok.Text)
                    });
                    dgwProducts.DataSource = _productDal.GetAll();
                }
                else
                {
                    MessageBox.Show("Ürün Sayısı Sıfırdan Az Olamaz. Lütfen Ürün Sayısı Değerlerini Kontrol Edin", "Değer hatası!", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                }
            }
            catch (Exception)
            {
                //çıkarılacak stok kısmına sayısal olmayan değerler girilemez.
                MessageBox.Show("Stok çıkış sayfasında stok değişim miktarı özel karakter veya harf içeremez. Değeri kontrol edin ve tekrar deneyin.", "Değer hatası!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

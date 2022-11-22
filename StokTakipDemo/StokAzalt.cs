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
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUrunKodu.Text = dgwProducts.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnStokAzalt_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(dgwProducts.CurrentRow.Cells[2].Value) - Convert.ToInt32(tbxCikisStok.Text) > 0) {
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
                MessageBox.Show("Stok çıkış sayfasında stok değişim miktarı özel karakter veya harf içeremez. Değeri kontrol edin ve tekrar deneyin.", "Değer hatası!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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
            try
            {
                if (Convert.ToInt32(tbxStock.Text) > 0)
                {
                    _productDal.Add(new Product
                    {

                        UrunAdi = tbxName.Text,
                        UrunSayisi = Convert.ToInt32(tbxStock.Text)
                    });
                    MessageBox.Show("Ürün Eklendi!");
                }
                else
                {
                    MessageBox.Show("Ürün Sayısı Sıfırdan Az Olamaz. Lütfen Ürün Sayısı Değerlerini Kontrol Edin", "Değer hatası!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ürün Adı ve Ürün Sayısı Boş Bırakılamaz. Ürün Sayısı Harf ve Özel Karakter İçeremez!", "Değer hatası!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}

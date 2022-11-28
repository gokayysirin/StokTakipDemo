using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Bu form ekranı Ürün Düzenle işlemi için yapılmıştır. Değiştirilecek ürün tablodan seçilir, değerler textboxlara yansır. Kullanıcı istediği değerleri değiştirir.
 *Butona tıkladığında ürün güncellenir. Ürün Sayısının ve Ürün Adının boş bırakılmasına izin verilmez. Ürün sayısı negatif olamaz. 
 *Ürün sayısına sadece pozitif sayısal değerler girilebilir.*/
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
    public partial class FrmDuzenle : Form
    {
        public FrmDuzenle()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void FrmDuzenle_Load(object sender, EventArgs e)
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }//form açıldığında değerler tabloya otomatik yüklenir. 

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try//ürün adı ve sayısı boş bırakılamaz. Ürün sayısına sadece pozitif sayısal değerler girilebilir.
            {
                if (Convert.ToInt32(tbxStock.Text) >= 0) { //ürün sayısı negatif olamaz
                    _productDal.Update(new Product
                    {
                        UrunAdi = tbxName.Text,
                        UrunKodu = Convert.ToInt32(tbxCode.Text),
                        UrunSayisi = Convert.ToInt32(tbxStock.Text)
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
                MessageBox.Show("Ürün Adı ve Ürün Sayısı Boş Bırakılamaz. Ürün Sayısı Harf ve Özel Karakter İçeremez!", "Değer hatası!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        } //Düzenleme işlemini tamamlar.

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxName.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxStock.Text= dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxCode.Text= dgwProducts.CurrentRow.Cells[0].Value.ToString();
        }//tabloda hangi ürüne tıklanırsa o ürünün verileri textboxlara çağırır.

        
    }
}

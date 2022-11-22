using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

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
            
        }

        private void StokGiris_Load(object sender, EventArgs e)
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            tbxUrunKodu.Text = dgwProducts.CurrentRow.Cells[0].Value.ToString();
        }
    }
}

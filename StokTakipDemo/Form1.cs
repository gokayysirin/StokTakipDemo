/*
 * Bu program bir sanayi dükkanýnýn gerekli stok takip iþlemlerini yapabilmesi için yazýlmýþtýr. Visual Studio üzerinden yazýlmýþ olup .NET(6.0) sürümündedir.
 * Entity Framework kullanýlmýþtýr. SQLServer ile veri iþlemleri yapýlmýþtýr. 1 ana ekran ve 6 yan ekran içerir. */
/*
 * 
 *      |------------------------------|
 *      |       GÖKAY ÞÝRÝN-2022       |
 *      |       | @gokayysirin |       |   
 *      |                              |
 *      |------------------------------|
 *      
 *                                               */
namespace StokTakipDemo
{
    public partial class FrmAnaEkran : Form
    {
        public FrmAnaEkran()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            FrmListele frmListele = new FrmListele();
            frmListele.Show();
        }//ürünleri listele sayfasý

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmEkle frmEkle = new FrmEkle();
            frmEkle.Show();
        }//ürün ekle sayfasý

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmDuzenle frmDuzenle = new FrmDuzenle();
            frmDuzenle.Show();
        }//ürün düzenle sayfasý

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FrmSil frmSil = new FrmSil();
            frmSil.Show();
        }//ürün sil sayfasý

        private void btnStockUp_Click(object sender, EventArgs e)
        {
            StokGiris stokGiris = new StokGiris();
            stokGiris.Show();
        }//stok giriþ sayfasý

        private void btnStockDown_Click(object sender, EventArgs e)
        {
            StokAzalt stokAzalt = new StokAzalt();
            stokAzalt.Show();
        }//stok çýkýþ sayfasý

        private void FrmAnaEkran_Load(object sender, EventArgs e)
        {

        }
    }
}
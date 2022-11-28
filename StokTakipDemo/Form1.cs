/*
 * Bu program bir sanayi d�kkan�n�n gerekli stok takip i�lemlerini yapabilmesi i�in yaz�lm��t�r. Visual Studio �zerinden yaz�lm�� olup .NET(6.0) s�r�m�ndedir.
 * Entity Framework kullan�lm��t�r. SQLServer ile veri i�lemleri yap�lm��t�r. 1 ana ekran ve 6 yan ekran i�erir. */
/*
 * 
 *      |------------------------------|
 *      |       G�KAY ��R�N-2022       |
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
        }//�r�nleri listele sayfas�

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmEkle frmEkle = new FrmEkle();
            frmEkle.Show();
        }//�r�n ekle sayfas�

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmDuzenle frmDuzenle = new FrmDuzenle();
            frmDuzenle.Show();
        }//�r�n d�zenle sayfas�

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FrmSil frmSil = new FrmSil();
            frmSil.Show();
        }//�r�n sil sayfas�

        private void btnStockUp_Click(object sender, EventArgs e)
        {
            StokGiris stokGiris = new StokGiris();
            stokGiris.Show();
        }//stok giri� sayfas�

        private void btnStockDown_Click(object sender, EventArgs e)
        {
            StokAzalt stokAzalt = new StokAzalt();
            stokAzalt.Show();
        }//stok ��k�� sayfas�

        private void FrmAnaEkran_Load(object sender, EventArgs e)
        {

        }
    }
}
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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmEkle frmEkle = new FrmEkle();
            frmEkle.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmDuzenle frmDuzenle = new FrmDuzenle();
            frmDuzenle.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FrmSil frmSil = new FrmSil();
            frmSil.Show();
        }

        private void btnStockUp_Click(object sender, EventArgs e)
        {
            StokGiris stokGiris = new StokGiris();
            stokGiris.Show();
        }

        private void btnStockDown_Click(object sender, EventArgs e)
        {
            StokAzalt stokAzalt = new StokAzalt();
            stokAzalt.Show();
        }
    }
}
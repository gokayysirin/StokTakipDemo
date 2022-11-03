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
    }
}
namespace StokTakipDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            FrmListele frmListele = new FrmListele();
            frmListele.Show();
        }
    }
}
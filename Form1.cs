namespace materi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            lblData.Visible = true;
            lblData.Text = "No. Pendaftaran : " + txtPendaftaran.Text +
            "\nNama Lengkap : " + txtNamaLengkap.Text +
            "\nAlamat : " + txtAlamat.Text +
            "\nNoHp : " + txtHP.Text +
            "\nTanggal lahir : " + cbTanggal.Text + " " + cbBulan.Text + " " + cbTahun.Text + " " +
            "\nTempat Lahir : " + txtTempatlahir.Text +
            "\nEmail : " + txtEmail.Text;
          
        }

        private void txtHP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
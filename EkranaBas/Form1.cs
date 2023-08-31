namespace EkranaBas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            MessageBox.Show("Hoþ Geldiniz " + ad + " " + soyad, "Bilgilendirme Mesajý", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            comboBox1.Items.Add(ad);
            comboBox1.Items.Add(soyad);

        }
    }
}
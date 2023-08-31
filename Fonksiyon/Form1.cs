namespace Fonksiyon
{
    public partial class Form1 : Form
    {
        public string sonuc;
        public void textBoxTemizle()
        {
            textBox9.Clear();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            sonuc = (Convert.ToInt16(textBox1.Text) + Convert.ToInt16(textBox2.Text)).ToString();
            textBox9.Text = sonuc;
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            textBoxTemizle();
            sonuc = (Convert.ToInt16(textBox3.Text) - Convert.ToInt16(textBox4.Text)).ToString();
            textBox9.Text = sonuc;
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            textBoxTemizle();
            sonuc = (Convert.ToInt16(textBox5.Text) * Convert.ToInt16(textBox6.Text)).ToString();
            textBox9.Text = sonuc;
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            textBoxTemizle();
            sonuc = (Convert.ToInt16(textBox7.Text) / Convert.ToInt16(textBox8.Text)).ToString();
            textBox9.Text = sonuc;
        }
    }
}
namespace SınavNotuHesaplaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bgtnHesapla_Click(object sender, EventArgs e)
        {
           
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            int vize = Int32.Parse(textBox3.Text);
            int final = Int32.Parse(textBox4.Text);
            double sonuc = vize * 0.4 + final * 0.6;
            label6.Visible = true;
            label6.Text = "Sayın " + ad + soyad + " hesaplanan notunuz: " + sonuc.ToString();
            if(sonuc > 50 )
            {
                MessageBox.Show("Tebrikler geçtiniz!","Geçme Durumunuz",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Maalesef kaldınız");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Visible = false;
        }
    }
}
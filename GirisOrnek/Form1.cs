namespace GirisOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) > 1 || int.Parse(textBox1.Text) > 100)
            {
                errorProvider1.SetError(textBox1, "1 ile 100 aras�nda say� giriniz");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string metin = textBox2.Text;
            if(metin.Length > 10)
            {
                errorProvider1.SetError(textBox2, "Girdi�iniz metin 10 karakterden uzundur!!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
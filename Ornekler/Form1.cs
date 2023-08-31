using System.Xml;

namespace Ornekler
{
    public partial class Form1 : Form
    {
        string havaDurumu_Link = "https://www.mgm.gov.tr/FTPDATA/analiz/sonSOA.xml";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHavaDurumuGoster_Click(object sender, EventArgs e)
        {
            XmlDocument doc1 = new XmlDocument();
            doc1.Load(havaDurumu_Link);
            XmlElement root = doc1.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("sehirler");

            foreach (XmlNode node in nodes)
            {
                string il = node["ili"].InnerText;
                string durum = node["Durum"].InnerText;
                string mak_sicaklik = node["Mak"].InnerText;

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = il;
                row.Cells[1].Value = durum;
                row.Cells[2].Value = mak_sicaklik;
                dataGridView1.Rows.Add(row);
            }
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            DataGridView dtg = new DataGridView();
            dtg = dataGridView1;
            textBox1.Text = dtg.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dtg.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dtg.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
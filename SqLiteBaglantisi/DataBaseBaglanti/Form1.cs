using System.Data;
using System.Data.SQLite;
namespace DataBaseBaglanti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SQLiteConnection conn;

        public void listele()
        {
            conn = new SQLiteConnection("Data source = Veriler.db");
            conn.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM Ogrenci", conn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "info");
            dataGridView1.DataSource = dataSet.Tables[0];
            conn.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }
    }
}
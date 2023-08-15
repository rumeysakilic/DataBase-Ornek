using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
namespace SqLiteBaglantisi
{
    public partial class Form1 : Form
    {
        string path = "DataBase.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\Veriler.db";

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }
        //show data in table
        private void listele()
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM Ogrenci";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Insert(0, dr.GetString(0), dr.GetString(1),dr.GetString(2),dr.GetString(3));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }
    }
}
using System.Data.SQLite;

namespace VeriTabanıUygulaması
{
    public partial class Form1 : Form
    {
        string path = "DataBase.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\DataBase.db";

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }
        //show data in table
        private void DataShow()
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM test";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Insert(0, dr.GetString(0), dr.GetString(1));
            }
        }
        //create database and table
        private void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
                {
                    sqlite.Open();
                    string sql = "CREATE TABLE test (name varchar(20),id varchar(12))";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                Console.WriteLine("DataBase cannot create!!");
                return;
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "INSERT INTO test(name,id) VALUES(@name,@id)";

                string NAME = txtName.Text;
                string ID = txtId.Text;

                cmd.Parameters.AddWithValue("@name", NAME);
                cmd.Parameters.AddWithValue("@id", ID);

                dataGridView1.ColumnCount = 2;
                dataGridView1.Columns[0].Name = "Name";
                dataGridView1.Columns[1].Name = "Id";
                string[] row = new string[] { NAME, ID };
                dataGridView1.Rows.Add(row);

                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                Console.WriteLine("Cannot insert data");
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "UPDATE test SET id=@Id where name=@Name";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Id", txtId.Text);

                cmd.ExecuteNonQuery();
                dataGridView1.Rows.Clear();
                DataShow();
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot update data");
                return;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(con);

            try
            { 
                cmd.CommandText = "DELETE FROM test where name = @Name";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Name", txtName);
                cmd.ExecuteNonQuery();
                dataGridView1.Rows.Clear();
                DataShow();
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot delete data");
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value !=null)
            {
                dataGridView1.CurrentRow.Selected = true;
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                txtId.Text = dataGridView1.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                txtId.Text = dataGridView1.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Create_db();
            DataShow();
        }
    }
}
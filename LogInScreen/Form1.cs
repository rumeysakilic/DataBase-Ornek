using System.Data;
using System.Data.SQLite;
namespace LogInScreen
{
    public partial class Form1 : Form
    {
        SQLiteConnection conn;
        SQLiteDataReader dr;
        SQLiteCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text;
            string password = txtPassword.Text;

            conn = new SQLiteConnection("Data source = User.db");
            cmd = new SQLiteCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM UserInfo WHERE userName = '"+txtUser.Text+ "'and password ='" +txtPassword.Text+"'";
            dr = cmd.ExecuteReader();

            if(dr.Read())
            {
                MessageBox.Show("Login is succsesfull!!");
                Form2 form2 = new Form2();
                form2.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login is incorrect!!");
            }
            conn.Close();
        }
    }
}
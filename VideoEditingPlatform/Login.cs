using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoEditingPlatform
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbcheck();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        public int getIdUser(string nom)
        {
            string cs = @"server=localhost;userid=root;password=;database=videoeditingplatform";
            var con = new MySqlConnection(cs);
            con.Open();
            string stm = "select id from users WHERE username=@Name ";
            var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@Name", nom);
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int idUser = reader.GetInt32("id");

                return idUser;
            }
            else
            {
                return 0;
            }
                
        }
        public void dbcheck()
        {
            string cs = @"server=localhost;userid=root;password=;database=videoeditingplatform";
            var con = new MySqlConnection(cs);
            try
            {
               
                con.Open();
                string stm = "select id,username,password,privieliges,delay from users WHERE username =@Name AND password =@Password; ";
                var cmd = new MySqlCommand(stm, con);
                cmd.Parameters.AddWithValue("@Name", userLogin.Text);
                cmd.Parameters.AddWithValue("@Password", passLogin.Text);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Int32 idUser = reader.GetInt32("id");
                    String username = reader.GetString("username");
                    Int32 delay = reader.GetInt32("delay");
                    Boolean priv = reader.GetBoolean("privieliges");
                    Users.idUser = idUser;
                    Users.username = username;
                    Users.delay = delay;
                    Users.priv = priv;
                    if (priv == false)
                    {
                        HomeT homeT = new HomeT();
                        this.Hide();
                        homeT.Show();
                        
                    }
                    else
                    {
                        HomeA homea = new HomeA();
                        this.Hide();
                        homea.Show();
                    }

                }
               else
                {
                    MessageBox.Show("Authentication failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            con.Close();
        }

        
    }
}

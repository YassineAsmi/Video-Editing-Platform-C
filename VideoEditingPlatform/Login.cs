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
        public void dbcheck()
        {
            string cs = @"server=localhost;userid=root;password=;database=videoeditingplatform";
            var con = new MySqlConnection(cs);
            try
            {
               
                con.Open();
                string stm = "select username,password from users WHERE username =@Name AND password =@Password";
                var cmd = new MySqlCommand(stm, con);

                cmd.Parameters.AddWithValue("@Name", userLogin.Text);
                cmd.Parameters.AddWithValue("@Password", passLogin.Text);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    pageRedirect();
                }
               else
                {
                    Console.WriteLine("unknow info");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("login failed");
            }
            con.Close();
        }
        public void pageRedirect()
        {
            HomeT homeT = new HomeT();
            if (homeT == null)
            {
                homeT.Parent = this;
            }
            else
            {
                homeT.Show();
                this.Hide();
            }
        }
    }
}

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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)

        {
            string cs = @"server=localhost;userid=root;password=;database=videoeditingplatform";
            var con = new MySqlConnection(cs);
            var con2 = new MySqlConnection(cs);
            if (txtUsername.Text == "" && txtemail.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            con.Open();
            string stm = "select email from users WHERE email = @email";
            var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@email", txtemail.Text);
            var reader = cmd.ExecuteReader();
            
            if (reader.Read())
            {
                MessageBox.Show("Account Already exist", "Registration UnSuccessfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            else
            {
                con2.Open();
                string register = "INSERT INTO users (username,email,password) VALUES (@username,@email,@Password)";
                var cmd2 = new MySqlCommand(register, con2);

                cmd2.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd2.Parameters.AddWithValue("@email", txtemail.Text);
                cmd2.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd2.ExecuteNonQuery();
                con2.Close();

                HomeT homeT = new HomeT();
                this.Hide();
                homeT.Show();

                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Users.priv)
            {
                HomeA homea = new HomeA();
                this.Hide();
                homea.Show();
            }
            else
            {
                HomeT homeT = new HomeT();
                this.Hide();
                homeT.Show();

            }
        }
    }



}


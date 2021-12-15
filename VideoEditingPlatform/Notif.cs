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
    public partial class Notif : Form
    {
        public Notif()
        {
            InitializeComponent();
        }

        private void Notif_Load(object sender, EventArgs e)
        {

        }
        public void DoNotif()
        {
            string today = DateTime.Today.Day.ToString();
            string cs = @"server=localhost;userid=root;password=;database=videoeditingplatform";
            var con = new MySqlConnection(cs);
            con.Open();
            string register = "Select delay, nomVideo, dateTravail From videos, users where videos.idUser = users.id ";
            var cmd = new MySqlCommand(register, con);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string deadline = reader.GetString("dateTravail");
                string nom = reader.GetString("nomVideo");
                int del = reader.GetInt32("delay");
                string ldd = deadline.Substring(deadline.Length - 2);
                int lddI = Int32.Parse(ldd);
                int datenotif = Int32.Parse(today) - del;
                if(datenotif == lddI)
                {
                    MessageBox.Show("DeadLine Notification Alert for :"+nom+" End on :"+ldd, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            HomeT homeT = new HomeT();
            this.Hide();
            homeT.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string cs = @"server=localhost;userid=root;password=;database=videoeditingplatform";
            var con2 = new MySqlConnection(cs);
            con2.Open();
            string register = "UPDATE users SET delay=@delay  where id = @idUser";
            var cmd2 = new MySqlCommand(register, con2);
            Console.WriteLine("User delay :"+Users.delay);
            cmd2.Parameters.Add("@delay", MySqlDbType.Int32).Value = Int32.Parse(Delay.Text);
            Console.WriteLine("User delay :", Users.delay);
            cmd2.Parameters.Add("@idUser", MySqlDbType.Int32).Value = Users.idUser;
            Console.WriteLine("User delay :"+ Users.idUser);
            try
            {
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Delay updated succecfully", "Notification Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Delay not updated"+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con2.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Videos video =  new Videos();
            this.Hide();
            video.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            this.Hide();
            clients.Show();
        }

        private void OnClickLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
            Users.idUser = 0;
            Users.username = "";
            Users.delay = 0;
        }

        private void gradientColor1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

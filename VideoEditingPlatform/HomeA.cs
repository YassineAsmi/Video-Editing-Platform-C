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
    public partial class HomeA : Form
    {
        public HomeA()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            this.Hide(); ;
            clients.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Videos videos = new Videos();
            this.Hide();
            videos.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Notif notif = new Notif();
            this.Hide();
            notif.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
            Users.idUser = 0;
            Users.username = "";
            Users.delay = 0;
        }
    }
}

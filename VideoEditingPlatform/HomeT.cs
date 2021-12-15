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
    public partial class HomeT : Form
    {
        public HomeT()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeT_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
            Users.idUser = 0;
            Users.username = "";
            Users.delay = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Notif notif = new Notif();
            this.Hide();
            notif.Show();
        }

        private void HomeT_Shown(object sender, EventArgs e)
        {
            Notif notif = new Notif();
            notif.DoNotif();
        }
    }
}

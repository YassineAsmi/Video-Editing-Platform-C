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
    public partial class Videos : Form
    {
        AddVideo addvideo;
        
        public Videos()
        {
            InitializeComponent();
            addvideo = new AddVideo(this);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            this.Hide();
        }
        public void DisplayVideo()
        {
            DBClient.DisplayAndSearch("Select idVideo,NomPrenom,nomVideo,dateTravail,Musique,Status From videos,clients where clients.idClient=videos.idClient;", dataGridViewVideos);
        }
        private void OnClickAdd_Click(object sender, EventArgs e)
        {
            addvideo.ShowDialog();
        }

        private void Videos_Shown(object sender, EventArgs e)
        {
            DisplayVideo();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DBVideo.DisplayAndSearch("Select idVideo, NomPrenom, nomVideo, dateTravail, Musique, Status From videos, clients where clients.idClient = videos.idClient and NomPrenom LIKE '%" + SearchVideo.Text + "%'", dataGridViewVideos);

        }

        private void dataGridViewVideos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewVideos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //Edit button message box
                EditVideo eV = new EditVideo(this);
                eV.idVideo = dataGridViewVideos.Rows[e.RowIndex].Cells[2].Value.ToString();
                eV.nomVideo = dataGridViewVideos.Rows[e.RowIndex].Cells[4].Value.ToString();
                eV.dateTravail = dataGridViewVideos.Rows[e.RowIndex].Cells[5].Value.ToString();
                eV.Musique = dataGridViewVideos.Rows[e.RowIndex].Cells[6].Value.ToString();
                eV.Status = (bool)dataGridViewVideos.Rows[e.RowIndex].Cells[7].Value;
                eV.UpdateInfo();
                eV.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                //Delete button message box
                if (MessageBox.Show("Are you sure you want to delete this video?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DBVideo.DeleteVideo(dataGridViewVideos.Rows[e.RowIndex].Cells[2].Value.ToString());
                    DisplayVideo();
                }

                return;
            }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeT homeT = new HomeT();
            this.Hide();
            homeT.Show();
        }
    }
}

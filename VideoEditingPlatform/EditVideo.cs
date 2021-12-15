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
    public partial class EditVideo : Form
    {
        private readonly Videos _parent;
        public String idVideo, nomVideo, dateTravail, Musique;
        public Boolean Status;

        private void btnSave_Click(object sender, EventArgs e)
        {
            string cs = @"server=localhost;userid=root;password=;database=videoeditingplatform";
            var con2 = new MySqlConnection(cs);
            con2.Open();
            string register = "UPDATE videos SET nomVideo=@nomVideo, dateTravail=@dateTravail, Musique=@Musique, Status =@Status  where idVideo=@idVideo;";
            var cmd2 = new MySqlCommand(register, con2);
            cmd2.Parameters.Add("@nomVideo", MySqlDbType.VarChar).Value = VideoNameEdit.Text;
            cmd2.Parameters.Add("@dateTravail", MySqlDbType.VarChar).Value = dateTravail;
            cmd2.Parameters.Add("@Musique", MySqlDbType.VarChar).Value = SongEdit.Text;
            cmd2.Parameters.Add("@Status", MySqlDbType.Binary).Value = intConv();
            cmd2.Parameters.Add("@idVideo", MySqlDbType.Int32).Value = idVideo;
            try
            {
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Video has updated succecfully", "Client Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Video not updated"+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con2.Close();
            this.Close();
            clear();
        }

        public void UpdateInfo()
        {
            VideoNameEdit.Text = nomVideo;
            DeadLineEdit.Text = dateTravail;
            SongEdit.Text = Musique;
            StatusEdit.Checked = Status;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int intConv()
        {
            if (StatusEdit.Checked)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public EditVideo(Videos parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void clear()
        {
            VideoNameEdit.Text = DeadLineEdit.Text = SongEdit.Text = "";

        }
    }
}

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
            string register = "UPDATE Videos SET nomVideo=@nomVideo, dateTravail=@dateTravail, Musique=@Musique, Status =@Status  where idVideo=@idVideo;";
            var cmd2 = new MySqlCommand(register, con2);
            cmd2.Parameters.Add("@idVideo", MySqlDbType.VarChar).Value = idVideo;
            cmd2.Parameters.Add("@nomVideo", MySqlDbType.VarChar).Value = nomVideo;
            cmd2.Parameters.Add("@dateTravail", MySqlDbType.VarChar).Value = dateTravail;
            cmd2.Parameters.Add("@Musique", MySqlDbType.VarChar).Value = Musique;
            cmd2.Parameters.Add("@Status", MySqlDbType.VarChar).Value = Status;
            try
            {
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Video has updated succecfully", "Client Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Video not updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con2.Close();
            clear();
        }

        public void UpdateInfo()
        {
            VideoNameEdit.Text = nomVideo;
            DeadLineEdit.Text = dateTravail;
            SongEdit.Text = Musique;
            StatusEdit.Checked = Status;

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

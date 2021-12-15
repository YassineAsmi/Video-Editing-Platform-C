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
    public partial class AddVideo : Form
    {
        private readonly Videos _parent;
        public String idVideo,nomVideo, dateTravail, Musique,nameClient;
        public Int32 idC;
        private void AddVideo_Load(object sender, EventArgs e)
        {
            string cs = @"server=localhost;userid=root;password=;database=videoeditingplatform";
            string sql = "SELECT NomPrenom FROM Clients";
            var con = new MySqlConnection(cs);
            con.Open();
            var cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            ClientNameAdd.Items.Clear();
            while (reader.Read())
            {
                nameClient = reader.GetString("NomPrenom");
                ClientNameAdd.Items.Add(nameClient);
            }
            con.Close();
        }

        private void AddVideo_Shown(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string cs = @"server=localhost;userid=root;password=;database=videoeditingplatform";
            string sql = "Select idClient From clients where NomPrenom=?";
            var con = new MySqlConnection(cs);
            con.Open();
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.Add("@nomVideo", MySqlDbType.VarChar).Value = ClientNameAdd.SelectedItem.ToString();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            { 
                idC = reader.GetInt32("idClient");;
                Video vd =new Video(VideoNameAdd.Text,DeadLineAdd.Text,SongAdd.Text,idC);
                DBVideo.AddVideo(vd);

            }
            con.Close();
            clear();
            this.Close();

        }


        public AddVideo(Videos parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void clear()
        {
            VideoNameAdd.Text = DeadLineAdd.Text = SongAdd.Text = "";

        }
        private void lbltxt_Click(object sender, EventArgs e)
        {

        }
    }
}

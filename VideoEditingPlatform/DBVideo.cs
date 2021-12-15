using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoEditingPlatform
{
    class DBVideo
    {
       
        public static void AddVideo(Video vd)
        {
            
            string cs = @"server=localhost;userid=root;password=;database=videoeditingplatform";
            var con2 = new MySqlConnection(cs);
            con2.Open();
            string register = "INSERT INTO videos(nomVideo,dateTravail,Musique,idClient,idUser) VALUES (@nomVideo,@dateTravail,@Musique,@idClient,@idUser);";
            var cmd2 = new MySqlCommand(register, con2);
            cmd2.Parameters.Add("@nomVideo", MySqlDbType.VarChar).Value = vd.nomVideo ;
            cmd2.Parameters.Add("@dateTravail", MySqlDbType.VarChar).Value = vd.dateTravail;
            cmd2.Parameters.Add("@Musique", MySqlDbType.VarChar).Value = vd.Musique;
            cmd2.Parameters.Add("@idClient", MySqlDbType.Int64).Value = vd.idClient;
            cmd2.Parameters.Add("@idUser", MySqlDbType.Int64).Value = Users.idUser;
           
           try
            {
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Client has added succecfully", "Client Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Client not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } 
            con2.Close();
        }
        public static void UpdateVideo(Video vd, String id,Boolean Status)
        {
            string cs = @"server=localhost;userid=root;password=;database=videoeditingplatform";
            var con2 = new MySqlConnection(cs);
            con2.Open();
            string register = "UPDATE Videos SET nomVideo=@nomVideo, dateTravail=@dateTravail, Musique=@Musique, Status =@Status  where idVideo=@idVideo;";
            var cmd2 = new MySqlCommand(register, con2);
            cmd2.Parameters.Add("@idVideo", MySqlDbType.VarChar).Value = id;
            cmd2.Parameters.Add("@nomVideo", MySqlDbType.VarChar).Value = vd.nomVideo;
            cmd2.Parameters.Add("@dateTravail", MySqlDbType.VarChar).Value = vd.dateTravail;
            cmd2.Parameters.Add("@Musique", MySqlDbType.VarChar).Value = vd.Musique;
            cmd2.Parameters.Add("@Status", MySqlDbType.VarChar).Value = Status ;
            try
            {
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Client has updated succecfully", "Client Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Client not updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con2.Close();

        }

        public static void DeleteVideo(String id)
        {
            string cs = @"server=localhost;userid=root;password=;database=videoeditingplatform";
            var con2 = new MySqlConnection(cs);
            con2.Open();
            string register = "DELETE FROM Videos where idVideo=@idVideo;";
            var cmd2 = new MySqlCommand(register, con2);
            cmd2.Parameters.Add("@idVideo", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Deleted succecfully", "Deleted Succefully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Client not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con2.Close();

        }

        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            string cs = @"server=localhost;userid=root;password=;database=videoeditingplatform";
            var con = new MySqlConnection(cs);
            var cmd = new MySqlCommand(sql, con);
            var adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }
    }
}

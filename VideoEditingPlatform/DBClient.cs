using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoEditingPlatform
{
    class DBClient
    {
        public static void AddClient(Client clt)
        {
            string cs = @"server=localhost;userid=root;password=;database=videoeditingplatform";
            var con = new MySqlConnection(cs);
            var con2 = new MySqlConnection(cs);
            con.Open();
            string stm = "select NomPrenom,address,tel from Clients WHERE tel = @tel; ";
            var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@tel", clt.tel);
            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Account Already exist", "Registration UnSuccessfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            else
            {
                con2.Open();
                string register = "INSERT INTO Clients (NomPrenom,address,tel) VALUES (@NomPrenom,@address,@tel)";
                var cmd2 = new MySqlCommand(register, con2);
                cmd2.Parameters.AddWithValue("@NomPrenom", clt.NomPrenom);
                cmd2.Parameters.AddWithValue("@address", clt.address);
                cmd2.Parameters.AddWithValue("@tel", clt.tel);
                cmd2.ExecuteNonQuery();
                con2.Close();

                try
                {
                    MessageBox.Show("Client has added succecfully", "Client Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqllException ex)
                {
                    MessageBox.Show("Client not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con2.Close();

            }
        }
        public static void UpdateClient(Client clt,String id)
        {
            string cs = @"server=localhost;userid=root;password=;database=videoeditingplatform";
            var con2 = new MySqlConnection(cs);
                con2.Open();
                string register = "UPDATE Clients SET NomPrenom=@NomPrenom address=@address tel=@tel where idClient=@idClient";
                var cmd2 = new MySqlCommand(register, con2);
                cmd2.Parameters.AddWithValue("@NomPrenom", clt.NomPrenom);
                cmd2.Parameters.AddWithValue("@address", clt.address);
                cmd2.Parameters.AddWithValue("@tel", clt.tel);
            try
            {
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Client has updated succecfully", "Client Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch(MySqllException ex)
            {
                MessageBox.Show("Client not updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
                con2.Close();

            }

        public static void DeleteClient(Client clt, String id)
        {
            string cs = @"server=localhost;userid=root;password=;database=videoeditingplatform";
            var con2 = new MySqlConnection(cs);
            con2.Open();
            string register = "DELETE FROM Clients where idClient=@idClient;";
            var cmd2 = new MySqlCommand(register, con2);
            cmd2.Parameters.AddWithValue("@NomPrenom", clt.NomPrenom);
            cmd2.Parameters.AddWithValue("@address", clt.address);
            cmd2.Parameters.AddWithValue("@tel", clt.tel);
            try
            {
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Deleted succecfully", "Deleted Succefully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqllException ex)
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

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
    class DBClient
    {
        public static void AddClient(Client clt)
        {
            Debug.WriteLine("this is db client :  "+clt.Nomprenom + clt.Address + clt.Tel);
            string cs = @"server=localhost;userid=root;password=;database=videoeditingplatform";
            var con2 = new MySqlConnection(cs);
            con2.Open();
            string register = "INSERT INTO Clients (NomPrenom,address,tel) VALUES (@NomPrenom,@address,@tel);";
                var cmd2 = new MySqlCommand(register, con2);
                cmd2.Parameters.Add("@NomPrenom", MySqlDbType.VarChar).Value = clt.Nomprenom;
                cmd2.Parameters.Add("@address", MySqlDbType.VarChar).Value = clt.Address;
                cmd2.Parameters.Add("@tel", MySqlDbType.Int64).Value = clt.Tel;
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
        public static void UpdateClient(Client clt,String id)
        {
            string cs = @"server=localhost;userid=root;password=;database=videoeditingplatform";
            var con2 = new MySqlConnection(cs);
                con2.Open();
                string register = "UPDATE Clients SET NomPrenom=@NomPrenom address=@address tel=@tel where idClient=@idClient;";
                var cmd2 = new MySqlCommand(register, con2);
                cmd2.Parameters.AddWithValue("@NomPrenom", clt.Nomprenom);
                cmd2.Parameters.AddWithValue("@address", clt.Address);
                cmd2.Parameters.AddWithValue("@tel", clt.Tel);
            try
            {
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Client has updated succecfully", "Client Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch(MySqlException ex)
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
            cmd2.Parameters.AddWithValue("@NomPrenom", clt.Nomprenom);
            cmd2.Parameters.AddWithValue("@address", clt.Address);
            cmd2.Parameters.AddWithValue("@tel", clt.Tel);
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

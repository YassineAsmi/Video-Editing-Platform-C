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
    public partial class Add_Client : Form
    {
        private readonly Clients _parent;
        public Add_Client(Clients parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_Client()
        {
            string cs = @"server=localhost;userid=root;password=;database=videoeditingplatform";
            var con = new MySqlConnection(cs);



            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Save")
            {
                if (add_name_client.Text == "" && add_address_client.Text == "" && add_Tel_client.Text == "")
                {
                    MessageBox.Show("Some fields are empty please fill them", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    Client clt = new Client(add_name_client.Text, add_address_client.Text, add_Tel_client.Text);
                    DBClient.AddClient(clt);
                    clear();

                }


            }
            _parent.Display();
            
        }
        
        public void clear()
        {
            add_name_client.Text = add_address_client.Text = add_Tel_client.Text = "";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

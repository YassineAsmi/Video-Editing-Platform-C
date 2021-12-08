using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        public String idClient, name, address, tel;
        public Add_Client(Clients parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void UpdateInfo()
        {
            lbltxt.Text = "Edit Client";
            btnSave.Text = "Edit";
            add_name_client.Text = name;
            add_address_client.Text = address;
            add_Tel_client.Text = tel;

        }
        public void SaveInfo()
        {
            lbltxt.Text = "Add Client";
            btnSave.Text = "Save";
            

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

                if (add_name_client.Text == "" && add_address_client.Text == "" && add_Tel_client.Text == "")
                {
                    MessageBox.Show("Some fields are empty please fill them", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                if(btnSave.Text == "Save")
                {
                    Debug.WriteLine(add_name_client.Text + add_address_client.Text + add_Tel_client.Text);
                    Client clt = new Client(add_name_client.Text, add_address_client.Text, Int32.Parse(add_Tel_client.Text));
                    DBClient.AddClient(clt);
                    clear();

                }
                if(btnSave.Text == "Edit")
                {
                    Client clt = new Client(add_name_client.Text, add_address_client.Text, Int32.Parse(add_Tel_client.Text));
                    Debug.WriteLine("id client : "+idClient);
                    DBClient.UpdateClient(clt, idClient);
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

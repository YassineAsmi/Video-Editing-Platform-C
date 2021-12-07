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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
 
        }



        private void Clients_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            this.Hide();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }




        private void button7_Click(object sender, EventArgs e)
        {
            Add_Client form = new Add_Client(this);
            form.ShowDialog();
        }
        public void Display()
        {
            DBClient.DisplayAndSearch("Select idClient,NomPrenom,address,tel from clients;", dataGridViewClients);
        }
        private void Clients_Shown(object sender, EventArgs e)
        {
            Display();
        
        }

        
        
    }
}

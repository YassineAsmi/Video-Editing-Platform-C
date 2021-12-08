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

        Add_Client addClient;
        public Clients()
        {
            InitializeComponent();
            addClient = new Add_Client(this);
            
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
            addClient.clear();
            addClient.SaveInfo();
            addClient.ShowDialog();
        }
        public void Display()
        {
            DBClient.DisplayAndSearch("Select idClient,NomPrenom,address,tel from clients;", dataGridViewClients);
        }
        private void Clients_Shown(object sender, EventArgs e)
        {
            Display();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void v_TextChanged(object sender, EventArgs e)
        {
            DBClient.DisplayAndSearch("Select idClient,NomPrenom,address,tel from clients WHERE NomPrenom LIKE '%"+search.Text +"%'", dataGridViewClients);
        }

        private void dataGridViewClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                //Edit button message box
                addClient.clear();
                addClient.idClient = dataGridViewClients.Rows[e.RowIndex].Cells[2].Value.ToString();
                addClient.name = dataGridViewClients.Rows[e.RowIndex].Cells[3].Value.ToString();
                addClient.address = dataGridViewClients.Rows[e.RowIndex].Cells[4].Value.ToString();
                addClient.tel = dataGridViewClients.Rows[e.RowIndex].Cells[5].Value.ToString();
                addClient.UpdateInfo();
                addClient.ShowDialog();
                return;
            }
            if(e.ColumnIndex == 1)
            {
                //Delete button message box
                if(MessageBox.Show("Are you sure you want to delete this client?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DBClient.DeleteClient(dataGridViewClients.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                
                return;
            }
        }
    }
}

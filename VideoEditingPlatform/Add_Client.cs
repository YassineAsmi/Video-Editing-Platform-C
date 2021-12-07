using MySql.Data.MySqlClient.Memcached;
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
        Clients _Clients = null;
        public Add_Client()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(_Clients == null)
            {
                Clients clients = new Clients()
                {
                    Name = name.Text,
                    Address = address.Text,
                    Tel = tel.Text
                };
            }
        }
    }
}

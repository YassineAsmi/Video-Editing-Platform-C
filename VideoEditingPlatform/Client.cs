using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoEditingPlatform
{
    class Client
    {
        public string Nomprenom { get; set; }
        public string Address { get; set; }
        public int Tel { get; set; }
        public Client(String nomprenom, String address,int tel)
        {
            Nomprenom = nomprenom;
            Address = address;
            Tel = tel;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoEditingPlatform
{
    class Client
    {
        private string text1;
        private string text2;
        private string text3;

        public Client(string text1, string text2, string text3)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
        }

        public int idClient { get; set; }
        public string NomPrenom { get; set; }
        public string address { get; set; }
        public int tel { get; set; }
    }
}

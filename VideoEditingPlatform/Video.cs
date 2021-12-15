using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoEditingPlatform
{
    class Video
    {
        public string nomVideo { get; set; }
        public string dateTravail { get; set; }
        public string Musique { get; set; }
        public int idClient { get; set; }
        public Video(string nomvideo, string datetravail,string musique,int idclient)
      {
            nomVideo = nomvideo;
            dateTravail = datetravail;
            Musique = musique;
            idClient = idclient;
        }

     
    }
}

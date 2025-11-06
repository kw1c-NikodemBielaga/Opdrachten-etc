//Nikodem Bielaa
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8_VoetbalToernooi.Model
{
    public class TeamModel
    {
        /*
      maker nikodem bielaga
      datum : 10-06-25
   */
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public DocentModel Docent { get; set; }
    }
}

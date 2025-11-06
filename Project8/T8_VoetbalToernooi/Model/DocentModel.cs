using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8_VoetbalToernooi.Model
{
    public class DocentModel
    {
        /*
      maker nikodem bielaga
      datum : 10-06-25
   */
        public int DocentId { get; set; }
        public string Naam { get; set; }
        public string Email { get; set; }
        public string Rol { get; set; }

        public override string ToString()
        {
            return Naam;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8_Praktijkopdracht.Model
{
    public class TaakModule
    {
        public int TaakId { get; set; }
        public string TaakName { get; set; }
        public string TaakOmschrijving { get; set; }
        public DateTime TaakStartdatum { get; set; }
        public DateTime TaakInleverdatum { get;set; }
        public string TaakStatus { get; set; }
        public int ModuleId { get; set; }
    }
}

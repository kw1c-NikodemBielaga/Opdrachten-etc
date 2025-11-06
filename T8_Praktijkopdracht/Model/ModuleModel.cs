using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8_Praktijkopdracht.Model
{
    public class ModuleModel
    {
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public int ThemaId { get; set; }    
        public int DocentId{ get; set; }
        public string ThemaNaam { get; set; }
        public string DocentNaam { get; set; }
        public string Afbeelding { get; set; } 
    }
}

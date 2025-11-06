//Nikodem Bielaga
// 01-04-2025
//Oefening74
using System;

namespace Oefening74.Model
{
    public class DoctorModel 
    {
        public int DoctorID { get; set; }
        public int DoctorNumber { get; set; }
        public string DoctorName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime FirstEpisodeDate { get; set; }
        public DateTime? LastEpisodeDate { get; set; }
    }
}

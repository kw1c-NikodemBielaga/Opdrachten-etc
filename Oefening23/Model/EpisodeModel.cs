//Nikodem Bielaga
// 14-04-2025
//Oefening23
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DrWho;
using DrWho.Model;

namespace DrWho.Model
{
    public class EpisodeModel
    {
        public int EpisodeId { get; set; }
        public int SeriesNumber { get; set; }
        public int EpisodeNumber { get; set; }
        public string EpisodeType { get; set; }
        public string Title { get; set; }
        public DateTime EpisodeDate { get; set; }
        public AuthorModel Autor { get; set; }
        //Foreign key in tabel -> Volledige 'class' in class
        public DoctorModel Doctor { get; set; }
        public string Notes { get; set; }
        public EpisodeModel()
        {
            Doctor = new DoctorModel();
        }

        public int TalletsOp()
        {
            return 0;
        }
    }
}

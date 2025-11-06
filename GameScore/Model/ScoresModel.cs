// Nikodem Bielaga
// 03-04-2025
// Praktijk project
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScore.Model
{
    public class ScoresModel
    {
        public int ScoreId { get; set; }
        public string PlayerName { get; set; }
        public int Score { get; set; }
        public DateTime ScoreDate { get; set; }
    }
}

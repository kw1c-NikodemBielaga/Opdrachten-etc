using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8_VoetbalToernooi.Model
{
    public class WedstrijdModel
    {
        /*
      maker niek van der heijden
      datum : 10-06-25
   */
        public TeamModel Team1 { get; set; }
        public TeamModel Team2 { get; set; }
        public TeamModel Winnaar { get; set; }

        public int ScoreTeam1 { get; set; }
        public int ScoreTeam2 { get; set; }

        public void BepaalWinnaarMetScore()
        {
            Random rnd = new Random();
            ScoreTeam1 = rnd.Next(0, 5);
            ScoreTeam2 = rnd.Next(0, 5);

            while (ScoreTeam1 == ScoreTeam2)
            {
                ScoreTeam1 = rnd.Next(0, 5);
                ScoreTeam2 = rnd.Next(0, 5);
            }

            Winnaar = ScoreTeam1 > ScoreTeam2 ? Team1 : Team2;
        }
    }
}

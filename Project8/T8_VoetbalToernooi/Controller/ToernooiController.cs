using System;
using System.Collections.Generic;
using System.Windows.Forms;
using T8_VoetbalToernooi.Model;

namespace T8_VoetbalToernooi.Controller
{
    /*
       maker nikodem bielaga
       datum : 10-06-25
    */
    public class ToernooiController
    {
        private readonly ToernooiModel _model;

        public ToernooiController(ToernooiModel model)
        {
            _model = model;
        }

        public void VoegWedstrijdToe(string team1Naam, string team2Naam)
        {
            var wedstrijd = new WedstrijdModel
            {
                Team1 = new TeamModel { Name = team1Naam },
                Team2 = new TeamModel { Name = team2Naam }

            };

            _model.Wedstrijden.Add(wedstrijd);
        }

        public int VoegUniekeWedstrijdToe(string team1Naam, string team2Naam)
        {
            var wedstrijd = new WedstrijdModel
            {
                Team1 = new TeamModel { Name = team1Naam },
                Team2 = new TeamModel { Name = team2Naam }

            };

            _model.Wedstrijden.Add(wedstrijd);
            return _model.Wedstrijden.Count - 1;
        }

        public WedstrijdModel SpeelWedstrijdMetScore(int index)
        {
            if (index >= 0 && index < _model.Wedstrijden.Count)
            {
                var wedstrijd = _model.Wedstrijden[index];
                wedstrijd.BepaalWinnaarMetScore();
                return wedstrijd;
            }

            return null;
        }

        public bool IsWedstrijdGespeeld(int index)
        {
            return index < _model.Wedstrijden.Count && _model.Wedstrijden[index].Winnaar != null;
        }

        public string GetWinnaar(int index)
        {
            return _model.Wedstrijden[index].Winnaar.Name;
        }
    }
}

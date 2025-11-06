using Microsoft.VisualStudio.TestTools.UnitTesting;
using T8_VoetbalToernooi.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T8_VoetbalToernooi.Model;

namespace T8_VoetbalToernooi.Controller.Tests
{
    [TestClass()]
    public class ToernooiControllerTests
    {

        [TestMethod]
        public void VoegWedstrijdToe_VoegtWedstrijdCorrectToe()
        {
            // Arrange
            var model = new ToernooiModel { Wedstrijden = new List<WedstrijdModel>() };
            var controller = new ToernooiController(model);

            string team1 = "Team A";
            string team2 = "Team B";

            // Act
            controller.VoegWedstrijdToe(team1, team2);

            // Assert
            Assert.AreEqual(1, model.Wedstrijden.Count, "Wedstrijd is niet toegevoegd.");
            Assert.AreEqual(team1, model.Wedstrijden[0].Team1.Name, "Team1 naam klopt niet.");
            Assert.AreEqual(team2, model.Wedstrijden[0].Team2.Name, "Team2 naam klopt niet.");
        }
    }
}

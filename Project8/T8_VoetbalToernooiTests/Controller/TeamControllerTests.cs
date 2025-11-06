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
    public class TeamControllerTests
    {
        [TestMethod()]
        public void CreateTest()
        {
            TeamController teamController = new TeamController();
            DocentController docentController = new DocentController();

            string uniekeNaam = "TestDocent_" + Guid.NewGuid().ToString();
            string uniekeEmail = uniekeNaam.ToLower() + "@example.com";

            DocentModel nieuweDocent = new DocentModel
            {
                Naam = uniekeNaam,
                Email = uniekeEmail,
                Rol = "Admin" // <-- aangepaste rol
            };

            // Voeg de docent toe
            int docentInsertResult = docentController.Create(nieuweDocent);
            Assert.AreEqual(1, docentInsertResult, "Docent is niet toegevoegd.");

            // Haal het docentId op
            DocentModel toegevoegdeDocent = docentController.Read().FirstOrDefault(d => d.Email == uniekeEmail);
            Assert.IsNotNull(toegevoegdeDocent, "Docent niet gevonden na toevoegen.");

            // Maak een uniek team
            string uniekeTeamNaam = "UnitTestTeam_" + Guid.NewGuid().ToString();
            TeamModel nieuwTeam = new TeamModel
            {
                Name = uniekeTeamNaam,
                Score = 3,
                Docent = toegevoegdeDocent
            };

            // Act
            int teamInsertResult = teamController.Create(nieuwTeam);

            // Assert
            Assert.AreEqual(1, teamInsertResult, "Team is niet toegevoegd.");

            // Clean-up
            int teamDeleteResult = teamController.Delete(nieuwTeam);
            Assert.AreEqual(1, teamDeleteResult, "Team is niet verwijderd.");

            int docentDeleteResult = docentController.Delete(toegevoegdeDocent.DocentId);
            Assert.AreEqual(1, docentDeleteResult, "Docent is niet verwijderd.");
        }
    }
}
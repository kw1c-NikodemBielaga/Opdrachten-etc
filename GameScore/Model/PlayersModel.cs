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
    public class PlayersModel  
    {
        // Eigenschap voor het unieke ID van de speler (meestal een nummer)
        public int PlayerId { get; set; }
        // Eigenschap voor de naam van de speler (zoals een gebruikersnaam)
        public string PlayerName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        // Eigenschap voor de geboortedatum van de speler
        public DateTime DateOfBirth { get; set; }

    }
}

//Nikodem Bielaga
//14.05.2025
//T8_Praktijkopdacht
// Nodige namespaces voor systeemfunctionaliteit en database-interactie
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T8_Praktijkopdracht.Model; // Verwijzing naar het model waarin TaakModule is gedefinieerd

namespace T8_Praktijkopdracht.Controller
{
    // De controllerklasse voor het beheren van taken
    public class TaakController
    {
        // De connectiestring voor verbinding met de database
        string conString = "Data Source=LAPTOP-889JICD3;Initial Catalog=TaakOverzichtDB;Integrated Security=True;";

        // Methode om alle taken op te halen uit de database
        public List<TaakModule> GetTaken()
        {
            List<TaakModule> taken = new List<TaakModule>(); // Lijst om taken in op te slaan

            string query = "SELECT * FROM tblTaken"; // Query om alle rijen uit de taken-tabel op te halen

            using (SqlConnection connection = new SqlConnection(conString)) // Nieuwe SQL-verbinding
            using (SqlCommand cmd = new SqlCommand(query, connection)) // SQL-opdracht aanmaken
            {
                connection.Open(); // Verbinding openen
                SqlDataReader reader = cmd.ExecuteReader(); // Query uitvoeren en resultaten lezen

                // Resultaten rij voor rij uitlezen
                while (reader.Read())
                {
                    // Nieuw taakobject aanmaken met gegevens uit de database
                    TaakModule taak = new TaakModule
                    {
                        TaakId = Convert.ToInt32(reader["TaakId"]),
                        TaakName = reader["Naam"].ToString(),
                        TaakOmschrijving = reader["Omschrijving"].ToString(),
                        TaakStartdatum = Convert.ToDateTime(reader["Startdatum"]),
                        TaakInleverdatum = Convert.ToDateTime(reader["Inleverdatum"]),
                        TaakStatus = reader["Status"].ToString(),
                        ModuleId = Convert.ToInt32(reader["ModuleId"])
                    };

                    taken.Add(taak); // Taak toevoegen aan de lijst
                }

                reader.Close(); // Reader sluiten
            }

            return taken; // Lijst met taken teruggeven
        }

        // Methode om een taak te verwijderen uit de database op basis van de naam
        public bool VerwijderTaak(string taakNaam)
        {
            string query = "DELETE FROM tblTaken WHERE Naam = @Naam"; // Delete-query op basis van naam

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Naam", taakNaam); // Parameter invullen met taaknaam

                connection.Open(); // Verbinding openen
                int rowsAffected = cmd.ExecuteNonQuery(); // Query uitvoeren

                return rowsAffected > 0; // Teruggeven of er rijen zijn verwijderd
            }
        }

        // Methode om alle taken op te halen die bij een bepaalde module horen
        public List<TaakModule> GetTakenVoorModule(int moduleId)
        {
            List<TaakModule> taken = new List<TaakModule>(); // Lijst om resultaten op te slaan

            string query = @"SELECT TaakId, Naam, Omschrijving, Startdatum, Inleverdatum, Status, ModuleId
                             FROM tblTaken 
                             WHERE ModuleId = @ModuleId"; // Query met filter op moduleId

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@ModuleId", moduleId); // Parameter instellen
                connection.Open(); // Verbinding openen

                SqlDataReader reader = cmd.ExecuteReader(); // Resultaten ophalen

                while (reader.Read())
                {
                    // Taakobject opbouwen met de gegevens van deze specifieke module
                    TaakModule taak = new TaakModule
                    {
                        TaakId = Convert.ToInt32(reader["TaakId"]),
                        TaakName = reader["Naam"].ToString(),
                        TaakOmschrijving = reader["Omschrijving"].ToString(),
                        TaakStartdatum = Convert.ToDateTime(reader["Startdatum"]),
                        TaakInleverdatum = Convert.ToDateTime(reader["Inleverdatum"]),
                        TaakStatus = reader["Status"].ToString(),
                        ModuleId = Convert.ToInt32(reader["ModuleId"])
                    };
                    taken.Add(taak); // Taak toevoegen aan de lijst
                }
            }

            return taken; // Lijst met taken teruggeven
        }
    }
}

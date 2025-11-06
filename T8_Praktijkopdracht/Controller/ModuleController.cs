//Nikodem Bielaga
//14.05.2025
//T8_Praktijkopdacht
// Benodigde namespaces voor database, systeemfunctionaliteiten en modellen
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T8_Praktijkopdracht.Model;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace T8_Praktijkopdracht.Controller
{
    // De class die verantwoordelijk is voor het beheren van modules
    public class ModuleController
    {
        // De connectiestring die nodig is om verbinding te maken met de SQL Server database
        string conString = "Data Source=LAPTOP-889JICD3;Initial Catalog=TaakOverzichtDB;Integrated Security=True;";

        // Methode om een lijst van modules op te halen uit de database
        public List<ModuleModel> GetModule()
        {
            // Een lege lijst waarin de opgehaalde modules worden opgeslagen
            List<ModuleModel> modules = new List<ModuleModel>();

            // SQL-query om gegevens op te halen uit de tblModule, tblThema en tblDocent tabellen
            string query = @"
                            SELECT
                                m.ModuleId, 
                                m.Naam AS ModuleNaam, 
                                m.ThemaId, 
                                t.Hoofdstuk AS ThemaNaam, 
                                m.DocentId,
                                (d.Voornaam + ' ' + d.Achternaam) AS DocentNaam,
                                d.Afbeelding
                            FROM tblModule m
                            INNER JOIN tblThema t ON m.ThemaId = t.ThemaId
                            INNER JOIN tblDocent d ON m.DocentId = d.DocentId";

            // Openen van de databaseverbinding en uitvoeren van de SQL-query
            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open(); // Verbinding met database openen
                SqlDataReader reader = cmd.ExecuteReader(); // Query uitvoeren en resultaten ophalen

                // Lezen van elke rij uit het resultaat en deze toevoegen aan de lijst
                while (reader.Read())
                {
                    ModuleModel module = new ModuleModel
                    {
                        ModuleId = Convert.ToInt32(reader["ModuleId"]), // Module ID
                        ModuleName = reader["ModuleNaam"].ToString(), // Naam van de module
                        ThemaId = Convert.ToInt32(reader["ThemaId"]), // Thema ID
                        ThemaNaam = reader["ThemaNaam"].ToString(), // Naam van het thema (hoofdstuk)
                        DocentId = Convert.ToInt32(reader["DocentId"]), // Docent ID
                        DocentNaam = reader["DocentNaam"].ToString(), // Volledige naam van de docent
                        Afbeelding = reader["Afbeelding"].ToString() // Afbeelding van de docent
                    };

                    modules.Add(module); // Toevoegen van het module object aan de lijst
                }
                reader.Close(); // Reader sluiten
            }

            return modules; // De lijst van modules teruggeven
        }

        // Methode om een module te verwijderen uit de database op basis van moduleId
        public void DeleteModule(int moduleId)
        {
            try
            {
                // Verbinding maken met de database
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open(); // Openen van de verbinding

                    // SQL-query om de module te verwijderen
                    string query = "DELETE FROM tblModule WHERE ModuleId = @ModuleId";

                    // De SQL-command klaarmaken met parameter
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ModuleId", moduleId); // Parameter toevoegen
                        command.ExecuteNonQuery(); // Query uitvoeren
                    }
                }
            }
            catch (Exception ex)
            {
                // Foutmelding tonen als er iets misgaat
                MessageBox.Show("Fout bij verwijderen van module: " + ex.Message);
            }
        }

    }
}

//Nikodem Bielaga
//14.05.2025
//T8_Praktijkopdacht
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T8_Praktijkopdracht.Model; // Verwijzing naar het ThemaModel
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace T8_Praktijkopdracht.Controller
{
    // Deze klasse beheert alle acties met betrekking tot 'Thema's' in de database
    public class ThemaController
    {
        // Connectiestring voor verbinding met SQL Server database
        string conString = "Data Source=LAPTOP-889JICD3;Initial Catalog=TaakOverzichtDB;Integrated Security=True;";

        // Methode om alle thema's op te halen uit de database
        public List<ThemaModel> GetThemas()
        {
            List<ThemaModel> themas = new List<ThemaModel>(); // Lijst om opgehaalde thema's op te slaan

            // SQL-query om velden op te halen uit de tblThema
            string query = "SELECT ThemaId, Hoofdstuk, Naam, DocentId FROM tblThema";

            // SQL-verbinding en command aanmaken en uitvoeren
            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open(); // Openen van de databaseverbinding
                SqlDataReader reader = cmd.ExecuteReader(); // Uitvoeren van de query en resultaten lezen

                // Elke rij uit de resultaten uitlezen
                while (reader.Read())
                {
                    // Aanmaken van een ThemaModel object met gegevens uit de reader
                    ThemaModel thema = new ThemaModel
                    {
                        ThemaId = Convert.ToInt32(reader["ThemaId"]), // Thema ID ophalen
                        ThemaHoofdstuk = reader["Hoofdstuk"].ToString(), // Hoofdstuknaam
                        ThemaName = reader["Naam"].ToString(), // Naam van het thema
                        DocentId = Convert.ToInt32(reader["DocentId"]) // ID van de docent
                    };

                    themas.Add(thema); // Toevoegen van het thema aan de lijst
                }

                reader.Close(); // Reader sluiten
            }

            return themas; // De lijst met thema's teruggeven
        }

        // Methode om een nieuw thema toe te voegen aan de database
        public void AddThema(string hoofdstuk, string naam, int docentId)
        {
            try
            {
                // Openen van verbinding en uitvoeren van insert query
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open(); // Verbinding openen

                    // SQL-query om een nieuw thema toe te voegen
                    string query = "INSERT INTO tblThema (Hoofdstuk, Naam, DocentId) VALUES (@Hoofdstuk, @Naam, @DocentId)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parameters koppelen aan de query
                        command.Parameters.AddWithValue("@Hoofdstuk", hoofdstuk);
                        command.Parameters.AddWithValue("@Naam", naam);
                        command.Parameters.AddWithValue("@DocentId", docentId);

                        command.ExecuteNonQuery(); // Query uitvoeren
                    }
                }
            }
            catch (Exception ex)
            {
                // Foutmelding tonen als er iets misgaat bij het toevoegen
                MessageBox.Show("Fout bij toevoegen van thema: " + ex.Message);
            }
        }

        // Methode om een thema te verwijderen op basis van het thema ID
        public void DeleteThema(int themaId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open(); // Verbinding openen

                    // Delete-query om het thema te verwijderen
                    string query = "DELETE FROM tblThema WHERE ThemaId = @ThemaId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ThemaId", themaId); // Parameter toevoegen
                        command.ExecuteNonQuery(); // Query uitvoeren
                    }
                }
            }
            catch (Exception ex)
            {
                // Foutmelding tonen bij een exception
                MessageBox.Show("Fout bij verwijderen van thema: " + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

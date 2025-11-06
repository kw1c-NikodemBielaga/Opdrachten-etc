//Nikodem Bielaga
// 01-04-2025
//Oefening12
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Oefening74.Model; // Verwijzing naar het modelbestand waarin DoctorModel is gedefinieerd

namespace Oefening74.Controller
{
    public class DoctorController
    {
        // Verbindingsstring voor de database, waarin de server, database en authenticatiemethode zijn opgegeven.
        string conString = "Data Source=LAPTOP-889JICD3;Initial Catalog=DoctorWho;Integrated Security=True;";

        // Methode om alle dokters uit de database te lezen en terug te geven als een lijst van DoctorModel-objecten.
        public List<DoctorModel> ReadAll()
        {
            List<DoctorModel> doctors = new List<DoctorModel>(); // Lijst om de opgehaalde dokters op te slaan.

            try
            {
                // Maak een nieuwe SQL-verbinding met de opgegeven verbindingsstring.
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    string query = "SELECT * FROM tblDoctor"; // SQL-query om alle dokters op te halen.
                    SqlCommand command = new SqlCommand(query, connection); // Maak een SQL-opdracht met de query en verbinding.
                    connection.Open(); // Open de databaseverbinding.
                    SqlDataReader reader = command.ExecuteReader(); // Voer de query uit en sla de resultaten op in de reader.

                    int rowCount = 0; // Teller om het aantal gelezen rijen bij te houden

                    // Loop door de resultatenrijen en zet ze om naar DoctorModel-objecten.
                    while (reader.Read())
                    {
                        rowCount++; // Verhoog de teller bij elke gelezen rij.

                        DoctorModel doctor = new DoctorModel
                        {
                            DoctorID = reader.IsDBNull(reader.GetOrdinal("DoctorID")) ? 0 : reader.GetInt32(reader.GetOrdinal("DoctorID")), // Controleer op NULL
                            DoctorName = reader.IsDBNull(reader.GetOrdinal("DoctorName")) ? "Onbekend" : reader.GetString(reader.GetOrdinal("DoctorName")), // Controleer op NULL
                            DoctorNumber = reader.IsDBNull(reader.GetOrdinal("DoctorNumber")) ? 0 : reader.GetInt32(reader.GetOrdinal("DoctorNumber")), // Controleer op NULL
                            BirthDate = reader.IsDBNull(reader.GetOrdinal("BirthDate")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("BirthDate")), // Controleer op NULL
                            FirstEpisodeDate = reader.IsDBNull(reader.GetOrdinal("FirstEpisodeDate")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("FirstEpisodeDate")), // Controleer op NULL
                            LastEpisodeDate = reader.IsDBNull(reader.GetOrdinal("LastEpisodeDate")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("LastEpisodeDate")) // Controleer op NULL en nullable DateTime
                        };

                        // Log de gevonden dokter in de console voor debugdoeleinden
                        Console.WriteLine($"Gevonden dokter: {doctor.DoctorName}, ID: {doctor.DoctorID}, BirthDate: {doctor.BirthDate}");

                        doctors.Add(doctor); // Voeg de dokter toe aan de lijst.
                    }

                    reader.Close(); // Sluit de DataReader.

                    // Toon het aantal rijen in de console voor debugdoeleinden
                    Console.WriteLine($"Totaal aantal dokters gelezen: {rowCount}"); // Toon het aantal gelezen dokters.
                }
            }
            catch (Exception ex) // Foutafhandeling als er iets misgaat met de databaseverbinding of query-uitvoering.
            {
                Console.WriteLine($"Database error: {ex.Message}"); // Toon een foutmelding in de console.
            }

            return doctors; // Geef de lijst met dokters terug.
        }
        public int Update(DoctorModel doctor)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string query = @"UPDATE tblDoctor
                             SET DoctorName = @DoctorName,
                                 DoctorNumber = @DoctorNumber,
                                 BirthDate = @BirthDate,
                                 FirstEpisodeDate = @FirstEpisodeDate,
                                 LastEpisodeDate = @LastEpisodeDate
                             WHERE DoctorID = @DoctorID";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@DoctorID", doctor.DoctorID);
                    cmd.Parameters.AddWithValue("@DoctorName", doctor.DoctorName);
                    cmd.Parameters.AddWithValue("@DoctorNumber", doctor.DoctorNumber);
                    cmd.Parameters.AddWithValue("@BirthDate", doctor.BirthDate);
                    cmd.Parameters.AddWithValue("@FirstEpisodeDate", doctor.FirstEpisodeDate);
                    cmd.Parameters.AddWithValue("@LastEpisodeDate", (object)doctor.LastEpisodeDate ?? DBNull.Value);

                    con.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fout bij updaten: " + ex.Message);
            }

            return rowsAffected;
        }
    }
}

// Nikodem Bielaga
// 03-04-2025
// Praktijk project
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using GameScore.Model;

namespace GameScore.Controller
{
    // De controller die de interactie met de database voor de spelers beheert
    public class PlayerController
    {
        // Connectiestring voor de database
        private readonly string conString = "Data Source=LAPTOP-889JICD3;Initial Catalog=GameScoreDB;Integrated Security=True;";

        // Methode om alle spelers uit de database op te halen
        public List<PlayersModel> GetAllPlayers()
        {
            // Maak een lijst van spelers om de resultaten op te slaan
            List<PlayersModel> players = new List<PlayersModel>();

            try
            {
                // Maak verbinding met de database
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open(); // Open de verbinding
                    // SQL-query om alle spelers op te halen, gesorteerd op spelersnaam
                    string query = "SELECT PlayerId, PlayerName, FirstName, LastName, Email, DateOfBirth FROM tblPlayers ORDER BY PlayerName DESC";

                    // Voer de SQL-query uit
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader()) // Voer de lezing van de resultaten uit
                    {
                        // Lees elke rij en voeg de speler toe aan de lijst
                        while (reader.Read())
                        {
                            PlayersModel player = new PlayersModel
                            {
                                // Zet de velden van de speler in het model
                                PlayerId = Convert.ToInt32(reader["PlayerId"]),
                                PlayerName = reader["PlayerName"].ToString(),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Email = reader["Email"].ToString(),
                                DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]) // Zet de geboortedatum om naar DateTime
                            };

                            // Voeg de speler toe aan de lijst
                            players.Add(player);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Foutafhandelingsmechanisme bij een SQL-fout
                Console.WriteLine("Databasefout: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Foutafhandelingsmechanisme voor andere fouten
                Console.WriteLine("Er is een fout opgetreden: " + ex.Message);
            }

            // Geef de lijst van spelers terug
            return players;
        }

        // Methode om een nieuwe speler toe te voegen aan de database
        public void AddPlayer(string playerName, string firstName, string lastName, string email, DateTime dateOfBirth)
        {
            try
            {
                // Maak verbinding met de database
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open(); // Open de verbinding
                    // SQL-query om een nieuwe speler toe te voegen
                    string query = "INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateOfBirth) VALUES (@PlayerName, @FirstName, @LastName, @Email, @DateOfBirth)";

                    // Voer de SQL-query uit met parameters
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PlayerName", playerName); // Voeg de spelernaam toe
                    command.Parameters.AddWithValue("@FirstName", firstName);   // Voeg de voornaam toe
                    command.Parameters.AddWithValue("@LastName", lastName);     // Voeg de achternaam toe
                    command.Parameters.AddWithValue("@Email", email);           // Voeg het emailadres toe
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth.ToString("dd-MM-yyyy")); // Voeg de geboortedatum toe

                    command.ExecuteNonQuery(); // Voer de query uit (zonder resultaten terug te geven)
                }
            }
            catch (Exception ex)
            {
                // Foutafhandelingsmechanisme bij fout in het toevoegen van een speler
                MessageBox.Show("Fout bij toevoegen speler: " + ex.Message, "Database Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Methode om een speler uit de database te verwijderen
        public void DeletePlayer(int playerId)
        {
            try
            {
                // Maak verbinding met de database
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open(); // Open de verbinding
                    // SQL-query om een speler te verwijderen op basis van de speler-ID
                    string query = "DELETE FROM tblPlayers WHERE PlayerId = @PlayerId";

                    // Voer de SQL-query uit met de speler-ID als parameter
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PlayerId", playerId);

                    command.ExecuteNonQuery(); // Voer de query uit (zonder resultaten terug te geven)
                }
            }
            catch (Exception ex)
            {
                // Foutafhandelingsmechanisme bij fout in het verwijderen van een speler
                MessageBox.Show("Error deleting player: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Methode om een speler in de database bij te werken
        public void UpdatePlayer(int playerId, string playerName, string firstName, string lastName, string email, DateTime dateOfBirth)
        // 'playerId' is het unieke ID van de speler die je wilt bijwerken. Dit wordt gebruikt om de juiste speler te identificeren in de database.
        // 'playerName' is de naam van de speler, zoals ingevoerd door de gebruiker.
        // 'firstName' is de voornaam van de speler.
        // 'lastName' is de achternaam van de speler.
        // 'email' is het e-mailadres van de speler.
        // 'dateOfBirth' is de geboortedatum van de speler.
        {
            try
            {
                // Maak verbinding met de database
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open(); // Open de verbinding
                    // SQL-query om de gegevens van een speler bij te werken
                    string query = "UPDATE tblPlayers SET PlayerName = @PlayerName, FirstName = @FirstName, LastName = @LastName, Email = @Email, DateOfBirth = @DateOfBirth WHERE PlayerId = @PlayerId";

                    // Voer de SQL-query uit met de bijgewerkte gegevens
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PlayerName", playerName); // Voeg de nieuwe spelernaam toe
                    command.Parameters.AddWithValue("@FirstName", firstName);   // Voeg de nieuwe voornaam toe
                    command.Parameters.AddWithValue("@LastName", lastName);     // Voeg de nieuwe achternaam toe
                    command.Parameters.AddWithValue("@Email", email);           // Voeg het nieuwe emailadres toe
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth.ToString("dd-MM-yyyy")); // Voeg de nieuwe geboortedatum toe
                    command.Parameters.AddWithValue("@PlayerId", playerId);     // Geef de speler-ID om de juiste speler bij te werken

                    command.ExecuteNonQuery(); // Voer de query uit (zonder resultaten terug te geven)
                }
            }
            catch (Exception ex)
            {
                // Foutafhandelingsmechanisme bij fout in het bijwerken van een speler
                MessageBox.Show("Fout bij updaten speler: " + ex.Message, "Database Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

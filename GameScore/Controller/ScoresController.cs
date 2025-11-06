// Nikodem Bielaga
// 03-04-2025
// Praktijk project
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using GameScore.Model;

namespace GameScore.Controller
{
    // De controller die de interactie met de database voor de scores beheert
    public class ScoresController
    {
        // De connectiestring voor de database
        string conString = "Data Source=LAPTOP-889JICD3;Initial Catalog=GameScoreDB;Integrated Security=True;";

        // Methode om de scores van een specifieke speler op te halen op basis van de spelernaam
        public List<ScoresModel> GetScoresByPlayerName(string playerName)
        {
            List<ScoresModel> scores = new List<ScoresModel>();
            try
            {
                // Maak verbinding met de database
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open(); // Open de verbinding
                    // SQL-query om scores van een speler op te halen, gesorteerd op scoredatum
                    string query = "SELECT ScoreId, PlayerName, Score, ScoreDate FROM tblScores WHERE PlayerName = @PlayerName ORDER BY ScoreDate DESC";
                    SqlCommand command = new SqlCommand(query, connection);
                    // Voeg de spelernaam toe als parameter om SQL-injectie te voorkomen
                    command.Parameters.AddWithValue("@PlayerName", playerName);

                    // Voer de query uit en lees de resultaten
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read()) // Lees elke rij in de resultaten
                        {
                            // Zet de gegevens om naar een ScoresModel object
                            ScoresModel score = new ScoresModel
                            {
                                ScoreId = Convert.ToInt32(reader["ScoreId"]),
                                // Haal de 'PlayerName' op uit de database en zet deze om naar een          string
                                PlayerName = reader["PlayerName"].ToString(),
                                // Haal de 'Score' op uit de database en zet deze om naar een               integeratie 
                                Score = Convert.ToInt32(reader["Score"]),
                                // Haal de 'ScoreDate' op uit de database en zet deze om naar een           DateTime object
                                ScoreDate = Convert.ToDateTime(reader["ScoreDate"])
                            };

                            // Voeg het score-object toe aan de lijst
                            scores.Add(score);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Foutafhandelingsmechanisme bij fouten tijdens het ophalen van scores
                MessageBox.Show("Error retrieving scores for player: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Geef de lijst van scores terug
            return scores;
        }

        // Methode om alle scores op te halen, gesorteerd op score in aflopende volgorde
        public List<ScoresModel> GetAllScores()
        {
            List<ScoresModel> scores = new List<ScoresModel>();
            try
            {
                // Maak verbinding met de database
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open(); // Open de verbinding
                    // SQL-query om alle scores op te halen, gesorteerd op score
                    string query = "SELECT ScoreId, PlayerName, Score, ScoreDate FROM tblScores ORDER BY Score DESC";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Voer de query uit en lees de resultaten
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read()) // Lees elke rij in de resultaten
                        {
                            // Zet de gegevens om naar een ScoresModel object
                            ScoresModel score = new ScoresModel
                            {
                                ScoreId = Convert.ToInt32(reader["ScoreId"]),
                                PlayerName = reader["PlayerName"].ToString(),
                                Score = Convert.ToInt32(reader["Score"]),
                                ScoreDate = Convert.ToDateTime(reader["ScoreDate"])
                            };

                            // Voeg het score-object toe aan de lijst
                            scores.Add(score);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Foutafhandelingsmechanisme bij fouten tijdens het ophalen van scores
                MessageBox.Show("Error retrieving scores: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Geef de lijst van scores terug
            return scores;
        }

        // Methode om een score toe te voegen aan de database
        public void AddScore(int scoreId, string playerName, int score, DateTime scoreDate)
        {
            try
            {
                // Maak verbinding met de database
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open(); // Open de verbinding
                    // SQL-query om een score toe te voegen
                    string query = "INSERT INTO tblScores (PlayerName, Score, ScoreDate) VALUES (@PlayerName, @Score, @ScoreDate)";
                    SqlCommand command = new SqlCommand(query, connection);
                    // Voeg de parameters toe voor spelernaam, score en scoredatum
                    command.Parameters.AddWithValue("@PlayerName", playerName);
                    command.Parameters.AddWithValue("@Score", score);

                    // Formatteer de DateTime naar 'dd-MM-yyyy' voor opslag in de database
                    string formattedDate = scoreDate.ToString("dd-MM-yyyy");
                    command.Parameters.AddWithValue("@ScoreDate", formattedDate);

                    // Voer de query uit (zonder resultaat terug te geven)
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Foutafhandelingsmechanisme bij fouten tijdens het toevoegen van een score
                MessageBox.Show("Error adding score: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Methode om een score uit de database te verwijderen
        public void DeleteScore(int scoreId)
        {
            try
            {
                // Maak verbinding met de database
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open(); // Open de verbinding
                    // SQL-query om een score te verwijderen op basis van de score-ID
                    string query = "DELETE FROM tblScores WHERE ScoreId = @ScoreId";
                    SqlCommand command = new SqlCommand(query, connection);
                    // Voeg de score-ID toe als parameter
                    command.Parameters.AddWithValue("@ScoreId", scoreId);

                    // Voer de query uit (zonder resultaat terug te geven)
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Foutafhandelingsmechanisme bij fouten tijdens het verwijderen van een score
                MessageBox.Show("Error deleting score: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Methode om een score bij te werken in de database
        public void UpdateScore(int scoreId, string playerName, int score, DateTime scoreDate)
        {
            try
            {
                // Maak verbinding met de database
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open(); // Open de verbinding
                    // SQL-query om een score bij te werken op basis van de score-ID
                    string query = "UPDATE tblScores SET PlayerName = @PlayerName, Score = @Score, ScoreDate = @ScoreDate WHERE ScoreId = @ScoreId";
                    SqlCommand command = new SqlCommand(query, connection);
                    // Voeg de parameters toe voor spelernaam, score, scoredatum en score-ID
                    command.Parameters.AddWithValue("@PlayerName", playerName);
                    command.Parameters.AddWithValue("@Score", score);
                    command.Parameters.AddWithValue("@ScoreDate", scoreDate.ToString("dd-MM-yyyy"));
                    command.Parameters.AddWithValue("@ScoreId", scoreId);

                    // Voer de query uit (zonder resultaat terug te geven)
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Foutafhandelingsmechanisme bij fouten tijdens het bijwerken van een score
                MessageBox.Show("Error updating score: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

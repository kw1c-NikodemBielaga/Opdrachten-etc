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
    // De controller die de interactie met de database voor de top 10 scores beheert
    public class TopController
    {
        // De connectiestring voor de database
        string conString = "Data Source=LAPTOP-889JICD3;Initial Catalog=GameScoreDB;Integrated Security=True;";

        // Methode om de top 10 scores op te halen uit de database
        public List<ScoresModel> GetTopScores()
        {
            List<ScoresModel> scores = new List<ScoresModel>(); // Lijst om de scores op te slaan
            try
            {
                // Maak verbinding met de database
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open(); // Open de verbinding

                    // SQL-query om de top 10 hoogste scores op te halen
                    string query = "SELECT TOP 10 ScoreId, PlayerName, Score, ScoreDate FROM tblScores ORDER BY Score DESC";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Voer de query uit en lees de resultaten
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read()) // Lees elke rij in de resultaten
                        {
                            // Zet de gegevens om naar een ScoresModel object
                            ScoresModel score = new ScoresModel
                            {
                                ScoreId = Convert.ToInt32(reader["ScoreId"]), // Zet de ScoreId om naar een integer
                                PlayerName = reader["PlayerName"].ToString(), // Zet de spelernaam om naar een string
                                Score = Convert.ToInt32(reader["Score"]), // Zet de score om naar een integer
                                ScoreDate = Convert.ToDateTime(reader["ScoreDate"]) // Zet de scoredatum om naar een DateTime
                            };

                            // Voeg het score-object toe aan de lijst
                            scores.Add(score);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Foutafhandelingsmechanisme bij fouten tijdens het ophalen van de top scores
                MessageBox.Show("Error retrieving top scores: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Geef de lijst van top scores terug
            return scores;
        }
    }
}

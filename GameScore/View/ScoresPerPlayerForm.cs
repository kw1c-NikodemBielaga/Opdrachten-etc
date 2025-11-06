// Nikodem Bielaga
// 03-04-2025
// Praktijk project
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GameScore.Model; // Verwijst naar het model dat de scoregegevens bevat

namespace GameScore.View
{
    // ScoresPerPlayerForm is een formulier om de scores van een specifieke speler weer te geven
    public partial class ScoresPerPlayerForm : Form
    {
        private List<ScoresModel> playerScores; // Lijst om de scores van de speler op te slaan

        // Constructor voor het ScoresPerPlayerForm
        // Dit formulier ontvangt de lijst met scores van de speler
        public ScoresPerPlayerForm(List<ScoresModel> scores)
        {
            InitializeComponent(); // Initialiseer de componenten van het formulier
            playerScores = scores; // Wijs de ontvangen scores toe aan de playerScores lijst
        }

        // Event handler voor het laden van het formulier
        private void ScoresPerPlayerForm_Load(object sender, EventArgs e)
        {
            LoadPlayerScores(); // Laad de scores van de speler bij het openen van het formulier
        }

        // Methode om de scores van de speler weer te geven in de ListView
        private void LoadPlayerScores()
        {
            lvScoreView.Items.Clear(); // Maak de ListView leeg voordat nieuwe items worden geladen

            // Controleer of de kolommen al zijn ingesteld
            if (lvScoreView.Columns.Count == 0)
            {
                lvScoreView.View = System.Windows.Forms.View.Details; // Zet de weergave van de ListView naar Details
                lvScoreView.FullRowSelect = true; // Zorg ervoor dat de volledige rij geselecteerd wordt
                lvScoreView.GridLines = true; // Zet de randen van de cellen aan

                // Voeg de kolommen toe aan de ListView
                lvScoreView.Columns.Add("Rank", 50);
                lvScoreView.Columns.Add("PlayerName", 150);
                lvScoreView.Columns.Add("Score", 80);
                lvScoreView.Columns.Add("ScoreDate", 120);
            }

            // Sorteer de scores op basis van de score (hoog naar laag)
            var sortedScores = playerScores.OrderByDescending(score => score.Score).ToList();

            int rank = 1; // Begin de rang met 1
            // Loop door de gesorteerde lijst van scores
            foreach (ScoresModel score in sortedScores)
            {
                // Maak een nieuw item in de ListView voor elke score
                ListViewItem item = new ListViewItem(rank.ToString()); // Gebruik rank als eerste kolom
                item.SubItems.Add(score.PlayerName); // Voeg de naam van de speler toe
                item.SubItems.Add(score.Score.ToString()); // Voeg de score toe
                item.SubItems.Add(score.ScoreDate.ToString("dd-MM-yyyy")); // Voeg de datum van de score toe

                // Voeg het item toe aan de ListView
                lvScoreView.Items.Add(item);
                rank++; // Verhoog de rang voor de volgende score
            }

            // Zorg ervoor dat alle kolommen automatisch worden aangepast naar de inhoud
            foreach (ColumnHeader column in lvScoreView.Columns)
            {
                column.Width = -2; // Zet de breedte van de kolommen op automatisch
            }
        }

        // Event handler voor de annuleerknop (bijvoorbeeld voor het sluiten van het formulier)
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Sluit het formulier wanneer de gebruiker op 'Cancel' klikt
        }
    }
}

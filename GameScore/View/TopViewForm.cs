// Nikodem Bielaga
// 03-04-2025
// Praktijk project
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GameScore.Controller; // Verwijst naar de controller die de scoregegevens beheert
using GameScore.Model; // Verwijst naar het model waarin de scoregegevens worden opgeslagen

namespace GameScore.View
{
    // De TopViewForm klasse is een formulier voor het weergeven van de topscores
    public partial class TopViewForm : Form
    {
        // De controller voor het beheren van de topscores
        private TopController topController;

        // De constructor van het formulier
        public TopViewForm()
        {
            InitializeComponent(); // Initialiseer de componenten (formulieren en besturingselementen)
            topController = new TopController(); // Maak een nieuw TopController-object aan voor het ophalen van scores
        }

        // Event handler voor het laden van het formulier
        private void TopViewForm_Load(object sender, EventArgs e)
        {
            // Stel de kolommen in voor de ListView
            if (lvTopView.Columns.Count == 0) // Controleer of er al kolommen zijn ingesteld
            {
                lvTopView.View = System.Windows.Forms.View.Details; // Zet de weergave van de ListView naar 'Details' (lijstweergave)
                lvTopView.FullRowSelect = true; // Zorg ervoor dat de hele rij geselecteerd wordt
                lvTopView.GridLines = true; // Zet de randen van de cellen aan

                // Voeg de kolommen toe aan de ListView
                lvTopView.Columns.Add("Rank", 50); // Kolom voor de rang
                lvTopView.Columns.Add("ScoreId", 50); // Kolom voor de score-ID
                lvTopView.Columns.Add("PlayerName", 150); // Kolom voor de naam van de speler
                lvTopView.Columns.Add("Score", 80); // Kolom voor de score
                lvTopView.Columns.Add("ScoreDate", 120); // Kolom voor de datum van de score
            }

            // Verkrijg de topscores via de controller
            List<ScoresModel> scores = topController.GetTopScores(); // Verkrijgt een lijst van scores uit de controller

            // Doorloop de lijst van scores en voeg ze toe aan de ListView
            int rank = 1; // Begin bij rang 1 voor de top score
            foreach (ScoresModel score in scores) // Loop door alle scores
            {
                // Maak een ListViewItem voor elke score
                ListViewItem item = new ListViewItem(rank.ToString()); // Maak een nieuw item aan met de rang
                item.SubItems.Add(score.ScoreId.ToString()); // Voeg de score-ID toe aan het item
                item.SubItems.Add(score.PlayerName); // Voeg de naam van de speler toe
                item.SubItems.Add(score.Score.ToString()); // Voeg de score zelf toe
                item.SubItems.Add(score.ScoreDate.ToShortDateString()); // Voeg de datum van de score toe

                // Voeg het item toe aan de ListView
                lvTopView.Items.Add(item);

                rank++;  // Verhoog de rang voor de volgende score
            }
        }

        // Event handler voor het sluiten van het formulier
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Sluit het formulier wanneer de exit-knop wordt geklikt
        }
    }
}

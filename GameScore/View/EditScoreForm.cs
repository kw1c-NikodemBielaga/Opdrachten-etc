// Nikodem Bielaga
// 03-04-2025
// Praktijk project
using System;
using System.Windows.Forms;
using GameScore.Controller;
using GameScore.Model;

namespace GameScore.View
{
    // Formulier om een score te bewerken
    public partial class EditScoreForm : Form
    {
        private ScoresModel selectedScore; // De score die bewerkt moet worden
        private ScoresController scoresController; // De controller voor het beheren van scores

        // Constructor die een ScoresModel object accepteert om het formulier te vullen
        public EditScoreForm(ScoresModel score, bool isAdmin)
        {
            InitializeComponent(); // Initialiseer de componenten van het formulier
            scoresController = new ScoresController(); // Maak een nieuwe instantie van de ScoresController
            selectedScore = score; // Sla de geselecteerde score op

            // Vul de velden met de geselecteerde score gegevens
            tbScoreId.Text = selectedScore.ScoreId.ToString();
            tbPlayer.Text = selectedScore.PlayerName;
            tbScore.Text = selectedScore.Score.ToString();
            dtpScoreData.Value = selectedScore.ScoreDate;

            // Schakel het scoreveld uit als de gebruiker een admin is
            if (isAdmin)
            {
                tbScore.Enabled = false;  // Admins kunnen de score niet bewerken
            }
            else
            {
                tbScore.Enabled = true;  // Niet-admins kunnen de score bewerken
            }

            tbScoreId.Enabled = false; // ScoreId kan niet bewerkt worden
        }

        // Event handler voor de "Opslaan" knop
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Valideer of alle velden zijn ingevuld
            if (string.IsNullOrEmpty(tbPlayer.Text) || string.IsNullOrEmpty(tbScore.Text) || string.IsNullOrEmpty(tbScoreId.Text))
            {
                MessageBox.Show("Alle velden moeten ingevuld zijn.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Valideer of Score en ScoreId geldig zijn nummers
            if (!int.TryParse(tbScore.Text, out int score) || !int.TryParse(tbScoreId.Text, out int scoreId))
            {
                MessageBox.Show("Score en ScoreId moeten nummers zijn.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Bereid de bijgewerkte score gegevens voor
            selectedScore.PlayerName = tbPlayer.Text;
            selectedScore.Score = score;
            selectedScore.ScoreDate = dtpScoreData.Value;

            try
            {
                // Werk de score bij in de database via de ScoresController
                scoresController.UpdateScore(selectedScore.ScoreId, selectedScore.PlayerName, selectedScore.Score, selectedScore.ScoreDate);

                MessageBox.Show("Score succesvol bijgewerkt!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();  // Sluit het bewerkformulier
            }
            catch (Exception ex)
            {
                // Foutafhandeling bij het bijwerken van de score in de database
                MessageBox.Show("Fout bij bijwerken van score: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler voor het laden van het formulier 
        private void EditScoreForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

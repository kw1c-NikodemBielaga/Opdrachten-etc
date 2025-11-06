// Nikodem Bielaga
// 03-04-2025
// Praktijk project
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameScore.Controller; // Verwijst naar de controller die de scorelogica beheert
using GameScore.Model; // Verwijst naar het model dat de scoregegevens bevat

namespace GameScore.View
{
    // De ScoresViewForm klasse is een formulier om scores te beheren en weer te geven
    public partial class ScoresViewForm : Form
    {
        // Verwijzing naar de controller voor het beheren van scores
        private ScoresController scoresController;
        private bool isAdmin = false; // Bepaalt of de huidige gebruiker admin is
        private bool isPlayerAdmin = false; // Bepaalt of de huidige gebruiker speleradmin is
        private bool isReader = false;  // Bepaalt of de huidige gebruiker alleen lezer is

        // De constructor van het formulier
        public ScoresViewForm()
        {
            InitializeComponent(); // Initialiseer de componenten (formulieren en besturingselementen)
            scoresController = new ScoresController(); // Maak een nieuwe instantie van de ScoresController

            // Zorg ervoor dat we de huidige gebruiker ophalen na het inloggen
            isAdmin = LoginForm.currentUser == "T7_admin"; // Controleer of de gebruiker admin is
            isPlayerAdmin = LoginForm.currentUser == "T7_playeradmin"; // Controleer of de gebruiker speleradmin is
            isReader = LoginForm.currentUser == "T7_reader"; // Controleer of de gebruiker alleen lezer is
        }

        // Event handler voor het laden van het formulier
        private void ScoresViewForm_Load(object sender, EventArgs e)
        {
            LoadScores(); // Laad de scores in de ListView
            lvScoreView.DoubleClick += lvScoreView_DoubleClick; // Voeg de dubbelklik-event toe aan de ListView

            // Stel de rechten in voor knoppen op basis van de rol van de gebruiker
            if (isAdmin)
            {
                btnAdd.Enabled = true; // Admin heeft toegang om scores toe te voegen
                btnDelete.Enabled = true; // Admin heeft toegang om scores te verwijderen
                btnEdit.Enabled = true; // Admin heeft toegang om scores te bewerken
            }
            else if (isPlayerAdmin || isReader)
            {
                btnAdd.Enabled = false; // Beperk toegang voor PlayerAdmin en Reader
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
            }
            else
            {
                // Geef een waarschuwing als de gebruiker geen toegang heeft
                MessageBox.Show("Je hebt geen rechten om scores te bekijken.", "Geen toegang", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close(); // Sluit het formulier als de gebruiker geen toegang heeft
            }
        }

        // Laad de scores in de ListView
        private void LoadScores()
        {
            lvScoreView.Items.Clear(); // Maak de ListView leeg voordat nieuwe scores worden geladen

            if (lvScoreView.Columns.Count == 0) // Controleer of de kolommen al zijn ingesteld
            {
                lvScoreView.View = System.Windows.Forms.View.Details; // Zet de weergave naar details
                lvScoreView.FullRowSelect = true; // Zorg ervoor dat de volledige rij geselecteerd wordt
                lvScoreView.GridLines = true; // Zet de randen van de cellen aan

                // Voeg de kolommen toe aan de ListView
                lvScoreView.Columns.Add("Rank", 50);
                lvScoreView.Columns.Add("PlayerName", 150);
                lvScoreView.Columns.Add("Score", 80);
                lvScoreView.Columns.Add("ScoreDate", 120);
            }

            // Verkrijg de lijst van scores via de ScoresController
            List<ScoresModel> scores = scoresController.GetAllScores();
            int rank = 1;

            // Loop door alle scores en voeg ze toe aan de ListView
            foreach (ScoresModel score in scores)
            {
                ListViewItem item = new ListViewItem(rank.ToString()); // Voeg de rang toe
                item.SubItems.Add(score.PlayerName); // Voeg de naam van de speler toe
                item.SubItems.Add(score.Score.ToString()); // Voeg de score toe
                item.SubItems.Add(score.ScoreDate.ToString("dd-MM-yyyy")); // Voeg de datum van de score toe

                item.Tag = score.ScoreId; // Sla de ScoreId op in de Tag van het item (voor latere bewerkingen)

                lvScoreView.Items.Add(item); // Voeg het item toe aan de ListView
                rank++; // Verhoog de rang voor de volgende score
            }

            // Pas de breedte van de kolommen aan
            foreach (ColumnHeader column in lvScoreView.Columns)
            {
                column.Width = -2;  // Auto resize de kolommen
            }
        }

        // Event handler voor de knop 'Add' om een nieuwe score toe te voegen
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!isAdmin) // Controleer of de gebruiker admin is
            {
                MessageBox.Show("Je hebt geen toestemming om scores te bewerken.", "Geen Toegang", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Controleer of alle velden zijn ingevuld
                if (string.IsNullOrEmpty(tbScoreId.Text) || string.IsNullOrEmpty(tbPlayer.Text) || string.IsNullOrEmpty(tbScore.Text))
                {
                    MessageBox.Show("Alle velden moeten ingevuld zijn.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Controleer of ScoreId en Score getallen zijn
                if (!int.TryParse(tbScoreId.Text, out int scoreId) || !int.TryParse(tbScore.Text, out int score))
                {
                    MessageBox.Show("Score ID en Score moeten nummers zijn.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string playerName = tbPlayer.Text; // Verkrijg de naam van de speler
                DateTime scoreDate = dtpScoreData.Value; // Verkrijg de datum van de score

                // Voeg de score toe via de controller
                scoresController.AddScore(scoreId, playerName, score, scoreDate);
                MessageBox.Show("Score succesvol toegevoegd!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadScores(); // Herlaad de scores om de ListView bij te werken
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fout: " + ex.Message, "Invoerfout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler voor de knop 'Delete' om een score te verwijderen
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!isAdmin) // Controleer of de gebruiker admin is
            {
                MessageBox.Show("Je hebt geen toestemming om scores te bewerken.", "Geen Toegang", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Controleer of een item is geselecteerd
            if (lvScoreView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecteer eerst een score om te verwijderen.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verkrijg de ScoreId van het geselecteerde item
            int scoreId = (int)lvScoreView.SelectedItems[0].Tag;

            // Vraag om bevestiging voordat de score wordt verwijderd
            DialogResult dialogResult = MessageBox.Show("Weet u zeker dat u deze score wilt verwijderen?", "Bevestiging", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    // Verwijder de score via de controller
                    scoresController.DeleteScore(scoreId);

                    // Verwijder het item uit de ListView
                    lvScoreView.SelectedItems[0].Remove();

                    MessageBox.Show("Score succesvol verwijderd!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadScores();  // Herlaad de scores om de ListView bij te werken
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fout bij verwijderen: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event handler voor het selecteren van een item in de ListView
        private void lvScoreView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Zorg ervoor dat de verwijderknop alleen geactiveerd wordt als een item geselecteerd is
            btnDelete.Enabled = lvScoreView.SelectedItems.Count > 0;
        }

        // Event handler voor de knop 'Edit' om een score te bewerken
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!isAdmin) // Controleer of de gebruiker admin is
            {
                MessageBox.Show("Je hebt geen toestemming om scores te bewerken.", "Geen Toegang", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Controleer of een item is geselecteerd
            if (lvScoreView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecteer eerst een score om te bewerken.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verkrijg de details van de geselecteerde score
            int scoreId = (int)lvScoreView.SelectedItems[0].Tag;
            string playerName = lvScoreView.SelectedItems[0].SubItems[1].Text;
            int score = int.Parse(lvScoreView.SelectedItems[0].SubItems[2].Text);
            DateTime scoreDate = DateTime.ParseExact(lvScoreView.SelectedItems[0].SubItems[3].Text, "dd-MM-yyyy", null);

            // Maak een ScoresModel voor de geselecteerde score
            ScoresModel selectedScore = new ScoresModel
            {
                ScoreId = scoreId,
                PlayerName = playerName,
                Score = score,
                ScoreDate = scoreDate,
            };

            // Open het formulier om de score te bewerken
            EditScoreForm editForm = new EditScoreForm(selectedScore, isAdmin);
            editForm.ShowDialog(); // Toon het formulier als dialoog
            LoadScores();  // Herlaad de scores na bewerking
        }

        // Event handler voor dubbelklikken op een item in de ListView
        private void lvScoreView_DoubleClick(object sender, EventArgs e)
        {
            // Controleer of er een item geselecteerd is
            if (lvScoreView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecteer eerst een speler om de scores te bekijken.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verkrijg de naam van de speler van de geselecteerde item
            string playerName = lvScoreView.SelectedItems[0].SubItems[1].Text;

            // Haal scores van de geselecteerde speler op via de PlayerName
            List<ScoresModel> playerScores = scoresController.GetScoresByPlayerName(playerName);

            // Maak een nieuw formulier voor het weergeven van scores per speler
            ScoresPerPlayerForm scoresPerPlayerForm = new ScoresPerPlayerForm(playerScores);
            scoresPerPlayerForm.ShowDialog();  // Toon het formulier als dialoog
        }
    }
}

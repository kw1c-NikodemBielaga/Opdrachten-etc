// Nikodem Bielaga
// 03-04-2025
// Praktijk project
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GameScore.Controller;
using GameScore.Model;

namespace GameScore.View
{
    // Formulier voor het beheren van spelers in de game
    public partial class PlayersViewForm : Form
    {
        private PlayerController playersController; // Verantwoordelijk voor de interactie met de spelersdata
        private bool isAdmin = false;               // Bepaalde rechten voor de admin
        private bool isPlayerAdmin = false;         // Bepaalde rechten voor de speleradmin
        private bool isReader = false;              // Lezer zonder bewerkingsrechten

        // Constructor voor PlayersViewForm
        public PlayersViewForm()
        {
            InitializeComponent(); // Initialiseer de componenten van het formulier
            playersController = new PlayerController(); // Maak een nieuwe controller aan voor spelersbeheer

            // Controleer rechten op basis van de gebruikersnaam
            string user = LoginForm.currentUser;  // Haal de ingelogde gebruiker op
            isAdmin = user == "T7_admin";         // Controleer of de gebruiker een admin is
            isPlayerAdmin = user == "T7_playeradmin"; // Controleer of de gebruiker een speleradmin is
            isReader = user == "T7_reader";       // Controleer of de gebruiker een lezer is
        }

        // Event handler voor het laden van het formulier
        private void PlayersViewForm_Load(object sender, EventArgs e)
        {
            LoadPlayers(); // Laad de spelerslijst bij het openen van het formulier

            // Stel de knoppen in afhankelijk van de rechten van de gebruiker
            btnAdd.Enabled = isAdmin;         // Alleen admins kunnen spelers toevoegen
            btnDelete.Enabled = isAdmin;      // Alleen admins kunnen spelers verwijderen
            btnEdit.Enabled = isAdmin || isPlayerAdmin; // Admins en speleradmins kunnen spelers bewerken

            // Als de gebruiker een lezer is, mogen ze niets doen
            if (isReader)
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
            }
        }

        // Laad de lijst van spelers in de ListView
        private void LoadPlayers()
        {
            lvPlayerView.Items.Clear(); // Maak de ListView leeg voordat nieuwe gegevens worden geladen

            // Controleer of de kolommen al zijn ingesteld
            if (lvPlayerView.Columns.Count == 0)
            {
                lvPlayerView.View = System.Windows.Forms.View.Details;  // Zet de weergave naar details
                lvPlayerView.FullRowSelect = true;  // Maak de hele rij selecteerbaar
                lvPlayerView.GridLines = true;      // Zet de gridlijnen aan

                // Voeg de kolommen toe aan de ListView
                lvPlayerView.Columns.Add("PlayerName", 150);
                lvPlayerView.Columns.Add("FirstName", 100);
                lvPlayerView.Columns.Add("LastName", 100);
                lvPlayerView.Columns.Add("Email", 150);
                lvPlayerView.Columns.Add("DateOfBirth", 120);
            }

            // Haal de lijst van alle spelers op
            List<PlayersModel> players = playersController.GetAllPlayers();

            // Voeg elke speler toe aan de ListView
            foreach (PlayersModel player in players)
            {
                ListViewItem item = new ListViewItem(player.PlayerName);
                item.SubItems.Add(player.FirstName); // Voeg voornaam toe
                item.SubItems.Add(player.LastName);  // Voeg achternaam toe
                item.SubItems.Add(player.Email);     // Voeg e-mail toe
                item.SubItems.Add(player.DateOfBirth.ToString("dd-MM-yyyy")); // Voeg geboortedatum toe

                lvPlayerView.Items.Add(item);  // Voeg het item toe aan de ListView
                item.Tag = player.PlayerId;    // Bewaar de PlayerId in de Tag voor latere verwijdering of bewerking
            }

            // Pas de breedte van de kolommen automatisch aan
            foreach (ColumnHeader column in lvPlayerView.Columns)
            {
                column.Width = -2;  // Zorg ervoor dat de kolommen automatisch de juiste breedte krijgen
            }
        }

        // Event handler voor de knop 'Voeg Speler Toe'
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Controleer of alle verplichte velden zijn ingevuld
                if (string.IsNullOrEmpty(tbPlayerName.Text) || string.IsNullOrEmpty(tbFirstName.Text) ||
                    string.IsNullOrEmpty(tbLastName.Text) || string.IsNullOrEmpty(tbEmail.Text))
                {
                    MessageBox.Show("Alle velden moeten ingevuld zijn.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verkrijg de gegevens van de nieuwe speler
                string playerName = tbPlayerName.Text.Trim();
                string firstName = tbFirstName.Text.Trim();
                string lastName = tbLastName.Text.Trim();
                string email = tbEmail.Text.Trim();
                DateTime dob = dtpDateofBirth.Value;

                // Voeg de speler toe via de controller
                playersController.AddPlayer(playerName, firstName, lastName, email, dob);
                MessageBox.Show("Speler succesvol toegevoegd!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPlayers(); // Herlaad de spelerslijst
            }
            catch (Exception ex)
            {
                // Foutafhandeling als er iets misgaat bij het toevoegen van de speler
                MessageBox.Show("Fout: " + ex.Message, "Invoerfout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler voor de knop 'Verwijder Speler'
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Controleer of er een speler geselecteerd is om te verwijderen
            if (lvPlayerView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecteer eerst een speler om te verwijderen.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Haal de PlayerId op van het geselecteerde item
            int playerId = (int)lvPlayerView.SelectedItems[0].Tag;

            // Bevestigingsdialoog voor verwijderen
            DialogResult dialogResult = MessageBox.Show("Weet u zeker dat u deze speler wilt verwijderen?", "Bevestiging", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    // Verwijder de speler via de controller
                    playersController.DeletePlayer(playerId);
                    lvPlayerView.SelectedItems[0].Remove();  // Verwijder het item uit de ListView
                    MessageBox.Show("Speler succesvol verwijderd!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Foutafhandeling bij het verwijderen van de speler
                    MessageBox.Show("Fout bij verwijderen: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event handler voor het aanpassen van de geselecteerde speler
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Controleer of er een speler geselecteerd is om te bewerken
            if (lvPlayerView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecteer eerst een speler om te bewerken.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verkrijg de gegevens van de geselecteerde speler
            int playerId = (int)lvPlayerView.SelectedItems[0].Tag;
            string playerName = lvPlayerView.SelectedItems[0].SubItems[0].Text;
            string firstName = lvPlayerView.SelectedItems[0].SubItems[1].Text;
            string lastName = lvPlayerView.SelectedItems[0].SubItems[2].Text;
            string email = lvPlayerView.SelectedItems[0].SubItems[3].Text;
            DateTime dob = DateTime.ParseExact(lvPlayerView.SelectedItems[0].SubItems[4].Text, "dd-MM-yyyy", null);

            // Maak een PlayersModel object van de geselecteerde speler
            PlayersModel selectedPlayer = new PlayersModel
            {
                PlayerId = playerId,
                PlayerName = playerName,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                DateOfBirth = dob
            };

            // Open het bewerkformulier voor de geselecteerde speler
            EditPlayerForm editForm = new EditPlayerForm(selectedPlayer);
            editForm.ShowDialog(); // Toon het bewerkformulier als dialoog
            LoadPlayers(); // Herlaad de lijst na bewerking
        }

    }
}

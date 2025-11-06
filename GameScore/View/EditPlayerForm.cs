// Nikodem Bielaga
// 03-04-2025
// Praktijk project
using System;
using System.Windows.Forms;
using GameScore.Model;
using GameScore.Controller;

namespace GameScore.View
{
    // Formulier voor het bewerken van spelergegevens
    public partial class EditPlayerForm : Form
    {
        private PlayersModel player;  // Het PlayersModel-object dat de speler vertegenwoordigt
        private PlayerController controller;  // De controller die verantwoordelijk is voor spelerbewerkingen

        // Constructor die een PlayersModel-object accepteert om het formulier in te vullen
        public EditPlayerForm(PlayersModel playerToEdit)
        {
            InitializeComponent();  // Initialiseer de componenten van het formulier
            player = playerToEdit;  // Zet de speler die bewerkt moet worden
            controller = new PlayerController();  // Maak een nieuwe controller aan
        }

        // Event handler voor het laden van het formulier
        private void EditPlayerForm_Load(object sender, EventArgs e)
        {
            // Vul de velden in het formulier met de gegevens van de speler
            tbPlayerName.Text = player.PlayerName;
            tbFirstName.Text = player.FirstName;
            tbLastName.Text = player.LastName;
            tbEmail.Text = player.Email;
            dtpDateofBirth.Value = player.DateOfBirth;
        }

        // Event handler voor de "Opslaan" knop
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            // Valideer of alle velden zijn ingevuld
            if (string.IsNullOrWhiteSpace(tbPlayerName.Text) || string.IsNullOrWhiteSpace(tbFirstName.Text) ||
                string.IsNullOrWhiteSpace(tbLastName.Text) || string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("Alle velden moeten ingevuld zijn.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // Stop verder gaan als er lege velden zijn
            }

            try
            {
                // Werk de spelerinformatie bij met de nieuwe gegevens uit het formulier
                player.PlayerName = tbPlayerName.Text.Trim();
                player.FirstName = tbFirstName.Text.Trim();
                player.LastName = tbLastName.Text.Trim();
                player.Email = tbEmail.Text.Trim();
                player.DateOfBirth = dtpDateofBirth.Value;

                // Roep de UpdatePlayer-methode van de controller aan om de spelergegevens bij te werken in de database
                controller.UpdatePlayer(
                    player.PlayerId,
                    player.PlayerName,
                    player.FirstName,
                    player.LastName,
                    player.Email,
                    player.DateOfBirth
                );

                MessageBox.Show("Speler succesvol bijgewerkt!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();  // Sluit het formulier na het bijwerken van de gegevens
            }
            catch (Exception ex)
            {
                // Toon een foutmelding als er iets misgaat bij het bijwerken van de speler
                MessageBox.Show("Fout bij bijwerken: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler voor de "Sluiten" knop
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();  // Sluit het formulier zonder wijzigingen
        }
    }
}

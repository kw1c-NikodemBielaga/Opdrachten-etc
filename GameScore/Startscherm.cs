// Nikodem Bielaga
// 03-04-2025
// Praktijk project
using System;
using System.Windows.Forms;
using GameScore.View;

namespace GameScore
{
    public partial class Startscherm : Form
    {
        // Constructor van het Startscherm-formulier
        public Startscherm()
        {
            InitializeComponent(); // Initialiseert de componenten van het formulier
        }

        // Event handler voor het laden van het Startscherm-formulier
        private void Startscherm_Load(object sender, EventArgs e)
        {
            // Verberg eerst alle menu-items totdat we weten wie de gebruiker is
            scoresToolStripMenuItem.Visible = false;  // Scorebeheer menu-item verbergen
            playerToolStripMenuItem.Visible = false;  // Spelerbeheer menu-item verbergen
            top10ToolStripMenuItem.Visible = false;   // Top 10 menu-item verbergen

            // Controleer of er een ingelogde gebruiker is en toon menu-items afhankelijk van hun rol
            if (!string.IsNullOrEmpty(LoginForm.currentUser))
            {
                top10ToolStripMenuItem.Visible = true;  // Top 10 altijd zichtbaar voor ingelogde gebruikers

                // Als de gebruiker een van de toegestane rollen is, toon dan de menu-items voor score en spelerbeheer
                if (LoginForm.currentUser == "T7_admin" || LoginForm.currentUser == "T7_playeradmin" || LoginForm.currentUser == "T7_reader")
                {
                    scoresToolStripMenuItem.Visible = true;  // Scorebeheer zichtbaar voor bepaalde gebruikers
                    playerToolStripMenuItem.Visible = true;  // Spelerbeheer zichtbaar voor bepaalde gebruikers
                }
            }
        }

        // Event handler voor het klikken op het "Top 10" menu-item
        private void top10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open een nieuw formulier om de top 10 scores weer te geven
            TopViewForm topViewForm = new TopViewForm();
            topViewForm.Show();  // Toon het TopViewForm
        }

        // Event handler voor het klikken op het "Scores" menu-item
        private void scoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Controleer of de gebruiker de juiste rol heeft voor toegang tot het scorebeheer
            if (LoginForm.currentUser == "T7_admin" || LoginForm.currentUser == "T7_playeradmin" || LoginForm.currentUser == "T7_reader")
            {
                // Open het formulier voor scorebeheer
                ScoresViewForm scoresViewForm = new ScoresViewForm();
                scoresViewForm.Show();  // Toon het ScoresViewForm
            }
            else
            {
                // Als de gebruiker geen toegang heeft, toon een waarschuwing
                MessageBox.Show("Je hebt geen toegang tot het scorebeheer.", "Geen Toegang", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Event handler voor het klikken op het "Spelers" menu-item
        private void playerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Controleer of de gebruiker de juiste rol heeft voor toegang tot het spelerbeheer
            if (LoginForm.currentUser == "T7_admin" || LoginForm.currentUser == "T7_playeradmin" || LoginForm.currentUser == "T7_reader")
            {
                // Open het formulier voor spelerbeheer
                PlayersViewForm playersViewForm = new PlayersViewForm();
                playersViewForm.Show();  // Toon het PlayersViewForm
            }
            else
            {
                // Als de gebruiker geen toegang heeft, toon een waarschuwing
                MessageBox.Show("Je hebt geen toegang tot het spelerbeheer.", "Geen Toegang", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Event handler voor het klikken op het "Afsluiten" menu-item
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();  // Sluit het Startscherm-formulier
        }

        // Event handler voor het laden van het Startscherm-formulier (ongebruikte methode, kan verwijderd worden)
        private void Startscherm_Load_1(object sender, EventArgs e)
        {
            // Deze methode is momenteel niet nodig, het kan veilig verwijderd worden.
        }
    }
}

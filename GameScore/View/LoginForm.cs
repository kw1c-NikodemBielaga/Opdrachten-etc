// Nikodem Bielaga
// 03-04-2025
// Praktijk project
using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace GameScore.View
{
    // Loginformulier voor de gameapplicatie
    public partial class LoginForm : Form
    {
        public static string currentUser; // Opslaan van de huidige ingelogde gebruiker
        public static string currentPassword; // Opslaan van het wachtwoord van de huidige gebruiker (indien nodig)

        // Constructor voor het loginformulier
        public LoginForm()
        {
            InitializeComponent(); // Initialiseer de componenten van het formulier
        }

        // Event handler voor de login knop
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Verbindingsstring naar de SQL Server database "GameScoreDB" op de lokale computer.
            // "Data Source" is de naam van de server/computer waarop SQL Server draait.
            // "Integrated Security=True" betekent dat Windows-authenticatie gebruikt wordt.
            string conString = "Data Source=LAPTOP-889JICD3;Initial Catalog=GameScoreDB;Integrated Security=True;";

            // SQL-query om te controleren of er een SQL-gebruiker bestaat met een bepaalde naam.
            // @username is een parameter die later gevuld wordt om SQL-injectie te voorkomen.
            // We zoeken alleen naar logins van het type 'SQL_LOGIN' (dus geen Windows-gebruikers).
            string query = "SELECT name FROM sys.server_principals WHERE name = @username AND type_desc = 'SQL_LOGIN';";

            try
            {
                // Maak verbinding met de database
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    conn.Open(); // Open de databaseverbinding

                    // SQL-query uitvoeren om de gebruiker te valideren
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", tbUsername.Text); // Voeg de gebruikersnaam toe aan de query
                    SqlDataReader reader = cmd.ExecuteReader(); // Voer de query uit en verkrijg de gegevens

                    if (reader.Read()) // Als er een resultaat wordt gevonden (de gebruiker bestaat)
                    {
                        currentUser = reader["name"].ToString(); // Sla de gebruikersnaam op
                        MessageBox.Show("Ingelogd als: " + currentUser, "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK; // Geef OK terug zodat de login succesvol is
                    }
                    else // Als de gebruiker niet bestaat of verkeerde gegevens zijn ingevoerd
                    {
                        MessageBox.Show("Onjuiste gebruikersnaam of wachtwoord", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.Cancel; // Geef Cancel terug zodat de login mislukt is
                    }
                    reader.Close(); // Sluit de datareader
                }
            }
            catch (Exception ex)
            {
                // Foutafhandeling bij een probleem met de login (bijvoorbeeld netwerkfout of SQL-fout)
                MessageBox.Show("Fout bij login: " + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Statische methode om het loginformulier te tonen en de login te controleren
        public static bool ShowLogin()
        {
            using (LoginForm loginForm = new LoginForm()) // Maak een nieuw loginformulier
            {
                if (loginForm.ShowDialog() == DialogResult.OK) // Als de login succesvol is (OK wordt geretourneerd)
                {
                    currentUser = loginForm.tbUsername.Text; // Sla de gebruikersnaam van het formulier op
                    return true; // Login was succesvol
                }
                return false; // Login is niet succesvol (gebruiker heeft geannuleerd of verkeerde gegevens)
            }
        }
    }
}

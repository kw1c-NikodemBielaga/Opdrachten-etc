//Nikodem Bielaga
//14.05.2025
//T8_Praktijkopdacht
// Importeren van benodigde namespaces
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T8_Praktijkopdracht.Controller;
using T8_Praktijkopdracht.Model;

namespace T8_Praktijkopdracht.View
{
    public partial class frmTaakOverview : Form
    {
        // Constructor: initialiseert het formulier
        public frmTaakOverview()
        {
            InitializeComponent();
        }

        // Wordt uitgevoerd bij het laden van het formulier
        private void frmTaakOverview_Load(object sender, EventArgs e)
        {
            LoadTaken(); // Laad taken in de ListView
        }

        // Methode om taken uit de controller op te halen en in de ListView te tonen
        private void LoadTaken()
        {
            lvTaken.Items.Clear(); // Verwijder bestaande items uit de lijst

            // Voeg kolommen toe als deze nog niet aanwezig zijn
            if (lvTaken.Columns.Count == 0)
            {
                lvTaken.View = System.Windows.Forms.View.Details; // Detailweergave
                lvTaken.FullRowSelect = true; // Hele rij selecteerbaar

                lvTaken.Columns.Add("Naam", 100);
                lvTaken.Columns.Add("Omschrijving", 200);
                lvTaken.Columns.Add("Startdatum", 100);
                lvTaken.Columns.Add("Inleverdatum", 100);
                lvTaken.Columns.Add("Status", 80);
            }

            // Haal taken op via de controller
            TaakController controller = new TaakController();
            List<TaakModule> taken = controller.GetTaken();

            // Voeg elke taak toe aan de ListView
            foreach (TaakModule taak in taken)
            {
                ListViewItem item = new ListViewItem(taak.TaakName);
                item.SubItems.Add(taak.TaakOmschrijving);
                item.SubItems.Add(taak.TaakStartdatum.ToShortDateString());
                item.SubItems.Add(taak.TaakInleverdatum.ToShortDateString());
                item.SubItems.Add(taak.TaakStatus);

                lvTaken.Items.Add(item);
            }
        }

        // Methode om alle taken te exporteren naar een CSV-bestand
        private void ExportTakenNaarCSV(string filePath)
        {
            StringBuilder csvContent = new StringBuilder();

            // Voeg de kolomnamen toe
            csvContent.AppendLine("Naam,Omschrijving,Startdatum,Inleverdatum,Status");

            // Doorloop alle taken in de ListView
            foreach (ListViewItem item in lvTaken.Items)
            {
                List<string> row = new List<string>();

                // Voeg elke kolomwaarde toe aan de rij, en verwerk speciale tekens
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    string value = subItem.Text.Replace("\"", "\"\""); // Dubbele aanhalingstekens escapen
                    if (value.Contains(",") || value.Contains("\""))
                    {
                        value = $"\"{value}\""; // Omring met aanhalingstekens
                    }
                    row.Add(value);
                }

                // Voeg de rij toe aan de CSV-inhoud
                csvContent.AppendLine(string.Join(",", row));
            }

            // Schrijf de inhoud weg naar het opgegeven bestandspad
            File.WriteAllText(filePath, csvContent.ToString(), Encoding.UTF8);
        }

        // Wordt uitgevoerd wanneer op de knop 'Exporteer naar CSV' wordt geklikt
        private void btnTaakCSV_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Stel het dialoogvenster in
                saveFileDialog.Filter = "CSV-bestanden (*.csv)|*.csv";
                saveFileDialog.Title = "Exporteer taken naar CSV";
                saveFileDialog.FileName = "TakenOverzicht.csv";

                // Als de gebruiker op OK klikt
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Exporteer de taken
                        ExportTakenNaarCSV(saveFileDialog.FileName);
                        MessageBox.Show("Taken succesvol geëxporteerd naar CSV!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Toon foutmelding bij falen
                        MessageBox.Show("Er is een fout opgetreden bij het exporteren:\n" + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Wordt uitgevoerd wanneer op de knop 'Filteren' wordt geklikt
        private void btnTaakFilteren_Click(object sender, EventArgs e)
        {
            // Haal alle taken op via de controller
            TaakController controller = new TaakController();
            List<TaakModule> taken = controller.GetTaken();

            // Sorteer de taken op taakomschrijving
            List<TaakModule> gesorteerdeTaken = taken.OrderBy(m => m.TaakOmschrijving).ToList();

            lvTaken.Items.Clear(); // Leeg de lijst

            // Voeg gesorteerde taken toe aan de ListView
            foreach (TaakModule taak in gesorteerdeTaken)
            {
                ListViewItem item = new ListViewItem(taak.TaakName);
                item.SubItems.Add(taak.TaakOmschrijving);
                item.SubItems.Add(taak.TaakStartdatum.ToShortDateString());
                item.SubItems.Add(taak.TaakInleverdatum.ToShortDateString());
                item.SubItems.Add(taak.TaakStatus);

                lvTaken.Items.Add(item);
            }
        }

        // Wordt uitgevoerd wanneer op de knop 'Verwijderen' wordt geklikt
        private void btnTaakVerwijdern_Click(object sender, EventArgs e)
        {
            // Controleer of er een taak geselecteerd is
            if (lvTaken.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecteer eerst een taak om te verwijderen.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Haal de naam van de geselecteerde taak op
            string taakNaam = lvTaken.SelectedItems[0].Text;

            // Vraag bevestiging aan de gebruiker
            DialogResult result = MessageBox.Show($"Weet je zeker dat je taak '{taakNaam}' wilt verwijderen?", "Bevestigen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Verwijder de taak via de controller
                TaakController controller = new TaakController();
                bool success = controller.VerwijderTaak(taakNaam);

                // Toon resultaat aan gebruiker
                if (success)
                {
                    MessageBox.Show("Taak succesvol verwijderd.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTaken(); // Herlaad de takenlijst
                }
                else
                {
                    MessageBox.Show("Verwijderen mislukt. Controleer of de taak bestaat.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

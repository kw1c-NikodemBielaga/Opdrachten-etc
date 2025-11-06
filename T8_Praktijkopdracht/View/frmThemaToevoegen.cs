//Nikodem Bielaga
//14.05.2025
//T8_Praktijkopdacht
// Benodigde namespaces voor forms, data, en controller toegang
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T8_Praktijkopdracht.Controller;

namespace T8_Praktijkopdracht.View
{
    // Formulier waarmee een nieuw thema kan worden toegevoegd
    public partial class frmThemaToevoegen : Form
    {
        // Constructor: initialiseert het formulier
        public frmThemaToevoegen()
        {
            InitializeComponent(); // Laadt de GUI-componenten
        }

        // Event-handler: wordt uitgevoerd zodra het formulier is geladen
        private void frmThemaToevoegen_Load(object sender, EventArgs e)
        {
            // Leeg eerst de dropdown (ComboBox) voor DocentId's
            tbDocentId.Items.Clear();

            // Voeg handmatig mogelijke docentId's toe (1 t/m 4)
            tbDocentId.Items.Add("1");
            tbDocentId.Items.Add("2");
            tbDocentId.Items.Add("3");
            tbDocentId.Items.Add("4");

            // Selecteer standaard de eerste docentId
            tbDocentId.SelectedIndex = 0;
        }

        // Event-handler: wordt uitgevoerd wanneer op de "Opslaan" knop wordt geklikt
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Haal gebruikersinvoer op en verwijder eventuele spaties
            string hoofdstuk = tbHoofdstuk.Text.Trim();
            string naam = tbNaam.Text.Trim();
            string docentIdText = tbDocentId.SelectedItem?.ToString();

            // Controleer of alle velden zijn ingevuld
            if (string.IsNullOrEmpty(hoofdstuk) || string.IsNullOrEmpty(naam) || string.IsNullOrEmpty(docentIdText))
            {
                MessageBox.Show("Vul alle velden in.", "Invoerfout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Controleer of docentId een geldig geheel getal is
            if (!int.TryParse(docentIdText, out int docentId))
            {
                MessageBox.Show("DocentId moet een geldig getal zijn.", "Invoerfout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Roep de controller aan om het thema toe te voegen aan de database
            ThemaController controller = new ThemaController();
            controller.AddThema(hoofdstuk, naam, docentId);

            // Toon bevestiging en sluit het formulier
            MessageBox.Show("Thema succesvol toegevoegd.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Sluit het huidige invoerscherm
        }

        // Event-handler voor als de selectie in de docentId ComboBox verandert
        private void tbDocentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

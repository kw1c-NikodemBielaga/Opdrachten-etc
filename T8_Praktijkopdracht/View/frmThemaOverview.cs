//Nikodem Bielaga
//14.05.2025
//T8_Praktijkopdacht
// Benodigde namespaces voor forms, controllers en modellen
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
using T8_Praktijkopdracht.Model;

namespace T8_Praktijkopdracht.View
{
    // Formulier voor het tonen, toevoegen, verwijderen en sorteren van thema's
    public partial class frmThemaOverview : Form
    {
        // Constructor: initialiseert het formulier
        public frmThemaOverview()
        {
            InitializeComponent();
        }

        // Wordt uitgevoerd zodra het formulier geladen is
        private void frmThemaOverview_Load(object sender, EventArgs e)
        {
            LoadThemas(); // Laad de thema's uit de database
        }

        // Methode om thema's uit de database op te halen en in de ListView te tonen
        private void LoadThemas()
        {
            lvThema.Items.Clear(); // Maak eerst de lijst leeg

            // Voeg kolommen toe als dit nog niet eerder is gedaan
            if (lvThema.Columns.Count == 0)
            {
                lvThema.View = System.Windows.Forms.View.Details;
                lvThema.FullRowSelect = true;

                lvThema.Columns.Add("Hoofdstuk", 150);
                lvThema.Columns.Add("Naam", 150);
            }

            // Haal thema's op via de controller
            ThemaController controller = new ThemaController();
            List<ThemaModel> themas = controller.GetThemas();

            // Voeg elk thema toe aan de ListView
            foreach (ThemaModel thema in themas)
            {
                ListViewItem item = new ListViewItem(thema.ThemaHoofdstuk.ToString());
                item.SubItems.Add(thema.ThemaName);
                item.Tag = thema.ThemaId; // Sla het ID op in de Tag voor later gebruik
                lvThema.Items.Add(item);
            }
        }

        // Wordt uitgevoerd wanneer op "Thema Toevoegen" wordt geklikt
        private void btnThemaToevoegen_Click(object sender, EventArgs e)
        {
            // Open het formulier om een nieuw thema toe te voegen
            frmThemaToevoegen frmThemaToevoegen = new frmThemaToevoegen();
            frmThemaToevoegen.ShowDialog(); // Wacht tot formulier gesloten is

            LoadThemas(); // Herlaad de lijst met thema's
        }

        // Wordt uitgevoerd wanneer op "Thema Verwijderen" wordt geklikt
        private void btnThemaVerwijderen_Click(object sender, EventArgs e)
        {
            // Controleer of er een item geselecteerd is
            if (lvThema.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecteer eerst een thema om te verwijderen.", "Waarschuwing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Vraag bevestiging aan de gebruiker
            var result = MessageBox.Show("Weet je zeker dat je dit thema wilt verwijderen?", "Bevestiging", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Haal geselecteerd item op en lees het themaId uit de Tag
                ListViewItem selectedItem = lvThema.SelectedItems[0];
                int themaId = (int)selectedItem.Tag;

                // Verwijder thema via de controller
                ThemaController controller = new ThemaController();
                controller.DeleteThema(themaId);

                LoadThemas(); // Herlaad de lijst na verwijderen
            }
        }

        // Wordt uitgevoerd wanneer op "Filteren" wordt geklikt (sorteert op naam)
        private void btnThemaFilteren_Click(object sender, EventArgs e)
        {
            ThemaController controller = new ThemaController();
            List<ThemaModel> themas = controller.GetThemas();

            // Sorteer de thema's alfabetisch op naam
            List<ThemaModel> gesorteerdeThemas = themas.OrderBy(t => t.ThemaName).ToList();

            lvThema.Items.Clear(); // Maak de lijst leeg

            // Voeg gesorteerde thema's toe aan de ListView
            foreach (ThemaModel thema in gesorteerdeThemas)
            {
                ListViewItem item = new ListViewItem(thema.ThemaHoofdstuk.ToString());
                item.SubItems.Add(thema.ThemaName);
                lvThema.Items.Add(item);
            }
        }
    }
}

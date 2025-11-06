// Nikodem Bielaga
// 23-03-2025

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oefening62.Model; // Importeren van het model voor de groepen
using Opdracht62.Controller; // Importeren van de controller voor groepsbeheer

namespace Oefening62
{
    public partial class FrmGroupForm : Form
    {
        // Controller voor het beheren van groepen
        private GroupController groupController;
        // Lijst om groepsmodellen op te slaan
        private List<GroupModel> groupModels = new List<GroupModel>();

        // Constructor van het formulier
        public FrmGroupForm()
        {
            InitializeComponent(); // Initialisatie van de UI-componenten
            groupController = new GroupController(); // Initialisatie van de controller
        }

        // Methode die wordt aangeroepen wanneer het formulier wordt geladen
        private void FrmGroupForm_Load(object sender, EventArgs e)
        {
            // Kolommen toevoegen aan de ListView
            lvGroupView.Columns.Add("Groepcode");
            lvGroupView.Columns.Add("Groepjaar");
            lvGroupView.Columns.Add("Mentornaam");

            // De weergave-instelling van de ListView instellen op "Details"
            lvGroupView.View = View.Details;
        }

        // Event-handler voor het toevoegen van een nieuwe groep
        private void btnGroupToevoegen_Click(object sender, EventArgs e)
        {
            // Nieuw groepsobject aanmaken
            GroupModel newGroup = new GroupModel();
            newGroup.GroupCode = tbGroepcode.Text; // Invoerveld voor groepcode
            newGroup.GroupMentorName = tbMentornaam.Text; // Invoerveld voor mentornaam

            // Controle of het ingevoerde jaar een geldig getal is
            if (int.TryParse(tbGroepjaar.Text, out int year))
            {
                newGroup.GroupYear = year;
            }
            else
            {
                // Foutmelding tonen als het jaar ongeldig is
                MessageBox.Show("Voer een geldig jaar in.");
                return;
            }

            // Nieuwe groep opslaan via de controller
            groupController.Create(newGroup);

            // De lijstweergave bijwerken
            UpdateGroupListView();
        }

        // Methode om de ListView bij te werken met de huidige groepen
        private void UpdateGroupListView()
        {
            lvGroupView.Items.Clear(); // Eerst de huidige items verwijderen
            List<GroupModel> groups = groupController.Read(); // Groepen ophalen uit de database of geheugen

            // Controle of er groepen zijn om weer te geven
            if (groups.Count == 0)
            {
                MessageBox.Show("Geen klassen gevonden.");
                return;
            }

            // Door alle groepen loopen en toevoegen aan de ListView
            foreach (var group in groups)
            {
                var item = new ListViewItem(group.GroupCode); // Eerste kolom: Groepcode
                item.SubItems.Add(group.GroupYear.ToString()); // Tweede kolom: Groepjaar
                item.SubItems.Add(group.GroupMentorName); // Derde kolom: Mentornaam
                lvGroupView.Items.Add(item);
            }
        }

        // Event-handler voor het sluiten van het formulier
        private void btnSluiten_Click(object sender, EventArgs e)
        {
            this.Close(); // Formulier sluiten
        }

        // Event-handler voor het handmatig bijwerken van de lijstweergave
        private void btnListView_Click(object sender, EventArgs e)
        {
            UpdateGroupListView(); // Roep de methode aan om de ListView bij te werken
        }
    }
}

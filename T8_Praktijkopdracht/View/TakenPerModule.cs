//Nikodem Bielaga
//14.05.2025
//T8_Praktijkopdacht
// Benodigde namespaces voor forms, data en controller/model toegang
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
    // Windows Form die de taken toont voor een specifiek module
    public partial class TakenPerModule : Form
    {
        // Private variabele om het meegegeven moduleId op te slaan
        private int _moduleId;

        // Constructor van het formulier, ontvangt een moduleId als parameter
        public TakenPerModule(int moduleId)
        {
            InitializeComponent(); // Initialiseert de UI-componenten
            _moduleId = moduleId;  // Slaat het meegegeven moduleId lokaal op
        }

        // Event-handler: wordt automatisch aangeroepen wanneer het formulier geladen wordt
        private void TakenPerModule_Load(object sender, EventArgs e)
        {
            LoadTakenVoorModule(); // Laadt de taken voor de geselecteerde module
        }

        // Methode om de taken van een bepaalde module op te halen en te tonen in de ListView
        private void LoadTakenVoorModule()
        {
            // Leegt de huidige items in de ListView
            lvTakenPerModule.Items.Clear();

            // Stelt de weergave in op Details-weergave (rijen en kolommen)
            lvTakenPerModule.View = System.Windows.Forms.View.Details;
            lvTakenPerModule.FullRowSelect = true; // Maakt het mogelijk om hele rijen te selecteren

            // Voegt kolommen toe aan de ListView, als ze er nog niet zijn
            if (lvTakenPerModule.Columns.Count == 0)
            {
                lvTakenPerModule.Columns.Add("Naam", 200);            // Naam van de taak
                lvTakenPerModule.Columns.Add("Omschrijving", 200);    // Beschrijving van de taak
                lvTakenPerModule.Columns.Add("Startdatum", 200);      // Startdatum
                lvTakenPerModule.Columns.Add("Inleverdatum", 200);    // Deadline
                lvTakenPerModule.Columns.Add("Status", 200);          // Status van de taak
            }

            // Maakt een instantie van de controller aan en haalt taken op voor de huidige module
            TaakController controller = new TaakController();
            List<TaakModule> taken = controller.GetTakenVoorModule(_moduleId);

            // Itereert door de opgehaalde taken en voegt elke taak toe aan de ListView
            foreach (var taak in taken)
            {
                ListViewItem item = new ListViewItem(taak.TaakName); // Eerste kolom: naam
                item.SubItems.Add(taak.TaakOmschrijving);            // Tweede kolom: omschrijving
                item.SubItems.Add(taak.TaakStartdatum.ToShortDateString()); // Derde: startdatum
                item.SubItems.Add(taak.TaakInleverdatum.ToShortDateString()); // Vierde: inleverdatum
                item.SubItems.Add(taak.TaakStatus);                  // Vijfde: status

                lvTakenPerModule.Items.Add(item); // Voeg de taak toe aan de ListView
            }
        }
    }
}

//Nikodem Bielaga
//14.05.2025
//T8_Praktijkopdacht
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Voor het werken met bestanden en paden
using T8_Praktijkopdracht.Controller;
using T8_Praktijkopdracht.Model;

namespace T8_Praktijkopdracht.View
{
    public partial class frmModuleOverview : Form
    {
        // Lijst met alle modules
        private List<ModuleModel> alleModules = new List<ModuleModel>();

        // Constructor van het formulier
        public frmModuleOverview()
        {
            InitializeComponent();
        }

        // Bij het laden van het formulier
        private void frmModuleOverview_Load(object sender, EventArgs e)
        {
            LoadModule(); // Laad de modules in de ListView
        }

        // Methode om modules in de ListView te laden
        private void LoadModule()
        {
            lvModule.Items.Clear(); // Maak de lijst leeg

            // Voeg kolommen toe als ze nog niet bestaan
            if (lvModule.Columns.Count == 0)
            {
                lvModule.View = System.Windows.Forms.View.Details;
                lvModule.FullRowSelect = true;

                lvModule.Columns.Add("Module", 150);
                lvModule.Columns.Add("Thema", 100);
                lvModule.Columns.Add("Docent", 150);
            }

            // Haal modules op via controller
            ModuleController controller = new ModuleController();
            List<ModuleModel> modules = controller.GetModule();

            // Voeg elke module toe aan de ListView
            foreach (ModuleModel module in modules)
            {
                ListViewItem item = new ListViewItem(module.ModuleName);
                item.SubItems.Add(module.ThemaNaam);  // Thema-naam tonen
                item.SubItems.Add(module.DocentNaam); // Docent-naam tonen
                item.Tag = module.ModuleId;           // Bewaar ID als tag

                lvModule.Items.Add(item);
            }
        }

        // Verwijder de geselecteerde module
        private void btnModuleVerwijderen_Click(object sender, EventArgs e)
        {
            if (lvModule.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecteer eerst een module om te verwijderen.", "Waarschuwing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Weet je zeker dat je deze module wilt verwijderen?", "Bevestiging", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ListViewItem selectedItem = lvModule.SelectedItems[0];

                if (selectedItem.Tag == null)
                {
                    MessageBox.Show("Er is geen geldig ID gevonden voor het geselecteerde item.");
                    return;
                }

                int moduleId = (int)selectedItem.Tag;

                ModuleController controller = new ModuleController();
                controller.DeleteModule(moduleId); // Verwijder via controller

                LoadModule(); // Herlaad lijst na verwijderen
            }
        }

        // Toon afbeelding van docent die aan module is gekoppeld
        private void btnFoto_Click(object sender, EventArgs e)
        {
            if (lvModule.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecteer eerst een module om de docentfoto te tonen.");
                return;
            }

            // Haal geselecteerde moduleId op
            int moduleId = (int)lvModule.SelectedItems[0].Tag;

            // Haal module op via controller
            ModuleController controller = new ModuleController();
            ModuleModel module = controller.GetModule().FirstOrDefault(m => m.ModuleId == moduleId);

            if (module == null || string.IsNullOrEmpty(module.Afbeelding))
            {
                MessageBox.Show("Geen afbeelding gevonden voor deze docent.");
                return;
            }

            // Stel het volledige pad samen van de afbeelding
            string imagePath = Path.Combine(Application.StartupPath, "Images", module.Afbeelding);

            if (!File.Exists(imagePath))
            {
                MessageBox.Show("Pad naar afbeelding:\n" + imagePath);
                return;
            }

            // Toon afbeelding in PictureBox met vaste afmetingen
            pbDocentFoto.Image = Image.FromFile(imagePath);
            pbDocentFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDocentFoto.Width = 200;
            pbDocentFoto.Height = 200;
        }

        // Sorteer en filter de lijst op naam van de module
        private void btnModuleFilteren_Click(object sender, EventArgs e)
        {
            ModuleController controller = new ModuleController();
            List<ModuleModel> modules = controller.GetModule();

            // Sorteer modules op ModuleName
            List<ModuleModel> gesorteerdeModules = modules.OrderBy(m => m.ModuleName).ToList();

            lvModule.Items.Clear(); // Maak de lijst leeg

            // Voeg gesorteerde modules opnieuw toe
            foreach (ModuleModel module in gesorteerdeModules)
            {
                ListViewItem item = new ListViewItem(module.ModuleName);
                item.SubItems.Add(module.ThemaNaam);
                item.SubItems.Add(module.DocentNaam);

                lvModule.Items.Add(item);
            }
        }

        // Toon taken die gekoppeld zijn aan een specifieke module
        private void btnTaken_Click(object sender, EventArgs e)
        {
            if (lvModule.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecteer een module om de taken te bekijken.");
                return;
            }

            int moduleId = (int)lvModule.SelectedItems[0].Tag;

            // Open het formulier voor taken per module en geef de moduleId mee
            TakenPerModule takenForm = new TakenPerModule(moduleId);
            takenForm.ShowDialog(); // Blokkerende weergave van het nieuwe formulier
        }
    }
}

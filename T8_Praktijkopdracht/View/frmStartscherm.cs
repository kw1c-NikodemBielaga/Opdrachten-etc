//Nikodem Bielaga
//14.05.2025
//T8_Praktijkopdacht
// Importeer het View-namespace waarin de andere formulieren zich bevinden
using T8_Praktijkopdracht.View;

namespace T8_Praktijkopdracht
{
    public partial class frmStartscherm : Form
    {
        // Constructor: initialiseert het startschermformulier
        public frmStartscherm()
        {
            InitializeComponent();
        }

        // Wordt uitgevoerd wanneer op "Thema" in het menu wordt geklikt
        private void themaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open het formulier voor thema-overzicht
            frmThemaOverview themaOverview = new frmThemaOverview();
            themaOverview.Show(); // Toon het formulier
        }

        // Wordt uitgevoerd wanneer op "Module" in het menu wordt geklikt
        private void moduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open het formulier voor module-overzicht
            frmModuleOverview moduleOverview = new frmModuleOverview();
            moduleOverview.Show(); // Toon het formulier
        }

        // Wordt uitgevoerd wanneer op "Taak" in het menu wordt geklikt
        private void taakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open het formulier voor taak-overzicht
            frmTaakOverview moduleOverview = new frmTaakOverview();
            moduleOverview.Show(); // Toon het formulier
        }

        // Wordt uitgevoerd wanneer op "Exit" in het menu wordt geklikt
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Sluit het startscherm en beëindig de applicatie
            this.Close();
        }

        private void frmStartscherm_Load(object sender, EventArgs e)
        {

        }
    }
}

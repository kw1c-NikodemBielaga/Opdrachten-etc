using T8_VoetbalToernooi.View.Toernooi;

namespace T8_VoetbalToernooi
{
    public partial class Startscherm : Form
    {
        /*
maker akif
datum : 10-06-25
*/
        public Startscherm()
        {
            InitializeComponent();
        }

        private void docentenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form openForm = Application.OpenForms.OfType<View.Docenten>().FirstOrDefault();

            if (openForm == null)
            {
                // Niet open, dus maak en toon het venster
                View.Docenten docent = new View.Docenten();
                docent.Show();
            }
            else
            {
                // Al open, eventueel naar voren brengen
                openForm.BringToFront();
                MessageBox.Show("Dit venster is al open.");
            }

        }

        private void temasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form openForm = Application.OpenForms.OfType<View.TeamsOverzichtView>().FirstOrDefault();

            if (openForm == null)
            {
                // Niet open, dus maak en toon het venster
                View.TeamsOverzichtView docent = new View.TeamsOverzichtView();
                docent.Show();
            }
            else
            {
                // Al open, eventueel naar voren brengen
                openForm.BringToFront();
                MessageBox.Show("Dit venster is al open.");
            }
        }

        private void toernooiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form openForm = Application.OpenForms.OfType<frmToernooi>().FirstOrDefault();

            if (openForm == null)
            {
                // Niet open, dus maak en toon het venster
                frmToernooi toernooiForm = new frmToernooi();
                toernooiForm.Show();
            }
            else
            {
                // Al open, eventueel naar voren brengen
                openForm.BringToFront();
                MessageBox.Show("Dit venster is al open.");
            }
        }

        private void Startscherm_Load(object sender, EventArgs e)
        {

        }
    }
}

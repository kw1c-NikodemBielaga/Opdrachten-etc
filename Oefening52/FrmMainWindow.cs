namespace Oefening52
{
    public partial class FrmMainWindow : Form
    {
        public FrmMainWindow()
        {
            InitializeComponent();
        }

        private void deelnamerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Maak een nieuw instance van FrmPersonAdd en toon het
            FrmPersonAdd personAddForm = new FrmPersonAdd();
            personAddForm.Show(); // Gebruik .Show() om het venster te openen
        }

        private void FrmMainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}

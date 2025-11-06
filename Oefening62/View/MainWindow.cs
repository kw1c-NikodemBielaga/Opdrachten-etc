namespace Oefening62
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void beheerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudentForm studentAddForm = new FrmStudentForm();
            studentAddForm.Show(); // Gebruik .Show() om het venster te openen
        }

        private void beheerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmGroupForm groupAddForm = new FrmGroupForm();
            groupAddForm.Show(); // Gebruik .Show() om het venster te openen
        }

    }
}

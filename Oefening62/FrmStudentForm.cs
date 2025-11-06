// Nikodem Bielaga
// 23-03-2025

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oefening62.Model; // Importeren van het model voor studenten
using Opdracht62.Controller; // Importeren van de controller voor studentenbeheer

namespace Oefening62
{
    public partial class FrmStudentForm : Form
    {
        // Controller voor studentenbeheer
        private StudentController controller;
        // Controller voor groepsbeheer
        private GroupController groupController;
        // Lijst om studentmodellen op te slaan
        private List<StudentModel> StudentModels = new List<StudentModel>();
        // Lijst om groepsmodellen op te slaan
        private List<GroupModel> groupModels = new List<GroupModel>();

        // Constructor van het formulier
        public FrmStudentForm()
        {
            InitializeComponent(); // Initialisatie van UI-componenten
            controller = new StudentController(); // Initialiseer de studentencontroller
            groupController = new GroupController(); // Initialiseer de groepscontroller
        }

        // Methode die wordt aangeroepen wanneer het formulier wordt geladen
        private void FrmStudentForm_Load(object sender, EventArgs e)
        {
            // Kolommen toevoegen aan de ListView voor studenten
            lvLeerlingView.Columns.Add("Leerlingnaam");
            lvLeerlingView.Columns.Add("Leerlinnummer");
            lvLeerlingView.Columns.Add("Telefoon");
            lvLeerlingView.Columns.Add("Klas");

            // Weergave-instelling van de ListView instellen op "Details"
            lvLeerlingView.View = View.Details;

            // Klassen toevoegen aan de combobox (dropdown menu)
            cbKlas.DataSource = groupModels;
            cbKlas.DisplayMember = "Groupcode";
            cbKlas.ValueMember = "GroupYear";

            
            List<StudentModel> StudentModels = controller.Read();  // Lees de studenten uit de controller

            // Door alle studenten loopen en toevoegen aan de ListView
            foreach (var StudentModel in StudentModels)
            {
                var item = new ListViewItem(StudentModel.StudentName); // Eerste kolom: Naam van de student
                item.SubItems.Add(StudentModel.StudentNumber.ToString()); // Tweede kolom: Studentnummer
                item.SubItems.Add(StudentModel.StudentTelephone); // Derde kolom: Telefoonnummer
                item.SubItems.Add(StudentModel.StudentClassCode); // Vierde kolom: Klas
                lvLeerlingView.Items.Add(item);
            }


        }

        // Event-handler voor het toevoegen van een nieuwe student
        private void btnLeerlingToevoegen_Click(object sender, EventArgs e)
        {
            // Nieuw StudentModel-object aanmaken
            StudentModel newStudent = new StudentModel();
            newStudent.StudentName = tbLeerlingnaam.Text; // Naam van de student invullen

            // Controle of het ingevoerde leerlingnummer een geldig getal is
            if (int.TryParse(tbLeerlingnummer.Text, out int studentNumber))
            {
                newStudent.StudentNumber = studentNumber;
            }
            else
            {
                // Foutmelding tonen als het leerlingnummer ongeldig is
                MessageBox.Show("Please enter a valid number for the student number.");
                return;
            }

            // Telefoonnummer en klascode invullen
            newStudent.StudentTelephone = tbTelephone.Text;
            newStudent.StudentClassCode = cbKlas.SelectedItem?.ToString(); // Haal de geselecteerde klas op

            // Voeg de student toe via de controller
            controller.Create(newStudent);

            // Werk de ListView bij met de nieuwe student
            UpdateStudentListView();
        }

        // Methode om de ListView bij te werken met de huidige studenten
        private void UpdateStudentListView()
        {
            lvLeerlingView.Items.Clear(); // Verwijder alle bestaande items
            List<StudentModel> StudentModels = controller.Read();

        }

        // Event-handler voor het handmatig bijwerken van de lijstweergave
        private void btnListView_Click(object sender, EventArgs e)
        {
            UpdateStudentListView();  // Roep de methode aan om de ListView bij te werken
        }

        // Event-handler voor het sluiten van het formulier
        private void btnSluiten_Click(object sender, EventArgs e)
        {
            this.Close(); // Formulier sluiten
        }
    }
}

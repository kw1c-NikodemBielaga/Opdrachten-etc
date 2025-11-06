//Nikodem Bielaga
// 14-04-2025
//Oefening23
using DrWho.Controller;
using DrWho.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DrWho.View
{
    public partial class frmDoctorOverview : Form
    {
        private object selectedScore;

        private void FillListView()
        {
            DoctorController doctorController = new DoctorController();
            List<DoctorModel> doctorList = doctorController.ReadAll();
            lvDoctors.Items.Clear();
            foreach (DoctorModel doctor in doctorList)
            {
                ListViewItem lvItem = new ListViewItem(doctor.DoctorNumber.ToString());
                lvItem.SubItems.Add(doctor.DoctorName);
                lvItem.SubItems.Add(doctor.BirthDate.ToString("dd-MM-yyyy"));
                lvItem.SubItems.Add(doctor.FirstEpisodeDate.ToString("dd-MM-yyyy"));
                lvItem.SubItems.Add(doctor.LastEpisodeDate.ToString("dd-MM-yyyy"));
                lvItem.Tag = doctor;

                lvDoctors.Items.Add(lvItem);
            }
        }

        public frmDoctorOverview()
        {
            InitializeComponent();
        }

        private void frmDoctorOverview_Load(object sender, EventArgs e)
        {
            lvDoctors.Columns.Add("Number");
            lvDoctors.Columns.Add("Name");
            lvDoctors.Columns.Add("Birth date");
            lvDoctors.Columns.Add("First episode date");
            lvDoctors.Columns.Add("Lasat episode date");

            lvDoctors.FullRowSelect = true;
            lvDoctors.View = System.Windows.Forms.View.Details;
            lvDoctors.HeaderStyle = ColumnHeaderStyle.Clickable;

            FillListView();
        }

        // Methode die wordt aangeroepen wanneer de 'Bewerken' knop wordt geklikt
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Controleer of er een item in de ListView is geselecteerd
            if (lvDoctors.SelectedItems.Count == 0)
            {
                // Als er geen arts geselecteerd is, toon een waarschuwingsbericht
                MessageBox.Show("Selecteer een doctor om te bewerken.", "Let op", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop de methode als er geen arts is geselecteerd
            }

            // Haal het geselecteerde item uit de ListView
            ListViewItem selectedItem = lvDoctors.SelectedItems[0];

            // Haal het DoctorModel object op dat aan dit item is gekoppeld (via Tag)
            DoctorModel selectedDoctor = (DoctorModel)selectedItem.Tag;

            // Maak een nieuw formulier voor het bewerken van de arts, en geef het geselecteerde arts-object door
            frmDoctorEdit editForm = new frmDoctorEdit(selectedDoctor);

            // Toon het formulier en wacht op de gebruiker om het op te slaan of te annuleren
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // Als de gebruiker op OK heeft geklikt (na opslaan), vul de ListView opnieuw in om de wijzigingen te tonen
                FillListView();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvDoctors.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecteer een doctor om te verwijderen.", "Let op", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selectedItem = lvDoctors.SelectedItems[0];
            DoctorModel selectedDoctor = (DoctorModel)selectedItem.Tag;

            DialogResult confirm = MessageBox.Show(
                $"Weet je zeker dat je Dr. {selectedDoctor.DoctorName} wilt verwijderen?",
                "Bevestigen",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    DoctorController doctorController = new DoctorController();
                    bool success = doctorController.Delete(selectedDoctor);

                    if (success)
                    {
                        MessageBox.Show("Doctor succesvol verwijderd.");
                        FillListView();
                    }
                    else
                    {
                        MessageBox.Show("Verwijderen mislukt. Probeer opnieuw.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Er is een fout opgetreden tijdens het verwijderen: " + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
    }
}

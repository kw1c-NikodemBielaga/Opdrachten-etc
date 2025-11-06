//Nikodem Bielaga
// 14-04-2025
//Oefening23
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrWho.Controller;
using DrWho.Model;

namespace DrWho.View
{
    // Klasse voor het bewerken van artsgegevens
    public partial class frmDoctorEdit : Form
    {
        // Variabele voor de arts die wordt bewerkt
        private DoctorModel doctor;

        // Constructor die het artsobject ontvangt dat moet worden bewerkt
        public frmDoctorEdit(DoctorModel doctorToEdit)
        {
            InitializeComponent();  // Initialiseer de componenten van het formulier
            doctor = doctorToEdit;  // Sla het te bewerken artsobject op

            // Vul de velden in het formulier met de gegevens van de arts
            txtDoctorNumber.Text = doctor.DoctorNumber.ToString();
            txtName.Text = doctor.DoctorName;
            dtpBirthDate.Value = doctor.BirthDate == DateTime.MinValue ? DateTime.Now : doctor.BirthDate;
            dtpFirstEpisode.Value = doctor.FirstEpisodeDate == DateTime.MinValue ? DateTime.Now : doctor.FirstEpisodeDate;
            dtpLastEpisode.Value = doctor.LastEpisodeDate == DateTime.MinValue ? DateTime.Now : doctor.LastEpisodeDate;

            // Het artsnummer kan niet bewerkt worden, dus zet het als alleen-lezen
            txtDoctorNumber.Enabled = false;
        }

        // Methode die wordt aangeroepen wanneer de 'Opslaan' knop wordt geklikt
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Werk de velden van het artsobject bij met de nieuwe waarden
                doctor.DoctorName = txtName.Text;
                doctor.BirthDate = dtpBirthDate.Value;
                doctor.FirstEpisodeDate = dtpFirstEpisode.Value;
                doctor.LastEpisodeDate = dtpLastEpisode.Value;

                // Maak een controller voor de arts en voer de update uit
                DoctorController controller = new DoctorController();
                int result = controller.Update(doctor);

                // Als er wijzigingen zijn doorgevoerd (result > 0), geef een succesmelding weer
                if (result > 0)
                {
                    MessageBox.Show("Doctor succesvol bijgewerkt.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Zet de dialoogresultaat naar OK om het formulier te sluiten
                }
                else
                {
                    // Als er geen wijzigingen zijn doorgevoerd, toon een melding
                    MessageBox.Show("Geen wijzigingen doorgevoerd.", "Melding", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Als er een fout optreedt, toon een foutmelding met de foutdetails
                MessageBox.Show("Fout bij opslaan: " + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Methode die wordt aangeroepen wanneer de 'Annuleren' knop wordt geklikt
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Sluit het formulier zonder iets op te slaan
            this.Close();
        }

        private void frmDoctorEdit_Load(object sender, EventArgs e)
        {

        }
    }
}

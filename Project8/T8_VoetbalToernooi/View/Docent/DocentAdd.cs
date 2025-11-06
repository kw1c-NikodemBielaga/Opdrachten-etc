//Nikodem 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T8_VoetbalToernooi.Controller;
using T8_VoetbalToernooi.Model;

namespace T8_VoetbalToernooi.View.Docent
{
    public partial class DocentAdd : Form
    {
        /*
      maker akif
      datum : 10-06-25
   */
        public DocentAdd()
        {
            InitializeComponent();
        }
        private Docenten _parentForm;

        public DocentAdd(Docenten parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }



        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            DocentModel model = new DocentModel();
            DocentController controller = new DocentController();
            if (string.IsNullOrWhiteSpace(tbName.Text) ||
               string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("Alle velden moeten worden ingevuld.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DocentModel Docent = new DocentModel
            {
                Naam = tbName.Text,
                Email = tbEmail.Text,
                Rol = "Admin",
            };

            if (controller.BestaatDocent(Docent.Naam, Docent.Email))
            {
                MessageBox.Show("Deze gebruikersnaam of Email bestaat al.");
                return;
            }

            // Probeer de docent toe te voegen
            int result = controller.Create(Docent);

            if (result == 1)
            {
                MessageBox.Show($"Docent {Docent.Naam} is toegevoegd");
                _parentForm.FillDocentList(); // Ververs overzicht
                this.Close(); // Sluit het venster
            }
            else
            {
                MessageBox.Show("Er is iets mis gegaan bij het toevoegen");
            }


        }

    }
}

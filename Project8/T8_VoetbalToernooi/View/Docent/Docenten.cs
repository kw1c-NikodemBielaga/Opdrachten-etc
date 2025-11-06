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
using T8_VoetbalToernooi.View.Docent;

namespace T8_VoetbalToernooi.View
{
    public partial class Docenten : Form
    {
        /*
maker akif
datum : 10-06-25
*/
        DocentController controller = new DocentController();
        public Docenten()
        {
            InitializeComponent();
        }


        private void Docenten_Load(object sender, EventArgs e)
        {
            lvDocenten.Items.Clear();
            lvDocenten.Columns.Clear();

            lvDocenten.View = System.Windows.Forms.View.Details;


            lvDocenten.FullRowSelect = true;

            lvDocenten.Columns.Add("Naam");
            lvDocenten.Columns.Add("Email");

            FillDocentList();
        }

        public void FillDocentList()
        {
            lvDocenten.Items.Clear(); // Zorg dat dit helemaal bovenaan staat
            List<DocentModel> docenten = controller.Read();

            foreach (DocentModel docent in docenten)
            {
                ListViewItem item = new ListViewItem(docent.Naam);
                item.SubItems.Add(docent.Email);
                item.Tag = docent;
                lvDocenten.Items.Add(item);
            }

            lvDocenten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }


        private void btBack_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Form openForm = Application.OpenForms.OfType<DocentAdd>().FirstOrDefault();

            if (openForm == null)
            {
                // Niet open, dus maak en toon het venster
                DocentAdd docent = new DocentAdd(this);
                docent.Show();
            }
            else
            {
                // Al open, eventueel naar voren brengen
                openForm.BringToFront();
                MessageBox.Show("Dit venster is al open.");

            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lvDocenten.SelectedItems.Count > 0)
            {
                // Docent ophalen uit tag attribuut
                DocentModel taak = (DocentModel)lvDocenten.SelectedItems[0].Tag;

                // Delete methode aanroepen met docentId (int)
                if (controller.Delete(taak.DocentId) == 1)
                {
                    MessageBox.Show($"Docent {taak.Naam} is verwijderd");
                }
                else
                {
                    MessageBox.Show("Er is iets mis gegaan bij het verwijderen");
                }

                FillDocentList();
            }
        }
    }
}

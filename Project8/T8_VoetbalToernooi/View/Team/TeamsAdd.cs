using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T8_VoetbalToernooi.Controller;
using T8_VoetbalToernooi.Model;

namespace T8_VoetbalToernooi.View.Team
{
    
    public partial class TeamsAdd : Form
    {        /*
      maker akif
      datum : 10-06-25
   */
        TeamController controller = new TeamController();
        public TeamsAdd()
        {
            InitializeComponent();
        }
        private TeamsOverzichtView _parentForm;

        public TeamsAdd(TeamsOverzichtView parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void TeamsAdd_Load(object sender, EventArgs e)
        {

            List<DocentModel> docenten = controller.ReadDocent();
            if (docenten == null) {
                cbdocent.Items.Add("voeg een docent toe");
            }
            else { 
                foreach (DocentModel docent in docenten)
                {
                    //cbdocent.Items.Add(docent.Naam);
                    cbdocent.Items.Add(docent);
                } 
            }

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (cbdocent.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een docent.");
                return;
            }

            //MessageBox.Show((DocentModel)cbdocent.SelectedItem.ToString());
            DocentModel geselecteerdeDocent = (DocentModel)cbdocent.SelectedItem;

            TeamModel nieuwTeam = new TeamModel
            {
                Name = tbName.Text,
                Score = 0, 
                Docent = geselecteerdeDocent
            };

            controller.Create(nieuwTeam);

            _parentForm.FillListView(); // Ververs overzicht
            this.Close();

        }
    }
}

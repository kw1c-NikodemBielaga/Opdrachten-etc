using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T8_VoetbalToernooi.Controller;
using T8_VoetbalToernooi.Model;
using T8_VoetbalToernooi.View.Docent;
using T8_VoetbalToernooi.View.Team;

namespace T8_VoetbalToernooi.View
{
    public partial class TeamsOverzichtView : Form
    {
        /*
maker akif
datum : 10-06-25
*/
        private TeamController teamController = new TeamController();

        public TeamsOverzichtView()
        {
            InitializeComponent();
        }

        private void Teams_Load(object sender, EventArgs e)
        {
            lvTeams.Items.Clear();
            lvTeams.Columns.Clear();

            lvTeams.View = System.Windows.Forms.View.Details;


            lvTeams.FullRowSelect = true;

            FillListView();
            lvTeams.Columns.Add("Name");
            lvTeams.Columns.Add("Docent");
            lvTeams.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            FillListView();
        }
        public void FillListView()
        {

            lvTeams.Items.Clear(); // Zorg dat dit helemaal bovenaan staat
            List<TeamModel> teams = teamController.Read();

            foreach (TeamModel team in teams)
            {
                ListViewItem item = new ListViewItem(team.Name);
                item.SubItems.Add(team.Docent.Naam);
                lvTeams.Items.Add(item);

            }

        }

        



        private void btAdd_Click_1(object sender, EventArgs e)
        {
            Form openForm = Application.OpenForms.OfType<TeamsAdd>().FirstOrDefault();

            if (openForm == null)
            {
                TeamsAdd team = new TeamsAdd(this);
                team.Show();
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
            if (lvTeams.SelectedItems.Count > 0)
            {
                // student ophalen uit tag attribut
                TeamModel team = (TeamModel)lvTeams.SelectedItems[0].Tag;
                if (teamController.Delete(team) == 1)
                {
                    MessageBox.Show($"Team {team.Name} is verwijderd");
                }
                else
                {
                    MessageBox.Show("Er is iets mis gegaan bij het verwijderen");
                }
                FillListView();
            }
        }

        private void btTerug_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

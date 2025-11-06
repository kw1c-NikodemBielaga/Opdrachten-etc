using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrWho.Controller;
using DrWho.Model;
using Microsoft.VisualBasic;

namespace Oefening31.View
{
    public partial class frmEpisodeEdit : Form
    {

        private EpisodeModel episode;

        public frmEpisodeEdit(EpisodeModel episodeToEdit)
        {
            InitializeComponent();
            episode = episodeToEdit;

            txtTitle.Text = episode.Title;
            txtSeriesNumber.Text = episode.SeriesNumber.ToString();
            txtEpisodeNumber.Text = episode.EpisodeNumber.ToString();
            dtpEpisodeDate.Value = episode.EpisodeDate;

            // Vul AuthorName en DoctorName in als die bestaan
            txtAuthorName.Text = episode.Autor?.AuthorName ?? "Onbekend";
            txtDoctorName.Text = episode.Doctor?.DoctorName ?? "Onbekend";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                episode.Title = txtTitle.Text;
                episode.SeriesNumber = int.Parse(txtSeriesNumber.Text);
                episode.EpisodeNumber = int.Parse(txtEpisodeNumber.Text);
                episode.EpisodeDate = dtpEpisodeDate.Value;

                // AuthorName en DoctorName worden niet aangepast hier tenzij je dat expliciet wil
                // Als je ook de naam wilt aanpassen, voeg dan deze regels toe:
                episode.Autor.AuthorName = txtAuthorName.Text;
                episode.Doctor.DoctorName = txtDoctorName.Text;

                EpisodeController controller = new EpisodeController();
                int result = controller.Update(episode);

                if (result > 0)
                    DialogResult = DialogResult.OK;
                else
                    MessageBox.Show("Bijwerken mislukt.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fout bij opslaan: " + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

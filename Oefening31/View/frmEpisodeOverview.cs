//Nikodem Bielaga
// 14-04-2025
//Oefening32
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
using Oefening31.View;

namespace DrWho.View
{
    public partial class frmEpisodeOverview : Form
    {
        public frmEpisodeOverview()
        {
            InitializeComponent();
        }
        private void frmEpisodeOverview_Load(object sender, EventArgs e)
        { // Kolommen instellen
            lvEpisode.Columns.Add("SeriesNumber", 120);
            lvEpisode.Columns.Add("EpisodeNumber", 120);
            lvEpisode.Columns.Add("Title", 150);
            lvEpisode.Columns.Add("EpisodeDate", 120);
            lvEpisode.Columns.Add("AuthorName", 150);
            lvEpisode.Columns.Add("DoctorName", 150);

            lvEpisode.FullRowSelect = true;
            lvEpisode.View = System.Windows.Forms.View.Details;
            lvEpisode.HeaderStyle = ColumnHeaderStyle.Clickable;

            FillListView();
        }
        private void FillListView()
        {
            EpisodeController episodeController = new EpisodeController();
            List<EpisodeModel> episodeList = episodeController.ReadAll();

            lvEpisode.Items.Clear();

            foreach (EpisodeModel episodeItem in episodeList)
            {
                if (episodeItem == null) continue;

                ListViewItem item = new ListViewItem(episodeItem.SeriesNumber.ToString());
                item.SubItems.Add(episodeItem.EpisodeNumber.ToString());
                item.SubItems.Add(episodeItem.Title ?? "");
                item.SubItems.Add(episodeItem.EpisodeDate.ToString("dd-MM-yyyy"));
                item.SubItems.Add(episodeItem.Autor?.AuthorName ?? "");
                item.SubItems.Add(episodeItem.Doctor?.DoctorName ?? "");

                item.Tag = episodeItem;
                lvEpisode.Items.Add(item);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvEpisode.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecteer eerst een episode om te bewerken.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EpisodeModel selectedEpisode = (EpisodeModel)lvEpisode.SelectedItems[0].Tag;

            frmEpisodeEdit editForm = new frmEpisodeEdit(selectedEpisode);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                FillListView(); // Herlaad lijst om wijzigingen te tonen
            }
        }
    }
}

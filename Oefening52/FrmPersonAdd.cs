using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening52
{
    public partial class FrmPersonAdd : Form
    {
        public FrmPersonAdd()
        {
            InitializeComponent();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            lbVoornaam.Text = tbVoornaam.Text;
            lbAchternaam.Text = tbAchternaam.Text;
            lbWoonplaats.Text = tbWoonplaats.Text;
            lbGeboortedatum.Text = dtpGeboortedatum.Value.ToString();
            lbInschrijfdatum.Text = dtpInschrijfdatum.Value.ToString();
            lbGeslacht.Text = cbGeslacht.SelectedItem?.ToString();
            lbOpmerking.Text = rtbOpmerking.Text;
        }

        private void FrmPersonAdd_Load(object sender, EventArgs e)
        {
            cbGeslacht.Items.Add("Men");
            cbGeslacht.Items.Add("Vrouw");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbVoornaam.Clear();
            tbAchternaam.Clear();
            tbWoonplaats.Clear();
            dtpGeboortedatum.Value = DateTime.Now;
            dtpInschrijfdatum.Value = DateTime.Now;
            cbGeslacht.SelectedIndex = -1;
            rtbOpmerking.Clear();


            lbVoornaam.Text = "Label 9";
            lbAchternaam.Text = "Label 10";
            lbWoonplaats.Text = "Label 10";
            lbGeboortedatum.Text = "Label 11";
            lbInschrijfdatum.Text = "Label 12";
            lbGeslacht.Text = "Label 13";
            lbOpmerking.Text = "Label 14";
        }
    }
}

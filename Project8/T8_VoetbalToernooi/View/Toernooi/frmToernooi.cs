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
using T8_VoetbalToernooi.View;


namespace T8_VoetbalToernooi.View.Toernooi
{
    public partial class frmToernooi : Form
    {
        private ToernooiController _controller;
        private Dictionary<string, int> labelNaarWedstrijdIndex;
        private Dictionary<int, Label> wedstrijdNaarWinnaarLabel;
        private Dictionary<int, int> labelNummerNaarWedstrijdIndex;
        private Dictionary<int, (int, int)> knockoutSchema;

        public frmToernooi()
        {
            /*
maker niek van der Heijden
datum : 10-06-25
*/
            InitializeComponent();

            var model = new ToernooiModel();
            _controller = new ToernooiController(model);

            labelNaarWedstrijdIndex = new Dictionary<string, int>();
            labelNummerNaarWedstrijdIndex = new Dictionary<int, int>();
            wedstrijdNaarWinnaarLabel = new Dictionary<int, Label>();

            // Init eerste 32 teams (labels 1 t/m 32)
            string[] teams = new string[]
            {
                label1.Text, label2.Text, label3.Text, label4.Text,
                label5.Text, label6.Text, label7.Text, label8.Text,
                label9.Text, label10.Text, label11.Text, label12.Text,
                label13.Text, label14.Text, label15.Text, label16.Text,
                label17.Text, label18.Text, label19.Text, label20.Text,
                label21.Text, label22.Text, label23.Text, label24.Text,
                label25.Text, label26.Text, label27.Text, label28.Text,
                label29.Text, label30.Text, label31.Text, label32.Text
            };

            // Voeg eerste ronde wedstrijden toe (16 wedstrijden, indices 0-15)
            for (int i = 0; i < teams.Length; i += 2)
            {
                _controller.VoegWedstrijdToe(teams[i], teams[i + 1]);
            }

            // Koppel labels 1 t/m 32 aan hun wedstrijdindex
            // Label 1&2 = wedstrijd 0, Label 3&4 = wedstrijd 1, etc.
            for (int i = 1; i <= 32; i++)
            {
                labelNaarWedstrijdIndex["label" + i] = (i - 1) / 2;
            }

            // Labels 33 t/m 48 zijn eerste knock-out ronde labels
            for (int i = 33; i <= 48; i++)
            {
                var lbl = Controls.Find("label" + i, true).FirstOrDefault() as Label;
                if (lbl != null)
                {
                    // Map label 33 naar wedstrijd 0, label 34 naar wedstrijd 1, etc.
                    wedstrijdNaarWinnaarLabel[i - 33] = lbl;
                }
            }

            // Voeg click event toe aan labels 1 t/m 62
            for (int i = 1; i <= 62; i++)
            {
                var lbl = Controls.Find("label" + i, true).FirstOrDefault() as Label;
                if (lbl != null)
                    lbl.Click += Label_Click;
            }

            InitKnockoutSchema();
            UpdateKnockoutLabels();
        }

        private void InitKnockoutSchema()
        {
            knockoutSchema = new Dictionary<int, (int, int)>
            {
                // Eerste knock-out ronde (Labels 33-48)
                // Deze labels tonen de winnaars van de eerste ronde wedstrijden
                // Label 33 = winnaar wedstrijd 0, Label 34 = winnaar wedstrijd 1, etc.
                
                // Tweede ronde (Labels 49-56) - deze spelen tegen elkaar
                { 49, (33, 34) }, // Winnaar label 33 vs Winnaar label 34
                { 50, (35, 36) }, // Winnaar label 35 vs Winnaar label 36
                { 51, (37, 38) }, // Winnaar label 37 vs Winnaar label 38
                { 52, (39, 40) }, // Winnaar label 39 vs Winnaar label 40
                { 53, (41, 42) }, // Winnaar label 41 vs Winnaar label 42
                { 54, (43, 44) }, // Winnaar label 43 vs Winnaar label 44
                { 55, (45, 46) }, // Winnaar label 45 vs Winnaar label 46
                { 56, (47, 48) }, // Winnaar label 47 vs Winnaar label 48

                // Derde ronde (Labels 57-60) - Kwartfinales
                { 57, (49, 50) }, // Winnaar label 49 vs Winnaar label 50
                { 58, (51, 52) }, // Winnaar label 51 vs Winnaar label 52
                { 59, (53, 54) }, // Winnaar label 53 vs Winnaar label 54
                { 60, (55, 56) }, // Winnaar label 55 vs Winnaar label 56

                // Vierde ronde (Labels 61-62) - Halve finales
                { 61, (57, 58) }, // Winnaar label 57 vs Winnaar label 58
                { 62, (59, 60) }  // Winnaar label 59 vs Winnaar label 60
            };
        }

        private void Label_Click(object sender, EventArgs e)
        {
            if (sender is Label lbl)
            {
                int labelNummer = int.Parse(lbl.Name.Replace("label", ""));

                // Eerste ronde
                if (labelNaarWedstrijdIndex.TryGetValue(lbl.Name, out int index))
                {
                    SpeelEnToonWedstrijd(index, lbl);
                    return;
                }

                // Finale-logica: als je op label 61 of 62 klikt, en beide gevuld zijn, speel de finale
                if (labelNummer == 61 || labelNummer == 62)
                {
                    string team1 = GetWinnaarVanLabel(61);
                    string team2 = GetWinnaarVanLabel(62);

                    if (!string.IsNullOrEmpty(team1) && !team1.Contains("(") &&
                        !string.IsNullOrEmpty(team2) && !team2.Contains("("))
                    {
                        // Finale spelen
                        int finaleIndex;
                        if (!labelNummerNaarWedstrijdIndex.ContainsKey(999)) // 999 = fictief index voor finale
                        {
                            finaleIndex = _controller.VoegUniekeWedstrijdToe(team1, team2);
                            labelNummerNaarWedstrijdIndex[999] = finaleIndex;
                        }
                        else
                        {
                            finaleIndex = labelNummerNaarWedstrijdIndex[999];
                        }

                        var finale = _controller.SpeelWedstrijdMetScore(finaleIndex);

                        MessageBox.Show($"🏆 FINALE 🏆\n{team1} {finale.ScoreTeam1} - {finale.ScoreTeam2} {team2}\n\nWINNAAR: {finale.Winnaar.Name}",
                            "Toernooiwinnaar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Beide halve finales moeten eerst gespeeld worden.", "Finale niet beschikbaar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Normale knock-out klikverwerking
                foreach (var kvp in knockoutSchema)
                {
                    int doelLabelNummer = kvp.Key;
                    int input1 = kvp.Value.Item1;
                    int input2 = kvp.Value.Item2;

                    if (labelNummer == input1 || labelNummer == input2)
                    {
                        var doelLabel = Controls.Find("label" + doelLabelNummer, true).FirstOrDefault() as Label;
                        if (doelLabel != null)
                        {
                            SpeelKnockoutWedstrijd(doelLabelNummer, doelLabel);
                            return;
                        }
                    }
                }

                MessageBox.Show("Dit label is geen geldige invoer voor een volgende ronde.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SpeelKnockoutWedstrijd(int labelNummer, Label lbl)
        {
            if (knockoutSchema.TryGetValue(labelNummer, out var labelPaar))
            {
                int label1 = labelPaar.Item1;
                int label2 = labelPaar.Item2;

                // Haal de team namen op van de winnaar labels
                string team1 = GetWinnaarVanLabel(label1);
                string team2 = GetWinnaarVanLabel(label2);

                // Debug: Toon welke labels we proberen te lezen
                System.Diagnostics.Debug.WriteLine($"Label {labelNummer}: Probeer team1 van label {label1} = '{team1}', team2 van label {label2} = '{team2}'");

                // Controleer of beide teams beschikbaar zijn
                if (!string.IsNullOrEmpty(team1) && !team1.Contains("(") &&
                    !string.IsNullOrEmpty(team2) && !team2.Contains("("))
                {
                    // Maak nieuwe wedstrijd aan als deze nog niet bestaat
                    if (!labelNummerNaarWedstrijdIndex.ContainsKey(labelNummer))
                    {
                        int nieuweIndex = _controller.VoegUniekeWedstrijdToe(team1, team2);
                        labelNummerNaarWedstrijdIndex[labelNummer] = nieuweIndex;
                    }

                    int wedstrijdIndex = labelNummerNaarWedstrijdIndex[labelNummer];
                    var wedstrijd = _controller.SpeelWedstrijdMetScore(wedstrijdIndex);

                    // Toon uitslag in MessageBox
                    string uitslag = $"{team1} {wedstrijd.ScoreTeam1} - {wedstrijd.ScoreTeam2} {team2}\nWinnaar: {wedstrijd.Winnaar.Name}";
                    MessageBox.Show(uitslag, $"Uitslag {GetRondeNaam(labelNummer)}", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Update het label met de winnaar
                    lbl.Text = wedstrijd.Winnaar.Name;

                    // Update alle knockout labels voor volgende rondes
                    UpdateKnockoutLabels();
                }
                else
                {
                    MessageBox.Show($"Beide teams moeten eerst beschikbaar zijn.\nTeam 1 (label {label1}): {team1}\nTeam 2 (label {label2}): {team2}", "Let op", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void SpeelEnToonWedstrijd(int index, Label doelLabel)
        {
            var wedstrijd = _controller.SpeelWedstrijdMetScore(index);

            string team1 = wedstrijd.Team1.Name;
            string team2 = wedstrijd.Team2.Name;
            int score1 = wedstrijd.ScoreTeam1;
            int score2 = wedstrijd.ScoreTeam2;
            string winnaar = wedstrijd.Winnaar.Name;

            string uitslag = $"{team1} {score1} - {score2} {team2}\nWinnaar: {winnaar}";
            MessageBox.Show(uitslag, "Eerste Ronde", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Update het corresponderende winnaar label (33-48)
            if (wedstrijdNaarWinnaarLabel.TryGetValue(index, out Label winnaarLabel))
            {
                winnaarLabel.Text = winnaar;
            }

            UpdateKnockoutLabels();
        }

        private void UpdateKnockoutLabels()
        {
            foreach (var pair in knockoutSchema)
            {
                int labelNummer = pair.Key;
                int label1 = pair.Value.Item1;
                int label2 = pair.Value.Item2;

                string team1 = GetWinnaarVanLabel(label1);
                string team2 = GetWinnaarVanLabel(label2);

                // Check of beide teams beschikbaar zijn
                if (!string.IsNullOrEmpty(team1) && !team1.Contains("(") &&
                    !string.IsNullOrEmpty(team2) && !team2.Contains("("))
                {
                    var lbl = Controls.Find("label" + labelNummer, true).FirstOrDefault() as Label;
                    if (lbl != null)
                    {
                        // Alleen updaten als het label nog leeg is of nog de vs tekst heeft
                        if (string.IsNullOrWhiteSpace(lbl.Text) || lbl.Text.Contains("vs"))
                        {
                            lbl.Text = $"{team1} vs {team2}";
                        }
                    }
                }
            }
        }

        private string GetWinnaarVanLabel(int labelNummer)
        {
            var lbl = Controls.Find("label" + labelNummer, true).FirstOrDefault() as Label;
            if (lbl != null && !string.IsNullOrWhiteSpace(lbl.Text))
            {
                // Als het label geen "vs" bevat, dan is het een winnaar naam
                if (!lbl.Text.Contains("vs"))
                {
                    return lbl.Text;
                }
            }
            return $"(Winnaar label {labelNummer})";
        }

        private string GetRondeNaam(int labelNummer)
        {
            if (labelNummer >= 49 && labelNummer <= 56) return "Tweede Ronde";
            if (labelNummer >= 57 && labelNummer <= 60) return "Kwartfinale";
            if (labelNummer >= 61 && labelNummer <= 62) return "Halve Finale";
            return "Onbekend";
        }

        // Oude methode voor backwards compatibility
        private string GetTeamNaamOfGroep(int index)
        {
            if (_controller.IsWedstrijdGespeeld(index))
            {
                return _controller.GetWinnaar(index);
            }
            return $"(Winnaar van wedstrijd {index})";
        }

        private void frmToernooi_Load(object sender, EventArgs e)
        {

        }
    }
}


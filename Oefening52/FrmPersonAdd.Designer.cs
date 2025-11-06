namespace Oefening52
{
    partial class FrmPersonAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            btnOpslaan = new Button();
            rtbOpmerking = new RichTextBox();
            cbGeslacht = new ComboBox();
            dtpInschrijfdatum = new DateTimePicker();
            dtpGeboortedatum = new DateTimePicker();
            tbWoonplaats = new TextBox();
            tbAchternaam = new TextBox();
            tbVoornaam = new TextBox();
            groupBox2 = new GroupBox();
            btnReset = new Button();
            lbWoonplaats = new Label();
            lbOpmerking = new Label();
            lbGeslacht = new Label();
            lbInschrijfdatum = new Label();
            lbVoornaam = new Label();
            lbAchternaam = new Label();
            lbGeboortedatum = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 78);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Voornaam";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 111);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 1;
            label2.Text = "Achternaam";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 144);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 2;
            label3.Text = "Woonplaats";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 179);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 3;
            label4.Text = "Gebortedatum";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 212);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 4;
            label5.Text = "Inschrijfdatum";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 243);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 5;
            label6.Text = "Geslacht";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 274);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 6;
            label7.Text = "Opmerking";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnOpslaan);
            groupBox1.Controls.Add(rtbOpmerking);
            groupBox1.Controls.Add(cbGeslacht);
            groupBox1.Controls.Add(dtpInschrijfdatum);
            groupBox1.Controls.Add(dtpGeboortedatum);
            groupBox1.Controls.Add(tbWoonplaats);
            groupBox1.Controls.Add(tbAchternaam);
            groupBox1.Controls.Add(tbVoornaam);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(3, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(422, 437);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnOpslaan
            // 
            btnOpslaan.Location = new Point(19, 402);
            btnOpslaan.Name = "btnOpslaan";
            btnOpslaan.Size = new Size(94, 29);
            btnOpslaan.TabIndex = 14;
            btnOpslaan.Text = "Opslaan";
            btnOpslaan.UseVisualStyleBackColor = true;
            btnOpslaan.Click += btnOpslaan_Click;
            // 
            // rtbOpmerking
            // 
            rtbOpmerking.Location = new Point(125, 283);
            rtbOpmerking.Name = "rtbOpmerking";
            rtbOpmerking.Size = new Size(250, 119);
            rtbOpmerking.TabIndex = 13;
            rtbOpmerking.Text = "";
            // 
            // cbGeslacht
            // 
            cbGeslacht.FormattingEnabled = true;
            cbGeslacht.Location = new Point(125, 240);
            cbGeslacht.Name = "cbGeslacht";
            cbGeslacht.Size = new Size(218, 28);
            cbGeslacht.TabIndex = 12;
            // 
            // dtpInschrijfdatum
            // 
            dtpInschrijfdatum.Location = new Point(124, 207);
            dtpInschrijfdatum.Name = "dtpInschrijfdatum";
            dtpInschrijfdatum.Size = new Size(265, 27);
            dtpInschrijfdatum.TabIndex = 11;
            // 
            // dtpGeboortedatum
            // 
            dtpGeboortedatum.Location = new Point(124, 174);
            dtpGeboortedatum.Name = "dtpGeboortedatum";
            dtpGeboortedatum.Size = new Size(265, 27);
            dtpGeboortedatum.TabIndex = 10;
            // 
            // tbWoonplaats
            // 
            tbWoonplaats.Location = new Point(125, 141);
            tbWoonplaats.Name = "tbWoonplaats";
            tbWoonplaats.Size = new Size(218, 27);
            tbWoonplaats.TabIndex = 9;
            // 
            // tbAchternaam
            // 
            tbAchternaam.Location = new Point(125, 108);
            tbAchternaam.Name = "tbAchternaam";
            tbAchternaam.Size = new Size(218, 27);
            tbAchternaam.TabIndex = 8;
            // 
            // tbVoornaam
            // 
            tbVoornaam.Location = new Point(125, 75);
            tbVoornaam.Name = "tbVoornaam";
            tbVoornaam.Size = new Size(125, 27);
            tbVoornaam.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnReset);
            groupBox2.Controls.Add(lbWoonplaats);
            groupBox2.Controls.Add(lbOpmerking);
            groupBox2.Controls.Add(lbGeslacht);
            groupBox2.Controls.Add(lbInschrijfdatum);
            groupBox2.Controls.Add(lbVoornaam);
            groupBox2.Controls.Add(lbAchternaam);
            groupBox2.Controls.Add(lbGeboortedatum);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(448, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(340, 437);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Overzicht";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(193, 402);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(131, 29);
            btnReset.TabIndex = 15;
            btnReset.Text = "Formulier reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lbWoonplaats
            // 
            lbWoonplaats.AutoSize = true;
            lbWoonplaats.Location = new Point(38, 193);
            lbWoonplaats.Name = "lbWoonplaats";
            lbWoonplaats.Size = new Size(58, 20);
            lbWoonplaats.TabIndex = 21;
            lbWoonplaats.Text = "label10";
            // 
            // lbOpmerking
            // 
            lbOpmerking.AutoSize = true;
            lbOpmerking.Location = new Point(38, 342);
            lbOpmerking.Name = "lbOpmerking";
            lbOpmerking.Size = new Size(58, 20);
            lbOpmerking.TabIndex = 20;
            lbOpmerking.Text = "label14";
            // 
            // lbGeslacht
            // 
            lbGeslacht.AutoSize = true;
            lbGeslacht.Location = new Point(38, 302);
            lbGeslacht.Name = "lbGeslacht";
            lbGeslacht.Size = new Size(58, 20);
            lbGeslacht.TabIndex = 19;
            lbGeslacht.Text = "label13";
            // 
            // lbInschrijfdatum
            // 
            lbInschrijfdatum.AutoSize = true;
            lbInschrijfdatum.Location = new Point(38, 265);
            lbInschrijfdatum.Name = "lbInschrijfdatum";
            lbInschrijfdatum.Size = new Size(58, 20);
            lbInschrijfdatum.TabIndex = 18;
            lbInschrijfdatum.Text = "label12";
            // 
            // lbVoornaam
            // 
            lbVoornaam.AutoSize = true;
            lbVoornaam.Location = new Point(38, 115);
            lbVoornaam.Name = "lbVoornaam";
            lbVoornaam.Size = new Size(50, 20);
            lbVoornaam.TabIndex = 15;
            lbVoornaam.Text = "label9";
            // 
            // lbAchternaam
            // 
            lbAchternaam.AutoSize = true;
            lbAchternaam.Location = new Point(38, 157);
            lbAchternaam.Name = "lbAchternaam";
            lbAchternaam.Size = new Size(58, 20);
            lbAchternaam.TabIndex = 16;
            lbAchternaam.Text = "label10";
            // 
            // lbGeboortedatum
            // 
            lbGeboortedatum.AutoSize = true;
            lbGeboortedatum.Location = new Point(38, 229);
            lbGeboortedatum.Name = "lbGeboortedatum";
            lbGeboortedatum.Size = new Size(58, 20);
            lbGeboortedatum.TabIndex = 17;
            lbGeboortedatum.Text = "label11";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(28, 32);
            label8.Name = "label8";
            label8.Size = new Size(245, 38);
            label8.TabIndex = 0;
            label8.Text = "U heeft ingevuld:";
            // 
            // FrmPersonAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmPersonAdd";
            Text = "FrmPersonAdd";
            Load += FrmPersonAdd_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private TextBox tbVoornaam;
        private RichTextBox rtbOpmerking;
        private ComboBox cbGeslacht;
        private DateTimePicker dtpInschrijfdatum;
        private DateTimePicker dtpGeboortedatum;
        private TextBox tbWoonplaats;
        private TextBox tbAchternaam;
        private GroupBox groupBox2;
        private Button btnOpslaan;
        private Label label8;
        private Label lbWoonplaats;
        private Label lbOpmerking;
        private Label lbGeslacht;
        private Label lbInschrijfdatum;
        private Label lbVoornaam;
        private Label lbAchternaam;
        private Label lbGeboortedatum;
        private Button btnReset;
    }
}
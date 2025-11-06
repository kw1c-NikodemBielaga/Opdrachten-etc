namespace T8_Praktijkopdracht.View
{
    partial class frmTaakOverview
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
            groupBox1 = new GroupBox();
            lvTaken = new ListView();
            btnTaakFilteren = new Button();
            btnTaakCSV = new Button();
            btnTaakVerwijdern = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lvTaken);
            groupBox1.Location = new Point(11, 25);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(711, 381);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Taken";
            // 
            // lvTaken
            // 
            lvTaken.Location = new Point(7, 29);
            lvTaken.Margin = new Padding(3, 4, 3, 4);
            lvTaken.Name = "lvTaken";
            lvTaken.Size = new Size(691, 340);
            lvTaken.TabIndex = 0;
            lvTaken.UseCompatibleStateImageBehavior = false;
            // 
            // btnTaakFilteren
            // 
            btnTaakFilteren.BackColor = Color.FromArgb(0, 192, 0);
            btnTaakFilteren.Location = new Point(729, 359);
            btnTaakFilteren.Margin = new Padding(3, 4, 3, 4);
            btnTaakFilteren.Name = "btnTaakFilteren";
            btnTaakFilteren.Size = new Size(149, 48);
            btnTaakFilteren.TabIndex = 9;
            btnTaakFilteren.Text = "Taak filteren";
            btnTaakFilteren.UseVisualStyleBackColor = false;
            btnTaakFilteren.Click += btnTaakFilteren_Click;
            // 
            // btnTaakCSV
            // 
            btnTaakCSV.BackColor = Color.Red;
            btnTaakCSV.Location = new Point(885, 359);
            btnTaakCSV.Margin = new Padding(3, 4, 3, 4);
            btnTaakCSV.Name = "btnTaakCSV";
            btnTaakCSV.Size = new Size(149, 48);
            btnTaakCSV.TabIndex = 10;
            btnTaakCSV.Text = "Exporteren naar CSV";
            btnTaakCSV.UseVisualStyleBackColor = false;
            btnTaakCSV.Click += btnTaakCSV_Click;
            // 
            // btnTaakVerwijdern
            // 
            btnTaakVerwijdern.BackColor = Color.FromArgb(0, 192, 0);
            btnTaakVerwijdern.Location = new Point(811, 303);
            btnTaakVerwijdern.Margin = new Padding(3, 4, 3, 4);
            btnTaakVerwijdern.Name = "btnTaakVerwijdern";
            btnTaakVerwijdern.Size = new Size(149, 48);
            btnTaakVerwijdern.TabIndex = 12;
            btnTaakVerwijdern.Text = "Taak verwijderen";
            btnTaakVerwijdern.UseVisualStyleBackColor = false;
            btnTaakVerwijdern.Click += btnTaakVerwijdern_Click;
            // 
            // frmTaakOverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Shrek;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1038, 428);
            Controls.Add(btnTaakVerwijdern);
            Controls.Add(btnTaakCSV);
            Controls.Add(btnTaakFilteren);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmTaakOverview";
            Load += frmTaakOverview_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView lvTaken;
        private Button btnTaakFilteren;
        private Button btnTaakCSV;
        private Button btnTaakVerwijdern;
    }
}
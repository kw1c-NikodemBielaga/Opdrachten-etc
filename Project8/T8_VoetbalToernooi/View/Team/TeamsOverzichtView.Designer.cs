namespace T8_VoetbalToernooi.View
{
    partial class TeamsOverzichtView
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
            lvTeams = new ListView();
            lbteamOverzicht = new Label();
            btAdd = new Button();
            btDelete = new Button();
            btTerug = new Button();
            SuspendLayout();
            // 
            // lvTeams
            // 
            lvTeams.Location = new Point(55, 88);
            lvTeams.Name = "lvTeams";
            lvTeams.Size = new Size(698, 251);
            lvTeams.TabIndex = 0;
            lvTeams.UseCompatibleStateImageBehavior = false;

            // 
            // lbteamOverzicht
            // 
            lbteamOverzicht.AutoSize = true;
            lbteamOverzicht.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbteamOverzicht.Location = new Point(55, 33);
            lbteamOverzicht.Name = "lbteamOverzicht";
            lbteamOverzicht.Size = new Size(255, 37);
            lbteamOverzicht.TabIndex = 1;
            lbteamOverzicht.Text = "Overzicht van teams";
            // 
            // btAdd
            // 
            btAdd.Location = new Point(668, 369);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(85, 23);
            btAdd.TabIndex = 2;
            btAdd.Text = "Toevoegen";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click_1;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(363, 369);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(91, 23);
            btDelete.TabIndex = 3;
            btDelete.Text = "Verwijderen";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btTerug
            // 
            btTerug.Location = new Point(55, 369);
            btTerug.Name = "btTerug";
            btTerug.Size = new Size(75, 23);
            btTerug.TabIndex = 4;
            btTerug.Text = "Terug";
            btTerug.UseVisualStyleBackColor = true;
            btTerug.Click += btTerug_Click;
            // 
            // TeamsOverzichtView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Startschermfoto;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(794, 416);
            Controls.Add(btTerug);
            Controls.Add(btDelete);
            Controls.Add(btAdd);
            Controls.Add(lbteamOverzicht);
            Controls.Add(lvTeams);
            Name = "TeamsOverzichtView";
            Text = "Teams";
            Load += Teams_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvTeams;
        private Label lbteamOverzicht;
        private Button btAdd;
        private Button btDelete;
        private Button btTerug;
    }
}
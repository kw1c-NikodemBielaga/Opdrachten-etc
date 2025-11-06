namespace T8_Praktijkopdracht.View
{
    partial class frmThemaOverview
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
            btnThemaToevoegen = new Button();
            btnThemaFilteren = new Button();
            btnThemaVerwijderen = new Button();
            groupBox1 = new GroupBox();
            lvThema = new ListView();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnThemaToevoegen
            // 
            btnThemaToevoegen.BackColor = Color.FromArgb(0, 192, 0);
            btnThemaToevoegen.Location = new Point(591, 266);
            btnThemaToevoegen.Margin = new Padding(3, 4, 3, 4);
            btnThemaToevoegen.Name = "btnThemaToevoegen";
            btnThemaToevoegen.Size = new Size(149, 48);
            btnThemaToevoegen.TabIndex = 1;
            btnThemaToevoegen.Text = "Thema toevoegen";
            btnThemaToevoegen.UseVisualStyleBackColor = false;
            btnThemaToevoegen.Click += btnThemaToevoegen_Click;
            // 
            // btnThemaFilteren
            // 
            btnThemaFilteren.BackColor = Color.FromArgb(0, 192, 0);
            btnThemaFilteren.Location = new Point(591, 199);
            btnThemaFilteren.Margin = new Padding(3, 4, 3, 4);
            btnThemaFilteren.Name = "btnThemaFilteren";
            btnThemaFilteren.Size = new Size(149, 48);
            btnThemaFilteren.TabIndex = 2;
            btnThemaFilteren.Text = "Thema filteren";
            btnThemaFilteren.UseVisualStyleBackColor = false;
            btnThemaFilteren.Click += btnThemaFilteren_Click;
            // 
            // btnThemaVerwijderen
            // 
            btnThemaVerwijderen.BackColor = Color.FromArgb(0, 192, 0);
            btnThemaVerwijderen.Location = new Point(591, 334);
            btnThemaVerwijderen.Margin = new Padding(3, 4, 3, 4);
            btnThemaVerwijderen.Name = "btnThemaVerwijderen";
            btnThemaVerwijderen.Size = new Size(149, 48);
            btnThemaVerwijderen.TabIndex = 3;
            btnThemaVerwijderen.Text = "Thema verwijderen";
            btnThemaVerwijderen.UseVisualStyleBackColor = false;
            btnThemaVerwijderen.Click += btnThemaVerwijderen_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lvThema);
            groupBox1.Location = new Point(14, 33);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(526, 351);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thema's";
            // 
            // lvThema
            // 
            lvThema.Location = new Point(7, 29);
            lvThema.Margin = new Padding(3, 4, 3, 4);
            lvThema.Name = "lvThema";
            lvThema.Size = new Size(511, 312);
            lvThema.TabIndex = 0;
            lvThema.UseCompatibleStateImageBehavior = false;
            // 
            // frmThemaOverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Shrek;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(799, 447);
            Controls.Add(groupBox1);
            Controls.Add(btnThemaVerwijderen);
            Controls.Add(btnThemaFilteren);
            Controls.Add(btnThemaToevoegen);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmThemaOverview";
            Text = "frmThemaOverview";
            Load += frmThemaOverview_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnThemaToevoegen;
        private Button btnThemaFilteren;
        private Button btnThemaVerwijderen;
        private GroupBox groupBox1;
        private ListView lvThema;
    }
}
namespace T8_VoetbalToernooi.View
{
    partial class Docenten
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
            lvDocenten = new ListView();
            lbDocent = new Label();
            btBack = new Button();
            btAdd = new Button();
            btDelete = new Button();
            SuspendLayout();
            // 
            // lvDocenten
            // 
            lvDocenten.Location = new Point(20, 74);
            lvDocenten.Margin = new Padding(3, 2, 3, 2);
            lvDocenten.Name = "lvDocenten";
            lvDocenten.Size = new Size(653, 196);
            lvDocenten.TabIndex = 0;
            lvDocenten.UseCompatibleStateImageBehavior = false;
            // 
            // lbDocent
            // 
            lbDocent.AutoSize = true;
            lbDocent.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDocent.Location = new Point(20, 24);
            lbDocent.Name = "lbDocent";
            lbDocent.Size = new Size(131, 37);
            lbDocent.TabIndex = 1;
            lbDocent.Text = "Docenten";
            // 
            // btBack
            // 
            btBack.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btBack.Location = new Point(20, 292);
            btBack.Margin = new Padding(3, 2, 3, 2);
            btBack.Name = "btBack";
            btBack.Size = new Size(93, 22);
            btBack.TabIndex = 2;
            btBack.Text = "Terug";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(591, 292);
            btAdd.Margin = new Padding(3, 2, 3, 2);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(82, 22);
            btAdd.TabIndex = 3;
            btAdd.Text = "Toevoegen";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(480, 292);
            btDelete.Margin = new Padding(3, 2, 3, 2);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(87, 22);
            btDelete.TabIndex = 4;
            btDelete.Text = "Verwijderen";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // Docenten
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Startschermfoto;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(btDelete);
            Controls.Add(btAdd);
            Controls.Add(btBack);
            Controls.Add(lbDocent);
            Controls.Add(lvDocenten);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Docenten";
            Text = "Docenten";
            Load += Docenten_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvDocenten;
        private Label lbDocent;
        private Button btBack;
        private Button btAdd;
        private Button btDelete;
    }
}
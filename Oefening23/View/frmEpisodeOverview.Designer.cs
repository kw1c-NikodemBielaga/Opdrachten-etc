namespace DrWho.View
{
    partial class frmEpisodeOverview
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
            btnClose = new Button();
            lvEpisode = new ListView();
            label1 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(736, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 48);
            btnClose.TabIndex = 15;
            btnClose.Text = "Sluiten";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // lvEpisode
            // 
            lvEpisode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvEpisode.HeaderStyle = ColumnHeaderStyle.None;
            lvEpisode.Location = new Point(26, 104);
            lvEpisode.Name = "lvEpisode";
            lvEpisode.Size = new Size(873, 234);
            lvEpisode.TabIndex = 16;
            lvEpisode.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 19.8F);
            label1.Location = new Point(35, 8);
            label1.Name = "label1";
            label1.Size = new Size(238, 45);
            label1.TabIndex = 17;
            label1.Text = "Episode";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(26, 362);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 48);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Toevoegen";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(560, 362);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 48);
            btnEdit.TabIndex = 19;
            btnEdit.Text = "Bewerken";
            btnEdit.TextAlign = ContentAlignment.MiddleRight;
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(749, 362);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 48);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Verwijderen";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // frmEpisodeOverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 424);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(lvEpisode);
            Controls.Add(btnClose);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmEpisodeOverview";
            Text = "frmEpisodeOverview";
            Load += frmEpisodeOverview_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
        private ListView lvEpisode;
        private Label label1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}
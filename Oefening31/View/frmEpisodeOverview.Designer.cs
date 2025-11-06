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
            btnClose.Location = new Point(644, 6);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(131, 36);
            btnClose.TabIndex = 15;
            btnClose.Text = "Sluiten";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // lvEpisode
            // 
            lvEpisode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvEpisode.HeaderStyle = ColumnHeaderStyle.None;
            lvEpisode.Location = new Point(23, 78);
            lvEpisode.Margin = new Padding(3, 2, 3, 2);
            lvEpisode.Name = "lvEpisode";
            lvEpisode.Size = new Size(764, 176);
            lvEpisode.TabIndex = 16;
            lvEpisode.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 19.8F);
            label1.Location = new Point(31, 6);
            label1.Name = "label1";
            label1.Size = new Size(208, 34);
            label1.TabIndex = 17;
            label1.Text = "Episode";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(23, 272);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(131, 36);
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
            btnEdit.Location = new Point(490, 272);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(131, 36);
            btnEdit.TabIndex = 19;
            btnEdit.Text = "Bewerken";
            btnEdit.TextAlign = ContentAlignment.MiddleRight;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(655, 272);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 36);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Verwijderen";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // frmEpisodeOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 318);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(lvEpisode);
            Controls.Add(btnClose);
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
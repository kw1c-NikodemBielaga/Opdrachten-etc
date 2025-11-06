namespace T8_VoetbalToernooi.View.Team
{
    partial class TeamsAdd
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
            tbName = new TextBox();
            btCancel = new Button();
            btAdd = new Button();
            lbDocent = new Label();
            lbName = new Label();
            cbdocent = new ComboBox();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(64, 83);
            tbName.Name = "tbName";
            tbName.Size = new Size(162, 23);
            tbName.TabIndex = 11;
            // 
            // btCancel
            // 
            btCancel.Location = new Point(22, 225);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(75, 23);
            btCancel.TabIndex = 9;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(186, 225);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(80, 23);
            btAdd.TabIndex = 8;
            btAdd.Text = "Toevoegen";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // lbDocent
            // 
            lbDocent.AutoSize = true;
            lbDocent.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDocent.Location = new Point(120, 128);
            lbDocent.Name = "lbDocent";
            lbDocent.Size = new Size(57, 20);
            lbDocent.TabIndex = 7;
            lbDocent.Text = "Docent";
            // 
            // lbName
            // 
            lbName.AccessibleName = "";
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbName.Location = new Point(120, 60);
            lbName.Name = "lbName";
            lbName.Size = new Size(49, 20);
            lbName.TabIndex = 6;
            lbName.Text = "Name";
            // 
            // cbdocent
            // 
            cbdocent.FormattingEnabled = true;
            cbdocent.Location = new Point(64, 151);
            cbdocent.Name = "cbdocent";
            cbdocent.Size = new Size(162, 23);
            cbdocent.TabIndex = 12;
            // 
            // TeamsAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Startschermfoto;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(304, 280);
            Controls.Add(cbdocent);
            Controls.Add(tbName);
            Controls.Add(btCancel);
            Controls.Add(btAdd);
            Controls.Add(lbDocent);
            Controls.Add(lbName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TeamsAdd";
            Text = "TeamsAdd";
            Load += TeamsAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbName;
        private Button btCancel;
        private Button btAdd;
        private Label lbDocent;
        private Label lbName;
        private ComboBox cbdocent;
    }
}
namespace T8_Praktijkopdracht.View
{
    partial class frmThemaToevoegen
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
            button1 = new Button();
            btnSave = new Button();
            tbNaam = new TextBox();
            tbHoofdstuk = new TextBox();
            tbThemaId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbDocentId = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(0, 192, 0);
            groupBox1.Controls.Add(tbDocentId);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(tbNaam);
            groupBox1.Controls.Add(tbHoofdstuk);
            groupBox1.Controls.Add(tbThemaId);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(40, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(337, 240);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thema's Toevoegen";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Location = new Point(201, 204);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(130, 31);
            button1.TabIndex = 18;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gold;
            btnSave.Location = new Point(6, 204);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 31);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // tbNaam
            // 
            tbNaam.Location = new Point(143, 126);
            tbNaam.Name = "tbNaam";
            tbNaam.Size = new Size(151, 23);
            tbNaam.TabIndex = 6;
            // 
            // tbHoofdstuk
            // 
            tbHoofdstuk.Location = new Point(143, 85);
            tbHoofdstuk.Name = "tbHoofdstuk";
            tbHoofdstuk.Size = new Size(151, 23);
            tbHoofdstuk.TabIndex = 5;
            // 
            // tbThemaId
            // 
            tbThemaId.Location = new Point(143, 47);
            tbThemaId.Name = "tbThemaId";
            tbThemaId.Size = new Size(151, 23);
            tbThemaId.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 162);
            label4.Name = "label4";
            label4.Size = new Size(74, 17);
            label4.TabIndex = 3;
            label4.Text = "DocentId";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 126);
            label3.Name = "label3";
            label3.Size = new Size(50, 17);
            label3.TabIndex = 2;
            label3.Text = "Naam";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 85);
            label2.Name = "label2";
            label2.Size = new Size(82, 17);
            label2.TabIndex = 1;
            label2.Text = "Hoofdstuk";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 48);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 0;
            label1.Text = "ThemaId";
            // 
            // tbDocentId
            // 
            tbDocentId.FormattingEnabled = true;
            tbDocentId.Location = new Point(143, 162);
            tbDocentId.Name = "tbDocentId";
            tbDocentId.Size = new Size(151, 23);
            tbDocentId.TabIndex = 19;
            tbDocentId.SelectedIndexChanged += tbDocentId_SelectedIndexChanged;
            // 
            // frmThemaToevoegen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Shrek;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(448, 279);
            Controls.Add(groupBox1);
            Name = "frmThemaToevoegen";
            Text = "frmThemaToevoegen";
            Load += frmThemaToevoegen_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private TextBox tbThemaId;
        private Label label4;
        private Label label3;
        private TextBox tbNaam;
        private TextBox tbHoofdstuk;
        private Button button1;
        private Button btnSave;
        private ComboBox tbDocentId;
    }
}
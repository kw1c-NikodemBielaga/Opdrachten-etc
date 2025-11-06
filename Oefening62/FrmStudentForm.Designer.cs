namespace Oefening62
{
    partial class FrmStudentForm
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
            cbKlas = new ComboBox();
            btnLeerlingToevoegen = new Button();
            tbTelephone = new TextBox();
            tbLeerlingnummer = new TextBox();
            tbLeerlingnaam = new TextBox();
            StudentClassCode = new Label();
            StudentTelephone = new Label();
            StudentNumber = new Label();
            StudentName = new Label();
            btnListView = new Button();
            btnSluiten = new Button();
            lvLeerlingView = new ListView();
            lvLeerlingColumns = new GroupBox();
            groupBox1.SuspendLayout();
            lvLeerlingColumns.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.AppWorkspace;
            groupBox1.Controls.Add(cbKlas);
            groupBox1.Controls.Add(btnLeerlingToevoegen);
            groupBox1.Controls.Add(tbTelephone);
            groupBox1.Controls.Add(tbLeerlingnummer);
            groupBox1.Controls.Add(tbLeerlingnaam);
            groupBox1.Controls.Add(StudentClassCode);
            groupBox1.Controls.Add(StudentTelephone);
            groupBox1.Controls.Add(StudentNumber);
            groupBox1.Controls.Add(StudentName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 136);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Toevogen";
            // 
            // cbKlas
            // 
            cbKlas.FormattingEnabled = true;
            cbKlas.Location = new Point(442, 67);
            cbKlas.Name = "cbKlas";
            cbKlas.Size = new Size(140, 28);
            cbKlas.TabIndex = 9;
            // 
            // btnLeerlingToevoegen
            // 
            btnLeerlingToevoegen.Location = new Point(613, 80);
            btnLeerlingToevoegen.Name = "btnLeerlingToevoegen";
            btnLeerlingToevoegen.Size = new Size(152, 29);
            btnLeerlingToevoegen.TabIndex = 8;
            btnLeerlingToevoegen.Text = "Leerling toevogen ";
            btnLeerlingToevoegen.UseVisualStyleBackColor = true;
            btnLeerlingToevoegen.Click += btnLeerlingToevoegen_Click;
            // 
            // tbTelephone
            // 
            tbTelephone.Location = new Point(306, 67);
            tbTelephone.Name = "tbTelephone";
            tbTelephone.Size = new Size(112, 27);
            tbTelephone.TabIndex = 6;
            // 
            // tbLeerlingnummer
            // 
            tbLeerlingnummer.Location = new Point(157, 67);
            tbLeerlingnummer.Name = "tbLeerlingnummer";
            tbLeerlingnummer.Size = new Size(121, 27);
            tbLeerlingnummer.TabIndex = 5;
            // 
            // tbLeerlingnaam
            // 
            tbLeerlingnaam.Location = new Point(21, 67);
            tbLeerlingnaam.Name = "tbLeerlingnaam";
            tbLeerlingnaam.Size = new Size(112, 27);
            tbLeerlingnaam.TabIndex = 4;
            // 
            // StudentClassCode
            // 
            StudentClassCode.AutoSize = true;
            StudentClassCode.Location = new Point(442, 44);
            StudentClassCode.Name = "StudentClassCode";
            StudentClassCode.Size = new Size(36, 20);
            StudentClassCode.TabIndex = 3;
            StudentClassCode.Text = "Klas";
            // 
            // StudentTelephone
            // 
            StudentTelephone.AutoSize = true;
            StudentTelephone.Location = new Point(306, 44);
            StudentTelephone.Name = "StudentTelephone";
            StudentTelephone.Size = new Size(67, 20);
            StudentTelephone.TabIndex = 2;
            StudentTelephone.Text = "Telefoon";
            // 
            // StudentNumber
            // 
            StudentNumber.AutoSize = true;
            StudentNumber.Location = new Point(157, 44);
            StudentNumber.Name = "StudentNumber";
            StudentNumber.Size = new Size(121, 20);
            StudentNumber.TabIndex = 1;
            StudentNumber.Text = "Leerling nummer";
            // 
            // StudentName
            // 
            StudentName.AutoSize = true;
            StudentName.Location = new Point(21, 44);
            StudentName.Name = "StudentName";
            StudentName.Size = new Size(103, 20);
            StudentName.TabIndex = 0;
            StudentName.Text = "Leerling naam";
            // 
            // btnListView
            // 
            btnListView.Location = new Point(12, 409);
            btnListView.Name = "btnListView";
            btnListView.Size = new Size(188, 29);
            btnListView.TabIndex = 11;
            btnListView.Text = "ListView vernieuwen";
            btnListView.UseVisualStyleBackColor = true;
            btnListView.Click += btnListView_Click;
            // 
            // btnSluiten
            // 
            btnSluiten.Location = new Point(625, 409);
            btnSluiten.Name = "btnSluiten";
            btnSluiten.Size = new Size(152, 29);
            btnSluiten.TabIndex = 12;
            btnSluiten.Text = "Venster sluiten";
            btnSluiten.UseVisualStyleBackColor = true;
            btnSluiten.Click += btnSluiten_Click;
            // 
            // lvLeerlingView
            // 
            lvLeerlingView.Location = new Point(6, 26);
            lvLeerlingView.Name = "lvLeerlingView";
            lvLeerlingView.Size = new Size(759, 184);
            lvLeerlingView.TabIndex = 0;
            lvLeerlingView.UseCompatibleStateImageBehavior = false;
            // 
            // lvLeerlingColumns
            // 
            lvLeerlingColumns.Controls.Add(lvLeerlingView);
            lvLeerlingColumns.Location = new Point(12, 173);
            lvLeerlingColumns.Name = "lvLeerlingColumns";
            lvLeerlingColumns.Size = new Size(776, 225);
            lvLeerlingColumns.TabIndex = 10;
            lvLeerlingColumns.TabStop = false;
            lvLeerlingColumns.Text = "Huidige leerlingen";
            // 
            // FrmStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSluiten);
            Controls.Add(btnListView);
            Controls.Add(lvLeerlingColumns);
            Controls.Add(groupBox1);
            Name = "FrmStudentForm";
            Text = "FrmStudentForm";
            Load += FrmStudentForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            lvLeerlingColumns.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnLeerlingToevoegen;
        private TextBox tbTelephone;
        private TextBox tbLeerlingnummer;
        private TextBox tbLeerlingnaam;
        private Label StudentClassCode;
        private Label StudentTelephone;
        private Label StudentNumber;
        private Label StudentName;
        private Button btnListView;
        private ComboBox cbKlas;
        private Button btnSluiten;
        private ListView lvLeerlingView;
        private GroupBox lvLeerlingColumns;
    }
}
namespace Oefening62
{
    partial class FrmGroupForm
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
            btnGroupToevoegen = new Button();
            tbMentornaam = new TextBox();
            tbGroepjaar = new TextBox();
            tbGroepcode = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            brnListView = new Button();
            btnSluiten = new Button();
            lvLeerlingColumns = new GroupBox();
            lvGroupView = new ListView();
            groupBox1.SuspendLayout();
            lvLeerlingColumns.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.AppWorkspace;
            groupBox1.Controls.Add(btnGroupToevoegen);
            groupBox1.Controls.Add(tbMentornaam);
            groupBox1.Controls.Add(tbGroepjaar);
            groupBox1.Controls.Add(tbGroepcode);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 136);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Toevogen";
            // 
            // btnGroupToevoegen
            // 
            btnGroupToevoegen.Location = new Point(613, 80);
            btnGroupToevoegen.Name = "btnGroupToevoegen";
            btnGroupToevoegen.Size = new Size(152, 29);
            btnGroupToevoegen.TabIndex = 8;
            btnGroupToevoegen.Text = "Leerling toevogen ";
            btnGroupToevoegen.UseVisualStyleBackColor = true;
            btnGroupToevoegen.Click += btnGroupToevoegen_Click;
            // 
            // tbMentornaam
            // 
            tbMentornaam.Location = new Point(306, 67);
            tbMentornaam.Name = "tbMentornaam";
            tbMentornaam.Size = new Size(112, 27);
            tbMentornaam.TabIndex = 6;
            // 
            // tbGroepjaar
            // 
            tbGroepjaar.Location = new Point(157, 67);
            tbGroepjaar.Name = "tbGroepjaar";
            tbGroepjaar.Size = new Size(121, 27);
            tbGroepjaar.TabIndex = 5;
            // 
            // tbGroepcode
            // 
            tbGroepcode.Location = new Point(21, 67);
            tbGroepcode.Name = "tbGroepcode";
            tbGroepcode.Size = new Size(112, 27);
            tbGroepcode.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(442, 44);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(306, 44);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 2;
            label3.Text = " Mentornaam";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 44);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Groepjaar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 44);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "Groepcode";
            // 
            // brnListView
            // 
            brnListView.Location = new Point(12, 409);
            brnListView.Name = "brnListView";
            brnListView.Size = new Size(188, 29);
            brnListView.TabIndex = 12;
            brnListView.Text = "ListView vernieuwen";
            brnListView.UseVisualStyleBackColor = true;
            // 
            // btnSluiten
            // 
            btnSluiten.Location = new Point(636, 409);
            btnSluiten.Name = "btnSluiten";
            btnSluiten.Size = new Size(152, 29);
            btnSluiten.TabIndex = 13;
            btnSluiten.Text = "Venster sluiten";
            btnSluiten.UseVisualStyleBackColor = true;
            btnSluiten.Click += btnSluiten_Click;
            // 
            // lvLeerlingColumns
            // 
            lvLeerlingColumns.BackColor = SystemColors.AppWorkspace;
            lvLeerlingColumns.Controls.Add(lvGroupView);
            lvLeerlingColumns.Location = new Point(12, 169);
            lvLeerlingColumns.Name = "lvLeerlingColumns";
            lvLeerlingColumns.Size = new Size(776, 225);
            lvLeerlingColumns.TabIndex = 11;
            lvLeerlingColumns.TabStop = false;
            lvLeerlingColumns.Text = "Huidige leerlingen";
            // 
            // lvGroupView
            // 
            lvGroupView.Location = new Point(6, 26);
            lvGroupView.Name = "lvGroupView";
            lvGroupView.Size = new Size(759, 193);
            lvGroupView.TabIndex = 0;
            lvGroupView.UseCompatibleStateImageBehavior = false;
            // 
            // FrmGroupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSluiten);
            Controls.Add(brnListView);
            Controls.Add(lvLeerlingColumns);
            Controls.Add(groupBox1);
            Name = "FrmGroupForm";
            Text = "FrmGroupForm";
            Load += FrmGroupForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            lvLeerlingColumns.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnGroupToevoegen;
        private TextBox tbMentornaam;
        private TextBox tbGroepjaar;
        private TextBox tbGroepcode;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button brnListView;
        private Button btnSluiten;
        private GroupBox lvLeerlingColumns;
        private ListView lvGroupView;
    }
}
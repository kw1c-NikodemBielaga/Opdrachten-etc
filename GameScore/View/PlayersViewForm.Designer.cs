namespace GameScore.View
{
    partial class PlayersViewForm
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
            btnEdit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            lvPlayerView = new ListView();
            groupBox2 = new GroupBox();
            tbEmail = new TextBox();
            tbLastName = new TextBox();
            tbFirstName = new TextBox();
            tbPlayerName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            tbPlayerId = new TextBox();
            dtpDateofBirth = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(lvPlayerView);
            groupBox1.Location = new Point(82, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(750, 334);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Players";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Gold;
            btnEdit.Font = new Font("Arial Rounded MT Bold", 9F);
            btnEdit.Location = new Point(288, 286);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(149, 41);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Arial Rounded MT Bold", 9F);
            btnDelete.Location = new Point(583, 287);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(149, 41);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gold;
            btnAdd.Font = new Font("Arial Rounded MT Bold", 9F);
            btnAdd.Location = new Point(6, 287);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(149, 40);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lvPlayerView
            // 
            lvPlayerView.BackColor = Color.LimeGreen;
            lvPlayerView.Location = new Point(6, 26);
            lvPlayerView.Name = "lvPlayerView";
            lvPlayerView.Size = new Size(726, 255);
            lvPlayerView.TabIndex = 0;
            lvPlayerView.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LimeGreen;
            groupBox2.Controls.Add(tbEmail);
            groupBox2.Controls.Add(tbLastName);
            groupBox2.Controls.Add(tbFirstName);
            groupBox2.Controls.Add(tbPlayerName);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(tbPlayerId);
            groupBox2.Controls.Add(dtpDateofBirth);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(28, 352);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(846, 95);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Menu";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(526, 51);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(185, 27);
            tbEmail.TabIndex = 15;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(390, 51);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(130, 27);
            tbLastName.TabIndex = 14;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(254, 51);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(130, 27);
            tbFirstName.TabIndex = 13;
            // 
            // tbPlayerName
            // 
            tbPlayerName.Location = new Point(118, 51);
            tbPlayerName.Name = "tbPlayerName";
            tbPlayerName.Size = new Size(130, 27);
            tbPlayerName.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 10.2F);
            label6.Location = new Point(594, 28);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 9;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 10.2F);
            label5.Location = new Point(411, 28);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 8;
            label5.Text = "LastName";
            // 
            // tbPlayerId
            // 
            tbPlayerId.Location = new Point(6, 51);
            tbPlayerId.Name = "tbPlayerId";
            tbPlayerId.Size = new Size(106, 27);
            tbPlayerId.TabIndex = 7;
            // 
            // dtpDateofBirth
            // 
            dtpDateofBirth.CustomFormat = "dd-MM-yyyy";
            dtpDateofBirth.Format = DateTimePickerFormat.Custom;
            dtpDateofBirth.Location = new Point(717, 49);
            dtpDateofBirth.Name = "dtpDateofBirth";
            dtpDateofBirth.Size = new Size(123, 27);
            dtpDateofBirth.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.2F);
            label4.Location = new Point(727, 28);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 3;
            label4.Text = "DateofBirth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F);
            label3.Location = new Point(274, 28);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 2;
            label3.Text = "FirstName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.2F);
            label2.Location = new Point(129, 28);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 1;
            label2.Text = "PlayerName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.2F);
            label1.Location = new Point(18, 28);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "PlayerId";
            // 
            // PlayersViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.foto1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(898, 469);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Name = "PlayersViewForm";
            Text = "PlayersViewForm";
            Load += PlayersViewForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView lvPlayerView;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit;
        private GroupBox groupBox2;
        private TextBox tbPlayerId;
        private DateTimePicker dtpDateofBirth;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label6;
        private TextBox tbFirstName;
        private TextBox tbPlayerName;
        private TextBox tbEmail;
        private TextBox tbLastName;
    }
}
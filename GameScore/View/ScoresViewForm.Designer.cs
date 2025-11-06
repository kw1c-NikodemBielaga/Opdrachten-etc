namespace GameScore.View
{
    partial class ScoresViewForm
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
            lvScoreView = new ListView();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            groupBox2 = new GroupBox();
            tbScoreId = new TextBox();
            tbPlayer = new TextBox();
            tbScore = new TextBox();
            dtpScoreData = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lvScoreView
            // 
            lvScoreView.BackColor = Color.LimeGreen;
            lvScoreView.Location = new Point(36, 26);
            lvScoreView.Name = "lvScoreView";
            lvScoreView.Size = new Size(495, 241);
            lvScoreView.TabIndex = 0;
            lvScoreView.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(lvScoreView);
            groupBox1.Location = new Point(126, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(557, 319);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Scores";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Arial Rounded MT Bold", 9F);
            btnDelete.Location = new Point(391, 271);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 40);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Gold;
            btnEdit.Font = new Font("Arial Rounded MT Bold", 9F);
            btnEdit.Location = new Point(213, 270);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(149, 41);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gold;
            btnAdd.Font = new Font("Arial Rounded MT Bold", 9F);
            btnAdd.Location = new Point(36, 271);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(149, 40);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LimeGreen;
            groupBox2.Controls.Add(tbScoreId);
            groupBox2.Controls.Add(tbPlayer);
            groupBox2.Controls.Add(tbScore);
            groupBox2.Controls.Add(dtpScoreData);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(93, 337);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(625, 101);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Menu";
            // 
            // tbScoreId
            // 
            tbScoreId.Location = new Point(43, 49);
            tbScoreId.Name = "tbScoreId";
            tbScoreId.Size = new Size(135, 27);
            tbScoreId.TabIndex = 7;
            // 
            // tbPlayer
            // 
            tbPlayer.Location = new Point(184, 49);
            tbPlayer.Name = "tbPlayer";
            tbPlayer.Size = new Size(135, 27);
            tbPlayer.TabIndex = 6;
            // 
            // tbScore
            // 
            tbScore.Location = new Point(325, 49);
            tbScore.Name = "tbScore";
            tbScore.Size = new Size(135, 27);
            tbScore.TabIndex = 5;
            // 
            // dtpScoreData
            // 
            dtpScoreData.CustomFormat = "dd-MM-yyyy";
            dtpScoreData.Format = DateTimePickerFormat.Custom;
            dtpScoreData.Location = new Point(466, 49);
            dtpScoreData.Name = "dtpScoreData";
            dtpScoreData.Size = new Size(125, 27);
            dtpScoreData.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.2F);
            label4.Location = new Point(477, 26);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 3;
            label4.Text = "ScoreData";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F);
            label3.Location = new Point(365, 26);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 2;
            label3.Text = "Score";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.2F);
            label2.Location = new Point(198, 26);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 1;
            label2.Text = "PlayerName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label1.Location = new Point(69, 25);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 0;
            label1.Text = "ScoreId";
            // 
            // ScoresViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.foto1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Name = "ScoresViewForm";
            Text = "ScoresViewForm";
            Load += ScoresViewForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView lvScoreView;
        private GroupBox groupBox1;
        private Button btnAdd;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbScoreId;
        private TextBox tbPlayer;
        private TextBox tbScore;
        private DateTimePicker dtpScoreData;
        private Button btnEdit;
        private Button btnDelete;
    }
}
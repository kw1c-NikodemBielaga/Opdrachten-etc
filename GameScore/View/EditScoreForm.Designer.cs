namespace GameScore.View
{
    partial class EditScoreForm
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
            groupBox2 = new GroupBox();
            btnCancel = new Button();
            btnSave = new Button();
            tbScoreId = new TextBox();
            tbPlayer = new TextBox();
            tbScore = new TextBox();
            dtpScoreData = new DateTimePicker();
            label4 = new Label();
            lbScore = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LimeGreen;
            groupBox2.Controls.Add(btnCancel);
            groupBox2.Controls.Add(btnSave);
            groupBox2.Controls.Add(tbScoreId);
            groupBox2.Controls.Add(tbPlayer);
            groupBox2.Controls.Add(tbScore);
            groupBox2.Controls.Add(dtpScoreData);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(lbScore);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(59, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(347, 282);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Edit Menu Score";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gold;
            btnCancel.Location = new Point(177, 235);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(149, 41);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gold;
            btnSave.Location = new Point(22, 235);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(149, 41);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // tbScoreId
            // 
            tbScoreId.Location = new Point(143, 23);
            tbScoreId.Name = "tbScoreId";
            tbScoreId.Size = new Size(156, 27);
            tbScoreId.TabIndex = 7;
            // 
            // tbPlayer
            // 
            tbPlayer.Location = new Point(143, 69);
            tbPlayer.Name = "tbPlayer";
            tbPlayer.Size = new Size(156, 27);
            tbPlayer.TabIndex = 6;
            // 
            // tbScore
            // 
            tbScore.Location = new Point(143, 119);
            tbScore.Name = "tbScore";
            tbScore.Size = new Size(156, 27);
            tbScore.TabIndex = 5;
            // 
            // dtpScoreData
            // 
            dtpScoreData.Font = new Font("Arial Rounded MT Bold", 10.2F);
            dtpScoreData.Format = DateTimePickerFormat.Custom;
            dtpScoreData.Location = new Point(143, 176);
            dtpScoreData.Name = "dtpScoreData";
            dtpScoreData.Size = new Size(156, 27);
            dtpScoreData.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 11F);
            label4.Location = new Point(22, 176);
            label4.Name = "label4";
            label4.Size = new Size(107, 22);
            label4.TabIndex = 3;
            label4.Text = "ScoreData";
            // 
            // lbScore
            // 
            lbScore.AutoSize = true;
            lbScore.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbScore.Location = new Point(64, 119);
            lbScore.Name = "lbScore";
            lbScore.Size = new Size(63, 21);
            lbScore.TabIndex = 2;
            lbScore.Text = "Score";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 11F);
            label2.Location = new Point(6, 69);
            label2.Name = "label2";
            label2.Size = new Size(121, 22);
            label2.TabIndex = 1;
            label2.Text = "PlayerName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label1.Location = new Point(48, 25);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 0;
            label1.Text = "ScoreId";
            // 
            // EditScoreForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.foto1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(475, 328);
            Controls.Add(groupBox2);
            DoubleBuffered = true;
            Name = "EditScoreForm";
            Text = "EditScoreForm";
            Load += EditScoreForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox tbScoreId;
        private TextBox tbPlayer;
        private TextBox tbScore;
        private DateTimePicker dtpScoreData;
        private Label label4;
        private Label lbScore;
        private Label label2;
        private Label label1;
        private Button btnSave;
        private Button btnCancel;
    }
}
namespace GameScore.View
{
    partial class ScoresPerPlayerForm
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
            btnCancel = new Button();
            lvScoreView = new ListView();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(lvScoreView);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(559, 317);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Scores";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gold;
            btnCancel.Location = new Point(212, 270);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(149, 41);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lvScoreView
            // 
            lvScoreView.BackColor = Color.LimeGreen;
            lvScoreView.Location = new Point(27, 26);
            lvScoreView.Name = "lvScoreView";
            lvScoreView.Size = new Size(495, 241);
            lvScoreView.TabIndex = 0;
            lvScoreView.UseCompatibleStateImageBehavior = false;
            // 
            // ScoresPerPlayerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.foto1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(616, 355);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Name = "ScoresPerPlayerForm";
            Text = "ScoresPerPlayerForm";
            Load += ScoresPerPlayerForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView lvScoreView;
        private Button btnCancel;
    }
}
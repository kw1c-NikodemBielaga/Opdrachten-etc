namespace GameScore.View
{
    partial class TopViewForm
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
            lvTopView = new ListView();
            groupBox1 = new GroupBox();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lvTopView
            // 
            lvTopView.BackColor = Color.LimeGreen;
            lvTopView.Location = new Point(39, 26);
            lvTopView.Name = "lvTopView";
            lvTopView.Size = new Size(561, 237);
            lvTopView.TabIndex = 0;
            lvTopView.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(lvTopView);
            groupBox1.Location = new Point(100, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(642, 317);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Top 10 ";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Gold;
            btnExit.Font = new Font("Arial Rounded MT Bold", 9F);
            btnExit.Location = new Point(230, 269);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(149, 40);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // TopViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.foto1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Name = "TopViewForm";
            Text = "TopViewForm";
            Load += TopViewForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView lvTopView;
        private GroupBox groupBox1;
        private Button btnExit;
    }
}
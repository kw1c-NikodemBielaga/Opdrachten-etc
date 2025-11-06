namespace GameScore
{
    partial class Startscherm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            playGameToolStripMenuItem = new ToolStripMenuItem();
            playerToolStripMenuItem = new ToolStripMenuItem();
            scoresToolStripMenuItem = new ToolStripMenuItem();
            top10ToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.BackgroundImageLayout = ImageLayout.Center;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { playGameToolStripMenuItem, playerToolStripMenuItem, scoresToolStripMenuItem, top10ToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(0);
            menuStrip1.Size = new Size(270, 450);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // playGameToolStripMenuItem
            // 
            playGameToolStripMenuItem.BackColor = Color.Gold;
            playGameToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playGameToolStripMenuItem.ImageTransparentColor = Color.Transparent;
            playGameToolStripMenuItem.Name = "playGameToolStripMenuItem";
            playGameToolStripMenuItem.Padding = new Padding(100, 0, 5, 0);
            playGameToolStripMenuItem.Size = new Size(269, 36);
            playGameToolStripMenuItem.Text = "Play Game";
            // 
            // playerToolStripMenuItem
            // 
            playerToolStripMenuItem.BackColor = Color.Gold;
            playerToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            playerToolStripMenuItem.Size = new Size(269, 36);
            playerToolStripMenuItem.Text = "Players";
            playerToolStripMenuItem.Click += playerToolStripMenuItem_Click;
            // 
            // scoresToolStripMenuItem
            // 
            scoresToolStripMenuItem.BackColor = Color.Gold;
            scoresToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scoresToolStripMenuItem.Name = "scoresToolStripMenuItem";
            scoresToolStripMenuItem.Size = new Size(269, 36);
            scoresToolStripMenuItem.Text = "Scores";
            scoresToolStripMenuItem.Click += scoresToolStripMenuItem_Click;
            // 
            // top10ToolStripMenuItem
            // 
            top10ToolStripMenuItem.BackColor = Color.Gold;
            top10ToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            top10ToolStripMenuItem.Name = "top10ToolStripMenuItem";
            top10ToolStripMenuItem.Size = new Size(269, 36);
            top10ToolStripMenuItem.Text = "Top 10";
            top10ToolStripMenuItem.Click += top10ToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.Red;
            exitToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(269, 36);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Startscherm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.foto1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            Name = "Startscherm";
            Text = "Startscherm";
            Load += Startscherm_Load_1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem playGameToolStripMenuItem;
        private ToolStripMenuItem playerToolStripMenuItem;
        private ToolStripMenuItem scoresToolStripMenuItem;
        private ToolStripMenuItem top10ToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}

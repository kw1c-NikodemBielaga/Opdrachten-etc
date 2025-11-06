namespace T8_Praktijkopdracht
{
    partial class frmStartscherm
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
            themaToolStripMenuItem = new ToolStripMenuItem();
            moduleToolStripMenuItem = new ToolStripMenuItem();
            taakToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { themaToolStripMenuItem, moduleToolStripMenuItem, taakToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 213, 0, 3);
            menuStrip1.Size = new Size(219, 418);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // themaToolStripMenuItem
            // 
            themaToolStripMenuItem.BackColor = Color.FromArgb(0, 192, 0);
            themaToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            themaToolStripMenuItem.ImageTransparentColor = Color.Transparent;
            themaToolStripMenuItem.Name = "themaToolStripMenuItem";
            themaToolStripMenuItem.Padding = new Padding(100, 0, 5, 0);
            themaToolStripMenuItem.Size = new Size(204, 36);
            themaToolStripMenuItem.Text = "Thema";
            themaToolStripMenuItem.Click += themaToolStripMenuItem_Click;
            // 
            // moduleToolStripMenuItem
            // 
            moduleToolStripMenuItem.BackColor = Color.FromArgb(0, 192, 0);
            moduleToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            moduleToolStripMenuItem.ImageTransparentColor = Color.Transparent;
            moduleToolStripMenuItem.Name = "moduleToolStripMenuItem";
            moduleToolStripMenuItem.Size = new Size(204, 36);
            moduleToolStripMenuItem.Text = "Module";
            moduleToolStripMenuItem.Click += moduleToolStripMenuItem_Click;
            // 
            // taakToolStripMenuItem
            // 
            taakToolStripMenuItem.BackColor = Color.FromArgb(0, 192, 0);
            taakToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taakToolStripMenuItem.ImageTransparentColor = Color.Transparent;
            taakToolStripMenuItem.Name = "taakToolStripMenuItem";
            taakToolStripMenuItem.Size = new Size(204, 36);
            taakToolStripMenuItem.Text = "Taak";
            taakToolStripMenuItem.Click += taakToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.Red;
            exitToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitToolStripMenuItem.ImageTransparentColor = Color.Transparent;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(204, 36);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(0, 192, 0);
            textBox1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(939, 39);
            textBox1.TabIndex = 6;
            textBox1.Text = "                 Nou, laten we dan maar eens kijken wat we te doen hebben ";
            // 
            // frmStartscherm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Shrek;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(938, 418);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmStartscherm";
            Text = "frmStartscherm";
            Load += frmStartscherm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem themaToolStripMenuItem;
        private ToolStripMenuItem moduleToolStripMenuItem;
        private ToolStripMenuItem taakToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TextBox textBox1;
    }
}

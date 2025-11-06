namespace T8_VoetbalToernooi
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
            docentenToolStripMenuItem = new ToolStripMenuItem();
            temasToolStripMenuItem = new ToolStripMenuItem();
            toernooiToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { docentenToolStripMenuItem, temasToolStripMenuItem, toernooiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 120, 0, 2);
            menuStrip1.Size = new Size(126, 338);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // docentenToolStripMenuItem
            // 
            docentenToolStripMenuItem.BackColor = Color.Lime;
            docentenToolStripMenuItem.ForeColor = SystemColors.ControlText;
            docentenToolStripMenuItem.Name = "docentenToolStripMenuItem";
            docentenToolStripMenuItem.Size = new Size(113, 29);
            docentenToolStripMenuItem.Text = "Docenten";
            docentenToolStripMenuItem.Click += docentenToolStripMenuItem_Click;
            // 
            // temasToolStripMenuItem
            // 
            temasToolStripMenuItem.BackColor = Color.Lime;
            temasToolStripMenuItem.Name = "temasToolStripMenuItem";
            temasToolStripMenuItem.Size = new Size(113, 29);
            temasToolStripMenuItem.Text = "Teams";
            temasToolStripMenuItem.Click += temasToolStripMenuItem_Click;
            // 
            // toernooiToolStripMenuItem
            // 
            toernooiToolStripMenuItem.BackColor = Color.Lime;
            toernooiToolStripMenuItem.Name = "toernooiToolStripMenuItem";
            toernooiToolStripMenuItem.Size = new Size(113, 29);
            toernooiToolStripMenuItem.Text = "Toernooi";
            toernooiToolStripMenuItem.Click += toernooiToolStripMenuItem_Click;
            // 
            // Startscherm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Startschermfoto;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Startscherm";
            Text = "Startscherm";
            Load += Startscherm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem docentenToolStripMenuItem;
        private ToolStripMenuItem temasToolStripMenuItem;
        private ToolStripMenuItem toernooiToolStripMenuItem;
    }
}

namespace Oefening62
{
    partial class Form1
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
            bestandToolStripMenuItem = new ToolStripMenuItem();
            afsluitenToolStripMenuItem = new ToolStripMenuItem();
            studentenToolStripMenuItem = new ToolStripMenuItem();
            beheerToolStripMenuItem = new ToolStripMenuItem();
            groepenToolStripMenuItem = new ToolStripMenuItem();
            beheerToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { bestandToolStripMenuItem, studentenToolStripMenuItem, groepenToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            bestandToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { afsluitenToolStripMenuItem });
            bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            bestandToolStripMenuItem.Size = new Size(76, 24);
            bestandToolStripMenuItem.Text = "Bestand";
            // 
            // afsluitenToolStripMenuItem
            // 
            afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            afsluitenToolStripMenuItem.Size = new Size(150, 26);
            afsluitenToolStripMenuItem.Text = "Afsluiten";
            // 
            // studentenToolStripMenuItem
            // 
            studentenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { beheerToolStripMenuItem });
            studentenToolStripMenuItem.Name = "studentenToolStripMenuItem";
            studentenToolStripMenuItem.Size = new Size(90, 24);
            studentenToolStripMenuItem.Text = "Studenten";
            // 
            // beheerToolStripMenuItem
            // 
            beheerToolStripMenuItem.Name = "beheerToolStripMenuItem";
            beheerToolStripMenuItem.Size = new Size(138, 26);
            beheerToolStripMenuItem.Text = "Beheer";
            beheerToolStripMenuItem.Click += beheerToolStripMenuItem_Click;
            // 
            // groepenToolStripMenuItem
            // 
            groepenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { beheerToolStripMenuItem1 });
            groepenToolStripMenuItem.Name = "groepenToolStripMenuItem";
            groepenToolStripMenuItem.Size = new Size(84, 24);
            groepenToolStripMenuItem.Text = "Groepen ";
            // 
            // beheerToolStripMenuItem1
            // 
            beheerToolStripMenuItem1.Name = "beheerToolStripMenuItem1";
            beheerToolStripMenuItem1.Size = new Size(138, 26);
            beheerToolStripMenuItem1.Text = "Beheer";
            beheerToolStripMenuItem1.Click += beheerToolStripMenuItem1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "MainWindows";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem bestandToolStripMenuItem;
        private ToolStripMenuItem afsluitenToolStripMenuItem;
        private ToolStripMenuItem studentenToolStripMenuItem;
        private ToolStripMenuItem beheerToolStripMenuItem;
        private ToolStripMenuItem groepenToolStripMenuItem;
        private ToolStripMenuItem beheerToolStripMenuItem1;
    }
}

namespace T8_Praktijkopdracht.View
{
    partial class frmModuleOverview
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
            lvModule = new ListView();
            btnModuleVerwijderen = new Button();
            btnFoto = new Button();
            btnTaken = new Button();
            btnModuleFilteren = new Button();
            pbDocentFoto = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDocentFoto).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lvModule);
            groupBox1.Location = new Point(11, 35);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(570, 383);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Module's ";
            // 
            // lvModule
            // 
            lvModule.Location = new Point(7, 29);
            lvModule.Margin = new Padding(3, 4, 3, 4);
            lvModule.Name = "lvModule";
            lvModule.Size = new Size(547, 340);
            lvModule.TabIndex = 0;
            lvModule.UseCompatibleStateImageBehavior = false;
            // 
            // btnModuleVerwijderen
            // 
            btnModuleVerwijderen.BackColor = Color.FromArgb(0, 192, 0);
            btnModuleVerwijderen.Location = new Point(799, 370);
            btnModuleVerwijderen.Margin = new Padding(3, 4, 3, 4);
            btnModuleVerwijderen.Name = "btnModuleVerwijderen";
            btnModuleVerwijderen.Size = new Size(149, 48);
            btnModuleVerwijderen.TabIndex = 4;
            btnModuleVerwijderen.Text = "Module verwijderen";
            btnModuleVerwijderen.UseVisualStyleBackColor = false;
            btnModuleVerwijderen.Click += btnModuleVerwijderen_Click;
            // 
            // btnFoto
            // 
            btnFoto.BackColor = Color.FromArgb(0, 192, 0);
            btnFoto.Location = new Point(799, 305);
            btnFoto.Margin = new Padding(3, 4, 3, 4);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(149, 48);
            btnFoto.TabIndex = 5;
            btnFoto.Text = "Foto";
            btnFoto.UseVisualStyleBackColor = false;
            btnFoto.Click += btnFoto_Click;
            // 
            // btnTaken
            // 
            btnTaken.BackColor = Color.FromArgb(0, 192, 0);
            btnTaken.Location = new Point(644, 305);
            btnTaken.Margin = new Padding(3, 4, 3, 4);
            btnTaken.Name = "btnTaken";
            btnTaken.Size = new Size(149, 48);
            btnTaken.TabIndex = 7;
            btnTaken.Text = "Taken";
            btnTaken.UseVisualStyleBackColor = false;
            btnTaken.Click += btnTaken_Click;
            // 
            // btnModuleFilteren
            // 
            btnModuleFilteren.BackColor = Color.FromArgb(0, 192, 0);
            btnModuleFilteren.Location = new Point(644, 370);
            btnModuleFilteren.Margin = new Padding(3, 4, 3, 4);
            btnModuleFilteren.Name = "btnModuleFilteren";
            btnModuleFilteren.Size = new Size(149, 48);
            btnModuleFilteren.TabIndex = 8;
            btnModuleFilteren.Text = "Module filteren";
            btnModuleFilteren.UseVisualStyleBackColor = false;
            btnModuleFilteren.Click += btnModuleFilteren_Click;
            // 
            // pbDocentFoto
            // 
            pbDocentFoto.Location = new Point(687, 35);
            pbDocentFoto.Name = "pbDocentFoto";
            pbDocentFoto.Size = new Size(200, 200);
            pbDocentFoto.TabIndex = 9;
            pbDocentFoto.TabStop = false;
            // 
            // frmModuleOverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Shrek;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(959, 443);
            Controls.Add(pbDocentFoto);
            Controls.Add(btnModuleFilteren);
            Controls.Add(btnTaken);
            Controls.Add(btnFoto);
            Controls.Add(btnModuleVerwijderen);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmModuleOverview";
            Text = "frmModuleOverview";
            Load += frmModuleOverview_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbDocentFoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView lvModule;
        private Button btnModuleVerwijderen;
        private Button btnFoto;
        private Button btnTaken;
        private Button btnModuleFilteren;
        private PictureBox pbDocentFoto;
    }
}
namespace T8_VoetbalToernooi.View.Docent
{
    partial class DocentAdd
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
            lbName = new Label();
            lbEmail = new Label();
            btAdd = new Button();
            btCancel = new Button();
            tbEmail = new TextBox();
            tbName = new TextBox();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbName.Location = new Point(118, 51);
            lbName.Name = "lbName";
            lbName.Size = new Size(49, 20);
            lbName.TabIndex = 0;
            lbName.Text = "Naam";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEmail.Location = new Point(118, 112);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email";
            // 
            // btAdd
            // 
            btAdd.Location = new Point(178, 201);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(75, 23);
            btAdd.TabIndex = 2;
            btAdd.Text = "Toevoegen";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btCancel
            // 
            btCancel.Location = new Point(32, 201);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(75, 23);
            btCancel.TabIndex = 3;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(49, 135);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(178, 23);
            tbEmail.TabIndex = 4;
            // 
            // tbName
            // 
            tbName.Location = new Point(49, 74);
            tbName.Name = "tbName";
            tbName.Size = new Size(178, 23);
            tbName.TabIndex = 5;
            // 
            // DocentAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Startschermfoto;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(288, 264);
            Controls.Add(tbName);
            Controls.Add(tbEmail);
            Controls.Add(btCancel);
            Controls.Add(btAdd);
            Controls.Add(lbEmail);
            Controls.Add(lbName);
            Name = "DocentAdd";
            Text = "DocentAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbName;
        private Label lbEmail;
        private Button btAdd;
        private Button btCancel;
        private TextBox tbEmail;
        private TextBox tbName;
    }
}
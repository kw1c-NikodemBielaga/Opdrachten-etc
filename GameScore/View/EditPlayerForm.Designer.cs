namespace GameScore.View
{
    partial class EditPlayerForm
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
            btnSave = new Button();
            tbEmail = new TextBox();
            tbLastName = new TextBox();
            tbFirstName = new TextBox();
            tbPlayerName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            tbPlayerId = new TextBox();
            dtpDateofBirth = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnClose = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LimeGreen;
            groupBox2.Controls.Add(btnClose);
            groupBox2.Controls.Add(btnSave);
            groupBox2.Controls.Add(tbEmail);
            groupBox2.Controls.Add(tbLastName);
            groupBox2.Controls.Add(tbFirstName);
            groupBox2.Controls.Add(tbPlayerName);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(tbPlayerId);
            groupBox2.Controls.Add(dtpDateofBirth);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(47, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(376, 329);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Edit menu Player";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gold;
            btnSave.Location = new Point(20, 280);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(149, 41);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(118, 205);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(203, 27);
            tbEmail.TabIndex = 15;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(118, 160);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(130, 27);
            tbLastName.TabIndex = 14;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(118, 113);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(130, 27);
            tbFirstName.TabIndex = 13;
            // 
            // tbPlayerName
            // 
            tbPlayerName.Location = new Point(118, 69);
            tbPlayerName.Name = "tbPlayerName";
            tbPlayerName.Size = new Size(130, 27);
            tbPlayerName.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 10.2F);
            label6.Location = new Point(56, 205);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 9;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 10.2F);
            label5.Location = new Point(21, 161);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 8;
            label5.Text = "LastName";
            // 
            // tbPlayerId
            // 
            tbPlayerId.Location = new Point(118, 30);
            tbPlayerId.Name = "tbPlayerId";
            tbPlayerId.Size = new Size(130, 27);
            tbPlayerId.TabIndex = 7;
            // 
            // dtpDateofBirth
            // 
            dtpDateofBirth.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateofBirth.CustomFormat = "dd-MM-yyyy";
            dtpDateofBirth.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateofBirth.Format = DateTimePickerFormat.Custom;
            dtpDateofBirth.Location = new Point(118, 241);
            dtpDateofBirth.Name = "dtpDateofBirth";
            dtpDateofBirth.Size = new Size(130, 27);
            dtpDateofBirth.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.2F);
            label4.Location = new Point(11, 244);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 3;
            label4.Text = "DateofBirth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F);
            label3.Location = new Point(20, 117);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 2;
            label3.Text = "FirstName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.2F);
            label2.Location = new Point(6, 73);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 1;
            label2.Text = "PlayerName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.2F);
            label1.Location = new Point(36, 34);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "PlayerId";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Gold;
            btnClose.Location = new Point(204, 280);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(149, 41);
            btnClose.TabIndex = 17;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // EditPlayerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.foto1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(466, 351);
            Controls.Add(groupBox2);
            DoubleBuffered = true;
            Name = "EditPlayerForm";
            Text = "EditPlayerForm";
            Load += EditPlayerForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox tbEmail;
        private TextBox tbLastName;
        private TextBox tbFirstName;
        private TextBox tbPlayerName;
        private Label label6;
        private Label label5;
        private TextBox tbPlayerId;
        private DateTimePicker dtpDateofBirth;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSave;
        private Button btnClose;
    }
}
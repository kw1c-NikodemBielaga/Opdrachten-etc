namespace DrWho.View
{
    partial class frmDoctorEdit
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
            btnSave = new Button();
            btnCancel = new Button();
            dtpLastEpisode = new DateTimePicker();
            dtpFirstEpisode = new DateTimePicker();
            dtpBirthDate = new DateTimePicker();
            txtDoctorNumber = new TextBox();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(98, 269);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Opslaan";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(316, 269);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dtpLastEpisode
            // 
            dtpLastEpisode.Location = new Point(134, 204);
            dtpLastEpisode.Name = "dtpLastEpisode";
            dtpLastEpisode.Size = new Size(200, 23);
            dtpLastEpisode.TabIndex = 2;
            // 
            // dtpFirstEpisode
            // 
            dtpFirstEpisode.Location = new Point(134, 163);
            dtpFirstEpisode.Name = "dtpFirstEpisode";
            dtpFirstEpisode.Size = new Size(200, 23);
            dtpFirstEpisode.TabIndex = 3;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(134, 124);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(200, 23);
            dtpBirthDate.TabIndex = 4;
            // 
            // txtDoctorNumber
            // 
            txtDoctorNumber.Location = new Point(156, 36);
            txtDoctorNumber.Name = "txtDoctorNumber";
            txtDoctorNumber.Size = new Size(141, 23);
            txtDoctorNumber.TabIndex = 5;
            txtDoctorNumber.TextChanged += txtDoctorNumber_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(156, 76);
            txtName.Name = "txtName";
            txtName.Size = new Size(141, 23);
            txtName.TabIndex = 6;
            // 
            // frmDoctorEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 325);
            Controls.Add(txtName);
            Controls.Add(txtDoctorNumber);
            Controls.Add(dtpBirthDate);
            Controls.Add(dtpFirstEpisode);
            Controls.Add(dtpLastEpisode);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "frmDoctorEdit";
            Text = "frmDoctorEdit";
            Load += frmDoctorEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private DateTimePicker dtpLastEpisode;
        private DateTimePicker dtpFirstEpisode;
        private DateTimePicker dtpBirthDate;
        private TextBox txtDoctorNumber;
        private TextBox txtName;
    }
}
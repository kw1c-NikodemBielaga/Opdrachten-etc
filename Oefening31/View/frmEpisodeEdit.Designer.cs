namespace Oefening31.View
{
    partial class frmEpisodeEdit
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
            txtSeriesNumber = new TextBox();
            txtEpisodeNumber = new TextBox();
            txtTitle = new TextBox();
            dtpEpisodeDate = new DateTimePicker();
            btnSave = new Button();
            btnCancel = new Button();
            txtAuthorName = new TextBox();
            txtDoctorName = new TextBox();
            SuspendLayout();
            // 
            // txtSeriesNumber
            // 
            txtSeriesNumber.Location = new Point(111, 29);
            txtSeriesNumber.Name = "txtSeriesNumber";
            txtSeriesNumber.Size = new Size(116, 23);
            txtSeriesNumber.TabIndex = 0;
            // 
            // txtEpisodeNumber
            // 
            txtEpisodeNumber.Location = new Point(111, 76);
            txtEpisodeNumber.Name = "txtEpisodeNumber";
            txtEpisodeNumber.Size = new Size(116, 23);
            txtEpisodeNumber.TabIndex = 1;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(111, 121);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(116, 23);
            txtTitle.TabIndex = 2;
            // 
            // dtpEpisodeDate
            // 
            dtpEpisodeDate.Location = new Point(66, 164);
            dtpEpisodeDate.Name = "dtpEpisodeDate";
            dtpEpisodeDate.Size = new Size(200, 23);
            dtpEpisodeDate.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 276);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Opslaan";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(268, 276);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(111, 202);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(116, 23);
            txtAuthorName.TabIndex = 3;
            // 
            // txtDoctorName
            // 
            txtDoctorName.Location = new Point(111, 246);
            txtDoctorName.Name = "txtDoctorName";
            txtDoctorName.Size = new Size(116, 23);
            txtDoctorName.TabIndex = 4;
            // 
            // frmEpisodeEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 311);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dtpEpisodeDate);
            Controls.Add(txtDoctorName);
            Controls.Add(txtAuthorName);
            Controls.Add(txtTitle);
            Controls.Add(txtEpisodeNumber);
            Controls.Add(txtSeriesNumber);
            Name = "frmEpisodeEdit";
            Text = "frmEpisodeEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSeriesNumber;
        private TextBox txtEpisodeNumber;
        private TextBox txtTitle;
        private DateTimePicker dtpEpisodeDate;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtAuthorName;
        private TextBox txtDoctorName;
    }
}
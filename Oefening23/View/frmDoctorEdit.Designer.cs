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
            btnSave.Location = new Point(112, 359);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 31);
            btnSave.TabIndex = 0;
            btnSave.Text = "Opslaan";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(361, 359);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dtpLastEpisode
            // 
            dtpLastEpisode.Location = new Point(153, 272);
            dtpLastEpisode.Margin = new Padding(3, 4, 3, 4);
            dtpLastEpisode.Name = "dtpLastEpisode";
            dtpLastEpisode.Size = new Size(228, 27);
            dtpLastEpisode.TabIndex = 2;
            // 
            // dtpFirstEpisode
            // 
            dtpFirstEpisode.Location = new Point(153, 217);
            dtpFirstEpisode.Margin = new Padding(3, 4, 3, 4);
            dtpFirstEpisode.Name = "dtpFirstEpisode";
            dtpFirstEpisode.Size = new Size(228, 27);
            dtpFirstEpisode.TabIndex = 3;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(153, 165);
            dtpBirthDate.Margin = new Padding(3, 4, 3, 4);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(228, 27);
            dtpBirthDate.TabIndex = 4;
            // 
            // txtDoctorNumber
            // 
            txtDoctorNumber.Location = new Point(178, 48);
            txtDoctorNumber.Margin = new Padding(3, 4, 3, 4);
            txtDoctorNumber.Name = "txtDoctorNumber";
            txtDoctorNumber.Size = new Size(161, 27);
            txtDoctorNumber.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(178, 101);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(161, 27);
            txtName.TabIndex = 6;
            // 
            // frmDoctorEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 433);
            Controls.Add(txtName);
            Controls.Add(txtDoctorNumber);
            Controls.Add(dtpBirthDate);
            Controls.Add(dtpFirstEpisode);
            Controls.Add(dtpLastEpisode);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Margin = new Padding(3, 4, 3, 4);
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
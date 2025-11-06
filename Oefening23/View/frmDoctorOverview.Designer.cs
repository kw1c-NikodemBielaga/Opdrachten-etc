
namespace DrWho.View
{
    partial class frmDoctorOverview
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
            btnDelete = new Button();
            btnEdit = new Button();
            lvDoctors = new ListView();
            btnClose = new Button();
            btnAdd = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(537, 295);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 36);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Verwijderen";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(382, 295);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(131, 36);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Bewerken";
            btnEdit.TextAlign = ContentAlignment.MiddleRight;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // lvDoctors
            // 
            lvDoctors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvDoctors.HeaderStyle = ColumnHeaderStyle.None;
            lvDoctors.Location = new Point(32, 74);
            lvDoctors.Margin = new Padding(3, 2, 3, 2);
            lvDoctors.Name = "lvDoctors";
            lvDoctors.Size = new Size(638, 204);
            lvDoctors.TabIndex = 11;
            lvDoctors.UseCompatibleStateImageBehavior = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(534, 7);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(131, 36);
            btnClose.TabIndex = 14;
            btnClose.Text = "Sluiten";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(32, 295);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(131, 36);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Toevoegen";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = false;
            // label1
            // 
            label1.Font = new Font("Segoe UI", 19.8F);
            label1.Location = new Point(32, 9);
            label1.Name = "label1";
            label1.Size = new Size(208, 34);
            label1.TabIndex = 13;
            label1.Text = "Doctors";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmDoctorOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(lvDoctors);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmDoctorOverview";
            Text = "frmDoctorOverview";
            Load += frmDoctorOverview_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListView lvDoctors;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
    }
}
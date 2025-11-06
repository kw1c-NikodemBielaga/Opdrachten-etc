namespace T8_Praktijkopdracht.View
{
    partial class TakenPerModule
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
            lvTakenPerModule = new ListView();
            groupBox1.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lvTakenPerModule);
            groupBox1.Location = new Point(17, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(627, 289);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Taken";
            // 
            // lvTakenPerModule
            // 
            lvTakenPerModule.Location = new Point(6, 22);
            lvTakenPerModule.Name = "lvTakenPerModule";
            lvTakenPerModule.Size = new Size(605, 256);
            lvTakenPerModule.TabIndex = 0;
            lvTakenPerModule.UseCompatibleStateImageBehavior = false;
            // 
            // TakenPerModule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Shrek;
            ClientSize = new Size(656, 340);
            Controls.Add(groupBox1);
            Name = "TakenPerModule";
            Text = "TakenPerModule";
            Load += TakenPerModule_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView lvTakenPerModule;
    }
}
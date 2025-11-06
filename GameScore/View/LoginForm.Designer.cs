namespace GameScore.View
{
    partial class LoginForm
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
            btnLogin = new Button();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LimeGreen;
            groupBox2.Controls.Add(btnLogin);
            groupBox2.Controls.Add(tbUsername);
            groupBox2.Controls.Add(tbPassword);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(26, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(347, 282);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Login menu";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Gold;
            btnLogin.Location = new Point(91, 224);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(149, 41);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(48, 89);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(238, 27);
            tbUsername.TabIndex = 7;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(48, 170);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(238, 27);
            tbPassword.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 11F);
            label2.Location = new Point(118, 145);
            label2.Name = "label2";
            label2.Size = new Size(100, 22);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label1.Location = new Point(118, 65);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.foto1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(409, 331);
            Controls.Add(groupBox2);
            DoubleBuffered = true;
            Name = "LoginForm";
            Text = "LoginForm";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button btnLogin;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label label2;
        private Label label1;
    }
}
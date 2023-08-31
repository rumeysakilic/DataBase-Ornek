namespace LogInScreen
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
            btnLogin = new Button();
            label1 = new Label();
            txtUser = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(297, 265);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(129, 29);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "LogIn";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(50, 24);
            label1.Name = "label1";
            label1.Size = new Size(442, 54);
            label1.TabIndex = 1;
            label1.Text = "Welcome LogIn Screen";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(186, 121);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(240, 27);
            txtUser.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 121);
            label2.Name = "label2";
            label2.Size = new Size(135, 31);
            label2.TabIndex = 3;
            label2.Text = "User Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(78, 196);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(186, 196);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(240, 27);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(585, 381);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtUser);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label label1;
        private TextBox txtUser;
        private Label label2;
        private Label label3;
        private TextBox txtPassword;
    }
}
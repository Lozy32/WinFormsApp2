namespace WinFormsApp2
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            btnNext = new Button();
            btnBack = new Button();
            lblLogin = new Label();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(30, 55);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(200, 23);
            txtLogin.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(30, 115);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 2;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(30, 160);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(90, 30);
            btnNext.TabIndex = 0;
            btnNext.Text = "Далее";
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(140, 160);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 30);
            btnBack.TabIndex = 1;
            btnBack.Text = "Назад";
            btnBack.Click += btnBack_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(30, 30);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(44, 15);
            lblLogin.TabIndex = 5;
            lblLogin.Text = "Логин:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(30, 90);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(52, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Пароль:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 221);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblLogin);
            Name = "LoginForm";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
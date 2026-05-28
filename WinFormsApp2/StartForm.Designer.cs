namespace WinFormsApp2
{
    partial class StartForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnLogin = new Button();
            btnRegister = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(80, 100);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 40);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Авторизация";
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(220, 100);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(120, 40);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Регистрация";
            btnRegister.Click += btnRegister_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(100, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(259, 30);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Медицинская клиника";
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 211);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Controls.Add(lblTitle);
            Name = "StartForm";
            Text = "Главная";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
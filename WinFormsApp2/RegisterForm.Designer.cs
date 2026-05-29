namespace WinFormsApp2
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;

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
            txtFullName = new TextBox();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnNext = new Button();
            btnBack = new Button();
            lblFullName = new Label();
            lblLogin = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            cmbRole = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(30, 50);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(220, 23);
            txtFullName.TabIndex = 5;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(30, 100);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(220, 23);
            txtLogin.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(30, 150);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(220, 23);
            txtPassword.TabIndex = 3;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(30, 200);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(220, 23);
            txtConfirmPassword.TabIndex = 2;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(30, 258);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(100, 30);
            btnNext.TabIndex = 0;
            btnNext.Text = "Далее";
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(150, 258);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 30);
            btnBack.TabIndex = 1;
            btnBack.Text = "Назад";
            btnBack.Click += btnBack_Click;
            // 
            // lblFullName
            // 
            lblFullName.Location = new Point(30, 30);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(100, 23);
            lblFullName.TabIndex = 9;
            lblFullName.Text = "ФИО:";
            // 
            // lblLogin
            // 
            lblLogin.Location = new Point(30, 80);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(100, 23);
            lblLogin.TabIndex = 8;
            lblLogin.Text = "Логин:";
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(30, 130);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 23);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Пароль:";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.Location = new Point(30, 180);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(100, 23);
            lblConfirmPassword.TabIndex = 6;
            lblConfirmPassword.Text = "Подтверждение:";
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Администратор", "Врач", "Пациент" });
            cmbRole.Location = new Point(79, 229);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(121, 23);
            cmbRole.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 232);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 11;
            label1.Text = "Роль";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 311);
            Controls.Add(label1);
            Controls.Add(cmbRole);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(txtFullName);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblLogin);
            Controls.Add(lblFullName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        private ComboBox cmbRole;
        private Label label1;
    }
}

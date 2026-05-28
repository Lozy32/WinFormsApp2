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
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // Labels
            this.lblFullName.Location = new System.Drawing.Point(30, 30);
            this.lblFullName.Text = "ФИО:";
            this.lblLogin.Location = new System.Drawing.Point(30, 80);
            this.lblLogin.Text = "Логин:";
            this.lblPassword.Location = new System.Drawing.Point(30, 130);
            this.lblPassword.Text = "Пароль:";
            this.lblConfirmPassword.Location = new System.Drawing.Point(30, 180);
            this.lblConfirmPassword.Text = "Подтверждение:";
            // TextBoxes
            this.txtFullName.Location = new System.Drawing.Point(30, 50);
            this.txtFullName.Size = new System.Drawing.Size(220, 23);
            this.txtLogin.Location = new System.Drawing.Point(30, 100);
            this.txtLogin.Size = new System.Drawing.Size(220, 23);
            this.txtPassword.Location = new System.Drawing.Point(30, 150);
            this.txtPassword.Size = new System.Drawing.Size(220, 23);
            this.txtPassword.PasswordChar = '*';
            this.txtConfirmPassword.Location = new System.Drawing.Point(30, 200);
            this.txtConfirmPassword.Size = new System.Drawing.Size(220, 23);
            this.txtConfirmPassword.PasswordChar = '*';
            // Buttons
            this.btnNext.Location = new System.Drawing.Point(30, 250);
            this.btnNext.Size = new System.Drawing.Size(100, 30);
            this.btnNext.Text = "Далее";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnBack.Location = new System.Drawing.Point(150, 250);
            this.btnBack.Size = new System.Drawing.Size(100, 30);
            this.btnBack.Text = "Назад";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 311);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblFullName);
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

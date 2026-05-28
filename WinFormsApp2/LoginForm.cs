using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp2.Data;
using WinFormsApp2.Models;
using WinFormsApp2.Helpers;

namespace WinFormsApp2
{
    public partial class LoginForm : Form
    {
        private string _tempLogin = "";
        private string _tempPassword = "";
        private readonly UserRepository _userRepo;

        public LoginForm()
        {
            InitializeComponent();
            _userRepo = new UserRepository();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _tempLogin = txtLogin.Text.Trim();
            _tempPassword = txtPassword.Text;

            if (string.IsNullOrEmpty(_tempLogin) || string.IsNullOrEmpty(_tempPassword))
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }

            var captchaForm = new CaptchaForm(PerformLogin, () => { });
            captchaForm.ShowDialog();
        }

        private void PerformLogin()
        {
            User user = _userRepo.FindByLogin(_tempLogin);

            if (user != null && PasswordHasher.Verify(_tempPassword, user.PasswordSalt, user.PasswordHash))
            {
                MessageBox.Show($"Добро пожаловать, {user.FullName}!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                MainForm mainForm = new MainForm(user);
                mainForm.Show();

                this.Hide();  
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Clear();
                txtPassword.Clear();
                txtLogin.Focus();
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
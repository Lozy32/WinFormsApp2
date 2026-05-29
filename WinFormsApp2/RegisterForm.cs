using Microsoft.Data.Sqlite;
using System;
using System.Windows.Forms;
using WinFormsApp2.Data;
using WinFormsApp2.Helpers;
using WinFormsApp2.Models;

namespace WinFormsApp2
{
    public partial class RegisterForm : Form
    {
        private string _tempFullName = "";
        private string _tempLogin = "";
        private string _tempPassword = "";
        private readonly UserRepository _userRepo;

        private int _selectedRoleId;
        private string _selectedRoleName;

        public RegisterForm()
        {
            InitializeComponent();
            _userRepo = new UserRepository();

          
            cmbRole.Items.Clear();
            cmbRole.Items.Add("Администратор");
            cmbRole.Items.Add("Врач");
            cmbRole.Items.Add("Пациент");
            cmbRole.SelectedIndex = 2;
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _tempFullName = txtFullName.Text.Trim();
            _tempLogin = txtLogin.Text.Trim();
            _tempPassword = txtPassword.Text;
            string confirm = txtConfirmPassword.Text;

          
            if (string.IsNullOrWhiteSpace(_tempFullName))
            {
                MessageBox.Show("Введите ФИО");
                return;
            }
            if (string.IsNullOrWhiteSpace(_tempLogin) || _tempLogin.Length < 3)
            {
                MessageBox.Show("Логин должен содержать минимум 3 символа");
                return;
            }
            if (string.IsNullOrWhiteSpace(_tempPassword) || _tempPassword.Length < 4)
            {
                MessageBox.Show("Пароль должен содержать минимум 4 символа");
                return;
            }
            if (_tempPassword != confirm)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }
            if (_userRepo.LoginExists(_tempLogin))
            {
                MessageBox.Show("Этот логин уже занят!");
                return;
            }

            
            string selectedRole = cmbRole.SelectedItem?.ToString() ?? "Пациент";

            _selectedRoleId = selectedRole switch
            {
                "Администратор" => 1,
                "Врач" => 2,
                "Пациент" => 3,
                _ => 3
            };
            _selectedRoleName = selectedRole;

           
            var captchaForm = new CaptchaForm(PerformRegistration, () => { });
            captchaForm.ShowDialog();
        }

        private void PerformRegistration()
        {
            
            _userRepo.CreateUser(_tempLogin, _tempPassword, _tempFullName, _selectedRoleId);

            
            var user = _userRepo.FindByLogin(_tempLogin);

            
            if (_selectedRoleId == 2 && user != null)
            {
                var doctorRepo = new DoctorRepository();
                doctorRepo.CreateFromUser(user.Id, _tempFullName, "Терапевт", 1500);
            }

           
            if (_selectedRoleId == 3)
            {
                var patientRepo = new PatientRepository();
                patientRepo.Add(new Patient
                {
                    FullName = _tempFullName,
                    BirthDate = "",
                    Phone = ""
                });
            }

            MessageBox.Show($"Пользователь {_tempLogin} успешно зарегистрирован! (Роль: {_selectedRoleName})");
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
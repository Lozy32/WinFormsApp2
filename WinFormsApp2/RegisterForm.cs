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


            Label lblRole = new Label();
            lblRole.Text = "Роль:";
            lblRole.Location = new Point(30, 230);
            lblRole.Size = new Size(60, 25);
            this.Controls.Add(lblRole);

            
            ComboBox cmbRole = new ComboBox();
            cmbRole.Name = "cmbRole";
            cmbRole.Location = new Point(100, 227);
            cmbRole.Size = new Size(150, 25);
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Items.Add("Администратор");
            cmbRole.Items.Add("Врач");
            cmbRole.Items.Add("Пациент");
            cmbRole.SelectedIndex = 2; 
            this.Controls.Add(cmbRole);
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
                MessageBox.Show("Этот логин уже занят!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var captchaForm = new CaptchaForm(PerformRegistration, () => { });
            captchaForm.ShowDialog();
        }

        private void PerformRegistration()
        {
            // Создаем пользователя
            _userRepo.CreateUser(_tempLogin, _tempPassword, _tempFullName, _selectedRoleId);

            // Если роль "Пациент" (user), добавляем запись в таблицу Patients
            if (_selectedRoleId == 3)  // roleId = 3 для пациента
            {
                var patientRepo = new PatientRepository();
                patientRepo.Add(new Patient
                {
                    FullName = _tempFullName,  // ФИО из регистрации
                    BirthDate = "",
                    Phone = ""
                });
            }

            MessageBox.Show($"Пользователь {_tempLogin} успешно зарегистрирован!");
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
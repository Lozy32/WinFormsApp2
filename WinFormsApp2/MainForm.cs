using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp2.Data;
using WinFormsApp2.Models;


namespace WinFormsApp2
{
    public partial class MainForm : Form
    {
        private readonly User _currentUser;
        private readonly ActionLogRepository _logRepo;

        public MainForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
            _logRepo = new ActionLogRepository(user.Id, user.Login);
            ConfigureMenuByRole();
            lblWelcome.Text = $"Добро пожаловать, {user.FullName}! (Роль: {user.RoleName})";
        }

        private void ConfigureMenuByRole()
        {
            bool isAdmin = _currentUser.RoleName == "admin";
            bool isOperator = _currentUser.RoleName == "operator";
            bool isUser = _currentUser.RoleName == "user";

            // Настройка видимости пунктов меню
            doctorsMenuItem.Visible = isAdmin;      // Врачи - только для админа
            logsMenuItem.Visible = isAdmin;         // Журнал - только для админа
            patientsMenuItem.Visible = true;        // Пациенты - все видят
            appointmentsMenuItem.Visible = true;    // Приемы - все видят

            // Для пользователя (врача) - только просмотр
            if (isUser)
            {
                patientsMenuItem.Text = "Пациенты (просмотр)";
                appointmentsMenuItem.Text = "Мои приемы";
            }
        }

        private void patientsMenuItem_Click(object sender, EventArgs e)
        {
            var form = new PatientsForm(_logRepo);
            form.ShowDialog();
        }

        private void appointmentsMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AppointmentsForm(_logRepo);
            form.ShowDialog();
        }

        private void doctorsMenuItem_Click(object sender, EventArgs e)
        {
            var form = new DoctorsForm(_logRepo);
            form.ShowDialog();
        }

        private void logsMenuItem_Click(object sender, EventArgs e)
        {
            var form = new LogsForm();
            form.ShowDialog();
        }

        private void logoutMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
using Microsoft.VisualBasic;
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
    public partial class AppointmentsForm : Form
    {
        private readonly ActionLogRepository _logRepo;
        private readonly AppointmentRepository _appointmentRepo;
        private readonly DoctorRepository _doctorRepo;
        private readonly PatientRepository _patientRepo;

        public AppointmentsForm(ActionLogRepository logRepo)
        {
            InitializeComponent();
            _logRepo = logRepo;
            _appointmentRepo = new AppointmentRepository();
            _doctorRepo = new DoctorRepository();
            _patientRepo = new PatientRepository();

            Button btnCalculate = new Button()
            {
                Text = "Рассчитать",
                Location = new Point(580, 260),
                Size = new Size(100, 35),
                BackColor = Color.LightBlue
            };
            btnCalculate.Click += (s, e) => CalculatePrice();
            this.Controls.Add(btnCalculate);

            LoadDoctors();
            LoadPatients();
            LoadAppointments();
        }

        private void LoadDoctors()
        {
            var doctors = _doctorRepo.GetAll();
            cmbDoctor.DataSource = doctors;
            cmbDoctor.DisplayMember = "FullName";
            cmbDoctor.ValueMember = "Id";
            cmbDoctor.SelectedIndex = -1;
        }

        private void LoadPatients()
        {
            var patients = _patientRepo.GetAll();
            cmbPatient.DataSource = patients;
            cmbPatient.DisplayMember = "FullName";
            cmbPatient.ValueMember = "Id";
            cmbPatient.SelectedIndex = -1;
        }

        private void LoadAppointments()
        {
            var appointments = _appointmentRepo.GetAll();
            dataGridViewAppointments.DataSource = appointments;

            // Проверяем, что колонки существуют
            var cols = dataGridViewAppointments.Columns;
            if (cols == null) return;

            // Скрываем ID колонки
            if (cols.Contains("Id")) cols["Id"].Visible = false;
            if (cols.Contains("PatientId")) cols["PatientId"].Visible = false;
            if (cols.Contains("DoctorId")) cols["DoctorId"].Visible = false;

            // Устанавливаем заголовки
            if (cols.Contains("PatientName")) cols["PatientName"].HeaderText = "Пациент";
            if (cols.Contains("DoctorName")) cols["DoctorName"].HeaderText = "Врач";
            if (cols.Contains("AppointmentDate")) cols["AppointmentDate"].HeaderText = "Дата и время";
            if (cols.Contains("VisitType")) cols["VisitType"].HeaderText = "Тип приема";
            if (cols.Contains("FinalPrice")) cols["FinalPrice"].HeaderText = "Стоимость";
        }


        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDoctor.SelectedItem == null)
            {
                lblPrice.Text = "Стоимость: 0 руб.";
                return;
            }

            try
            {
                int doctorId = (int)cmbDoctor.SelectedValue;

                using var connection = DbConnectionFactory.Create();
                connection.Open();
                using var command = connection.CreateCommand();
                command.CommandText = "SELECT BasePrice FROM Doctors WHERE Id = $id";
                command.Parameters.AddWithValue("$id", doctorId);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    decimal basePrice = Convert.ToDecimal(result);
                    decimal finalPrice = basePrice;
                    if (cmbVisitType.SelectedItem?.ToString() == "Повторный")
                        finalPrice = basePrice * 0.8m;
                    lblPrice.Text = $"Стоимость: {finalPrice:F2} руб.";
                }
                else
                {
                    lblPrice.Text = "Стоимость: 0 руб.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
                lblPrice.Text = "Стоимость: 0 руб.";
            }
        }

        private void cmbVisitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void CalculatePrice()
        {
            if (cmbDoctor.SelectedItem == null)
            {
                lblPrice.Text = "Выберите врача!";
                return;
            }

            if (cmbDoctor.SelectedValue == null)
            {
                lblPrice.Text = "Ошибка: не удалось получить ID врача";
                return;
            }

            try
            {
                int doctorId = (int)cmbDoctor.SelectedValue;

                using var connection = DbConnectionFactory.Create();
                connection.Open();
                using var command = connection.CreateCommand();
                command.CommandText = "SELECT BasePrice FROM Doctors WHERE Id = $id";
                command.Parameters.AddWithValue("$id", doctorId);

                var result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    decimal basePrice = Convert.ToDecimal(result);
                    decimal finalPrice = basePrice;

                    string? visitType = cmbVisitType.SelectedItem?.ToString();
                    if (visitType == "Повторный")
                        finalPrice = basePrice * 0.8m;

                    lblPrice.Text = $"Стоимость: {finalPrice:F2} руб.";
                }
                else
                {
                    lblPrice.Text = "Стоимость: 0 руб.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
                lblPrice.Text = "Стоимость: 0 руб.";
            }
        }

        private decimal CalculateFinalPrice()
        {
            if (cmbDoctor.SelectedItem is Doctor doctor)
            {
                decimal price = doctor.BasePrice;
                if (cmbVisitType.SelectedItem?.ToString() == "Повторный")
                    price = price * 0.8m;
                return price;
            }
            return 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbPatient.SelectedItem == null)
            {
                MessageBox.Show("Выберите пациента");
                return;
            }
            if (cmbDoctor.SelectedItem == null)
            {
                MessageBox.Show("Выберите врача");
                return;
            }
            if (cmbVisitType.SelectedItem == null)
            {
                MessageBox.Show("Выберите тип приема");
                return;
            }

            var appointment = new Appointment
            {
                PatientId = (int)cmbPatient.SelectedValue,
                DoctorId = (int)cmbDoctor.SelectedValue,
                AppointmentDate = dtpDate.Value.ToString("yyyy-MM-dd HH:mm"),
                VisitType = cmbVisitType.SelectedItem?.ToString() ?? "Первичный",
                FinalPrice = CalculateFinalPrice()
            };

            _appointmentRepo.Add(appointment);

            string patientName = cmbPatient.Text;
            string doctorName = cmbDoctor.Text;
            _logRepo.Add("CREATE", "Appointment", $"Запись: {patientName} → {doctorName} на {appointment.AppointmentDate}");

            LoadAppointments();
            ClearInputs();
            MessageBox.Show("Запись успешно добавлена!");
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись для редактирования");
                return;
            }

            if (cmbPatient.SelectedItem == null || cmbDoctor.SelectedItem == null || cmbVisitType.SelectedItem == null)
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            var appointment = (Appointment)dataGridViewAppointments.CurrentRow.DataBoundItem;
            string oldInfo = $"{appointment.PatientName} → {appointment.DoctorName}";

            appointment.PatientId = (int)cmbPatient.SelectedValue;
            appointment.DoctorId = (int)cmbDoctor.SelectedValue;
            appointment.AppointmentDate = dtpDate.Value.ToString("yyyy-MM-dd HH:mm");
            appointment.VisitType = cmbVisitType.SelectedItem.ToString();
            appointment.FinalPrice = CalculateFinalPrice();

            _appointmentRepo.Update(appointment);
            _logRepo.Add("UPDATE", "Appointment", $"Изменена запись: {oldInfo} → {cmbPatient.Text} → {cmbDoctor.Text}");

            LoadAppointments();
            MessageBox.Show("Запись успешно обновлена!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись для удаления");
                return;
            }

            var appointment = (Appointment)dataGridViewAppointments.CurrentRow.DataBoundItem;

            if (MessageBox.Show($"Удалить запись {appointment.PatientName} → {appointment.DoctorName}?",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _appointmentRepo.Delete(appointment.Id);
                _logRepo.Add("DELETE", "Appointment", $"Удалена запись: {appointment.PatientName} → {appointment.DoctorName}");
                LoadAppointments();
                ClearInputs();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            cmbPatient.SelectedIndex = -1;
            cmbDoctor.SelectedIndex = -1;
            dtpDate.Value = DateTime.Now.AddHours(1);
            cmbVisitType.SelectedIndex = 0;
            lblPrice.Text = "Стоимость: 0 руб.";
        }

        private void dataGridViewAppointments_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.CurrentRow != null && dataGridViewAppointments.CurrentRow.DataBoundItem is Appointment appointment)
            {
                cmbPatient.SelectedValue = appointment.PatientId;
                cmbDoctor.SelectedValue = appointment.DoctorId;
                if (DateTime.TryParse(appointment.AppointmentDate, out DateTime date))
                    dtpDate.Value = date;
                cmbVisitType.SelectedItem = appointment.VisitType;
                CalculatePrice();
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Простая проверка
            if (cmbDoctor.SelectedItem == null)
            {
                MessageBox.Show("Сначала выберите врача!");
                lblPrice.Text = "Стоимость: 0 руб.";
                return;
            }

            try
            {
                int doctorId = (int)cmbDoctor.SelectedValue;

                using var connection = DbConnectionFactory.Create();
                connection.Open();
                using var command = connection.CreateCommand();
                command.CommandText = "SELECT BasePrice FROM Doctors WHERE Id = $id";
                command.Parameters.AddWithValue("$id", doctorId);

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    decimal basePrice = Convert.ToDecimal(result);
                    decimal finalPrice = basePrice;

                    if (cmbVisitType.SelectedItem?.ToString() == "Повторный")
                        finalPrice = basePrice * 0.8m;

                    lblPrice.Text = $"Стоимость: {finalPrice:F2} руб.";
                    MessageBox.Show($"Цена: {finalPrice} руб.");
                }
                else
                {
                    MessageBox.Show("Цена не найдена в базе данных!");
                    lblPrice.Text = "Стоимость: 0 руб.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
                lblPrice.Text = "Стоимость: 0 руб.";
            }
        }
    }
}
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
    public partial class PatientsForm : Form
    {
        private readonly ActionLogRepository _logRepo;
        private readonly PatientRepository _patientRepo;

        public PatientsForm(ActionLogRepository logRepo)
        {
            InitializeComponent();
            _logRepo = logRepo;
            _patientRepo = new PatientRepository();

            // Привязка кнопок (если не привязаны в дизайнере)
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;

            LoadPatients();
        }
        private void LoadPatients()
        {
            string searchText = txtSearch?.Text.Trim() ?? "";
            var patients = _patientRepo.GetAll(searchText);
            dataGridViewPatients.DataSource = patients;

            if (dataGridViewPatients.Columns.Contains("Id"))
                dataGridViewPatients.Columns["Id"].Visible = false;
            if (dataGridViewPatients.Columns.Contains("FullName"))
                dataGridViewPatients.Columns["FullName"].HeaderText = "ФИО";
            if (dataGridViewPatients.Columns.Contains("BirthDate"))
                dataGridViewPatients.Columns["BirthDate"].HeaderText = "Дата рождения";
            if (dataGridViewPatients.Columns.Contains("Phone"))
                dataGridViewPatients.Columns["Phone"].HeaderText = "Телефон";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadPatients();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txtSearch != null)
                txtSearch.Clear();
            txtFullName.Clear();
            txtBirthDate.Clear();
            txtPhone.Clear();
            LoadPatients();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Введите ФИО пациента");
                return;
            }

            var patient = new Patient
            {
                FullName = txtFullName.Text.Trim(),
                BirthDate = txtBirthDate.Text.Trim(),
                Phone = txtPhone.Text.Trim()
            };

            _patientRepo.Add(patient);
            _logRepo.Add("CREATE", "Patient", $"Добавлен пациент: {patient.FullName}");
            LoadPatients();
            ClearInputs();
            MessageBox.Show("Пациент успешно добавлен!");
        }

        // Редактирование пациента (button2)
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись для редактирования");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Введите ФИО пациента");
                return;
            }

            var patient = (Patient)dataGridViewPatients.CurrentRow.DataBoundItem;
            string oldName = patient.FullName;

            patient.FullName = txtFullName.Text.Trim();
            patient.BirthDate = txtBirthDate.Text.Trim();
            patient.Phone = txtPhone.Text.Trim();

            _patientRepo.Update(patient);
            _logRepo.Add("UPDATE", "Patient", $"Изменен пациент: {oldName} → {patient.FullName}");
            LoadPatients();
            MessageBox.Show("Пациент успешно обновлен!");
        }

        // Удаление пациента (button3)
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись для удаления");
                return;
            }

            var patient = (Patient)dataGridViewPatients.CurrentRow.DataBoundItem;

            if (MessageBox.Show($"Удалить пациента '{patient.FullName}'?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _patientRepo.Delete(patient.Id);
                _logRepo.Add("DELETE", "Patient", $"Удален пациент: {patient.FullName}");
                LoadPatients();
                ClearInputs();
            }
        }

        private void ClearInputs()
        {
            txtFullName.Clear();
            txtBirthDate.Clear();
            txtPhone.Clear();
        }

        private void dataGridViewPatients_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPatients.CurrentRow != null)
            {
                var patient = (Patient)dataGridViewPatients.CurrentRow.DataBoundItem;
                txtFullName.Text = patient.FullName;
                txtBirthDate.Text = patient.BirthDate;
                txtPhone.Text = patient.Phone;
            }
        }
    }
}
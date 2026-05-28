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
    public partial class DoctorsForm : Form
    {
        private readonly ActionLogRepository _logRepo;
        private readonly DoctorRepository _doctorRepo;

        public DoctorsForm(ActionLogRepository logRepo)
        {
            InitializeComponent();
            _logRepo = logRepo;
            _doctorRepo = new DoctorRepository();
            LoadDoctors();
        }

        private void LoadDoctors()
        {
            var doctors = _doctorRepo.GetAll();
            dataGridViewDoctors.DataSource = doctors;

            
            if (dataGridViewDoctors.Columns["Id"] != null)
                dataGridViewDoctors.Columns["Id"].Visible = false;
            if (dataGridViewDoctors.Columns["FullName"] != null)
                dataGridViewDoctors.Columns["FullName"].HeaderText = "ФИО врача";
            if (dataGridViewDoctors.Columns["Specialization"] != null)
                dataGridViewDoctors.Columns["Specialization"].HeaderText = "Специализация";
            if (dataGridViewDoctors.Columns["BasePrice"] != null)
                dataGridViewDoctors.Columns["BasePrice"].HeaderText = "Базовая цена (руб.)";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new DoctorEditForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _doctorRepo.Add(form.Doctor);
                LoadDoctors();
                ClearInputs();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewDoctors.CurrentRow == null)
            {
                MessageBox.Show("Выберите врача для редактирования", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var doctor = (Doctor)dataGridViewDoctors.CurrentRow.DataBoundItem;
            var form = new DoctorEditForm(doctor);
            if (form.ShowDialog() == DialogResult.OK)
            {
                _doctorRepo.Update(form.Doctor);
                LoadDoctors();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewDoctors.CurrentRow == null)
            {
                MessageBox.Show("Выберите врача для удаления", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var doctor = (Doctor)dataGridViewDoctors.CurrentRow.DataBoundItem;

            if (MessageBox.Show($"Удалить врача '{doctor.FullName}'?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _doctorRepo.Delete(doctor.Id);
                LoadDoctors();
                ClearInputs();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            var doctors = _doctorRepo.GetAll(searchText);
            dataGridViewDoctors.DataSource = doctors;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadDoctors();
        }

        private void dataGridViewDoctors_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewDoctors.CurrentRow != null)
            {
                var doctor = (Doctor)dataGridViewDoctors.CurrentRow.DataBoundItem;
                txtFullName.Text = doctor.FullName;
                txtSpecialization.Text = doctor.Specialization;
                numPrice.Value = doctor.BasePrice;
            }
        }

        private void ClearInputs()
        {
            txtFullName.Clear();
            txtSpecialization.Clear();
            numPrice.Value = 0;
        }
    }
}
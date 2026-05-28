using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp2.Models;

namespace WinFormsApp2
{
    public partial class DoctorEditForm : Form
    {
        public Doctor Doctor { get; private set; }
        private readonly bool _isEdit;

        public DoctorEditForm(Doctor doctor = null)
        {
            InitializeComponent();

            if (doctor != null)
            {
                _isEdit = true;
                Doctor = doctor;
                txtFullName.Text = doctor.FullName;
                txtSpecialization.Text = doctor.Specialization;
                numPrice.Value = doctor.BasePrice;
                this.Text = "Редактирование врача";
            }
            else
            {
                _isEdit = false;
                Doctor = new Doctor();
                this.Text = "Добавление врача";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Введите ФИО врача", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSpecialization.Text))
            {
                MessageBox.Show("Введите специализацию", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Doctor.FullName = txtFullName.Text.Trim();
            Doctor.Specialization = txtSpecialization.Text.Trim();
            Doctor.BasePrice = numPrice.Value;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
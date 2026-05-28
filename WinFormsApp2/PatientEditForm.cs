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
    public partial class PatientEditForm : Form
    {
        public Patient Patient { get; private set; }
        private readonly bool _isEdit;

        public PatientEditForm(Patient patient = null)
        {
            InitializeComponent();

            if (patient != null)
            {
                _isEdit = true;
                Patient = patient;
                txtFullName.Text = patient.FullName;
                txtBirthDate.Text = patient.BirthDate;
                txtPhone.Text = patient.Phone;
                this.Text = "Редактирование пациента";
            }
            else
            {
                _isEdit = false;
                Patient = new Patient();
                this.Text = "Добавление пациента";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Введите ФИО пациента", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Patient.FullName = txtFullName.Text.Trim();
            Patient.BirthDate = txtBirthDate.Text.Trim();
            Patient.Phone = txtPhone.Text.Trim();

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
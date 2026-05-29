namespace WinFormsApp2
{
    partial class AppointmentsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.ComboBox cmbDoctorFilter;
        private System.Windows.Forms.Label lblDoctorFilter;
        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblVisitType;
        private System.Windows.Forms.ComboBox cmbVisitType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewAppointments = new DataGridView();
            cmbDoctorFilter = new ComboBox();
            lblDoctorFilter = new Label();
            groupBoxList = new GroupBox();
            groupBoxDetails = new GroupBox();
            lblPatient = new Label();
            cmbPatient = new ComboBox();
            lblDoctor = new Label();
            cmbDoctor = new ComboBox();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            lblVisitType = new Label();
            cmbVisitType = new ComboBox();
            lblPrice = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnCalculate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).BeginInit();
            groupBoxList.SuspendLayout();
            groupBoxDetails.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewAppointments
            // 
            dataGridViewAppointments.AllowUserToAddRows = false;
            dataGridViewAppointments.AllowUserToDeleteRows = false;
            dataGridViewAppointments.Dock = DockStyle.Fill;
            dataGridViewAppointments.Location = new Point(3, 19);
            dataGridViewAppointments.MultiSelect = false;
            dataGridViewAppointments.Name = "dataGridViewAppointments";
            dataGridViewAppointments.ReadOnly = true;
            dataGridViewAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAppointments.Size = new Size(544, 358);
            dataGridViewAppointments.TabIndex = 0;
            // 
            // cmbDoctorFilter
            // 
            cmbDoctorFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDoctorFilter.Location = new Point(120, 397);
            cmbDoctorFilter.Name = "cmbDoctorFilter";
            cmbDoctorFilter.Size = new Size(200, 23);
            cmbDoctorFilter.TabIndex = 2;
            // 
            // lblDoctorFilter
            // 
            lblDoctorFilter.Location = new Point(15, 400);
            lblDoctorFilter.Name = "lblDoctorFilter";
            lblDoctorFilter.Size = new Size(100, 23);
            lblDoctorFilter.TabIndex = 1;
            lblDoctorFilter.Text = "Фильтр по врачу:";
            // 
            // groupBoxList
            // 
            groupBoxList.Controls.Add(dataGridViewAppointments);
            groupBoxList.Location = new Point(12, 12);
            groupBoxList.Name = "groupBoxList";
            groupBoxList.Size = new Size(550, 380);
            groupBoxList.TabIndex = 0;
            groupBoxList.TabStop = false;
            groupBoxList.Text = "Список записей";
            // 
            // groupBoxDetails
            // 
            groupBoxDetails.Controls.Add(lblPatient);
            groupBoxDetails.Controls.Add(cmbPatient);
            groupBoxDetails.Controls.Add(lblDoctor);
            groupBoxDetails.Controls.Add(cmbDoctor);
            groupBoxDetails.Controls.Add(lblDate);
            groupBoxDetails.Controls.Add(dtpDate);
            groupBoxDetails.Controls.Add(lblVisitType);
            groupBoxDetails.Controls.Add(cmbVisitType);
            groupBoxDetails.Controls.Add(lblPrice);
            groupBoxDetails.Location = new Point(570, 12);
            groupBoxDetails.Name = "groupBoxDetails";
            groupBoxDetails.Size = new Size(350, 300);
            groupBoxDetails.TabIndex = 3;
            groupBoxDetails.TabStop = false;
            groupBoxDetails.Text = "Данные записи";
            // 
            // lblPatient
            // 
            lblPatient.Location = new Point(10, 30);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(58, 23);
            lblPatient.TabIndex = 0;
            lblPatient.Text = "Пациент:";
            // 
            // cmbPatient
            // 
            cmbPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPatient.Location = new Point(85, 30);
            cmbPatient.Name = "cmbPatient";
            cmbPatient.Size = new Size(240, 23);
            cmbPatient.TabIndex = 1;
            // 
            // lblDoctor
            // 
            lblDoctor.Location = new Point(10, 65);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(58, 23);
            lblDoctor.TabIndex = 2;
            lblDoctor.Text = "Врач:";
            // 
            // cmbDoctor
            // 
            cmbDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDoctor.Location = new Point(85, 65);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(240, 23);
            cmbDoctor.TabIndex = 3;
            // 
            // lblDate
            // 
            lblDate.Location = new Point(10, 100);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(100, 23);
            lblDate.TabIndex = 4;
            lblDate.Text = "Дата и время:";
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "yyyy-MM-dd HH:mm";
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(116, 100);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(150, 23);
            dtpDate.TabIndex = 5;
            // 
            // lblVisitType
            // 
            lblVisitType.Location = new Point(10, 135);
            lblVisitType.Name = "lblVisitType";
            lblVisitType.Size = new Size(100, 23);
            lblVisitType.TabIndex = 6;
            lblVisitType.Text = "Тип приема:";
            // 
            // cmbVisitType
            // 
            cmbVisitType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVisitType.Items.AddRange(new object[] { "Первичный", "Повторный" });
            cmbVisitType.Location = new Point(116, 132);
            cmbVisitType.Name = "cmbVisitType";
            cmbVisitType.Size = new Size(120, 23);
            cmbVisitType.TabIndex = 7;
            // 
            // lblPrice
            // 
            lblPrice.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPrice.ForeColor = Color.Green;
            lblPrice.Location = new Point(10, 170);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(200, 25);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Стоимость: 0 руб.";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(590, 330);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 35);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Добавить";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(700, 330);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 35);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Изменить";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(810, 330);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 35);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Удалить";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(700, 380);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 35);
            btnClear.TabIndex = 7;
            btnClear.Text = "Очистить";
            btnClear.Click += btnClear_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(590, 380);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(100, 35);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Рассчитать";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // AppointmentsForm
            // 
            ClientSize = new Size(934, 461);
            Controls.Add(btnCalculate);
            Controls.Add(groupBoxList);
            Controls.Add(lblDoctorFilter);
            Controls.Add(cmbDoctorFilter);
            Controls.Add(groupBoxDetails);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AppointmentsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Приемы";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).EndInit();
            groupBoxList.ResumeLayout(false);
            groupBoxDetails.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Button btnCalculate;
    }
}
namespace WinFormsApp2
{
    partial class PatientsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewPatients = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnClear = new Button();
            txtFullName = new TextBox();
            txtBirthDate = new TextBox();
            txtPhone = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            lblSearch = new Label();
            lblFullName = new Label();
            lblBirthDate = new Label();
            lblPhone = new Label();
            groupBoxList = new GroupBox();
            groupBoxDetails = new GroupBox();
            lblRole = new Label();
            cmbRole = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).BeginInit();
            groupBoxList.SuspendLayout();
            groupBoxDetails.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewPatients
            // 
            dataGridViewPatients.AllowUserToAddRows = false;
            dataGridViewPatients.AllowUserToDeleteRows = false;
            dataGridViewPatients.Dock = DockStyle.Fill;
            dataGridViewPatients.Location = new Point(3, 19);
            dataGridViewPatients.MultiSelect = false;
            dataGridViewPatients.Name = "dataGridViewPatients";
            dataGridViewPatients.ReadOnly = true;
            dataGridViewPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPatients.Size = new Size(494, 328);
            dataGridViewPatients.TabIndex = 0;
            dataGridViewPatients.SelectionChanged += dataGridViewPatients_SelectionChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(64, 372);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 23);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(270, 370);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 30);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Найти";
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(355, 370);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 30);
            btnClear.TabIndex = 4;
            btnClear.Text = "Сброс";
            btnClear.Click += btnClear_Click;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(80, 27);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(250, 23);
            txtFullName.TabIndex = 1;
            // 
            // txtBirthDate
            // 
            txtBirthDate.Location = new Point(80, 62);
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.Size = new Size(150, 23);
            txtBirthDate.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(80, 97);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 23);
            txtPhone.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(30, 270);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 35);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Добавить";
            btnAdd.Click += button1_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(130, 270);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 35);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Изменить";
            btnEdit.Click += button2_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(230, 270);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 35);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Удалить";
            btnDelete.Click += button3_Click;
            // 
            // lblSearch
            // 
            lblSearch.Location = new Point(3, 375);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(55, 23);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Поиск:";
            // 
            // lblFullName
            // 
            lblFullName.Location = new Point(10, 30);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(64, 23);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "ФИО:";
            // 
            // lblBirthDate
            // 
            lblBirthDate.Location = new Point(10, 65);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(64, 23);
            lblBirthDate.TabIndex = 2;
            lblBirthDate.Text = "Дата рождения:";
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(10, 100);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(64, 23);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Телефон:";
            // 
            // groupBoxList
            // 
            groupBoxList.Controls.Add(dataGridViewPatients);
            groupBoxList.Location = new Point(12, 12);
            groupBoxList.Name = "groupBoxList";
            groupBoxList.Size = new Size(500, 350);
            groupBoxList.TabIndex = 0;
            groupBoxList.TabStop = false;
            groupBoxList.Text = "Список пациентов";
            // 
            // groupBoxDetails
            // 
            groupBoxDetails.Controls.Add(lblFullName);
            groupBoxDetails.Controls.Add(txtFullName);
            groupBoxDetails.Controls.Add(lblBirthDate);
            groupBoxDetails.Controls.Add(txtBirthDate);
            groupBoxDetails.Controls.Add(lblPhone);
            groupBoxDetails.Controls.Add(txtPhone);
            groupBoxDetails.Location = new Point(520, 12);
            groupBoxDetails.Name = "groupBoxDetails";
            groupBoxDetails.Size = new Size(350, 250);
            groupBoxDetails.TabIndex = 5;
            groupBoxDetails.TabStop = false;
            groupBoxDetails.Text = "Данные пациента";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(30, 240);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(37, 15);
            lblRole.TabIndex = 9;
            lblRole.Text = "Роль:";
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Location = new Point(110, 237);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(150, 23);
            cmbRole.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(544, 339);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(651, 339);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Изменить";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(755, 339);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 13;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            // 
            // PatientsForm
            // 
            ClientSize = new Size(884, 461);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBoxList);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(groupBoxDetails);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(lblRole);
            Controls.Add(cmbRole);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PatientsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Пациенты";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).EndInit();
            groupBoxList.ResumeLayout(false);
            groupBoxDetails.ResumeLayout(false);
            groupBoxDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
        private Button button2;
        private Button button3;
    }
}

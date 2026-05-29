namespace WinFormsApp2
{
    partial class DoctorsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewDoctors;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtSpecialization;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblSpecialization;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.GroupBox groupBoxDetails;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewDoctors = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnClear = new Button();
            txtFullName = new TextBox();
            txtSpecialization = new TextBox();
            numPrice = new NumericUpDown();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            lblSearch = new Label();
            lblFullName = new Label();
            lblSpecialization = new Label();
            lblPrice = new Label();
            groupBoxList = new GroupBox();
            groupBoxDetails = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            groupBoxList.SuspendLayout();
            groupBoxDetails.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewDoctors
            // 
            dataGridViewDoctors.AllowUserToAddRows = false;
            dataGridViewDoctors.AllowUserToDeleteRows = false;
            dataGridViewDoctors.Dock = DockStyle.Fill;
            dataGridViewDoctors.Location = new Point(3, 19);
            dataGridViewDoctors.MultiSelect = false;
            dataGridViewDoctors.Name = "dataGridViewDoctors";
            dataGridViewDoctors.ReadOnly = true;
            dataGridViewDoctors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDoctors.Size = new Size(494, 328);
            dataGridViewDoctors.TabIndex = 0;
            dataGridViewDoctors.SelectionChanged += dataGridViewDoctors_SelectionChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(60, 372);
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
            txtFullName.Location = new Point(110, 27);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(220, 23);
            txtFullName.TabIndex = 1;
            // 
            // txtSpecialization
            // 
            txtSpecialization.Location = new Point(110, 62);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.Size = new Size(220, 23);
            txtSpecialization.TabIndex = 3;
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 2;
            numPrice.Location = new Point(150, 97);
            numPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(120, 23);
            numPrice.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(540, 230);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 35);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Добавить";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(650, 230);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 35);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Изменить";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(760, 230);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 35);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Удалить";
            btnDelete.Click += btnDelete_Click;
            // 
            // lblSearch
            // 
            lblSearch.Location = new Point(12, 375);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(100, 23);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Поиск:";
            // 
            // lblFullName
            // 
            lblFullName.Location = new Point(10, 30);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(100, 23);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "ФИО врача:";
            // 
            // lblSpecialization
            // 
            lblSpecialization.Location = new Point(10, 65);
            lblSpecialization.Name = "lblSpecialization";
            lblSpecialization.Size = new Size(100, 23);
            lblSpecialization.TabIndex = 2;
            lblSpecialization.Text = "Специализация:";
            // 
            // lblPrice
            // 
            lblPrice.Location = new Point(10, 100);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(100, 23);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Базовая цена (руб.):";
            // 
            // groupBoxList
            // 
            groupBoxList.Controls.Add(dataGridViewDoctors);
            groupBoxList.Location = new Point(12, 12);
            groupBoxList.Name = "groupBoxList";
            groupBoxList.Size = new Size(500, 350);
            groupBoxList.TabIndex = 0;
            groupBoxList.TabStop = false;
            groupBoxList.Text = "Список врачей";
            // 
            // groupBoxDetails
            // 
            groupBoxDetails.Controls.Add(lblFullName);
            groupBoxDetails.Controls.Add(txtFullName);
            groupBoxDetails.Controls.Add(lblSpecialization);
            groupBoxDetails.Controls.Add(txtSpecialization);
            groupBoxDetails.Controls.Add(lblPrice);
            groupBoxDetails.Controls.Add(numPrice);
            groupBoxDetails.Location = new Point(520, 12);
            groupBoxDetails.Name = "groupBoxDetails";
            groupBoxDetails.Size = new Size(350, 200);
            groupBoxDetails.TabIndex = 5;
            groupBoxDetails.TabStop = false;
            groupBoxDetails.Text = "Данные врача";
            // 
            // DoctorsForm
            // 
            ClientSize = new Size(884, 461);
            Controls.Add(groupBoxList);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(groupBoxDetails);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DoctorsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Врачи";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctors).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            groupBoxList.ResumeLayout(false);
            groupBoxDetails.ResumeLayout(false);
            groupBoxDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
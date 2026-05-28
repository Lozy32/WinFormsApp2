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
            this.dataGridViewDoctors = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtSpecialization = new System.Windows.Forms.TextBox();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblSpecialization = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.groupBoxList.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            this.SuspendLayout();

            // groupBoxList
            this.groupBoxList.Text = "Список врачей";
            this.groupBoxList.Location = new System.Drawing.Point(12, 12);
            this.groupBoxList.Size = new System.Drawing.Size(500, 350);

            // dataGridViewDoctors
            this.dataGridViewDoctors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDoctors.AllowUserToAddRows = false;
            this.dataGridViewDoctors.AllowUserToDeleteRows = false;
            this.dataGridViewDoctors.ReadOnly = true;
            this.dataGridViewDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDoctors.MultiSelect = false;
            this.dataGridViewDoctors.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewDoctors.Size = new System.Drawing.Size(494, 325);
            this.dataGridViewDoctors.SelectionChanged += new System.EventHandler(this.dataGridViewDoctors_SelectionChanged);

            this.groupBoxList.Controls.Add(this.dataGridViewDoctors);

            // lblSearch
            this.lblSearch.Text = "Поиск:";
            this.lblSearch.Location = new System.Drawing.Point(12, 375);

            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(60, 372);
            this.txtSearch.Size = new System.Drawing.Size(200, 23);

            // btnSearch
            this.btnSearch.Text = "Найти";
            this.btnSearch.Location = new System.Drawing.Point(270, 370);
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // btnClear
            this.btnClear.Text = "Сброс";
            this.btnClear.Location = new System.Drawing.Point(355, 370);
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // groupBoxDetails
            this.groupBoxDetails.Text = "Данные врача";
            this.groupBoxDetails.Location = new System.Drawing.Point(520, 12);
            this.groupBoxDetails.Size = new System.Drawing.Size(350, 200);

            // lblFullName
            this.lblFullName.Text = "ФИО врача:";
            this.lblFullName.Location = new System.Drawing.Point(10, 30);

            // txtFullName
            this.txtFullName.Location = new System.Drawing.Point(110, 27);
            this.txtFullName.Size = new System.Drawing.Size(220, 23);

            // lblSpecialization
            this.lblSpecialization.Text = "Специализация:";
            this.lblSpecialization.Location = new System.Drawing.Point(10, 65);

            // txtSpecialization
            this.txtSpecialization.Location = new System.Drawing.Point(110, 62);
            this.txtSpecialization.Size = new System.Drawing.Size(220, 23);

            // lblPrice
            this.lblPrice.Text = "Базовая цена (руб.):";
            this.lblPrice.Location = new System.Drawing.Point(10, 100);

            // numPrice
            this.numPrice.Location = new System.Drawing.Point(150, 97);
            this.numPrice.Minimum = 0;
            this.numPrice.Maximum = 10000;
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Size = new System.Drawing.Size(120, 23);

            this.groupBoxDetails.Controls.Add(this.lblFullName);
            this.groupBoxDetails.Controls.Add(this.txtFullName);
            this.groupBoxDetails.Controls.Add(this.lblSpecialization);
            this.groupBoxDetails.Controls.Add(this.txtSpecialization);
            this.groupBoxDetails.Controls.Add(this.lblPrice);
            this.groupBoxDetails.Controls.Add(this.numPrice);

            // btnAdd
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Location = new System.Drawing.Point(540, 230);
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnEdit
            this.btnEdit.Text = "Изменить";
            this.btnEdit.Location = new System.Drawing.Point(650, 230);
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // btnDelete
            this.btnDelete.Text = "Удалить";
            this.btnDelete.Location = new System.Drawing.Point(760, 230);
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // Добавление контролов
            this.Controls.Add(this.groupBoxList);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);

            this.Text = "Врачи";
            this.Size = new System.Drawing.Size(900, 500);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.groupBoxList.ResumeLayout(false);
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
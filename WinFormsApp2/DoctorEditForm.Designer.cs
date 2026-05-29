namespace WinFormsApp2
{
    partial class DoctorEditForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblSpecialization;
        private System.Windows.Forms.TextBox txtSpecialization;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblSpecialization = new Label();
            txtSpecialization = new TextBox();
            lblPrice = new Label();
            numPrice = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            SuspendLayout();
            // 
            // lblFullName
            // 
            lblFullName.Location = new Point(20, 25);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(100, 23);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "ФИО врача:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(130, 22);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(250, 23);
            txtFullName.TabIndex = 1;
            // 
            // lblSpecialization
            // 
            lblSpecialization.Location = new Point(20, 60);
            lblSpecialization.Name = "lblSpecialization";
            lblSpecialization.Size = new Size(100, 23);
            lblSpecialization.TabIndex = 2;
            lblSpecialization.Text = "Специализация:";
            // 
            // txtSpecialization
            // 
            txtSpecialization.Location = new Point(130, 57);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.Size = new Size(250, 23);
            txtSpecialization.TabIndex = 3;
            // 
            // lblPrice
            // 
            lblPrice.Location = new Point(20, 95);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(100, 23);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Базовая цена (руб.):";
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 2;
            numPrice.Location = new Point(150, 92);
            numPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(120, 23);
            numPrice.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(100, 140);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 35);
            btnSave.TabIndex = 6;
            btnSave.Text = "Сохранить";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(220, 140);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Отмена";
            btnCancel.Click += btnCancel_Click;
            // 
            // DoctorEditForm
            // 
            ClientSize = new Size(420, 210);
            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Controls.Add(lblSpecialization);
            Controls.Add(txtSpecialization);
            Controls.Add(lblPrice);
            Controls.Add(numPrice);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DoctorEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Врач";
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

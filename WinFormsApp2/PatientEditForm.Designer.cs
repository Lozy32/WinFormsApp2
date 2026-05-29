namespace WinFormsApp2
{
    partial class PatientEditForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
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
            lblBirthDate = new Label();
            txtBirthDate = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblFullName
            // 
            lblFullName.Location = new Point(20, 25);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(100, 23);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "ФИО:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(100, 22);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(250, 23);
            txtFullName.TabIndex = 1;
            // 
            // lblBirthDate
            // 
            lblBirthDate.Location = new Point(20, 60);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(100, 23);
            lblBirthDate.TabIndex = 2;
            lblBirthDate.Text = "Дата рождения:";
            // 
            // txtBirthDate
            // 
            txtBirthDate.Location = new Point(130, 57);
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.Size = new Size(150, 23);
            txtBirthDate.TabIndex = 3;
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(20, 95);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 23);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Телефон:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(100, 92);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 23);
            txtPhone.TabIndex = 5;
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
            // PatientEditForm
            // 
            ClientSize = new Size(400, 210);
            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Controls.Add(lblBirthDate);
            Controls.Add(txtBirthDate);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PatientEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Пациент";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
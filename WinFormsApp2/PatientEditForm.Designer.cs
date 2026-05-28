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
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblFullName.Text = "ФИО:";
            this.lblFullName.Location = new System.Drawing.Point(20, 25);

            this.txtFullName.Location = new System.Drawing.Point(100, 22);
            this.txtFullName.Size = new System.Drawing.Size(250, 23);

            this.lblBirthDate.Text = "Дата рождения:";
            this.lblBirthDate.Location = new System.Drawing.Point(20, 60);

            this.txtBirthDate.Location = new System.Drawing.Point(130, 57);
            this.txtBirthDate.Size = new System.Drawing.Size(150, 23);

            this.lblPhone.Text = "Телефон:";
            this.lblPhone.Location = new System.Drawing.Point(20, 95);

            this.txtPhone.Location = new System.Drawing.Point(100, 92);
            this.txtPhone.Size = new System.Drawing.Size(200, 23);

            this.btnSave.Text = "Сохранить";
            this.btnSave.Location = new System.Drawing.Point(100, 140);
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.Text = "Отмена";
            this.btnCancel.Location = new System.Drawing.Point(220, 140);
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.Text = "Пациент";
            this.ClientSize = new System.Drawing.Size(400, 210);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
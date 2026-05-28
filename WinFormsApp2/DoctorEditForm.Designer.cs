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
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblSpecialization = new System.Windows.Forms.Label();
            this.txtSpecialization = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();

            this.lblFullName.Text = "ФИО врача:";
            this.lblFullName.Location = new System.Drawing.Point(20, 25);

            this.txtFullName.Location = new System.Drawing.Point(130, 22);
            this.txtFullName.Size = new System.Drawing.Size(250, 23);

            this.lblSpecialization.Text = "Специализация:";
            this.lblSpecialization.Location = new System.Drawing.Point(20, 60);

            this.txtSpecialization.Location = new System.Drawing.Point(130, 57);
            this.txtSpecialization.Size = new System.Drawing.Size(250, 23);

            this.lblPrice.Text = "Базовая цена (руб.):";
            this.lblPrice.Location = new System.Drawing.Point(20, 95);

            this.numPrice.Location = new System.Drawing.Point(150, 92);
            this.numPrice.Minimum = 0;
            this.numPrice.Maximum = 10000;
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Size = new System.Drawing.Size(120, 23);

            this.btnSave.Text = "Сохранить";
            this.btnSave.Location = new System.Drawing.Point(100, 140);
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.Text = "Отмена";
            this.btnCancel.Location = new System.Drawing.Point(220, 140);
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.Text = "Врач";
            this.ClientSize = new System.Drawing.Size(420, 210);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblSpecialization);
            this.Controls.Add(this.txtSpecialization);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);

            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

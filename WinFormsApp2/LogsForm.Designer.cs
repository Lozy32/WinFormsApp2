namespace WinFormsApp2
{
    partial class LogsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewLogs;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBoxList;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewLogs = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBoxList = new System.Windows.Forms.GroupBox();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).BeginInit();
            this.groupBoxList.SuspendLayout();
            this.SuspendLayout();

            // groupBoxList
            this.groupBoxList.Text = "Журнал действий";
            this.groupBoxList.Location = new System.Drawing.Point(12, 12);
            this.groupBoxList.Size = new System.Drawing.Size(800, 400);

            // dataGridViewLogs
            this.dataGridViewLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLogs.AllowUserToAddRows = false;
            this.dataGridViewLogs.AllowUserToDeleteRows = false;
            this.dataGridViewLogs.ReadOnly = true;
            this.dataGridViewLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLogs.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewLogs.Size = new System.Drawing.Size(794, 375);

            this.groupBoxList.Controls.Add(this.dataGridViewLogs);

            // btnRefresh
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.Location = new System.Drawing.Point(600, 425);
            this.btnRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // btnClear
            this.btnClear.Text = "Очистить журнал";
            this.btnClear.Location = new System.Drawing.Point(710, 425);
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.Controls.Add(this.groupBoxList);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClear);

            this.Text = "Журнал действий";
            this.Size = new System.Drawing.Size(850, 500);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).EndInit();
            this.groupBoxList.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
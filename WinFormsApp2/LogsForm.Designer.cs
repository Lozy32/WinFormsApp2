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
            dataGridViewLogs = new DataGridView();
            btnRefresh = new Button();
            btnClear = new Button();
            groupBoxList = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLogs).BeginInit();
            groupBoxList.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewLogs
            // 
            dataGridViewLogs.AllowUserToAddRows = false;
            dataGridViewLogs.AllowUserToDeleteRows = false;
            dataGridViewLogs.Dock = DockStyle.Fill;
            dataGridViewLogs.Location = new Point(3, 19);
            dataGridViewLogs.Name = "dataGridViewLogs";
            dataGridViewLogs.ReadOnly = true;
            dataGridViewLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLogs.Size = new Size(794, 378);
            dataGridViewLogs.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(600, 425);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 35);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Обновить";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(710, 425);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 35);
            btnClear.TabIndex = 2;
            btnClear.Text = "Очистить журнал";
            btnClear.Click += btnClear_Click;
            // 
            // groupBoxList
            // 
            groupBoxList.Controls.Add(dataGridViewLogs);
            groupBoxList.Location = new Point(12, 12);
            groupBoxList.Name = "groupBoxList";
            groupBoxList.Size = new Size(800, 400);
            groupBoxList.TabIndex = 0;
            groupBoxList.TabStop = false;
            groupBoxList.Text = "Журнал действий";
            // 
            // LogsForm
            // 
            ClientSize = new Size(834, 461);
            Controls.Add(groupBoxList);
            Controls.Add(btnRefresh);
            Controls.Add(btnClear);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LogsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Журнал действий";
            ((System.ComponentModel.ISupportInitialize)dataGridViewLogs).EndInit();
            groupBoxList.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
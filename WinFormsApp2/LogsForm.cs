using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp2.Data;

namespace WinFormsApp2
{
    public partial class LogsForm : Form
    {
        private readonly ActionLogRepository _logRepo;

        public LogsForm()
        {
            InitializeComponent();
            _logRepo = new ActionLogRepository();
            LoadLogs();
        }

        private void LoadLogs()
        {
            var logs = _logRepo.GetAll();
            dataGridViewLogs.DataSource = logs;

            
            if (dataGridViewLogs.Columns["Id"] != null)
                dataGridViewLogs.Columns["Id"].Visible = false;
            if (dataGridViewLogs.Columns["UserId"] != null)
                dataGridViewLogs.Columns["UserId"].Visible = false;
            if (dataGridViewLogs.Columns["UserLogin"] != null)
                dataGridViewLogs.Columns["UserLogin"].HeaderText = "Пользователь";
            if (dataGridViewLogs.Columns["ActionType"] != null)
                dataGridViewLogs.Columns["ActionType"].HeaderText = "Действие";
            if (dataGridViewLogs.Columns["EntityName"] != null)
                dataGridViewLogs.Columns["EntityName"].HeaderText = "Сущность";
            if (dataGridViewLogs.Columns["Details"] != null)
                dataGridViewLogs.Columns["Details"].HeaderText = "Детали";
            if (dataGridViewLogs.Columns["CreatedAt"] != null)
                dataGridViewLogs.Columns["CreatedAt"].HeaderText = "Дата и время";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadLogs();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистить журнал действий?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                using var connection = DbConnectionFactory.Create();
                connection.Open();
                using var command = connection.CreateCommand();
                command.CommandText = "DELETE FROM ActionLogs";
                command.ExecuteNonQuery();
                LoadLogs();
            }
        }
    }
}
namespace WinFormsApp2
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsMenuItem;
        private System.Windows.Forms.ToolStripSeparator separator;
        private System.Windows.Forms.ToolStripMenuItem logoutMenuItem;
        private System.Windows.Forms.Label lblWelcome;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            mainMenuItem = new ToolStripMenuItem();
            patientsMenuItem = new ToolStripMenuItem();
            appointmentsMenuItem = new ToolStripMenuItem();
            doctorsMenuItem = new ToolStripMenuItem();
            logsMenuItem = new ToolStripMenuItem();
            separator = new ToolStripSeparator();
            logoutMenuItem = new ToolStripMenuItem();
            lblWelcome = new Label();
            label1 = new Label();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { mainMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(5, 2, 0, 2);
            menuStrip.Size = new Size(700, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // mainMenuItem
            // 
            mainMenuItem.DropDownItems.AddRange(new ToolStripItem[] { patientsMenuItem, appointmentsMenuItem, doctorsMenuItem, logsMenuItem, separator, logoutMenuItem });
            mainMenuItem.Name = "mainMenuItem";
            mainMenuItem.Size = new Size(99, 20);
            mainMenuItem.Text = "Главное меню";
            // 
            // patientsMenuItem
            // 
            patientsMenuItem.Name = "patientsMenuItem";
            patientsMenuItem.Size = new Size(171, 22);
            patientsMenuItem.Text = "Пациенты";
            patientsMenuItem.Click += patientsMenuItem_Click;
            // 
            // appointmentsMenuItem
            // 
            appointmentsMenuItem.Name = "appointmentsMenuItem";
            appointmentsMenuItem.Size = new Size(171, 22);
            appointmentsMenuItem.Text = "Приемы";
            appointmentsMenuItem.Click += appointmentsMenuItem_Click;
            // 
            // doctorsMenuItem
            // 
            doctorsMenuItem.Name = "doctorsMenuItem";
            doctorsMenuItem.Size = new Size(171, 22);
            doctorsMenuItem.Text = "Врачи";
            doctorsMenuItem.Click += doctorsMenuItem_Click;
            // 
            // logsMenuItem
            // 
            logsMenuItem.Name = "logsMenuItem";
            logsMenuItem.Size = new Size(171, 22);
            logsMenuItem.Text = "Журнал действий";
            logsMenuItem.Click += logsMenuItem_Click;
            // 
            // separator
            // 
            separator.Name = "separator";
            separator.Size = new Size(168, 6);
            // 
            // logoutMenuItem
            // 
            logoutMenuItem.Name = "logoutMenuItem";
            logoutMenuItem.Size = new Size(171, 22);
            logoutMenuItem.Text = "Выход";
            logoutMenuItem.Click += logoutMenuItem_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblWelcome.Location = new Point(12, 38);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(168, 21);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Добро пожаловать!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 98);
            label1.Name = "label1";
            label1.Size = new Size(186, 128);
            label1.TabIndex = 2;
            label1.Text = "🏥";
            label1.Click += label1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label1);
            Controls.Add(lblWelcome);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Медицинская клиника";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
    }
}
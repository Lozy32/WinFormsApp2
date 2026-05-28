namespace WinFormsApp2
{
    partial class CaptchaForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCaptchaCode;
        private System.Windows.Forms.TextBox txtCaptchaInput;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblMessage;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblCaptchaCode = new Label();
            txtCaptchaInput = new TextBox();
            btnVerify = new Button();
            btnRefresh = new Button();
            btnCancel = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // lblCaptchaCode
            // 
            lblCaptchaCode.BackColor = Color.LightGray;
            lblCaptchaCode.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblCaptchaCode.Location = new Point(160, 40);
            lblCaptchaCode.Name = "lblCaptchaCode";
            lblCaptchaCode.Size = new Size(200, 50);
            lblCaptchaCode.TabIndex = 5;
            lblCaptchaCode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCaptchaInput
            // 
            txtCaptchaInput.Location = new Point(160, 118);
            txtCaptchaInput.Name = "txtCaptchaInput";
            txtCaptchaInput.Size = new Size(200, 23);
            txtCaptchaInput.TabIndex = 4;
            // 
            // btnVerify
            // 
            btnVerify.Location = new Point(160, 151);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(90, 30);
            btnVerify.TabIndex = 3;
            btnVerify.Text = "Проверить";
            btnVerify.Click += btnVerify_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(270, 151);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 30);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Обновить";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(210, 187);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 30);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Отмена";
            btnCancel.Click += btnCancel_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(105, 253);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 15);
            lblMessage.TabIndex = 0;
            // 
            // CaptchaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 391);
            Controls.Add(lblMessage);
            Controls.Add(btnCancel);
            Controls.Add(btnRefresh);
            Controls.Add(btnVerify);
            Controls.Add(txtCaptchaInput);
            Controls.Add(lblCaptchaCode);
            Name = "CaptchaForm";
            Text = "Подтверждение";
            Load += CaptchaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
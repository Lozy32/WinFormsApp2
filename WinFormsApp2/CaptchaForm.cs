using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class CaptchaForm : Form
    {
        private string _currentCaptcha = "";
        private readonly Action _onSuccess;
        private readonly Action _onCancel;
        private readonly Random _random = new Random();

        // 👇 ДЛЯ БЛОКИРОВКИ - указываем полное имя System.Windows.Forms.Timer
        private int _failedAttempts = 0;
        private System.Windows.Forms.Timer _blockTimer;  // ← ПОЛНОЕ ИМЯ
        private DateTime _blockedUntil;

        public CaptchaForm(Action onSuccess, Action onCancel)
        {
            InitializeComponent();
            _onSuccess = onSuccess;
            _onCancel = onCancel;

            // Создаем таймер для разблокировки
            _blockTimer = new System.Windows.Forms.Timer();  // ← ПОЛНОЕ ИМЯ
            _blockTimer.Interval = 1000; // 1 секунда
            _blockTimer.Tick += BlockTimer_Tick;

            GenerateCaptcha();
        }

        private void GenerateCaptcha()
        {
            const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789";
            char[] code = new char[5];
            for (int i = 0; i < 5; i++)
                code[i] = chars[_random.Next(chars.Length)];

            _currentCaptcha = new string(code);
            lblCaptchaCode.Text = _currentCaptcha;
            txtCaptchaInput.Clear();
            lblMessage.Text = "";
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            // Проверка блокировки
            if (_blockedUntil > DateTime.Now)
            {
                int secondsLeft = (int)(_blockedUntil - DateTime.Now).TotalSeconds;
                MessageBox.Show($"Вход заблокирован. Подождите {secondsLeft} секунд.",
                    "Блокировка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string userInput = txtCaptchaInput.Text.Trim();

            if (string.Equals(userInput, _currentCaptcha, StringComparison.OrdinalIgnoreCase))
            {
                // УСПЕХ - сбрасываем счетчик
                _failedAttempts = 0;
                _onSuccess?.Invoke();
                this.Close();
            }
            else
            {
                // НЕВЕРНАЯ CAPTCHA
                _failedAttempts++;
                lblMessage.Text = $"❌ Неверный код! Попытка {_failedAttempts} из 3";
                lblMessage.ForeColor = Color.Red;

                // Обновляем CAPTCHA
                GenerateCaptcha();

                // Проверка: достигнут ли лимит (3 ошибки)
                if (_failedAttempts >= 3)
                {
                    BlockCaptchaFor30Seconds();
                }
            }
        }

        // БЛОКИРОВКА НА 30 СЕКУНД
        private void BlockCaptchaFor30Seconds()
        {
            _blockedUntil = DateTime.Now.AddSeconds(30);
            _blockTimer.Start();

            // Блокируем элементы управления
            btnVerify.Enabled = false;
            btnRefresh.Enabled = false;
            txtCaptchaInput.Enabled = false;

            // Меняем текст кнопки
            btnVerify.Text = "Заблокировано (30 сек)";

            // Сбрасываем счетчик (блокировка уже активна)
            _failedAttempts = 0;

            lblMessage.Text = "⛔ Слишком много неверных попыток! Вход заблокирован на 30 секунд.";
            lblMessage.ForeColor = Color.DarkRed;
        }

        // ТАЙМЕР ДЛЯ РАЗБЛОКИРОВКИ
        private void BlockTimer_Tick(object sender, EventArgs e)
        {
            int secondsLeft = (int)(_blockedUntil - DateTime.Now).TotalSeconds;

            if (secondsLeft <= 0)
            {
                // Разблокируем
                _blockTimer.Stop();
                btnVerify.Enabled = true;
                btnRefresh.Enabled = true;
                txtCaptchaInput.Enabled = true;
                btnVerify.Text = "Проверить";

                lblMessage.Text = "✅ Блокировка снята. Введите CAPTCHA.";
                lblMessage.ForeColor = Color.Green;

                GenerateCaptcha();
            }
            else
            {
                // Обновляем текст на кнопке
                btnVerify.Text = $"Заблокировано ({secondsLeft} сек)";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (btnVerify.Enabled)
            {
                GenerateCaptcha();
                lblMessage.Text = "Код CAPTCHA обновлен";
                lblMessage.ForeColor = Color.Blue;
            }
            else
            {
                MessageBox.Show("Дождитесь окончания блокировки.", "Блокировка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _onCancel?.Invoke();
            this.Close();
        }

        private void CaptchaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
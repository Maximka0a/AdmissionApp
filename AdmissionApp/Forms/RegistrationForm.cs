using System;
using System.Windows.Forms;
using AdmissionVGTU.Models;
using AdmissionVGTU.Repositories;

namespace AdmissionVGTU
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            try
            {
                User user = new User
                {
                    Username = txtUsername.Text.Trim(),
                    Password = txtPassword.Text,
                    RoleID = 1, // Роль "Абитуриент"
                    FullName = txtFullName.Text.Trim(),
                    PassportData = txtPassportData.Text.Trim(),
                    SNILS = txtSnils.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    ParentFullName = txtParentFullName.Text.Trim(),
                    PreviousInstitution = txtPreviousInstitution.Text.Trim()
                };

                bool success = UserRepository.Register(user);

                if (success)
                {
                    MessageBox.Show("Регистрация успешно завершена. Теперь вы можете войти в систему.",
                        "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка при регистрации. Пожалуйста, попробуйте снова.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка регистрации: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            // Проверка обязательных полей
            if (string.IsNullOrEmpty(txtUsername.Text) ||
                string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(txtConfirmPassword.Text) ||
                string.IsNullOrEmpty(txtFullName.Text) ||
                string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля (отмеченные *)", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Проверка совпадения паролей
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Проверка формата электронной почты
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Неверный формат электронной почты", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
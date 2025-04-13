using System;
using System.Windows.Forms;
using AdmissionApp.Models;
using AdmissionApp.Repositories;

namespace AdmissionApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, введите имя пользователя и пароль", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                User user = UserRepository.Authenticate(username, password);

                if (user != null)
                {
                    // Сохраняем информацию о текущем пользователе
                    CurrentUser.User = user;

                    if (user.RoleName == "Абитуриент")
                    {
                        // Открываем форму абитуриента
                        ApplicantDashboardForm dashboardForm = new ApplicantDashboardForm();
                        this.Hide();
                        dashboardForm.ShowDialog();
                        this.Show();
                        txtPassword.Clear();
                    }
                    else if (user.RoleName == "Работник приёмной комиссии")
                    {
                        // Открываем форму работника приемной комиссии
                        AdminDashboardForm dashboardForm = new AdminDashboardForm();
                        this.Hide();
                        dashboardForm.ShowDialog();
                        this.Show();
                        txtPassword.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Неверное имя пользователя или пароль", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при входе: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            this.Hide();
            registrationForm.ShowDialog();
            this.Show();
        }
    }

    // Статический класс для хранения информации о текущем пользователе
    public static class CurrentUser
    {
        public static User User { get; set; }
    }
}
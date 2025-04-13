using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using AdmissionApp.Models;
using AdmissionApp.Repositories;
using ApplicationModel = AdmissionApp.Models.Application; // Определяем псевдоним

namespace AdmissionApp
{
    public partial class ApplicationManagementForm : Form
    {
        private ApplicationModel application; // Используем псевдоним
        private User applicant;

        public ApplicationManagementForm(ApplicationModel application) // Используем псевдоним
        {
            InitializeComponent();
            this.application = application;
        }

        private void ApplicationManagementForm_Load(object sender, EventArgs e)
        {
            LoadApplicationDetails();
            LoadStatuses();
        }

        private void LoadApplicationDetails()
        {
            try
            {
                // Загрузка данных абитуриента
                applicant = UserRepository.GetUserById(application.UserID);

                if (applicant != null)
                {
                    lblApplicantName.Text = applicant.FullName;
                    lblPassportData.Text = applicant.PassportData;
                    lblSnils.Text = applicant.SNILS;
                    lblEmail.Text = applicant.Email;
                    lblPhone.Text = applicant.Phone;
                    lblParentName.Text = applicant.ParentFullName;
                    lblPreviousInstitution.Text = applicant.PreviousInstitution;
                }

                // Отображение данных заявления
                lblEducationLevel.Text = application.LevelName;

                if (application.AverageGrade > 0)
                {
                    lblGradeScore.Text = $"Средний балл: {application.AverageGrade}";
                }
                else if (application.ExamScore > 0)
                {
                    lblGradeScore.Text = $"Баллы ЕГЭ: {application.ExamScore}";
                }
                else
                {
                    lblGradeScore.Text = "Баллы не указаны";
                }

                lblSubmissionDate.Text = application.SubmissionDate.ToString("dd.MM.yyyy HH:mm");
                lblLastUpdateDate.Text = application.LastUpdateDate.ToString("dd.MM.yyyy HH:mm");

                // Настройка отображения статуса
                lblCurrentStatus.Text = application.StatusName;
                if (application.StatusID == 1) // ПОДАНО
                {
                    lblCurrentStatus.ForeColor = Color.Blue;
                }
                else if (application.StatusID == 2) // ГОТОВО
                {
                    lblCurrentStatus.ForeColor = Color.Green;
                }
                else if (application.StatusID == 3) // В ДОРАБОТКУ
                {
                    lblCurrentStatus.ForeColor = Color.Red;
                }

                // Загрузка списка выбранных направлений
                lstSelectedPrograms.DataSource = application.SelectedPrograms;
                lstSelectedPrograms.DisplayMember = "ProgramName";
                lstSelectedPrograms.ValueMember = "ProgramID";

                // Установка текущего комментария
                txtStatusComment.Text = application.StatusComment;

                // Настройка отображения пути к документу
                if (!string.IsNullOrEmpty(application.DocumentPath))
                {
                    lblDocumentPath.Text = Path.GetFileName(application.DocumentPath);
                }
                else
                {
                    lblDocumentPath.Text = "Документ не загружен";
                    btnOpenDocument.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных заявления: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Остальной код без изменений
        private void LoadStatuses()
        {
            try
            {
                var statuses = ReferenceDataRepository.GetApplicationStatuses();
                cmbStatus.DataSource = statuses;
                cmbStatus.DisplayMember = "StatusName";
                cmbStatus.ValueMember = "StatusID";
                cmbStatus.SelectedValue = application.StatusID;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки статусов: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpenDocument_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(application.DocumentPath) && File.Exists(application.DocumentPath))
            {
                try
                {
                    Process.Start(application.DocumentPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при открытии документа: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Документ не найден", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите статус", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int statusId = ((ApplicationStatus)cmbStatus.SelectedItem).StatusID;
            string statusComment = txtStatusComment.Text.Trim();

            // Проверка, что при статусе "В ДОРАБОТКУ" указан комментарий
            if (statusId == 3 && string.IsNullOrEmpty(statusComment))
            {
                MessageBox.Show("Для статуса \"В ДОРАБОТКУ\" необходимо указать комментарий", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool success = ApplicationRepository.UpdateApplicationStatus(application.ApplicationID, statusId, statusComment);

                if (success)
                {
                    MessageBox.Show("Статус заявления успешно обновлен", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка при обновлении статуса заявления", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления статуса: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
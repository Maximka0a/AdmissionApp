using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using AdmissionApp.Models;

namespace AdmissionApp
{
    public partial class ApplicationStatusForm : Form
    {
        private Models.Application application;

        public ApplicationStatusForm(Models.Application application)
        {
            InitializeComponent();
            this.application = application;
            LoadApplicationDetails();
        }

        private void LoadApplicationDetails()
        {
            try
            {
                // Отображение данных заявления
                lblApplicationId.Text = application.ApplicationID.ToString();
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
                lblStatus.Text = application.StatusName;
                if (application.StatusID == 1) // ПОДАНО
                {
                    lblStatus.ForeColor = System.Drawing.Color.Blue;
                }
                else if (application.StatusID == 2) // ГОТОВО
                {
                    lblStatus.ForeColor = System.Drawing.Color.Green;
                }
                else if (application.StatusID == 3) // В ДОРАБОТКУ
                {
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                }

                // Комментарий
                txtStatusComment.Text = application.StatusComment;

                // Загрузка списка выбранных направлений
                lstSelectedPrograms.DataSource = application.SelectedPrograms;
                lstSelectedPrograms.DisplayMember = "ProgramName";
                lstSelectedPrograms.ValueMember = "ProgramID";

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using AdmissionApp.Models;
using AdmissionApp.Repositories;
using ApplicationModel = AdmissionApp.Models.Application; // Определяем псевдоним для решения конфликта имен

namespace AdmissionApp
{
    public partial class ApplicationSubmissionForm : Form
    {
        private List<EducationLevel> educationLevels;
        private List<StudyProgram> availablePrograms;
        private List<StudyProgram> selectedPrograms = new List<StudyProgram>();
        private string documentPath = string.Empty;

        public ApplicationSubmissionForm()
        {
            InitializeComponent();
        }

        private void ApplicationSubmissionForm_Load(object sender, EventArgs e)
        {
            LoadEducationLevels();
            // По умолчанию скрываем поля баллов
            lblAverageGrade.Visible = false;
            txtAverageGrade.Visible = false;
            lblExamScore.Visible = false;
            txtExamScore.Visible = false;
        }

        private void LoadEducationLevels()
        {
            try
            {
                educationLevels = ReferenceDataRepository.GetEducationLevels();
                cmbEducationLevel.DataSource = educationLevels;
                cmbEducationLevel.DisplayMember = "LevelName";
                cmbEducationLevel.ValueMember = "LevelID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки уровней образования: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbEducationLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEducationLevel.SelectedItem != null)
            {
                int levelId = ((EducationLevel)cmbEducationLevel.SelectedItem).LevelID;
                LoadStudyPrograms(levelId);
                UpdateGradeInputVisibility(levelId);
            }
        }

        private void LoadStudyPrograms(int levelId)
        {
            try
            {
                availablePrograms = ReferenceDataRepository.GetStudyProgramsByLevel(levelId);
                lstAvailablePrograms.DataSource = availablePrograms;
                lstAvailablePrograms.DisplayMember = "ProgramName";
                lstAvailablePrograms.ValueMember = "ProgramID";

                UpdateSelectedProgramsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки направлений подготовки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateGradeInputVisibility(int levelId)
        {
            // Скрываем/показываем соответствующие поля в зависимости от уровня образования
            if (levelId == 1) // СПО
            {
                lblAverageGrade.Visible = true;
                txtAverageGrade.Visible = true;
                lblExamScore.Visible = false;
                txtExamScore.Visible = false;

                lblAverageGrade.Text = "Средний балл аттестата (до 5):";
                txtAverageGrade.Maximum = 5;
            }
            else if (levelId == 4) // Магистратура
            {
                lblAverageGrade.Visible = true;
                txtAverageGrade.Visible = true;
                lblExamScore.Visible = false;
                txtExamScore.Visible = false;

                lblAverageGrade.Text = "Средний балл диплома (до 100):";
                txtAverageGrade.Maximum = 100;
            }
            else // Бакалавриат или Специалитет
            {
                lblAverageGrade.Visible = false;
                txtAverageGrade.Visible = false;
                lblExamScore.Visible = true;
                txtExamScore.Visible = true;
            }
        }

        private void btnAddProgram_Click(object sender, EventArgs e)
        {
            if (lstAvailablePrograms.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите направление подготовки", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StudyProgram selectedProgram = (StudyProgram)lstAvailablePrograms.SelectedItem;

            // Проверяем, не выбрано ли уже 5 направлений
            if (selectedPrograms.Count >= 5)
            {
                MessageBox.Show("Вы можете выбрать не более 5 направлений подготовки", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Проверяем, не выбрано ли уже это направление
            if (selectedPrograms.Exists(p => p.ProgramID == selectedProgram.ProgramID))
            {
                MessageBox.Show("Это направление подготовки уже выбрано", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            selectedPrograms.Add(selectedProgram);
            UpdateSelectedProgramsList();
        }

        private void btnRemoveProgram_Click(object sender, EventArgs e)
        {
            if (lstSelectedPrograms.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите направление подготовки для удаления", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StudyProgram selectedProgram = (StudyProgram)lstSelectedPrograms.SelectedItem;
            selectedPrograms.RemoveAll(p => p.ProgramID == selectedProgram.ProgramID);
            UpdateSelectedProgramsList();
        }

        private void UpdateSelectedProgramsList()
        {
            lstSelectedPrograms.DataSource = null;
            lstSelectedPrograms.DataSource = selectedPrograms;
            lstSelectedPrograms.DisplayMember = "ProgramName";
            lstSelectedPrograms.ValueMember = "ProgramID";
        }

        private void btnUploadDocument_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "PDF файлы (*.pdf)|*.pdf",
                Title = "Выберите скан-копию документа об образовании"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                documentPath = openFileDialog.FileName;
                lblDocumentPath.Text = Path.GetFileName(documentPath);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            try
            {
                ApplicationModel application = new ApplicationModel // Используем псевдоним
                {
                    UserID = CurrentUser.User.UserID,
                    LevelID = ((EducationLevel)cmbEducationLevel.SelectedItem).LevelID,
                    SelectedPrograms = selectedPrograms,
                    DocumentPath = documentPath
                };

                // Установка соответствующего балла в зависимости от уровня образования
                int levelId = ((EducationLevel)cmbEducationLevel.SelectedItem).LevelID;
                if (levelId == 1 || levelId == 4) // СПО или Магистратура
                {
                    application.AverageGrade = txtAverageGrade.Value;
                }
                else // Бакалавриат или Специалитет
                {
                    application.ExamScore = txtExamScore.Value;
                }

                int applicationId = ApplicationRepository.CreateApplication(application);

                if (applicationId > 0)
                {
                    MessageBox.Show("Заявление успешно подано", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка при подаче заявления", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подачи заявления: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            if (cmbEducationLevel.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите уровень образования", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (selectedPrograms.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите хотя бы одно направление подготовки", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(documentPath))
            {
                MessageBox.Show("Пожалуйста, загрузите скан-копию документа об образовании", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AdmissionVGTU.Models;
using AdmissionVGTU.Repositories;

namespace AdmissionVGTU
{
    public partial class StudyProgramsManagementForm : Form
    {
        private List<EducationLevel> educationLevels;
        private List<StudyProgram> studyPrograms;

        public StudyProgramsManagementForm()
        {
            InitializeComponent();
        }

        private void StudyProgramsManagementForm_Load(object sender, EventArgs e)
        {
            LoadEducationLevels();
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
            }
        }

        private void LoadStudyPrograms(int levelId)
        {
            try
            {
                studyPrograms = ReferenceDataRepository.GetStudyProgramsByLevel(levelId);
                dgvPrograms.DataSource = studyPrograms;

                dgvPrograms.Columns["ProgramID"].HeaderText = "ID";
                dgvPrograms.Columns["ProgramName"].HeaderText = "Название направления";
                dgvPrograms.Columns["LevelID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки направлений подготовки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddProgram_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProgramName.Text.Trim()))
            {
                MessageBox.Show("Пожалуйста, введите название направления подготовки", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cmbEducationLevel.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите уровень образования", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                StudyProgram program = new StudyProgram
                {
                    ProgramName = txtProgramName.Text.Trim(),
                    LevelID = ((EducationLevel)cmbEducationLevel.SelectedItem).LevelID
                };

                bool success = ReferenceDataRepository.AddStudyProgram(program);

                if (success)
                {
                    MessageBox.Show("Направление подготовки успешно добавлено", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProgramName.Clear();

                    // Перезагрузка списка направлений
                    LoadStudyPrograms(program.LevelID);
                }
                else
                {
                    MessageBox.Show("Ошибка при добавлении направления подготовки", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления направления: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteProgram_Click(object sender, EventArgs e)
        {
            if (dgvPrograms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите направление подготовки для удаления", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StudyProgram selectedProgram = (StudyProgram)dgvPrograms.SelectedRows[0].DataBoundItem;

            DialogResult result = MessageBox.Show(
                $"Вы уверены, что хотите удалить направление \"{selectedProgram.ProgramName}\"?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool success = ReferenceDataRepository.DeleteStudyProgram(selectedProgram.ProgramID);

                    if (success)
                    {
                        MessageBox.Show("Направление подготовки успешно удалено", "Успех",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Перезагрузка списка направлений
                        LoadStudyPrograms(selectedProgram.LevelID);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при удалении направления подготовки", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления направления: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
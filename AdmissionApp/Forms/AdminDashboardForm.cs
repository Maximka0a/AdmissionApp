using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AdmissionVGTU.Models;
using AdmissionVGTU.Repositories;

namespace AdmissionVGTU
{
    public partial class AdminDashboardForm : Form
    {
        private List<Models.Application> applications;
        private List<EducationLevel> educationLevels;
        private List<ApplicationStatus> applicationStatuses;

        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            if (CurrentUser.User != null)
            {
                lblWelcome.Text = $"Добро пожаловать, {CurrentUser.User.FullName}!";
                LoadFilters();
                LoadApplications();
            }
            else
            {
                MessageBox.Show("Ошибка: Пользователь не авторизован.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); 
            }
        }

        private void LoadFilters()
        {
            try
            {
                educationLevels = ReferenceDataRepository.GetEducationLevels();
                var levelsWithAll = new List<EducationLevel>(educationLevels);
                levelsWithAll.Insert(0, new EducationLevel { LevelID = 0, LevelName = "Все уровни" });

                cmbEducationLevel.DataSource = levelsWithAll;
                cmbEducationLevel.DisplayMember = "LevelName";
                cmbEducationLevel.ValueMember = "LevelID";

                applicationStatuses = ReferenceDataRepository.GetApplicationStatuses();
                var statusesWithAll = new List<ApplicationStatus>(applicationStatuses);
                statusesWithAll.Insert(0, new ApplicationStatus { StatusID = 0, StatusName = "Все статусы" });

                cmbStatus.DataSource = statusesWithAll;
                cmbStatus.ValueMember = "StatusID";
                cmbStatus.DisplayMember = "StatusName"; 

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки фильтров: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadApplications()
        {
            try
            {
                string statusFilter = null;
                int levelFilter = 0;
                DateTime? dateFilter = null;

                if (cmbStatus.SelectedItem != null && ((ApplicationStatus)cmbStatus.SelectedItem).StatusID != 0)
                {
                    statusFilter = ((ApplicationStatus)cmbStatus.SelectedItem).StatusName;

                }

                if (cmbEducationLevel.SelectedItem != null && ((EducationLevel)cmbEducationLevel.SelectedItem).LevelID != 0)
                {
                    levelFilter = ((EducationLevel)cmbEducationLevel.SelectedItem).LevelID;
                }

                if (chkFilterByDate.Checked)
                {

                    dateFilter = dtpFilterDate.Value.Date;
                }

                applications = ApplicationRepository.GetAllApplications(statusFilter, levelFilter, dateFilter);
                dgvApplications.DataSource = null;
                dgvApplications.DataSource = applications;
                SetupDataGridViewColumns();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки заявлений: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridViewColumns()
        {
           
            dgvApplications.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


            if (dgvApplications.Columns.Contains("ApplicationID"))
            {
                dgvApplications.Columns["ApplicationID"].HeaderText = "ID";
                dgvApplications.Columns["ApplicationID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            if (dgvApplications.Columns.Contains("UserID"))
                dgvApplications.Columns["UserID"].Visible = false;
            if (dgvApplications.Columns.Contains("UserFullName"))
            {
                dgvApplications.Columns["UserFullName"].HeaderText = "ФИО абитуриента";
                dgvApplications.Columns["UserFullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvApplications.Columns["UserFullName"].MinimumWidth = 150;
            }
            if (dgvApplications.Columns.Contains("LevelID"))
                dgvApplications.Columns["LevelID"].Visible = false;
            if (dgvApplications.Columns.Contains("LevelName"))
            {
                dgvApplications.Columns["LevelName"].HeaderText = "Уровень образования";
                dgvApplications.Columns["LevelName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvApplications.Columns["LevelName"].MinimumWidth = 120;
            }
            if (dgvApplications.Columns.Contains("AverageGrade"))
            {
                dgvApplications.Columns["AverageGrade"].HeaderText = "Средний балл";
                dgvApplications.Columns["AverageGrade"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            if (dgvApplications.Columns.Contains("ExamScore"))
            {
                dgvApplications.Columns["ExamScore"].HeaderText = "Баллы ЕГЭ";
                dgvApplications.Columns["ExamScore"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            if (dgvApplications.Columns.Contains("DocumentPath"))
                dgvApplications.Columns["DocumentPath"].Visible = false;
            if (dgvApplications.Columns.Contains("StatusID"))
                dgvApplications.Columns["StatusID"].Visible = false;
            if (dgvApplications.Columns.Contains("StatusName"))
            {
                dgvApplications.Columns["StatusName"].HeaderText = "Статус";
                dgvApplications.Columns["StatusName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvApplications.Columns["StatusName"].MinimumWidth = 100;
            }
            if (dgvApplications.Columns.Contains("StatusComment"))
            {
                dgvApplications.Columns["StatusComment"].HeaderText = "Комментарий";
                dgvApplications.Columns["StatusComment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
                dgvApplications.Columns["StatusComment"].MinimumWidth = 150;
            }
            if (dgvApplications.Columns.Contains("SubmissionDate"))
            {
                dgvApplications.Columns["SubmissionDate"].HeaderText = "Дата подачи";
                dgvApplications.Columns["SubmissionDate"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
                dgvApplications.Columns["SubmissionDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvApplications.Columns["SubmissionDate"].MinimumWidth = 120;
            }
            if (dgvApplications.Columns.Contains("LastUpdateDate"))
            {
                dgvApplications.Columns["LastUpdateDate"].HeaderText = "Последнее обновление";
                dgvApplications.Columns["LastUpdateDate"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
                dgvApplications.Columns["LastUpdateDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvApplications.Columns["LastUpdateDate"].MinimumWidth = 120;
            }
        }


        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadApplications();
        }

        private void btnViewApplication_Click(object sender, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите заявление для просмотра", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Models.Application selectedApplication = (Models.Application)dgvApplications.SelectedRows[0].DataBoundItem;
            ApplicationManagementForm managementForm = new ApplicationManagementForm(selectedApplication);
            if (managementForm.ShowDialog() == DialogResult.OK)
            {
                LoadApplications(); // Refresh list after potential changes
            }
        }

        private void btnManagePrograms_Click(object sender, EventArgs e)
        {
            StudyProgramsManagementForm programsForm = new StudyProgramsManagementForm();
            programsForm.ShowDialog();
            // Optionally reload applications if program changes might affect them,
            // though unlikely in this context.
        }

        private void btnGenerateReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            CurrentUser.User = null;
            this.DialogResult = DialogResult.Abort; // Signal logout
            this.Close();
        }

        private void AdminDashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Reset user only if closing via 'X', not logout
            if (this.DialogResult != DialogResult.Abort)
            {
                // Decide if you want to log out user on 'X' click or just close the window
                // CurrentUser.User = null; // Uncomment if closing window should log out
            }
        }

        private void chkFilterByDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpFilterDate.Enabled = chkFilterByDate.Checked;
            // Optionally trigger filter reload when checkbox changes state
            // if (!chkFilterByDate.Checked) {
            //     LoadApplications(); // Reload without date filter if unchecked
            // }
        }
    }
}
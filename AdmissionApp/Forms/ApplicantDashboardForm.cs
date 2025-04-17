using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AdmissionVGTU.Models;
using AdmissionVGTU.Repositories;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing.Printing;
using System.Drawing;


namespace AdmissionVGTU
{
    public partial class ApplicantDashboardForm : Form
    {
        private List<Models.Application> applications;
        private Models.Application applicationToPrint; // Для печати
        private PrintDocument printDocument = new PrintDocument();

        public ApplicantDashboardForm()
        {
            InitializeComponent();
        }

        private void ApplicantDashboardForm_Load(object sender, EventArgs e)
        {
            if (CurrentUser.User != null)
            {
                lblWelcome.Text = $"Добро пожаловать, {CurrentUser.User.FullName}!";
                LoadApplications();
            }
            else
            {
                MessageBox.Show("Ошибка: Пользователь не авторизован.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LoadApplications()
        {
            try
            {
                if (CurrentUser.User == null) return;

                applications = ApplicationRepository.GetApplicationsByUserId(CurrentUser.User.UserID);
                dgvApplications.DataSource = null;
                dgvApplications.DataSource = applications;
                
                dgvApplications.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                if (dgvApplications.Columns.Contains("ApplicationID"))
                {
                    dgvApplications.Columns["ApplicationID"].HeaderText = "ID";
                    dgvApplications.Columns["ApplicationID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                if (dgvApplications.Columns.Contains("UserID"))
                    dgvApplications.Columns["UserID"].Visible = false;
                if (dgvApplications.Columns.Contains("UserFullName"))
                    dgvApplications.Columns["UserFullName"].Visible = false;
                if (dgvApplications.Columns.Contains("LevelID"))
                    dgvApplications.Columns["LevelID"].Visible = false;

                if (dgvApplications.Columns.Contains("LevelName"))
                {
                    dgvApplications.Columns["LevelName"].HeaderText = "Уровень образования";
                    dgvApplications.Columns["LevelName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки заявлений: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewApplication_Click(object sender, EventArgs e)
        {
            if (CurrentUser.User == null)
            {
                MessageBox.Show("Пожалуйста, войдите в систему для подачи заявления.", "Требуется вход", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ApplicationSubmissionForm submissionForm = new ApplicationSubmissionForm();
            if (submissionForm.ShowDialog() == DialogResult.OK)
            {
                LoadApplications();
            }
        }

        private void btnViewApplication_Click(object sender, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите заявление для просмотра.", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Models.Application selectedApplication = (Models.Application)dgvApplications.SelectedRows[0].DataBoundItem;
            ApplicationStatusForm statusForm = new ApplicationStatusForm(selectedApplication);
            statusForm.ShowDialog();
        }
        private void btnPrintApplication_Click(object sender, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите заявление для печати.", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Models.Application selectedApplication = (Models.Application)dgvApplications.SelectedRows[0].DataBoundItem;

            if (CurrentUser.User == null)
            {
                MessageBox.Show("Ошибка: Не удалось получить данные пользователя для печати.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            applicationToPrint = selectedApplication;
            printDocument.PrintPage -= PrintDocument_PrintPage; 
            printDocument.PrintPage += PrintDocument_PrintPage;

            PrintDialog printDlg = new PrintDialog();
            printDlg.Document = printDocument;

            if (printDlg.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (applicationToPrint == null) return;

            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            float lineHeight = 25f;
            System.Drawing.Font titleFont = new System.Drawing.Font("Arial", 16, FontStyle.Bold);
            System.Drawing.Font headerFont = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            System.Drawing.Font bodyFont = new System.Drawing.Font("Arial", 12, FontStyle.Regular);

            // Заголовок
            e.Graphics.DrawString("ЗАЯВЛЕНИЕ", titleFont, Brushes.Black, x, y);
            y += lineHeight * 2;

            // ФИО абитуриента
            string applicantName = CurrentUser.User?.FullName ?? "Имя не указано";
            e.Graphics.DrawString($"Я, {applicantName}, подал(а) документы в ВУЗ.", bodyFont, Brushes.Black, x, y);
            y += lineHeight * 2;

            // Направления подготовки
            e.Graphics.DrawString("На направления подготовки:", headerFont, Brushes.Black, x, y);
            y += lineHeight;

            if (applicationToPrint.SelectedPrograms != null && applicationToPrint.SelectedPrograms.Count > 0)
            {
                foreach (var program in applicationToPrint.SelectedPrograms)
                {
                    e.Graphics.DrawString("- " + (program.ProgramName ?? "Название не указано"), bodyFont, Brushes.Black, x + 20, y);
                    y += lineHeight;
                }
            }
            else
            {
                e.Graphics.DrawString("- Направления не выбраны.", bodyFont, Brushes.Black, x + 20, y);
                y += lineHeight;
            }

            // Дата
            y += lineHeight;
            e.Graphics.DrawString(DateTime.Now.ToString("dd.MM.yyyy"), bodyFont, Brushes.Black, x, y);

        }

        private void GenerateApplicationPdf(Models.Application application)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF файлы (*.pdf)|*.pdf",
                Title = "Сохранить заявление как PDF",
                FileName = $"Заявление_{CurrentUser.User?.FullName?.Replace(" ", "_") ?? "Applicant"}_{application.ApplicationID}.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Document document = new Document(PageSize.A4, 50, 50, 25, 25);
                try
                {
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));

                    string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                    if (!File.Exists(fontPath))
                    {
                        MessageBox.Show("Шрифт Arial не найден. Текст в PDF может отображаться некорректно.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        fontPath = BaseFont.HELVETICA;
                    }

                    BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    iTextSharp.text.Font titleFont = new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font headerFont = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font bodyFont = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL);
                    iTextSharp.text.Font listFont = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL);

                    document.Open();

                    Paragraph title = new Paragraph("ЗАЯВЛЕНИЕ", titleFont)
                    {
                        Alignment = Element.ALIGN_CENTER,
                        SpacingAfter = 20f
                    };
                    document.Add(title);

                    string applicantName = CurrentUser.User?.FullName ?? "Имя не указано";
                    Paragraph applicantInfo = new Paragraph($"Я, {applicantName}, подал(а) документы в ВУЗ.", bodyFont)
                    {
                        SpacingAfter = 15f
                    };
                    document.Add(applicantInfo);

                    Paragraph programsHeader = new Paragraph("На направления подготовки:", headerFont)
                    {
                        SpacingBefore = 10f,
                        SpacingAfter = 5f
                    };
                    document.Add(programsHeader);

                    iTextSharp.text.List programsList = new iTextSharp.text.List(iTextSharp.text.List.UNORDERED);
                    programsList.SetListSymbol("- ");
                    programsList.IndentationLeft = 20f;

                    if (application.SelectedPrograms != null && application.SelectedPrograms.Count > 0)
                    {
                        foreach (var program in application.SelectedPrograms)
                        {
                            programsList.Add(new ListItem(program.ProgramName ?? "Название не указано", listFont));
                        }
                    }
                    else
                    {
                        programsList.Add(new ListItem("Направления не выбраны.", listFont));
                    }
                    document.Add(programsList);

                    Paragraph dateParagraph = new Paragraph(DateTime.Now.ToString("dd.MM.yyyy"), bodyFont)
                    {
                        Alignment = Element.ALIGN_RIGHT,
                        SpacingBefore = 30f
                    };
                    document.Add(dateParagraph);

                    MessageBox.Show("Заявление успешно сохранено в формате PDF.", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (DocumentException docEx)
                {
                    MessageBox.Show($"Ошибка при создании PDF документа: {docEx.Message}", "Ошибка PDF",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (IOException ioEx)
                {
                    MessageBox.Show($"Ошибка при сохранении PDF: Файл может быть открыт в другой программе или нет прав на запись.\n{ioEx.Message}", "Ошибка файла",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Непредвиденная ошибка при сохранении PDF: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (document.IsOpen())
                    {
                        document.Close();
                    }
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            CurrentUser.User = null;
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void ApplicantDashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.Abort)
            {
            }
        }
    }
}
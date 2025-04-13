﻿using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using AdmissionApp.Repositories;
using System.Text;
using iTextSharp.text; // <<< Для iTextSharp Document, Paragraph, Font и т.д.
using iTextSharp.text.pdf; // <<< Для iTextSharp PdfWriter, BaseFont

namespace AdmissionApp
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            LoadReports();
        }

        private void LoadReports()
        {
            try
            {
                // Загрузка данных для отчетов
                DataTable programsData = ReportRepository.GetApplicationsByProgram();
                DataTable statusesData = ReportRepository.GetApplicationsByStatus();

                // Отображение таблиц данных
                dgvProgramStats.DataSource = programsData;
                dgvStatusStats.DataSource = statusesData;

                // Настройка отображения колонок
                dgvProgramStats.Columns["programname"].HeaderText = "Направление подготовки";
                dgvProgramStats.Columns["applicationcount"].HeaderText = "Количество заявлений";

                dgvStatusStats.Columns["statusname"].HeaderText = "Статус";
                dgvStatusStats.Columns["applicationcount"].HeaderText = "Количество заявлений";

                // Добавление итоговой строки к таблицам (клонируем, чтобы не модифицировать исходные для экспорта)
                AddTotalRow((DataTable)dgvProgramStats.DataSource, "programname", "applicationcount");
                AddTotalRow((DataTable)dgvStatusStats.DataSource, "statusname", "applicationcount");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки отчетов: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddTotalRow(DataTable table, string textColumnName, string countColumnName)
        {
            // Создаем копию DataTable, чтобы не изменять исходный источник данных для экспорта
            DataTable displayTable = table.Copy();

            // Вычисление общего количества
            int total = 0;
            foreach (DataRow row in displayTable.Rows)
            {
                // Проверяем на DBNull перед конвертацией
                if (row[countColumnName] != DBNull.Value)
                {
                    total += Convert.ToInt32(row[countColumnName]);
                }
            }

            // Добавление итоговой строки
            DataRow totalRow = displayTable.NewRow();
            totalRow[textColumnName] = "ИТОГО";
            totalRow[countColumnName] = total;
            displayTable.Rows.Add(totalRow);

            // Обновляем DataSource DataGridView новой таблицей с итоговой строкой
            if (textColumnName == "programname")
                dgvProgramStats.DataSource = displayTable;
            else if (textColumnName == "statusname")
                dgvStatusStats.DataSource = displayTable;
        }


        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF файлы (*.pdf)|*.pdf|CSV файлы (*.csv)|*.csv",
                Title = "Сохранить отчет",
                FileName = "Report" // Имя файла по умолчанию
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Определяем, какую *исходную* таблицу экспортировать (без строки "ИТОГО")
                    DataTable dataToExport = tabControl1.SelectedIndex == 0 ?
                        ReportRepository.GetApplicationsByProgram() : // Получаем свежие данные
                        ReportRepository.GetApplicationsByStatus();  // Получаем свежие данные

                    // Добавляем строку ИТОГО к данным *перед* экспортом
                    string textCol = tabControl1.SelectedIndex == 0 ? "programname" : "statusname";
                    string countCol = "applicationcount";
                    AddTotalRowForExport(dataToExport, textCol, countCol);


                    if (Path.GetExtension(saveFileDialog.FileName).ToLower() == ".csv")
                    {
                        ExportToCsv(dataToExport, saveFileDialog.FileName);
                        MessageBox.Show("Отчет успешно сохранен в формате CSV.", "Успех",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Path.GetExtension(saveFileDialog.FileName).ToLower() == ".pdf")
                    {
                        ExportToPdf(dataToExport, saveFileDialog.FileName);
                        MessageBox.Show("Отчет успешно сохранен в формате PDF.", "Успех",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (IOException ioEx) // Обработка ошибки доступа к файлу
                {
                    MessageBox.Show($"Ошибка при сохранении отчета: Файл может быть открыт в другой программе.\n{ioEx.Message}", "Ошибка файла",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении отчета: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Вспомогательный метод для добавления строки ИТОГО к DataTable перед экспортом
        private void AddTotalRowForExport(DataTable table, string textColumnName, string countColumnName)
        {
            int total = 0;
            foreach (DataRow row in table.Rows)
            {
                if (row[countColumnName] != DBNull.Value)
                {
                    total += Convert.ToInt32(row[countColumnName]);
                }
            }
            DataRow totalRow = table.NewRow();
            totalRow[textColumnName] = "ИТОГО";
            totalRow[countColumnName] = total;
            table.Rows.Add(totalRow);
        }


        private void ExportToCsv(DataTable dataTable, string filePath)
        {
            StringBuilder csv = new StringBuilder();

            // Добавляем заголовки из DataGridView (чтобы сохранить пользовательские имена)
            DataGridView dgv = tabControl1.SelectedIndex == 0 ? dgvProgramStats : dgvStatusStats;
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                csv.Append(dgv.Columns[i].HeaderText); // Используем HeaderText
                if (i < dgv.Columns.Count - 1)
                    csv.Append(',');
            }
            csv.AppendLine();


            // Добавляем данные
            foreach (DataRow row in dataTable.Rows)
            {
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(row[i]))
                    {
                        string value = row[i].ToString();
                        // Экранируем кавычки внутри значения и заключаем в кавычки, если есть запятая или кавычка
                        if (value.Contains(",") || value.Contains("\""))
                        {
                            value = $"\"{value.Replace("\"", "\"\"")}\""; // Удваиваем кавычки
                        }
                        csv.Append(value);
                    }
                    if (i < dataTable.Columns.Count - 1)
                        csv.Append(',');
                }
                csv.AppendLine();
            }

            // Записываем файл в UTF-8 с BOM (для лучшей совместимости с Excel)
            File.WriteAllText(filePath, csv.ToString(), Encoding.UTF8);
        }

        private void ExportToPdf(DataTable dataTable, string filePath)
        {
            Document document = new Document(PageSize.A4, 25, 25, 30, 30); // Поля страницы
            try
            {
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

                // --- Шрифты для поддержки кириллицы ---
                // Убедитесь, что шрифт Arial есть в системе или добавьте ttf файл в проект
                // и укажите путь к нему. "BaseFont.IDENTITY_H" важен для Unicode.
                string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                if (!File.Exists(fontPath))
                {
                    // Попытка использовать стандартный шрифт, если Arial не найден (может не поддерживать кириллицу)
                    // Или можно выбросить исключение/показать сообщение
                    // throw new FileNotFoundException("Шрифт Arial не найден. Невозможно создать PDF с кириллицей.");
                    MessageBox.Show("Шрифт Arial не найден. Текст в PDF может отображаться некорректно.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // Попробуем стандартный Helvetica как запасной вариант
                    fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "helvetica.ttf"); // Маловероятно, что сработает для кириллицы
                                                                                                                          // Если и его нет, iTextSharp может использовать встроенный по умолчанию, но он точно без кириллицы
                }


                BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font headerFont = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font cellFont = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.NORMAL);
                // --- Конец настройки шрифтов ---

                document.Open();

                // Создаем таблицу PDF
                PdfPTable pdfTable = new PdfPTable(dataTable.Columns.Count);
                pdfTable.WidthPercentage = 100; // Ширина таблицы в % от ширины страницы

                // Добавляем заголовки из DataGridView
                DataGridView dgv = tabControl1.SelectedIndex == 0 ? dgvProgramStats : dgvStatusStats;
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, headerFont)) // Используем HeaderText
                    {
                        BackgroundColor = BaseColor.LIGHT_GRAY, // Цвет фона заголовка
                        HorizontalAlignment = Element.ALIGN_CENTER,
                        VerticalAlignment = Element.ALIGN_MIDDLE,
                        Padding = 5
                    };
                    pdfTable.AddCell(cell);
                }
                pdfTable.HeaderRows = 1; // Указываем, что первая строка - это заголовок

                // Добавляем строки данных
                foreach (DataRow row in dataTable.Rows)
                {
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        string cellValue = row[i] != DBNull.Value ? row[i].ToString() : string.Empty;
                        PdfPCell cell = new PdfPCell(new Phrase(cellValue, cellFont))
                        {
                            Padding = 5,
                            // Выравнивание для числовых колонок (предполагаем, что вторая колонка числовая)
                            HorizontalAlignment = (i == 1) ? Element.ALIGN_RIGHT : Element.ALIGN_LEFT,
                            VerticalAlignment = Element.ALIGN_MIDDLE
                        };
                        pdfTable.AddCell(cell);
                    }
                }

                // Добавляем таблицу в документ
                document.Add(pdfTable);
            }
            catch (DocumentException docEx)
            {
                throw new Exception($"Ошибка при создании PDF документа: {docEx.Message}", docEx);
            }
            catch (IOException ioEx)
            {
                throw new IOException($"Ошибка доступа к файлу PDF: {ioEx.Message}", ioEx);
            }
            finally
            {
                // Обязательно закрываем документ
                if (document.IsOpen())
                {
                    document.Close();
                }
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
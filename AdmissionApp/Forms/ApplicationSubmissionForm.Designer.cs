namespace AdmissionVGTU
{
    partial class ApplicationSubmissionForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlDocument = new System.Windows.Forms.Panel();
            this.lblDocument = new System.Windows.Forms.Label();
            this.btnUploadDocument = new System.Windows.Forms.Button();
            this.lblDocumentPath = new System.Windows.Forms.Label();
            this.pnlScores = new System.Windows.Forms.Panel();
            this.lblAverageGrade = new System.Windows.Forms.Label();
            this.txtAverageGrade = new System.Windows.Forms.NumericUpDown();
            this.lblExamScore = new System.Windows.Forms.Label();
            this.txtExamScore = new System.Windows.Forms.NumericUpDown();
            this.pnlPrograms = new System.Windows.Forms.Panel();
            this.lblAvailablePrograms = new System.Windows.Forms.Label();
            this.lstAvailablePrograms = new System.Windows.Forms.ListBox();
            this.pnlProgramButtons = new System.Windows.Forms.Panel();
            this.btnAddProgram = new System.Windows.Forms.Button();
            this.btnRemoveProgram = new System.Windows.Forms.Button();
            this.lblSelectedPrograms = new System.Windows.Forms.Label();
            this.lstSelectedPrograms = new System.Windows.Forms.ListBox();
            this.pnlEducation = new System.Windows.Forms.Panel();
            this.lblEducationLevel = new System.Windows.Forms.Label();
            this.cmbEducationLevel = new System.Windows.Forms.ComboBox();

            ((System.ComponentModel.ISupportInitialize)(this.txtAverageGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExamScore)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlDocument.SuspendLayout();
            this.pnlScores.SuspendLayout();
            this.pnlPrograms.SuspendLayout();
            this.pnlProgramButtons.SuspendLayout();
            this.pnlEducation.SuspendLayout();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.pnlHeader.Controls.Add(this.lblFormTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Size = new System.Drawing.Size(760, 60);

            // lblFormTitle
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(20, 15);
            this.lblFormTitle.Text = "Подача заявления";

            // pnlFooter
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.btnSubmit);
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Size = new System.Drawing.Size(760, 65);

            // btnSubmit
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.ColorTranslator.FromHtml("#d1af69");
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.btnSubmit.Location = new System.Drawing.Point(470, 15);
            this.btnSubmit.Size = new System.Drawing.Size(180, 35);
            this.btnSubmit.Text = "Подать заявление";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // btnCancel
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(660, 15);
            this.btnCancel.Size = new System.Drawing.Size(80, 35);
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // pnlContent
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.pnlDocument);
            this.pnlContent.Controls.Add(this.pnlScores);
            this.pnlContent.Controls.Add(this.pnlPrograms);
            this.pnlContent.Controls.Add(this.pnlEducation);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 60);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(760, 375);
            this.pnlContent.TabIndex = 0;

            // pnlDocument
            this.pnlDocument.BackColor = System.Drawing.ColorTranslator.FromHtml("#f1f2f6");
            this.pnlDocument.Controls.Add(this.lblDocument);
            this.pnlDocument.Controls.Add(this.btnUploadDocument);
            this.pnlDocument.Controls.Add(this.lblDocumentPath);
            this.pnlDocument.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDocument.Location = new System.Drawing.Point(0, 300);
            this.pnlDocument.Size = new System.Drawing.Size(760, 60);

            // lblDocument
            this.lblDocument.AutoSize = true;
            this.lblDocument.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDocument.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.lblDocument.Location = new System.Drawing.Point(20, 18);
            this.lblDocument.Text = "Скан-копия документа образования:";

            // btnUploadDocument
            this.btnUploadDocument.BackColor = System.Drawing.ColorTranslator.FromHtml("#d1af69");
            this.btnUploadDocument.FlatAppearance.BorderSize = 0;
            this.btnUploadDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadDocument.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUploadDocument.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.btnUploadDocument.Location = new System.Drawing.Point(320, 13);
            this.btnUploadDocument.Size = new System.Drawing.Size(180, 30);
            this.btnUploadDocument.Text = "Загрузить документ";
            this.btnUploadDocument.UseVisualStyleBackColor = false;
            this.btnUploadDocument.Click += new System.EventHandler(this.btnUploadDocument_Click);

            // lblDocumentPath
            this.lblDocumentPath.AutoSize = true;
            this.lblDocumentPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblDocumentPath.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.lblDocumentPath.Location = new System.Drawing.Point(515, 20);
            this.lblDocumentPath.Text = "Документ не выбран";

            // pnlScores
            this.pnlScores.BackColor = System.Drawing.Color.White;
            this.pnlScores.Controls.Add(this.lblAverageGrade);
            this.pnlScores.Controls.Add(this.txtAverageGrade);
            this.pnlScores.Controls.Add(this.lblExamScore);
            this.pnlScores.Controls.Add(this.txtExamScore);
            this.pnlScores.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlScores.Location = new System.Drawing.Point(0, 250);
            this.pnlScores.Size = new System.Drawing.Size(760, 50);

            // lblAverageGrade
            this.lblAverageGrade.AutoSize = true;
            this.lblAverageGrade.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAverageGrade.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.lblAverageGrade.Location = new System.Drawing.Point(20, 16);
            this.lblAverageGrade.Text = "Средний балл аттестата:";

            // txtAverageGrade
            this.txtAverageGrade.BackColor = System.Drawing.ColorTranslator.FromHtml("#f1f2f6");
            this.txtAverageGrade.DecimalPlaces = 2;
            this.txtAverageGrade.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAverageGrade.Location = new System.Drawing.Point(225, 14);
            this.txtAverageGrade.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            this.txtAverageGrade.Size = new System.Drawing.Size(85, 25);

            // lblExamScore
            this.lblExamScore.AutoSize = true;
            this.lblExamScore.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblExamScore.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.lblExamScore.Location = new System.Drawing.Point(340, 16);
            this.lblExamScore.Text = "Баллы ЕГЭ:";

            // txtExamScore
            this.txtExamScore.BackColor = System.Drawing.ColorTranslator.FromHtml("#f1f2f6");
            this.txtExamScore.DecimalPlaces = 2;
            this.txtExamScore.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtExamScore.Location = new System.Drawing.Point(440, 14);
            this.txtExamScore.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.txtExamScore.Size = new System.Drawing.Size(85, 25);

            // pnlPrograms
            this.pnlPrograms.BackColor = System.Drawing.ColorTranslator.FromHtml("#f1f2f6");
            this.pnlPrograms.Controls.Add(this.lblAvailablePrograms);
            this.pnlPrograms.Controls.Add(this.lstAvailablePrograms);
            this.pnlPrograms.Controls.Add(this.pnlProgramButtons);
            this.pnlPrograms.Controls.Add(this.lblSelectedPrograms);
            this.pnlPrograms.Controls.Add(this.lstSelectedPrograms);
            this.pnlPrograms.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPrograms.Location = new System.Drawing.Point(0, 60);
            this.pnlPrograms.Size = new System.Drawing.Size(760, 190);

            // lblAvailablePrograms
            this.lblAvailablePrograms.AutoSize = true;
            this.lblAvailablePrograms.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAvailablePrograms.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.lblAvailablePrograms.Location = new System.Drawing.Point(20, 15);
            this.lblAvailablePrograms.Text = "Доступные направления подготовки:";

            // lstAvailablePrograms
            this.lstAvailablePrograms.BackColor = System.Drawing.ColorTranslator.FromHtml("#f1f2f6");
            this.lstAvailablePrograms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstAvailablePrograms.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstAvailablePrograms.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.lstAvailablePrograms.FormattingEnabled = true;
            this.lstAvailablePrograms.ItemHeight = 17;
            this.lstAvailablePrograms.Location = new System.Drawing.Point(20, 40);
            this.lstAvailablePrograms.Size = new System.Drawing.Size(220, 119);

            // pnlProgramButtons
            this.pnlProgramButtons.Controls.Add(this.btnAddProgram);
            this.pnlProgramButtons.Controls.Add(this.btnRemoveProgram);
            this.pnlProgramButtons.Location = new System.Drawing.Point(265, 65);
            this.pnlProgramButtons.Size = new System.Drawing.Size(50, 80);

            // btnAddProgram
            this.btnAddProgram.BackColor = System.Drawing.ColorTranslator.FromHtml("#d1af69");
            this.btnAddProgram.FlatAppearance.BorderSize = 0;
            this.btnAddProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProgram.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddProgram.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.btnAddProgram.Location = new System.Drawing.Point(0, 0);
            this.btnAddProgram.Size = new System.Drawing.Size(50, 35);
            this.btnAddProgram.Text = ">";
            this.btnAddProgram.UseVisualStyleBackColor = false;
            this.btnAddProgram.Click += new System.EventHandler(this.btnAddProgram_Click);

            // btnRemoveProgram
            this.btnRemoveProgram.BackColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.btnRemoveProgram.FlatAppearance.BorderSize = 0;
            this.btnRemoveProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveProgram.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRemoveProgram.ForeColor = System.Drawing.Color.White;
            this.btnRemoveProgram.Location = new System.Drawing.Point(0, 40);
            this.btnRemoveProgram.Size = new System.Drawing.Size(50, 35);
            this.btnRemoveProgram.Text = "<";
            this.btnRemoveProgram.UseVisualStyleBackColor = false;
            this.btnRemoveProgram.Click += new System.EventHandler(this.btnRemoveProgram_Click);

            // lblSelectedPrograms
            this.lblSelectedPrograms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectedPrograms.AutoSize = true;
            this.lblSelectedPrograms.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelectedPrograms.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.lblSelectedPrograms.Location = new System.Drawing.Point(340, 15);
            this.lblSelectedPrograms.Text = "Выбранные направления подготовки:";

            // lstSelectedPrograms
            this.lstSelectedPrograms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSelectedPrograms.BackColor = System.Drawing.ColorTranslator.FromHtml("#f1f2f6");
            this.lstSelectedPrograms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstSelectedPrograms.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstSelectedPrograms.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.lstSelectedPrograms.FormattingEnabled = true;
            this.lstSelectedPrograms.ItemHeight = 17;
            this.lstSelectedPrograms.Location = new System.Drawing.Point(340, 40);
            this.lstSelectedPrograms.Size = new System.Drawing.Size(220, 119);

            // pnlEducation
            this.pnlEducation.BackColor = System.Drawing.Color.White;
            this.pnlEducation.Controls.Add(this.lblEducationLevel);
            this.pnlEducation.Controls.Add(this.cmbEducationLevel);
            this.pnlEducation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEducation.Location = new System.Drawing.Point(0, 0);
            this.pnlEducation.Size = new System.Drawing.Size(760, 60);

            // lblEducationLevel
            this.lblEducationLevel.AutoSize = true;
            this.lblEducationLevel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEducationLevel.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.lblEducationLevel.Location = new System.Drawing.Point(20, 20);
            this.lblEducationLevel.Text = "Уровень образования:";

            // cmbEducationLevel
            this.cmbEducationLevel.BackColor = System.Drawing.ColorTranslator.FromHtml("#f1f2f6");
            this.cmbEducationLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEducationLevel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEducationLevel.Location = new System.Drawing.Point(220, 17);
            this.cmbEducationLevel.Size = new System.Drawing.Size(500, 25);
            this.cmbEducationLevel.TabIndex = 1;
            this.cmbEducationLevel.SelectedIndexChanged += new System.EventHandler(this.cmbEducationLevel_SelectedIndexChanged);

            // ApplicationSubmissionForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(760, 500);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(780, 540);
            this.Name = "ApplicationSubmissionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подача заявления";
            this.Load += new System.EventHandler(this.ApplicationSubmissionForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.txtAverageGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExamScore)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlDocument.ResumeLayout(false);
            this.pnlDocument.PerformLayout();
            this.pnlScores.ResumeLayout(false);
            this.pnlScores.PerformLayout();
            this.pnlPrograms.ResumeLayout(false);
            this.pnlPrograms.PerformLayout();
            this.pnlProgramButtons.ResumeLayout(false);
            this.pnlEducation.ResumeLayout(false);
            this.pnlEducation.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlDocument;
        private System.Windows.Forms.Label lblDocument;
        private System.Windows.Forms.Button btnUploadDocument;
        private System.Windows.Forms.Label lblDocumentPath;
        private System.Windows.Forms.Panel pnlScores;
        private System.Windows.Forms.Label lblAverageGrade;
        private System.Windows.Forms.NumericUpDown txtAverageGrade;
        private System.Windows.Forms.Label lblExamScore;
        private System.Windows.Forms.NumericUpDown txtExamScore;
        private System.Windows.Forms.Panel pnlPrograms;
        private System.Windows.Forms.Label lblAvailablePrograms;
        private System.Windows.Forms.ListBox lstAvailablePrograms;
        private System.Windows.Forms.Panel pnlProgramButtons;
        private System.Windows.Forms.Button btnAddProgram;
        private System.Windows.Forms.Button btnRemoveProgram;
        private System.Windows.Forms.Label lblSelectedPrograms;
        private System.Windows.Forms.ListBox lstSelectedPrograms;
        private System.Windows.Forms.Panel pnlEducation;
        private System.Windows.Forms.Label lblEducationLevel;
        private System.Windows.Forms.ComboBox cmbEducationLevel;
    }
}
namespace AdmissionVGTU
{
    partial class ApplicationStatusForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlBasicInfo = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblApplicationIdTitle = new System.Windows.Forms.Label();
            this.lblApplicationId = new System.Windows.Forms.Label();
            this.lblEducationLevelTitle = new System.Windows.Forms.Label();
            this.lblEducationLevel = new System.Windows.Forms.Label();
            this.lblGradeScoreTitle = new System.Windows.Forms.Label();
            this.lblGradeScore = new System.Windows.Forms.Label();
            this.lblSubmissionDateTitle = new System.Windows.Forms.Label();
            this.lblSubmissionDate = new System.Windows.Forms.Label();
            this.lblLastUpdateDateTitle = new System.Windows.Forms.Label();
            this.lblLastUpdateDate = new System.Windows.Forms.Label();
            this.pnlPrograms = new System.Windows.Forms.Panel();
            this.lblSelectedProgramsTitle = new System.Windows.Forms.Label();
            this.lstSelectedPrograms = new System.Windows.Forms.ListBox();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusCommentTitle = new System.Windows.Forms.Label();
            this.txtStatusComment = new System.Windows.Forms.TextBox();
            this.pnlDocuments = new System.Windows.Forms.Panel();
            this.lblDocumentTitle = new System.Windows.Forms.Label();
            this.btnOpenDocument = new System.Windows.Forms.Button();
            this.lblDocumentPath = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlBasicInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlPrograms.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.pnlDocuments.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.pnlHeader.Controls.Add(this.lblFormTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(540, 60);
            this.pnlHeader.TabIndex = 20;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(20, 15);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(212, 30);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Статус заявления";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.ColorTranslator.FromHtml("#f1f2f6");
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 605);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(15);
            this.pnlFooter.Size = new System.Drawing.Size(540, 65);
            this.pnlFooter.TabIndex = 21;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.ColorTranslator.FromHtml("#d1af69");
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.btnClose.Location = new System.Drawing.Point(340, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 40);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.pnlDocuments);
            this.pnlContent.Controls.Add(this.pnlStatus);
            this.pnlContent.Controls.Add(this.pnlPrograms);
            this.pnlContent.Controls.Add(this.pnlBasicInfo);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 60);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlContent.Size = new System.Drawing.Size(540, 545);
            this.pnlContent.TabIndex = 22;
            // 
            // pnlBasicInfo
            // 
            this.pnlBasicInfo.BackColor = System.Drawing.ColorTranslator.FromHtml("#f1f2f6");
            this.pnlBasicInfo.Controls.Add(this.tableLayoutPanel1);
            this.pnlBasicInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBasicInfo.Location = new System.Drawing.Point(0, 10);
            this.pnlBasicInfo.Name = "pnlBasicInfo";
            this.pnlBasicInfo.Padding = new System.Windows.Forms.Padding(20);
            this.pnlBasicInfo.Size = new System.Drawing.Size(540, 170);
            this.pnlBasicInfo.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tableLayoutPanel1.Controls.Add(this.lblApplicationIdTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblApplicationId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblEducationLevelTitle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEducationLevel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblGradeScoreTitle, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblGradeScore, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblSubmissionDateTitle, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblSubmissionDate, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblLastUpdateDateTitle, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblLastUpdateDate, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 130);
            this.tableLayoutPanel1.TabIndex = 0;
            //
            // lblApplicationIdTitle
            //
            this.lblApplicationIdTitle.AutoSize = true;
            this.lblApplicationIdTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblApplicationIdTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblApplicationIdTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.lblApplicationIdTitle.Text = "ID заявления:";
            this.lblApplicationIdTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblApplicationId
            //
            this.lblApplicationId.AutoSize = true;
            this.lblApplicationId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblApplicationId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblApplicationId.ForeColor = System.Drawing.ColorTranslator.FromHtml("#222");
            this.lblApplicationId.Text = "0";
            this.lblApplicationId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblEducationLevelTitle
            //
            this.lblEducationLevelTitle.AutoSize = true;
            this.lblEducationLevelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEducationLevelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblEducationLevelTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.lblEducationLevelTitle.Text = "Уровень образования:";
            this.lblEducationLevelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblEducationLevel
            //
            this.lblEducationLevel.AutoSize = true;
            this.lblEducationLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEducationLevel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEducationLevel.ForeColor = System.Drawing.ColorTranslator.FromHtml("#222");
            this.lblEducationLevel.Text = "...";
            this.lblEducationLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblGradeScoreTitle
            //
            this.lblGradeScoreTitle.AutoSize = true;
            this.lblGradeScoreTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGradeScoreTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblGradeScoreTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.lblGradeScoreTitle.Text = "Оценка/Балл:";
            this.lblGradeScoreTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblGradeScore
            //
            this.lblGradeScore.AutoSize = true;
            this.lblGradeScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGradeScore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGradeScore.ForeColor = System.Drawing.ColorTranslator.FromHtml("#222");
            this.lblGradeScore.Text = "...";
            this.lblGradeScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblSubmissionDateTitle
            //
            this.lblSubmissionDateTitle.AutoSize = true;
            this.lblSubmissionDateTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubmissionDateTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblSubmissionDateTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.lblSubmissionDateTitle.Text = "Дата подачи:";
            this.lblSubmissionDateTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblSubmissionDate
            //
            this.lblSubmissionDate.AutoSize = true;
            this.lblSubmissionDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubmissionDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubmissionDate.ForeColor = System.Drawing.ColorTranslator.FromHtml("#222");
            this.lblSubmissionDate.Text = "...";
            this.lblSubmissionDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblLastUpdateDateTitle
            //
            this.lblLastUpdateDateTitle.AutoSize = true;
            this.lblLastUpdateDateTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastUpdateDateTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblLastUpdateDateTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.lblLastUpdateDateTitle.Text = "Последнее обновление:";
            this.lblLastUpdateDateTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblLastUpdateDate
            //
            this.lblLastUpdateDate.AutoSize = true;
            this.lblLastUpdateDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastUpdateDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLastUpdateDate.ForeColor = System.Drawing.ColorTranslator.FromHtml("#222");
            this.lblLastUpdateDate.Text = "...";
            this.lblLastUpdateDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlPrograms
            // 
            this.pnlPrograms.BackColor = System.Drawing.Color.White;
            this.pnlPrograms.Controls.Add(this.lblSelectedProgramsTitle);
            this.pnlPrograms.Controls.Add(this.lstSelectedPrograms);
            this.pnlPrograms.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPrograms.Location = new System.Drawing.Point(0, 180);
            this.pnlPrograms.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPrograms.Name = "pnlPrograms";
            this.pnlPrograms.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.pnlPrograms.Size = new System.Drawing.Size(540, 120);
            this.pnlPrograms.TabIndex = 1;
            // 
            // lblSelectedProgramsTitle
            // 
            this.lblSelectedProgramsTitle.AutoSize = true;
            this.lblSelectedProgramsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelectedProgramsTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.lblSelectedProgramsTitle.Location = new System.Drawing.Point(3, 0);
            this.lblSelectedProgramsTitle.Name = "lblSelectedProgramsTitle";
            this.lblSelectedProgramsTitle.Size = new System.Drawing.Size(200, 19);
            this.lblSelectedProgramsTitle.TabIndex = 12;
            this.lblSelectedProgramsTitle.Text = "Выбранные направления:";
            // 
            // lstSelectedPrograms
            // 
            this.lstSelectedPrograms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSelectedPrograms.BackColor = System.Drawing.ColorTranslator.FromHtml("#f5f6fa");
            this.lstSelectedPrograms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstSelectedPrograms.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstSelectedPrograms.ForeColor = System.Drawing.ColorTranslator.FromHtml("#222");
            this.lstSelectedPrograms.FormattingEnabled = true;
            this.lstSelectedPrograms.ItemHeight = 17;
            this.lstSelectedPrograms.Location = new System.Drawing.Point(3, 25);
            this.lstSelectedPrograms.Name = "lstSelectedPrograms";
            this.lstSelectedPrograms.Size = new System.Drawing.Size(510, 68);
            this.lstSelectedPrograms.TabIndex = 13;
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.ColorTranslator.FromHtml("#f1f2f6");
            this.pnlStatus.Controls.Add(this.lblStatusTitle);
            this.pnlStatus.Controls.Add(this.lblStatus);
            this.pnlStatus.Controls.Add(this.lblStatusCommentTitle);
            this.pnlStatus.Controls.Add(this.txtStatusComment);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatus.Location = new System.Drawing.Point(0, 300);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.pnlStatus.Size = new System.Drawing.Size(540, 110);
            this.pnlStatus.TabIndex = 2;
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.AutoSize = true;
            this.lblStatusTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblStatusTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.lblStatusTitle.Location = new System.Drawing.Point(3, 0);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(150, 20);
            this.lblStatusTitle.TabIndex = 14;
            this.lblStatusTitle.Text = "Статус заявления:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.ColorTranslator.FromHtml("#d1af69");
            this.lblStatus.Location = new System.Drawing.Point(160, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(21, 25);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "...";
            // 
            // lblStatusCommentTitle
            // 
            this.lblStatusCommentTitle.AutoSize = true;
            this.lblStatusCommentTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatusCommentTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.lblStatusCommentTitle.Location = new System.Drawing.Point(3, 35);
            this.lblStatusCommentTitle.Name = "lblStatusCommentTitle";
            this.lblStatusCommentTitle.Size = new System.Drawing.Size(140, 15);
            this.lblStatusCommentTitle.TabIndex = 16;
            this.lblStatusCommentTitle.Text = "Комментарий статуса:";
            // 
            // txtStatusComment
            // 
            this.txtStatusComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatusComment.BackColor = System.Drawing.ColorTranslator.FromHtml("#f5f6fa");
            this.txtStatusComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatusComment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStatusComment.ForeColor = System.Drawing.ColorTranslator.FromHtml("#222");
            this.txtStatusComment.Location = new System.Drawing.Point(3, 55);
            this.txtStatusComment.Multiline = true;
            this.txtStatusComment.Name = "txtStatusComment";
            this.txtStatusComment.ReadOnly = true;
            this.txtStatusComment.Size = new System.Drawing.Size(510, 40);
            this.txtStatusComment.TabIndex = 17;
            // 
            // pnlDocuments
            // 
            this.pnlDocuments.BackColor = System.Drawing.Color.White;
            this.pnlDocuments.Controls.Add(this.lblDocumentTitle);
            this.pnlDocuments.Controls.Add(this.btnOpenDocument);
            this.pnlDocuments.Controls.Add(this.lblDocumentPath);
            this.pnlDocuments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDocuments.Location = new System.Drawing.Point(0, 410);
            this.pnlDocuments.Name = "pnlDocuments";
            this.pnlDocuments.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.pnlDocuments.Size = new System.Drawing.Size(540, 135);
            this.pnlDocuments.TabIndex = 3;
            // 
            // lblDocumentTitle
            // 
            this.lblDocumentTitle.AutoSize = true;
            this.lblDocumentTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDocumentTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.lblDocumentTitle.Location = new System.Drawing.Point(3, 0);
            this.lblDocumentTitle.Name = "lblDocumentTitle";
            this.lblDocumentTitle.Size = new System.Drawing.Size(220, 19);
            this.lblDocumentTitle.TabIndex = 18;
            this.lblDocumentTitle.Text = "Документ об образовании:";
            // 
            // btnOpenDocument
            // 
            this.btnOpenDocument.BackColor = System.Drawing.ColorTranslator.FromHtml("#d1af69");
            this.btnOpenDocument.FlatAppearance.BorderSize = 0;
            this.btnOpenDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenDocument.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnOpenDocument.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.btnOpenDocument.Location = new System.Drawing.Point(3, 30);
            this.btnOpenDocument.Name = "btnOpenDocument";
            this.btnOpenDocument.Size = new System.Drawing.Size(180, 30);
            this.btnOpenDocument.TabIndex = 19;
            this.btnOpenDocument.Text = "Открыть документ";
            this.btnOpenDocument.UseVisualStyleBackColor = false;
            this.btnOpenDocument.Click += new System.EventHandler(this.btnOpenDocument_Click);
            // 
            // lblDocumentPath
            // 
            this.lblDocumentPath.AutoSize = true;
            this.lblDocumentPath.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDocumentPath.ForeColor = System.Drawing.ColorTranslator.FromHtml("#222");
            this.lblDocumentPath.Location = new System.Drawing.Point(200, 36);
            this.lblDocumentPath.Name = "lblDocumentPath";
            this.lblDocumentPath.Size = new System.Drawing.Size(16, 19);
            this.lblDocumentPath.TabIndex = 20;
            this.lblDocumentPath.Text = "...";
            // 
            // ApplicationStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 670);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApplicationStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статус заявления";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlBasicInfo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlPrograms.ResumeLayout(false);
            this.pnlPrograms.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.pnlDocuments.ResumeLayout(false);
            this.pnlDocuments.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlBasicInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblApplicationIdTitle;
        private System.Windows.Forms.Label lblApplicationId;
        private System.Windows.Forms.Label lblEducationLevelTitle;
        private System.Windows.Forms.Label lblEducationLevel;
        private System.Windows.Forms.Label lblGradeScoreTitle;
        private System.Windows.Forms.Label lblGradeScore;
        private System.Windows.Forms.Label lblSubmissionDateTitle;
        private System.Windows.Forms.Label lblSubmissionDate;
        private System.Windows.Forms.Label lblLastUpdateDateTitle;
        private System.Windows.Forms.Label lblLastUpdateDate;
        private System.Windows.Forms.Panel pnlPrograms;
        private System.Windows.Forms.Label lblSelectedProgramsTitle;
        private System.Windows.Forms.ListBox lstSelectedPrograms;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusCommentTitle;
        private System.Windows.Forms.TextBox txtStatusComment;
        private System.Windows.Forms.Panel pnlDocuments;
        private System.Windows.Forms.Label lblDocumentTitle;
        private System.Windows.Forms.Button btnOpenDocument;
        private System.Windows.Forms.Label lblDocumentPath;
    }
}
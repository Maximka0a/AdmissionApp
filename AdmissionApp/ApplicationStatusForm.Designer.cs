namespace AdmissionApp
{
    partial class ApplicationStatusForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblApplicationId = new System.Windows.Forms.Label();
            this.lblEducationLevel = new System.Windows.Forms.Label();
            this.lblGradeScore = new System.Windows.Forms.Label();
            this.lblSubmissionDate = new System.Windows.Forms.Label();
            this.lblLastUpdateDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDocumentPath = new System.Windows.Forms.Label();
            this.lstSelectedPrograms = new System.Windows.Forms.ListBox();
            this.btnOpenDocument = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblApplicationIdTitle = new System.Windows.Forms.Label();
            this.lblEducationLevelTitle = new System.Windows.Forms.Label();
            this.lblSubmissionDateTitle = new System.Windows.Forms.Label();
            this.lblLastUpdateDateTitle = new System.Windows.Forms.Label();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.lblSelectedProgramsTitle = new System.Windows.Forms.Label();
            this.lblDocumentTitle = new System.Windows.Forms.Label();
            this.lblStatusCommentTitle = new System.Windows.Forms.Label();
            this.txtStatusComment = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblApplicationId
            // 
            this.lblApplicationId.AutoSize = true;
            this.lblApplicationId.Location = new System.Drawing.Point(150, 30);
            this.lblApplicationId.Name = "lblApplicationId";
            this.lblApplicationId.Size = new System.Drawing.Size(13, 13);
            this.lblApplicationId.TabIndex = 0;
            this.lblApplicationId.Text = "0";
            // 
            // lblEducationLevel
            // 
            this.lblEducationLevel.AutoSize = true;
            this.lblEducationLevel.Location = new System.Drawing.Point(150, 60);
            this.lblEducationLevel.Name = "lblEducationLevel";
            this.lblEducationLevel.Size = new System.Drawing.Size(16, 13);
            this.lblEducationLevel.TabIndex = 1;
            this.lblEducationLevel.Text = "...";
            // 
            // lblGradeScore
            // 
            this.lblGradeScore.AutoSize = true;
            this.lblGradeScore.Location = new System.Drawing.Point(150, 90);
            this.lblGradeScore.Name = "lblGradeScore";
            this.lblGradeScore.Size = new System.Drawing.Size(16, 13);
            this.lblGradeScore.TabIndex = 2;
            this.lblGradeScore.Text = "...";
            // 
            // lblSubmissionDate
            // 
            this.lblSubmissionDate.AutoSize = true;
            this.lblSubmissionDate.Location = new System.Drawing.Point(150, 120);
            this.lblSubmissionDate.Name = "lblSubmissionDate";
            this.lblSubmissionDate.Size = new System.Drawing.Size(16, 13);
            this.lblSubmissionDate.TabIndex = 3;
            this.lblSubmissionDate.Text = "...";
            // 
            // lblLastUpdateDate
            // 
            this.lblLastUpdateDate.AutoSize = true;
            this.lblLastUpdateDate.Location = new System.Drawing.Point(150, 150);
            this.lblLastUpdateDate.Name = "lblLastUpdateDate";
            this.lblLastUpdateDate.Size = new System.Drawing.Size(16, 13);
            this.lblLastUpdateDate.TabIndex = 4;
            this.lblLastUpdateDate.Text = "...";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.Location = new System.Drawing.Point(150, 180);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(20, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "...";
            // 
            // lblDocumentPath
            // 
            this.lblDocumentPath.AutoSize = true;
            this.lblDocumentPath.Location = new System.Drawing.Point(130, 378);
            this.lblDocumentPath.Name = "lblDocumentPath";
            this.lblDocumentPath.Size = new System.Drawing.Size(16, 13);
            this.lblDocumentPath.TabIndex = 6;
            this.lblDocumentPath.Text = "...";
            // 
            // lstSelectedPrograms
            // 
            this.lstSelectedPrograms.FormattingEnabled = true;
            this.lstSelectedPrograms.Location = new System.Drawing.Point(20, 242);
            this.lstSelectedPrograms.Name = "lstSelectedPrograms";
            this.lstSelectedPrograms.Size = new System.Drawing.Size(360, 95);
            this.lstSelectedPrograms.TabIndex = 7;
            // 
            // btnOpenDocument
            // 
            this.btnOpenDocument.Location = new System.Drawing.Point(20, 373);
            this.btnOpenDocument.Name = "btnOpenDocument";
            this.btnOpenDocument.Size = new System.Drawing.Size(100, 23);
            this.btnOpenDocument.TabIndex = 9;
            this.btnOpenDocument.Text = "Открыть";
            this.btnOpenDocument.UseVisualStyleBackColor = true;
            this.btnOpenDocument.Click += new System.EventHandler(this.btnOpenDocument_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(305, 413);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblApplicationIdTitle
            // 
            this.lblApplicationIdTitle.AutoSize = true;
            this.lblApplicationIdTitle.Location = new System.Drawing.Point(20, 30);
            this.lblApplicationIdTitle.Name = "lblApplicationIdTitle";
            this.lblApplicationIdTitle.Size = new System.Drawing.Size(91, 13);
            this.lblApplicationIdTitle.TabIndex = 11;
            this.lblApplicationIdTitle.Text = "ID заявления:";
            // 
            // lblEducationLevelTitle
            // 
            this.lblEducationLevelTitle.AutoSize = true;
            this.lblEducationLevelTitle.Location = new System.Drawing.Point(20, 60);
            this.lblEducationLevelTitle.Name = "lblEducationLevelTitle";
            this.lblEducationLevelTitle.Size = new System.Drawing.Size(123, 13);
            this.lblEducationLevelTitle.TabIndex = 12;
            this.lblEducationLevelTitle.Text = "Уровень образования:";
            // 
            // lblSubmissionDateTitle
            // 
            this.lblSubmissionDateTitle.AutoSize = true;
            this.lblSubmissionDateTitle.Location = new System.Drawing.Point(20, 120);
            this.lblSubmissionDateTitle.Name = "lblSubmissionDateTitle";
            this.lblSubmissionDateTitle.Size = new System.Drawing.Size(76, 13);
            this.lblSubmissionDateTitle.TabIndex = 13;
            this.lblSubmissionDateTitle.Text = "Дата подачи:";
            // 
            // lblLastUpdateDateTitle
            // 
            this.lblLastUpdateDateTitle.AutoSize = true;
            this.lblLastUpdateDateTitle.Location = new System.Drawing.Point(20, 150);
            this.lblLastUpdateDateTitle.Name = "lblLastUpdateDateTitle";
            this.lblLastUpdateDateTitle.Size = new System.Drawing.Size(121, 13);
            this.lblLastUpdateDateTitle.TabIndex = 14;
            this.lblLastUpdateDateTitle.Text = "Последнее обновление:";
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.AutoSize = true;
            this.lblStatusTitle.Location = new System.Drawing.Point(20, 180);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(44, 13);
            this.lblStatusTitle.TabIndex = 15;
            this.lblStatusTitle.Text = "Статус:";
            // 
            // lblSelectedProgramsTitle
            // 
            this.lblSelectedProgramsTitle.AutoSize = true;
            this.lblSelectedProgramsTitle.Location = new System.Drawing.Point(20, 226);
            this.lblSelectedProgramsTitle.Name = "lblSelectedProgramsTitle";
            this.lblSelectedProgramsTitle.Size = new System.Drawing.Size(127, 13);
            this.lblSelectedProgramsTitle.TabIndex = 16;
            this.lblSelectedProgramsTitle.Text = "Выбранные направления:";
            // 
            // lblDocumentTitle
            // 
            this.lblDocumentTitle.AutoSize = true;
            this.lblDocumentTitle.Location = new System.Drawing.Point(20, 357);
            this.lblDocumentTitle.Name = "lblDocumentTitle";
            this.lblDocumentTitle.Size = new System.Drawing.Size(140, 13);
            this.lblDocumentTitle.TabIndex = 17;
            this.lblDocumentTitle.Text = "Документ об образовании:";
            // 
            // lblStatusCommentTitle
            // 
            this.lblStatusCommentTitle.AutoSize = true;
            this.lblStatusCommentTitle.Location = new System.Drawing.Point(20, 196);
            this.lblStatusCommentTitle.Name = "lblStatusCommentTitle";
            this.lblStatusCommentTitle.Size = new System.Drawing.Size(120, 13);
            this.lblStatusCommentTitle.TabIndex = 18;
            this.lblStatusCommentTitle.Text = "Комментарий статуса:";
            // 
            // txtStatusComment
            // 
            this.txtStatusComment.Location = new System.Drawing.Point(153, 196);
            this.txtStatusComment.Multiline = true;
            this.txtStatusComment.Name = "txtStatusComment";
            this.txtStatusComment.ReadOnly = true;
            this.txtStatusComment.Size = new System.Drawing.Size(227, 23);
            this.txtStatusComment.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStatusComment);
            this.groupBox1.Controls.Add(this.lblStatusCommentTitle);
            this.groupBox1.Controls.Add(this.lblDocumentTitle);
            this.groupBox1.Controls.Add(this.lblSelectedProgramsTitle);
            this.groupBox1.Controls.Add(this.lblStatusTitle);
            this.groupBox1.Controls.Add(this.lblLastUpdateDateTitle);
            this.groupBox1.Controls.Add(this.lblSubmissionDateTitle);
            this.groupBox1.Controls.Add(this.lblEducationLevelTitle);
            this.groupBox1.Controls.Add(this.lblApplicationIdTitle);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnOpenDocument);
            this.groupBox1.Controls.Add(this.lstSelectedPrograms);
            this.groupBox1.Controls.Add(this.lblDocumentPath);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblLastUpdateDate);
            this.groupBox1.Controls.Add(this.lblSubmissionDate);
            this.groupBox1.Controls.Add(this.lblGradeScore);
            this.groupBox1.Controls.Add(this.lblEducationLevel);
            this.groupBox1.Controls.Add(this.lblApplicationId);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 442);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о заявлении";
            // 
            // ApplicationStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 466);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApplicationStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статус заявления";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblApplicationId;
        private System.Windows.Forms.Label lblEducationLevel;
        private System.Windows.Forms.Label lblGradeScore;
        private System.Windows.Forms.Label lblSubmissionDate;
        private System.Windows.Forms.Label lblLastUpdateDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDocumentPath;
        private System.Windows.Forms.ListBox lstSelectedPrograms;
        private System.Windows.Forms.Button btnOpenDocument;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblApplicationIdTitle;
        private System.Windows.Forms.Label lblEducationLevelTitle;
        private System.Windows.Forms.Label lblSubmissionDateTitle;
        private System.Windows.Forms.Label lblLastUpdateDateTitle;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.Label lblSelectedProgramsTitle;
        private System.Windows.Forms.Label lblDocumentTitle;
        private System.Windows.Forms.Label lblStatusCommentTitle;
        private System.Windows.Forms.TextBox txtStatusComment;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
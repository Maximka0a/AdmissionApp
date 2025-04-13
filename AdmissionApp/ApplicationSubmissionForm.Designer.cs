namespace AdmissionApp
{
    partial class ApplicationSubmissionForm
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
            this.lblEducationLevel = new System.Windows.Forms.Label();
            this.cmbEducationLevel = new System.Windows.Forms.ComboBox();
            this.lblAvailablePrograms = new System.Windows.Forms.Label();
            this.lblSelectedPrograms = new System.Windows.Forms.Label();
            this.lstAvailablePrograms = new System.Windows.Forms.ListBox();
            this.lstSelectedPrograms = new System.Windows.Forms.ListBox();
            this.btnAddProgram = new System.Windows.Forms.Button();
            this.btnRemoveProgram = new System.Windows.Forms.Button();
            this.lblAverageGrade = new System.Windows.Forms.Label();
            this.txtAverageGrade = new System.Windows.Forms.NumericUpDown();
            this.lblExamScore = new System.Windows.Forms.Label();
            this.txtExamScore = new System.Windows.Forms.NumericUpDown();
            this.lblDocument = new System.Windows.Forms.Label();
            this.btnUploadDocument = new System.Windows.Forms.Button();
            this.lblDocumentPath = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtAverageGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExamScore)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEducationLevel
            // 
            this.lblEducationLevel.AutoSize = true;
            this.lblEducationLevel.Location = new System.Drawing.Point(30, 30);
            this.lblEducationLevel.Name = "lblEducationLevel";
            this.lblEducationLevel.Size = new System.Drawing.Size(123, 13);
            this.lblEducationLevel.TabIndex = 0;
            this.lblEducationLevel.Text = "Уровень образования:";
            // 
            // cmbEducationLevel
            // 
            this.cmbEducationLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEducationLevel.FormattingEnabled = true;
            this.cmbEducationLevel.Location = new System.Drawing.Point(30, 50);
            this.cmbEducationLevel.Name = "cmbEducationLevel";
            this.cmbEducationLevel.Size = new System.Drawing.Size(250, 21);
            this.cmbEducationLevel.TabIndex = 1;
            this.cmbEducationLevel.SelectedIndexChanged += new System.EventHandler(this.cmbEducationLevel_SelectedIndexChanged);
            // 
            // lblAvailablePrograms
            // 
            this.lblAvailablePrograms.AutoSize = true;
            this.lblAvailablePrograms.Location = new System.Drawing.Point(30, 90);
            this.lblAvailablePrograms.Name = "lblAvailablePrograms";
            this.lblAvailablePrograms.Size = new System.Drawing.Size(196, 13);
            this.lblAvailablePrograms.TabIndex = 2;
            this.lblAvailablePrograms.Text = "Доступные направления подготовки:";
            // 
            // lblSelectedPrograms
            // 
            this.lblSelectedPrograms.AutoSize = true;
            this.lblSelectedPrograms.Location = new System.Drawing.Point(350, 90);
            this.lblSelectedPrograms.Name = "lblSelectedPrograms";
            this.lblSelectedPrograms.Size = new System.Drawing.Size(193, 13);
            this.lblSelectedPrograms.TabIndex = 3;
            this.lblSelectedPrograms.Text = "Выбранные направления подготовки:";
            // 
            // lstAvailablePrograms
            // 
            this.lstAvailablePrograms.FormattingEnabled = true;
            this.lstAvailablePrograms.Location = new System.Drawing.Point(30, 110);
            this.lstAvailablePrograms.Name = "lstAvailablePrograms";
            this.lstAvailablePrograms.Size = new System.Drawing.Size(250, 160);
            this.lstAvailablePrograms.TabIndex = 4;
            // 
            // lstSelectedPrograms
            // 
            this.lstSelectedPrograms.FormattingEnabled = true;
            this.lstSelectedPrograms.Location = new System.Drawing.Point(350, 110);
            this.lstSelectedPrograms.Name = "lstSelectedPrograms";
            this.lstSelectedPrograms.Size = new System.Drawing.Size(250, 160);
            this.lstSelectedPrograms.TabIndex = 5;
            // 
            // btnAddProgram
            // 
            this.btnAddProgram.Location = new System.Drawing.Point(290, 130);
            this.btnAddProgram.Name = "btnAddProgram";
            this.btnAddProgram.Size = new System.Drawing.Size(50, 30);
            this.btnAddProgram.TabIndex = 6;
            this.btnAddProgram.Text = ">";
            this.btnAddProgram.UseVisualStyleBackColor = true;
            this.btnAddProgram.Click += new System.EventHandler(this.btnAddProgram_Click);
            // 
            // btnRemoveProgram
            // 
            this.btnRemoveProgram.Location = new System.Drawing.Point(290, 170);
            this.btnRemoveProgram.Name = "btnRemoveProgram";
            this.btnRemoveProgram.Size = new System.Drawing.Size(50, 30);
            this.btnRemoveProgram.TabIndex = 7;
            this.btnRemoveProgram.Text = "<";
            this.btnRemoveProgram.UseVisualStyleBackColor = true;
            this.btnRemoveProgram.Click += new System.EventHandler(this.btnRemoveProgram_Click);
            // 
            // lblAverageGrade
            // 
            this.lblAverageGrade.AutoSize = true;
            this.lblAverageGrade.Location = new System.Drawing.Point(30, 290);
            this.lblAverageGrade.Name = "lblAverageGrade";
            this.lblAverageGrade.Size = new System.Drawing.Size(142, 13);
            this.lblAverageGrade.TabIndex = 8;
            this.lblAverageGrade.Text = "Средний балл аттестата:";
            // 
            // txtAverageGrade
            // 
            this.txtAverageGrade.DecimalPlaces = 2;
            this.txtAverageGrade.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtAverageGrade.Location = new System.Drawing.Point(190, 290);
            this.txtAverageGrade.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtAverageGrade.Name = "txtAverageGrade";
            this.txtAverageGrade.Size = new System.Drawing.Size(90, 20);
            this.txtAverageGrade.TabIndex = 9;
            // 
            // lblExamScore
            // 
            this.lblExamScore.AutoSize = true;
            this.lblExamScore.Location = new System.Drawing.Point(350, 290);
            this.lblExamScore.Name = "lblExamScore";
            this.lblExamScore.Size = new System.Drawing.Size(70, 13);
            this.lblExamScore.TabIndex = 10;
            this.lblExamScore.Text = "Баллы ЕГЭ:";
            // 
            // txtExamScore
            // 
            this.txtExamScore.DecimalPlaces = 2;
            this.txtExamScore.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtExamScore.Location = new System.Drawing.Point(430, 290);
            this.txtExamScore.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtExamScore.Name = "txtExamScore";
            this.txtExamScore.Size = new System.Drawing.Size(90, 20);
            this.txtExamScore.TabIndex = 11;
            // 
            // lblDocument
            // 
            this.lblDocument.AutoSize = true;
            this.lblDocument.Location = new System.Drawing.Point(30, 330);
            this.lblDocument.Name = "lblDocument";
            this.lblDocument.Size = new System.Drawing.Size(184, 13);
            this.lblDocument.TabIndex = 12;
            this.lblDocument.Text = "Скан-копия документа образования:";
            // 
            // btnUploadDocument
            // 
            this.btnUploadDocument.Location = new System.Drawing.Point(30, 350);
            this.btnUploadDocument.Name = "btnUploadDocument";
            this.btnUploadDocument.Size = new System.Drawing.Size(150, 30);
            this.btnUploadDocument.TabIndex = 13;
            this.btnUploadDocument.Text = "Загрузить документ";
            this.btnUploadDocument.UseVisualStyleBackColor = true;
            this.btnUploadDocument.Click += new System.EventHandler(this.btnUploadDocument_Click);
            // 
            // lblDocumentPath
            // 
            this.lblDocumentPath.AutoSize = true;
            this.lblDocumentPath.Location = new System.Drawing.Point(190, 360);
            this.lblDocumentPath.Name = "lblDocumentPath";
            this.lblDocumentPath.Size = new System.Drawing.Size(112, 13);
            this.lblDocumentPath.TabIndex = 14;
            this.lblDocumentPath.Text = "Документ не выбран";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(350, 400);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 30);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Подать заявление";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(480, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 30);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ApplicationSubmissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblDocumentPath);
            this.Controls.Add(this.btnUploadDocument);
            this.Controls.Add(this.lblDocument);
            this.Controls.Add(this.txtExamScore);
            this.Controls.Add(this.lblExamScore);
            this.Controls.Add(this.txtAverageGrade);
            this.Controls.Add(this.lblAverageGrade);
            this.Controls.Add(this.btnRemoveProgram);
            this.Controls.Add(this.btnAddProgram);
            this.Controls.Add(this.lstSelectedPrograms);
            this.Controls.Add(this.lstAvailablePrograms);
            this.Controls.Add(this.lblSelectedPrograms);
            this.Controls.Add(this.lblAvailablePrograms);
            this.Controls.Add(this.cmbEducationLevel);
            this.Controls.Add(this.lblEducationLevel);
            this.MinimumSize = new System.Drawing.Size(650, 500);
            this.Name = "ApplicationSubmissionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подача заявления";
            this.Load += new System.EventHandler(this.ApplicationSubmissionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAverageGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExamScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEducationLevel;
        private System.Windows.Forms.ComboBox cmbEducationLevel;
        private System.Windows.Forms.Label lblAvailablePrograms;
        private System.Windows.Forms.Label lblSelectedPrograms;
        private System.Windows.Forms.ListBox lstAvailablePrograms;
        private System.Windows.Forms.ListBox lstSelectedPrograms;
        private System.Windows.Forms.Button btnAddProgram;
        private System.Windows.Forms.Button btnRemoveProgram;
        private System.Windows.Forms.Label lblAverageGrade;
        private System.Windows.Forms.NumericUpDown txtAverageGrade;
        private System.Windows.Forms.Label lblExamScore;
        private System.Windows.Forms.NumericUpDown txtExamScore;
        private System.Windows.Forms.Label lblDocument;
        private System.Windows.Forms.Button btnUploadDocument;
        private System.Windows.Forms.Label lblDocumentPath;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}
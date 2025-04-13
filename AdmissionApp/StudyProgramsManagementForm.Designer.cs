namespace AdmissionApp
{
    partial class StudyProgramsManagementForm
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
            this.grpPrograms = new System.Windows.Forms.GroupBox();
            this.dgvPrograms = new System.Windows.Forms.DataGridView();
            this.grpAddProgram = new System.Windows.Forms.GroupBox();
            this.btnAddProgram = new System.Windows.Forms.Button();
            this.txtProgramName = new System.Windows.Forms.TextBox();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.btnDeleteProgram = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpPrograms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrograms)).BeginInit();
            this.grpAddProgram.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEducationLevel
            // 
            this.lblEducationLevel.AutoSize = true;
            this.lblEducationLevel.Location = new System.Drawing.Point(20, 20);
            this.lblEducationLevel.Name = "lblEducationLevel";
            this.lblEducationLevel.Size = new System.Drawing.Size(123, 13);
            this.lblEducationLevel.TabIndex = 0;
            this.lblEducationLevel.Text = "Уровень образования:";
            // 
            // cmbEducationLevel
            // 
            this.cmbEducationLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEducationLevel.FormattingEnabled = true;
            this.cmbEducationLevel.Location = new System.Drawing.Point(150, 17);
            this.cmbEducationLevel.Name = "cmbEducationLevel";
            this.cmbEducationLevel.Size = new System.Drawing.Size(250, 21);
            this.cmbEducationLevel.TabIndex = 1;
            this.cmbEducationLevel.SelectedIndexChanged += new System.EventHandler(this.cmbEducationLevel_SelectedIndexChanged);
            // 
            // grpPrograms
            // 
            this.grpPrograms.Controls.Add(this.dgvPrograms);
            this.grpPrograms.Location = new System.Drawing.Point(20, 50);
            this.grpPrograms.Name = "grpPrograms";
            this.grpPrograms.Size = new System.Drawing.Size(560, 250);
            this.grpPrograms.TabIndex = 2;
            this.grpPrograms.TabStop = false;
            this.grpPrograms.Text = "Направления подготовки";
            // 
            // dgvPrograms
            // 
            this.dgvPrograms.AllowUserToAddRows = false;
            this.dgvPrograms.AllowUserToDeleteRows = false;
            this.dgvPrograms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrograms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrograms.Location = new System.Drawing.Point(10, 20);
            this.dgvPrograms.MultiSelect = false;
            this.dgvPrograms.Name = "dgvPrograms";
            this.dgvPrograms.ReadOnly = true;
            this.dgvPrograms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrograms.Size = new System.Drawing.Size(540, 220);
            this.dgvPrograms.TabIndex = 0;
            // 
            // grpAddProgram
            // 
            this.grpAddProgram.Controls.Add(this.btnAddProgram);
            this.grpAddProgram.Controls.Add(this.txtProgramName);
            this.grpAddProgram.Controls.Add(this.lblProgramName);
            this.grpAddProgram.Location = new System.Drawing.Point(20, 310);
            this.grpAddProgram.Name = "grpAddProgram";
            this.grpAddProgram.Size = new System.Drawing.Size(560, 90);
            this.grpAddProgram.TabIndex = 3;
            this.grpAddProgram.TabStop = false;
            this.grpAddProgram.Text = "Добавление направления";
            // 
            // btnAddProgram
            // 
            this.btnAddProgram.Location = new System.Drawing.Point(429, 43);
            this.btnAddProgram.Name = "btnAddProgram";
            this.btnAddProgram.Size = new System.Drawing.Size(120, 30);
            this.btnAddProgram.TabIndex = 2;
            this.btnAddProgram.Text = "Добавить";
            this.btnAddProgram.UseVisualStyleBackColor = true;
            this.btnAddProgram.Click += new System.EventHandler(this.btnAddProgram_Click);
            // 
            // txtProgramName
            // 
            this.txtProgramName.Location = new System.Drawing.Point(130, 20);
            this.txtProgramName.Multiline = true;
            this.txtProgramName.Name = "txtProgramName";
            this.txtProgramName.Size = new System.Drawing.Size(420, 20);
            this.txtProgramName.TabIndex = 1;
            // 
            // lblProgramName
            // 
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.Location = new System.Drawing.Point(10, 23);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(110, 13);
            this.lblProgramName.TabIndex = 0;
            this.lblProgramName.Text = "Название направления:";
            // 
            // btnDeleteProgram
            // 
            this.btnDeleteProgram.Location = new System.Drawing.Point(20, 410);
            this.btnDeleteProgram.Name = "btnDeleteProgram";
            this.btnDeleteProgram.Size = new System.Drawing.Size(180, 30);
            this.btnDeleteProgram.TabIndex = 4;
            this.btnDeleteProgram.Text = "Удалить выбранное направление";
            this.btnDeleteProgram.UseVisualStyleBackColor = true;
            this.btnDeleteProgram.Click += new System.EventHandler(this.btnDeleteProgram_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(459, 410);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // StudyProgramsManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteProgram);
            this.Controls.Add(this.grpAddProgram);
            this.Controls.Add(this.grpPrograms);
            this.Controls.Add(this.cmbEducationLevel);
            this.Controls.Add(this.lblEducationLevel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudyProgramsManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление направлениями подготовки";
            this.Load += new System.EventHandler(this.StudyProgramsManagementForm_Load);
            this.grpPrograms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrograms)).EndInit();
            this.grpAddProgram.ResumeLayout(false);
            this.grpAddProgram.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEducationLevel;
        private System.Windows.Forms.ComboBox cmbEducationLevel;
        private System.Windows.Forms.GroupBox grpPrograms;
        private System.Windows.Forms.DataGridView dgvPrograms;
        private System.Windows.Forms.GroupBox grpAddProgram;
        private System.Windows.Forms.Button btnAddProgram;
        private System.Windows.Forms.TextBox txtProgramName;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.Button btnDeleteProgram;
        private System.Windows.Forms.Button btnClose;
    }
}
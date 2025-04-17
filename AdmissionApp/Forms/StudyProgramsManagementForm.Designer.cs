namespace AdmissionVGTU
{
    partial class StudyProgramsManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.flowFooterButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDeleteProgram = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlEducationSelect = new System.Windows.Forms.Panel();
            this.lblEducationLevel = new System.Windows.Forms.Label();
            this.cmbEducationLevel = new System.Windows.Forms.ComboBox();
            this.pnlPrograms = new System.Windows.Forms.Panel();
            this.grpPrograms = new System.Windows.Forms.GroupBox();
            this.dgvPrograms = new System.Windows.Forms.DataGridView();
            this.pnlAddProgram = new System.Windows.Forms.Panel();
            this.grpAddProgram = new System.Windows.Forms.GroupBox();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.txtProgramName = new System.Windows.Forms.TextBox();
            this.btnAddProgram = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.flowFooterButtons.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlEducationSelect.SuspendLayout();
            this.pnlPrograms.SuspendLayout();
            this.grpPrograms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrograms)).BeginInit();
            this.pnlAddProgram.SuspendLayout();
            this.grpAddProgram.SuspendLayout();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.pnlHeader.Controls.Add(this.lblFormTitle);
            this.pnlHeader.Controls.Add(this.lblCurrentDate);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Size = new System.Drawing.Size(700, 60);

            // lblFormTitle
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(24, 15);
            this.lblFormTitle.Text = "Управление направлениями";

            // lblCurrentDate
            this.lblCurrentDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCurrentDate.ForeColor = System.Drawing.ColorTranslator.FromHtml("#d1af69");
            this.lblCurrentDate.Location = new System.Drawing.Point(400, 22);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(270, 20);
            this.lblCurrentDate.TabIndex = 2;
            this.lblCurrentDate.Text = "2025-04-13 09:49:59";
            this.lblCurrentDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // pnlFooter
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.flowFooterButtons);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Size = new System.Drawing.Size(700, 65);

            // flowFooterButtons (новая панель для кнопок справа)
            this.flowFooterButtons.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowFooterButtons.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flowFooterButtons.Location = new System.Drawing.Point(340, 13);
            this.flowFooterButtons.Name = "flowFooterButtons";
            this.flowFooterButtons.Size = new System.Drawing.Size(340, 40);
            this.flowFooterButtons.Padding = new System.Windows.Forms.Padding(0);
            this.flowFooterButtons.WrapContents = false;
            this.flowFooterButtons.Controls.Add(this.btnDeleteProgram);
            this.flowFooterButtons.Controls.Add(this.btnClose);

            // btnDeleteProgram
            this.btnDeleteProgram.BackColor = System.Drawing.ColorTranslator.FromHtml("#d1af69");
            this.btnDeleteProgram.FlatAppearance.BorderSize = 0;
            this.btnDeleteProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProgram.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDeleteProgram.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.btnDeleteProgram.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnDeleteProgram.Size = new System.Drawing.Size(210, 38);
            this.btnDeleteProgram.Text = "Удалить выбранное";
            this.btnDeleteProgram.UseVisualStyleBackColor = false;
            this.btnDeleteProgram.Click += new System.EventHandler(this.btnDeleteProgram_Click);

            // btnClose
            this.btnClose.BackColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Size = new System.Drawing.Size(100, 38);
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // pnlContent
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.pnlPrograms);
            this.pnlContent.Controls.Add(this.pnlAddProgram);
            this.pnlContent.Controls.Add(this.pnlEducationSelect);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 60);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlContent.Size = new System.Drawing.Size(700, 435);
            this.pnlContent.TabIndex = 8;

            // pnlEducationSelect
            this.pnlEducationSelect.BackColor = System.Drawing.Color.White;
            this.pnlEducationSelect.Controls.Add(this.lblEducationLevel);
            this.pnlEducationSelect.Controls.Add(this.cmbEducationLevel);
            this.pnlEducationSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEducationSelect.Location = new System.Drawing.Point(0, 0);
            this.pnlEducationSelect.Name = "pnlEducationSelect";
            this.pnlEducationSelect.Size = new System.Drawing.Size(700, 56);
            this.pnlEducationSelect.TabIndex = 0;

            // lblEducationLevel
            this.lblEducationLevel.AutoSize = true;
            this.lblEducationLevel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblEducationLevel.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.lblEducationLevel.Location = new System.Drawing.Point(24, 16);
            this.lblEducationLevel.Name = "lblEducationLevel";
            this.lblEducationLevel.Size = new System.Drawing.Size(174, 20);
            this.lblEducationLevel.TabIndex = 0;
            this.lblEducationLevel.Text = "Уровень образования:";

            // cmbEducationLevel
            this.cmbEducationLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEducationLevel.BackColor = System.Drawing.ColorTranslator.FromHtml("#f1f2f6");
            this.cmbEducationLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEducationLevel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cmbEducationLevel.FormattingEnabled = true;
            this.cmbEducationLevel.Location = new System.Drawing.Point(210, 13);
            this.cmbEducationLevel.Name = "cmbEducationLevel";
            this.cmbEducationLevel.Size = new System.Drawing.Size(450, 27);
            this.cmbEducationLevel.TabIndex = 1;
            this.cmbEducationLevel.SelectedIndexChanged += new System.EventHandler(this.cmbEducationLevel_SelectedIndexChanged);

            // pnlPrograms
            this.pnlPrograms.Controls.Add(this.grpPrograms);
            this.pnlPrograms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrograms.Location = new System.Drawing.Point(0, 56);
            this.pnlPrograms.Name = "pnlPrograms";
            this.pnlPrograms.Padding = new System.Windows.Forms.Padding(24, 12, 24, 12);
            this.pnlPrograms.Size = new System.Drawing.Size(700, 245);
            this.pnlPrograms.TabIndex = 2;

            // grpPrograms
            this.grpPrograms.BackColor = System.Drawing.Color.White;
            this.grpPrograms.Controls.Add(this.dgvPrograms);
            this.grpPrograms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPrograms.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpPrograms.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.grpPrograms.Location = new System.Drawing.Point(24, 12);
            this.grpPrograms.Name = "grpPrograms";
            this.grpPrograms.Padding = new System.Windows.Forms.Padding(15);
            this.grpPrograms.Size = new System.Drawing.Size(652, 221);
            this.grpPrograms.TabIndex = 2;
            this.grpPrograms.TabStop = false;
            this.grpPrograms.Text = "Направления подготовки";

            // dgvPrograms
            this.dgvPrograms.AllowUserToAddRows = false;
            this.dgvPrograms.AllowUserToDeleteRows = false;
            this.dgvPrograms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrograms.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrograms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#d1af69");
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrograms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrograms.ColumnHeadersHeight = 32;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#d1af69");
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrograms.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrograms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrograms.Location = new System.Drawing.Point(15, 26);
            this.dgvPrograms.MultiSelect = false;
            this.dgvPrograms.Name = "dgvPrograms";
            this.dgvPrograms.ReadOnly = true;
            this.dgvPrograms.RowHeadersVisible = false;
            this.dgvPrograms.RowTemplate.Height = 32;
            this.dgvPrograms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrograms.Size = new System.Drawing.Size(622, 180);
            this.dgvPrograms.TabIndex = 0;

            // pnlAddProgram
            this.pnlAddProgram.Controls.Add(this.grpAddProgram);
            this.pnlAddProgram.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAddProgram.Location = new System.Drawing.Point(0, 301);
            this.pnlAddProgram.Name = "pnlAddProgram";
            this.pnlAddProgram.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.pnlAddProgram.Size = new System.Drawing.Size(700, 95);
            this.pnlAddProgram.TabIndex = 1;

            // grpAddProgram
            this.grpAddProgram.BackColor = System.Drawing.ColorTranslator.FromHtml("#f1f2f6");
            this.grpAddProgram.Controls.Add(this.lblProgramName);
            this.grpAddProgram.Controls.Add(this.txtProgramName);
            this.grpAddProgram.Controls.Add(this.btnAddProgram);
            this.grpAddProgram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAddProgram.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpAddProgram.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.grpAddProgram.Location = new System.Drawing.Point(24, 0);
            this.grpAddProgram.Name = "grpAddProgram";
            this.grpAddProgram.Size = new System.Drawing.Size(652, 95);
            this.grpAddProgram.TabIndex = 3;
            this.grpAddProgram.TabStop = false;
            this.grpAddProgram.Text = "Добавление направления";

            // lblProgramName
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblProgramName.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.lblProgramName.Location = new System.Drawing.Point(15, 35);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(183, 20);
            this.lblProgramName.TabIndex = 0;
            this.lblProgramName.Text = "Название направления:";

            // txtProgramName
            this.txtProgramName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProgramName.BackColor = System.Drawing.Color.White;
            this.txtProgramName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtProgramName.Location = new System.Drawing.Point(210, 32);
            this.txtProgramName.Name = "txtProgramName";
            this.txtProgramName.Size = new System.Drawing.Size(270, 27);
            this.txtProgramName.TabIndex = 1;

            // btnAddProgram
            this.btnAddProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProgram.BackColor = System.Drawing.ColorTranslator.FromHtml("#d1af69");
            this.btnAddProgram.FlatAppearance.BorderSize = 0;
            this.btnAddProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProgram.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddProgram.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.btnAddProgram.Location = new System.Drawing.Point(500, 29);
            this.btnAddProgram.Name = "btnAddProgram";
            this.btnAddProgram.Size = new System.Drawing.Size(130, 33);
            this.btnAddProgram.TabIndex = 2;
            this.btnAddProgram.Text = "Добавить";
            this.btnAddProgram.UseVisualStyleBackColor = false;
            this.btnAddProgram.Click += new System.EventHandler(this.btnAddProgram_Click);

            // StudyProgramsManagementForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 560);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudyProgramsManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление направлениями подготовки";
            this.Load += new System.EventHandler(this.StudyProgramsManagementForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.flowFooterButtons.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlEducationSelect.ResumeLayout(false);
            this.pnlEducationSelect.PerformLayout();
            this.pnlPrograms.ResumeLayout(false);
            this.grpPrograms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrograms)).EndInit();
            this.pnlAddProgram.ResumeLayout(false);
            this.grpAddProgram.ResumeLayout(false);
            this.grpAddProgram.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.FlowLayoutPanel flowFooterButtons;
        private System.Windows.Forms.Button btnDeleteProgram;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlEducationSelect;
        private System.Windows.Forms.Label lblEducationLevel;
        private System.Windows.Forms.ComboBox cmbEducationLevel;
        private System.Windows.Forms.Panel pnlPrograms;
        private System.Windows.Forms.GroupBox grpPrograms;
        private System.Windows.Forms.DataGridView dgvPrograms;
        private System.Windows.Forms.Panel pnlAddProgram;
        private System.Windows.Forms.GroupBox grpAddProgram;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.TextBox txtProgramName;
        private System.Windows.Forms.Button btnAddProgram;
    }
}
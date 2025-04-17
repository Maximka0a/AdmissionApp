namespace AdmissionVGTU
{
    partial class AdminDashboardForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.dgvApplications = new System.Windows.Forms.DataGridView();
            this.btnViewApplication = new System.Windows.Forms.Button();
            this.btnManagePrograms = new System.Windows.Forms.Button();
            this.btnGenerateReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblApplications = new System.Windows.Forms.Label();
            this.grpFilters = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.chkFilterByDate = new System.Windows.Forms.CheckBox();
            this.dtpFilterDate = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbEducationLevel = new System.Windows.Forms.ComboBox();
            this.lblEducationLevel = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).BeginInit();
            this.grpFilters.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(30, 15);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(347, 32);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Добро пожаловать, Админ!";
            // 
            // dgvApplications
            // 
            this.dgvApplications.AllowUserToAddRows = false;
            this.dgvApplications.AllowUserToDeleteRows = false;
            this.dgvApplications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApplications.BackgroundColor = System.Drawing.Color.White;
            this.dgvApplications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(175)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(175)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvApplications.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvApplications.Location = new System.Drawing.Point(39, 75);
            this.dgvApplications.MultiSelect = false;
            this.dgvApplications.Name = "dgvApplications";
            this.dgvApplications.ReadOnly = true;
            this.dgvApplications.RowHeadersVisible = false;
            this.dgvApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplications.Size = new System.Drawing.Size(1000, 310);
            this.dgvApplications.TabIndex = 1;
            // 
            // btnViewApplication
            // 
            this.btnViewApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(175)))), ((int)(((byte)(105)))));
            this.btnViewApplication.FlatAppearance.BorderSize = 0;
            this.btnViewApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewApplication.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewApplication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.btnViewApplication.Location = new System.Drawing.Point(30, 15);
            this.btnViewApplication.Name = "btnViewApplication";
            this.btnViewApplication.Size = new System.Drawing.Size(180, 45);
            this.btnViewApplication.TabIndex = 2;
            this.btnViewApplication.Text = "Просмотр";
            this.btnViewApplication.UseVisualStyleBackColor = false;
            this.btnViewApplication.Click += new System.EventHandler(this.btnViewApplication_Click);
            // 
            // btnManagePrograms
            // 
            this.btnManagePrograms.BackColor = System.Drawing.Color.White;
            this.btnManagePrograms.FlatAppearance.BorderSize = 0;
            this.btnManagePrograms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagePrograms.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnManagePrograms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.btnManagePrograms.Location = new System.Drawing.Point(30, 75);
            this.btnManagePrograms.Name = "btnManagePrograms";
            this.btnManagePrograms.Size = new System.Drawing.Size(180, 45);
            this.btnManagePrograms.TabIndex = 3;
            this.btnManagePrograms.Text = "Направления";
            this.btnManagePrograms.UseVisualStyleBackColor = false;
            this.btnManagePrograms.Click += new System.EventHandler(this.btnManagePrograms_Click);
            // 
            // btnGenerateReports
            // 
            this.btnGenerateReports.BackColor = System.Drawing.Color.White;
            this.btnGenerateReports.FlatAppearance.BorderSize = 0;
            this.btnGenerateReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReports.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerateReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.btnGenerateReports.Location = new System.Drawing.Point(30, 135);
            this.btnGenerateReports.Name = "btnGenerateReports";
            this.btnGenerateReports.Size = new System.Drawing.Size(180, 45);
            this.btnGenerateReports.TabIndex = 4;
            this.btnGenerateReports.Text = "Отчёты";
            this.btnGenerateReports.UseVisualStyleBackColor = false;
            this.btnGenerateReports.Click += new System.EventHandler(this.btnGenerateReports_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(30, 350);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 45);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Выйти";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblApplications
            // 
            this.lblApplications.AutoSize = true;
            this.lblApplications.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblApplications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.lblApplications.Location = new System.Drawing.Point(39, 35);
            this.lblApplications.Name = "lblApplications";
            this.lblApplications.Size = new System.Drawing.Size(234, 30);
            this.lblApplications.TabIndex = 6;
            this.lblApplications.Text = "Поданные заявления";
            // 
            // grpFilters
            // 
            this.grpFilters.BackColor = System.Drawing.Color.White;
            this.grpFilters.Controls.Add(this.btnFilter);
            this.grpFilters.Controls.Add(this.chkFilterByDate);
            this.grpFilters.Controls.Add(this.dtpFilterDate);
            this.grpFilters.Controls.Add(this.cmbStatus);
            this.grpFilters.Controls.Add(this.lblStatus);
            this.grpFilters.Controls.Add(this.cmbEducationLevel);
            this.grpFilters.Controls.Add(this.lblEducationLevel);
            this.grpFilters.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpFilters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.grpFilters.Location = new System.Drawing.Point(40, 412);
            this.grpFilters.Name = "grpFilters";
            this.grpFilters.Size = new System.Drawing.Size(765, 80);
            this.grpFilters.TabIndex = 7;
            this.grpFilters.TabStop = false;
            this.grpFilters.Text = "Фильтры";
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(175)))), ((int)(((byte)(105)))));
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.btnFilter.Location = new System.Drawing.Point(635, 25);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(110, 35);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "Применить";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // chkFilterByDate
            // 
            this.chkFilterByDate.AutoSize = true;
            this.chkFilterByDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkFilterByDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.chkFilterByDate.Location = new System.Drawing.Point(440, 30);
            this.chkFilterByDate.Name = "chkFilterByDate";
            this.chkFilterByDate.Size = new System.Drawing.Size(126, 23);
            this.chkFilterByDate.TabIndex = 5;
            this.chkFilterByDate.Text = "Фильтр по дате";
            this.chkFilterByDate.UseVisualStyleBackColor = true;
            this.chkFilterByDate.CheckedChanged += new System.EventHandler(this.chkFilterByDate_CheckedChanged);
            // 
            // dtpFilterDate
            // 
            this.dtpFilterDate.CalendarFont = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFilterDate.Enabled = false;
            this.dtpFilterDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFilterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFilterDate.Location = new System.Drawing.Point(440, 50);
            this.dtpFilterDate.Name = "dtpFilterDate";
            this.dtpFilterDate.Size = new System.Drawing.Size(131, 25);
            this.dtpFilterDate.TabIndex = 4;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(230, 45);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(180, 25);
            this.cmbStatus.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.lblStatus.Location = new System.Drawing.Point(230, 25);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 19);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Статус:";
            // 
            // cmbEducationLevel
            // 
            this.cmbEducationLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEducationLevel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEducationLevel.FormattingEnabled = true;
            this.cmbEducationLevel.Location = new System.Drawing.Point(20, 45);
            this.cmbEducationLevel.Name = "cmbEducationLevel";
            this.cmbEducationLevel.Size = new System.Drawing.Size(180, 25);
            this.cmbEducationLevel.TabIndex = 1;
            // 
            // lblEducationLevel
            // 
            this.lblEducationLevel.AutoSize = true;
            this.lblEducationLevel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEducationLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.lblEducationLevel.Location = new System.Drawing.Point(20, 25);
            this.lblEducationLevel.Name = "lblEducationLevel";
            this.lblEducationLevel.Size = new System.Drawing.Size(151, 19);
            this.lblEducationLevel.TabIndex = 0;
            this.lblEducationLevel.Text = "Уровень образования:";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1292, 65);
            this.pnlHeader.TabIndex = 8;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.btnViewApplication);
            this.pnlFooter.Controls.Add(this.btnManagePrograms);
            this.pnlFooter.Controls.Add(this.btnGenerateReports);
            this.pnlFooter.Controls.Add(this.btnLogout);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFooter.Location = new System.Drawing.Point(0, 65);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(240, 505);
            this.pnlFooter.TabIndex = 9;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.lblApplications);
            this.pnlMain.Controls.Add(this.grpFilters);
            this.pnlMain.Controls.Add(this.dgvApplications);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(240, 65);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMain.Size = new System.Drawing.Size(1052, 505);
            this.pnlMain.TabIndex = 10;
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1292, 570);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель управления приёмной комиссией";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminDashboardForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).EndInit();
            this.grpFilters.ResumeLayout(false);
            this.grpFilters.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DataGridView dgvApplications;
        private System.Windows.Forms.Button btnViewApplication;
        private System.Windows.Forms.Button btnManagePrograms;
        private System.Windows.Forms.Button btnGenerateReports;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblApplications;
        private System.Windows.Forms.GroupBox grpFilters;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.CheckBox chkFilterByDate;
        private System.Windows.Forms.DateTimePicker dtpFilterDate;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbEducationLevel;
        private System.Windows.Forms.Label lblEducationLevel;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlMain;
    }
}
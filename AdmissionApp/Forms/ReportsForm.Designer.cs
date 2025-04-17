namespace AdmissionVGTU
{
    partial class ReportsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageProgramsStats = new System.Windows.Forms.TabPage();
            this.chartPrograms = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvProgramStats = new System.Windows.Forms.DataGridView();
            this.tabPageStatusStats = new System.Windows.Forms.TabPage();
            this.chartStatuses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvStatusStats = new System.Windows.Forms.DataGridView();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPageProgramsStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrograms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramStats)).BeginInit();
            this.tabPageStatusStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatuses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatusStats)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageProgramsStats);
            this.tabControl1.Controls.Add(this.tabPageStatusStats);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(15, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(770, 486);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Normal;
            this.tabControl1.ItemSize = new System.Drawing.Size(160, 30);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            // 
            // tabPageProgramsStats
            // 
            this.tabPageProgramsStats.BackColor = System.Drawing.Color.White;
            this.tabPageProgramsStats.Controls.Add(this.chartPrograms);
            this.tabPageProgramsStats.Controls.Add(this.dgvProgramStats);
            this.tabPageProgramsStats.Location = new System.Drawing.Point(4, 34);
            this.tabPageProgramsStats.Name = "tabPageProgramsStats";
            this.tabPageProgramsStats.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageProgramsStats.Size = new System.Drawing.Size(762, 448);
            this.tabPageProgramsStats.TabIndex = 0;
            this.tabPageProgramsStats.Text = "По направлениям";
            // 
            // chartPrograms
            // 
            this.chartPrograms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartPrograms.BackColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chartPrograms.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.White;
            legend1.Font = new System.Drawing.Font("Segoe UI", 9F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartPrograms.Legends.Add(legend1);
            this.chartPrograms.Location = new System.Drawing.Point(10, 230);
            this.chartPrograms.Name = "chartPrograms";
            this.chartPrograms.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.chartPrograms.Size = new System.Drawing.Size(742, 200);
            this.chartPrograms.TabIndex = 1;
            this.chartPrograms.Text = "Статистика по направлениям";
            // 
            // dgvProgramStats
            // 
            this.dgvProgramStats.AllowUserToAddRows = false;
            this.dgvProgramStats.AllowUserToDeleteRows = false;
            this.dgvProgramStats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProgramStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProgramStats.BackgroundColor = System.Drawing.Color.White;
            this.dgvProgramStats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#d1af69");
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProgramStats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProgramStats.ColumnHeadersHeight = 32;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#d1af69");
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProgramStats.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProgramStats.Location = new System.Drawing.Point(10, 10);
            this.dgvProgramStats.Name = "dgvProgramStats";
            this.dgvProgramStats.ReadOnly = true;
            this.dgvProgramStats.RowHeadersVisible = false;
            this.dgvProgramStats.RowTemplate.Height = 32;
            this.dgvProgramStats.Size = new System.Drawing.Size(742, 211);
            this.dgvProgramStats.TabIndex = 0;
            // 
            // tabPageStatusStats
            // 
            this.tabPageStatusStats.BackColor = System.Drawing.Color.White;
            this.tabPageStatusStats.Controls.Add(this.chartStatuses);
            this.tabPageStatusStats.Controls.Add(this.dgvStatusStats);
            this.tabPageStatusStats.Location = new System.Drawing.Point(4, 34);
            this.tabPageStatusStats.Name = "tabPageStatusStats";
            this.tabPageStatusStats.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageStatusStats.Size = new System.Drawing.Size(762, 448);
            this.tabPageStatusStats.TabIndex = 1;
            this.tabPageStatusStats.Text = "По статусам";
            // 
            // chartStatuses
            // 
            this.chartStatuses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartStatuses.BackColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.chartStatuses.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.White;
            legend2.Font = new System.Drawing.Font("Segoe UI", 9F);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chartStatuses.Legends.Add(legend2);
            this.chartStatuses.Location = new System.Drawing.Point(10, 230);
            this.chartStatuses.Name = "chartStatuses";
            this.chartStatuses.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.chartStatuses.Size = new System.Drawing.Size(742, 200);
            this.chartStatuses.TabIndex = 1;
            this.chartStatuses.Text = "Статистика по статусам";
            // 
            // dgvStatusStats
            // 
            this.dgvStatusStats.AllowUserToAddRows = false;
            this.dgvStatusStats.AllowUserToDeleteRows = false;
            this.dgvStatusStats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStatusStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatusStats.BackgroundColor = System.Drawing.Color.White;
            this.dgvStatusStats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#d1af69");
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStatusStats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStatusStats.ColumnHeadersHeight = 32;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#d1af69");
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStatusStats.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStatusStats.Location = new System.Drawing.Point(10, 10);
            this.dgvStatusStats.Name = "dgvStatusStats";
            this.dgvStatusStats.ReadOnly = true;
            this.dgvStatusStats.RowHeadersVisible = false;
            this.dgvStatusStats.RowTemplate.Height = 32;
            this.dgvStatusStats.Size = new System.Drawing.Size(742, 211);
            this.dgvStatusStats.TabIndex = 0;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.ColorTranslator.FromHtml("#d1af69");
            this.btnGenerateReport.FlatAppearance.BorderSize = 0;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnGenerateReport.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.btnGenerateReport.Location = new System.Drawing.Point(15, 15);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(220, 38);
            this.btnGenerateReport.TabIndex = 1;
            this.btnGenerateReport.Text = "Сформировать отчет";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(565, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(220, 38);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.pnlHeader.Controls.Add(this.lblCurrentDate);
            this.pnlHeader.Controls.Add(this.lblFormTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 60);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCurrentDate.ForeColor = System.Drawing.ColorTranslator.FromHtml("#d1af69");
            this.lblCurrentDate.Location = new System.Drawing.Point(520, 22);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(265, 18);
            this.lblCurrentDate.TabIndex = 1;
            this.lblCurrentDate.Text = "2025-04-13 09:49:59";
            this.lblCurrentDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(20, 15);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(244, 32);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Отчеты по приему";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.btnGenerateReport);
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 576);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(800, 65);
            this.pnlFooter.TabIndex = 4;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.tabControl1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 60);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(15);
            this.pnlContent.Size = new System.Drawing.Size(800, 516);
            this.pnlContent.TabIndex = 5;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 641);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчеты по приему";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageProgramsStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPrograms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramStats)).EndInit();
            this.tabPageStatusStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStatuses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatusStats)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageProgramsStats;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrograms;
        private System.Windows.Forms.DataGridView dgvProgramStats;
        private System.Windows.Forms.TabPage tabPageStatusStats;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatuses;
        private System.Windows.Forms.DataGridView dgvStatusStats;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblCurrentDate;
    }
}
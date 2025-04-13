namespace AdmissionApp
{
    partial class ReportsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageProgramsStats = new System.Windows.Forms.TabPage();
            this.chartPrograms = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvProgramStats = new System.Windows.Forms.DataGridView();
            this.tabPageStatusStats = new System.Windows.Forms.TabPage();
            this.chartStatuses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvStatusStats = new System.Windows.Forms.DataGridView();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageProgramsStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrograms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramStats)).BeginInit();
            this.tabPageStatusStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatuses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatusStats)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageProgramsStats);
            this.tabControl1.Controls.Add(this.tabPageStatusStats);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 489);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageProgramsStats
            // 
            this.tabPageProgramsStats.Controls.Add(this.chartPrograms);
            this.tabPageProgramsStats.Controls.Add(this.dgvProgramStats);
            this.tabPageProgramsStats.Location = new System.Drawing.Point(4, 22);
            this.tabPageProgramsStats.Name = "tabPageProgramsStats";
            this.tabPageProgramsStats.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProgramsStats.Size = new System.Drawing.Size(752, 463);
            this.tabPageProgramsStats.TabIndex = 0;
            this.tabPageProgramsStats.Text = "Статистика по направлениям";
            this.tabPageProgramsStats.UseVisualStyleBackColor = true;
            // 
            // chartPrograms
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPrograms.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPrograms.Legends.Add(legend1);
            this.chartPrograms.Location = new System.Drawing.Point(6, 207);
            this.chartPrograms.Name = "chartPrograms";
            this.chartPrograms.Size = new System.Drawing.Size(740, 250);
            this.chartPrograms.TabIndex = 1;
            this.chartPrograms.Text = "chart1";
            // 
            // dgvProgramStats
            // 
            this.dgvProgramStats.AllowUserToAddRows = false;
            this.dgvProgramStats.AllowUserToDeleteRows = false;
            this.dgvProgramStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProgramStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgramStats.Location = new System.Drawing.Point(6, 6);
            this.dgvProgramStats.Name = "dgvProgramStats";
            this.dgvProgramStats.ReadOnly = true;
            this.dgvProgramStats.Size = new System.Drawing.Size(740, 195);
            this.dgvProgramStats.TabIndex = 0;
            // 
            // tabPageStatusStats
            // 
            this.tabPageStatusStats.Controls.Add(this.chartStatuses);
            this.tabPageStatusStats.Controls.Add(this.dgvStatusStats);
            this.tabPageStatusStats.Location = new System.Drawing.Point(4, 22);
            this.tabPageStatusStats.Name = "tabPageStatusStats";
            this.tabPageStatusStats.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStatusStats.Size = new System.Drawing.Size(752, 463);
            this.tabPageStatusStats.TabIndex = 1;
            this.tabPageStatusStats.Text = "Статистика по статусам";
            this.tabPageStatusStats.UseVisualStyleBackColor = true;
            // 
            // chartStatuses
            // 
            chartArea2.Name = "ChartArea1";
            this.chartStatuses.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartStatuses.Legends.Add(legend2);
            this.chartStatuses.Location = new System.Drawing.Point(6, 207);
            this.chartStatuses.Name = "chartStatuses";
            this.chartStatuses.Size = new System.Drawing.Size(740, 250);
            this.chartStatuses.TabIndex = 1;
            this.chartStatuses.Text = "chart2";
            // 
            // dgvStatusStats
            // 
            this.dgvStatusStats.AllowUserToAddRows = false;
            this.dgvStatusStats.AllowUserToDeleteRows = false;
            this.dgvStatusStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatusStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatusStats.Location = new System.Drawing.Point(6, 6);
            this.dgvStatusStats.Name = "dgvStatusStats";
            this.dgvStatusStats.ReadOnly = true;
            this.dgvStatusStats.Size = new System.Drawing.Size(740, 195);
            this.dgvStatusStats.TabIndex = 0;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(12, 507);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(150, 30);
            this.btnGenerateReport.TabIndex = 1;
            this.btnGenerateReport.Text = "Сформировать отчет";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(622, 507);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 551);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.tabControl1);
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
    }
}
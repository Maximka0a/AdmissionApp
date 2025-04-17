using System.Drawing;

namespace AdmissionVGTU
{
    partial class ApplicantDashboardForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPrintApplication = new System.Windows.Forms.Button();
            this.btnViewApplication = new System.Windows.Forms.Button();
            this.btnNewApplication = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblApplications = new System.Windows.Forms.Label();
            this.dgvApplications = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Controls.Add(this.lblDate);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1080, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(30, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(370, 30);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Добро пожаловать, Maximka0a!";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDate.ForeColor = System.Drawing.ColorTranslator.FromHtml("#d1af69");
            this.lblDate.Location = new System.Drawing.Point(800, 28);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(250, 18);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "2025-04-13 09:40:00";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.btnLogout);
            this.pnlFooter.Controls.Add(this.btnPrintApplication);
            this.pnlFooter.Controls.Add(this.btnViewApplication);
            this.pnlFooter.Controls.Add(this.btnNewApplication);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFooter.Location = new System.Drawing.Point(0, 70);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(220, 510);
            this.pnlFooter.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(20, 415);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 45);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Выйти";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPrintApplication
            // 
            this.btnPrintApplication.BackColor = Color.White;
            this.btnPrintApplication.FlatAppearance.BorderSize = 0;
            this.btnPrintApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintApplication.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrintApplication.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.btnPrintApplication.Location = new System.Drawing.Point(20, 140);
            this.btnPrintApplication.Name = "btnPrintApplication";
            this.btnPrintApplication.Size = new System.Drawing.Size(180, 45);
            this.btnPrintApplication.TabIndex = 4;
            this.btnPrintApplication.Text = "Распечатать";
            this.btnPrintApplication.UseVisualStyleBackColor = false;
            this.btnPrintApplication.Click += new System.EventHandler(this.btnPrintApplication_Click);
            // 
            // btnViewApplication
            // 
            this.btnViewApplication.BackColor = Color.White;
            this.btnViewApplication.FlatAppearance.BorderSize = 0;
            this.btnViewApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewApplication.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnViewApplication.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.btnViewApplication.Location = new System.Drawing.Point(20, 80);
            this.btnViewApplication.Name = "btnViewApplication";
            this.btnViewApplication.Size = new System.Drawing.Size(180, 45);
            this.btnViewApplication.TabIndex = 3;
            this.btnViewApplication.Text = "Просмотр";
            this.btnViewApplication.UseVisualStyleBackColor = false;
            this.btnViewApplication.Click += new System.EventHandler(this.btnViewApplication_Click);
            // 
            // btnNewApplication
            // 
            this.btnNewApplication.BackColor = System.Drawing.ColorTranslator.FromHtml("#d1af69");
            this.btnNewApplication.FlatAppearance.BorderSize = 0;
            this.btnNewApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewApplication.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNewApplication.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.btnNewApplication.Location = new System.Drawing.Point(20, 20);
            this.btnNewApplication.Name = "btnNewApplication";
            this.btnNewApplication.Size = new System.Drawing.Size(180, 45);
            this.btnNewApplication.TabIndex = 2;
            this.btnNewApplication.Text = "Подать заявление";
            this.btnNewApplication.UseVisualStyleBackColor = false;
            this.btnNewApplication.Click += new System.EventHandler(this.btnNewApplication_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.lblApplications);
            this.pnlMain.Controls.Add(this.dgvApplications);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(220, 70);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(30, 30, 30, 30);
            this.pnlMain.Size = new System.Drawing.Size(860, 510);
            this.pnlMain.TabIndex = 2;
            // 
            // lblApplications
            // 
            this.lblApplications.AutoSize = true;
            this.lblApplications.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblApplications.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.lblApplications.Location = new System.Drawing.Point(20, 20);
            this.lblApplications.Name = "lblApplications";
            this.lblApplications.Size = new System.Drawing.Size(210, 30);
            this.lblApplications.TabIndex = 6;
            this.lblApplications.Text = "Ваши заявления:";
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
            dataGridViewCellStyle1.BackColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#d1af69");
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#d1af69");
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvApplications.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvApplications.Location = new System.Drawing.Point(20, 70);
            this.dgvApplications.MultiSelect = false;
            this.dgvApplications.Name = "dgvApplications";
            this.dgvApplications.ReadOnly = true;
            this.dgvApplications.RowHeadersVisible = false;
            this.dgvApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplications.Size = new System.Drawing.Size(820, 410);
            this.dgvApplications.TabIndex = 1;
            // 
            // ApplicantDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 580);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "ApplicantDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Личный кабинет абитуриента";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ApplicantDashboardForm_FormClosing);
            this.Load += new System.EventHandler(this.ApplicantDashboardForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnPrintApplication;
        private System.Windows.Forms.Button btnViewApplication;
        private System.Windows.Forms.Button btnNewApplication;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblApplications;
        private System.Windows.Forms.DataGridView dgvApplications;
    }
}
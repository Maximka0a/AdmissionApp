namespace AdmissionApp
{
    partial class ApplicantDashboardForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.dgvApplications = new System.Windows.Forms.DataGridView();
            this.btnNewApplication = new System.Windows.Forms.Button();
            this.btnViewApplication = new System.Windows.Forms.Button();
            this.btnPrintApplication = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblApplications = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(175, 20);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Добро пожаловать!";
            // 
            // dgvApplications
            // 
            this.dgvApplications.AllowUserToAddRows = false;
            this.dgvApplications.AllowUserToDeleteRows = false;
            this.dgvApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplications.Location = new System.Drawing.Point(20, 80);
            this.dgvApplications.MultiSelect = false;
            this.dgvApplications.Name = "dgvApplications";
            this.dgvApplications.ReadOnly = true;
            this.dgvApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplications.Size = new System.Drawing.Size(1012, 300);
            this.dgvApplications.TabIndex = 1;
            // 
            // btnNewApplication
            // 
            this.btnNewApplication.Location = new System.Drawing.Point(20, 400);
            this.btnNewApplication.Name = "btnNewApplication";
            this.btnNewApplication.Size = new System.Drawing.Size(150, 30);
            this.btnNewApplication.TabIndex = 2;
            this.btnNewApplication.Text = "Подать заявление";
            this.btnNewApplication.UseVisualStyleBackColor = true;
            this.btnNewApplication.Click += new System.EventHandler(this.btnNewApplication_Click);
            // 
            // btnViewApplication
            // 
            this.btnViewApplication.Location = new System.Drawing.Point(180, 400);
            this.btnViewApplication.Name = "btnViewApplication";
            this.btnViewApplication.Size = new System.Drawing.Size(150, 30);
            this.btnViewApplication.TabIndex = 3;
            this.btnViewApplication.Text = "Просмотреть заявление";
            this.btnViewApplication.UseVisualStyleBackColor = true;
            this.btnViewApplication.Click += new System.EventHandler(this.btnViewApplication_Click);
            // 
            // btnPrintApplication
            // 
            this.btnPrintApplication.Location = new System.Drawing.Point(340, 400);
            this.btnPrintApplication.Name = "btnPrintApplication";
            this.btnPrintApplication.Size = new System.Drawing.Size(150, 30);
            this.btnPrintApplication.TabIndex = 4;
            this.btnPrintApplication.Text = "Распечатать заявление";
            this.btnPrintApplication.UseVisualStyleBackColor = true;
            this.btnPrintApplication.Click += new System.EventHandler(this.btnPrintApplication_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(882, 400);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 30);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Выход";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblApplications
            // 
            this.lblApplications.AutoSize = true;
            this.lblApplications.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblApplications.Location = new System.Drawing.Point(20, 60);
            this.lblApplications.Name = "lblApplications";
            this.lblApplications.Size = new System.Drawing.Size(122, 17);
            this.lblApplications.TabIndex = 6;
            this.lblApplications.Text = "Ваши заявления:";
            // 
            // ApplicantDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 461);
            this.Controls.Add(this.lblApplications);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPrintApplication);
            this.Controls.Add(this.btnViewApplication);
            this.Controls.Add(this.btnNewApplication);
            this.Controls.Add(this.dgvApplications);
            this.Controls.Add(this.lblWelcome);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "ApplicantDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Личный кабинет абитуриента";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ApplicantDashboardForm_FormClosing);
            this.Load += new System.EventHandler(this.ApplicantDashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DataGridView dgvApplications;
        private System.Windows.Forms.Button btnNewApplication;
        private System.Windows.Forms.Button btnViewApplication;
        private System.Windows.Forms.Button btnPrintApplication;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblApplications;
    }
}
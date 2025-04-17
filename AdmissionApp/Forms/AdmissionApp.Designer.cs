namespace AdmissionVGTU
{
    partial class ApplicationManagementForm
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

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlRightSide = new System.Windows.Forms.Panel();
            this.grpStatusUpdate = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtStatusComment = new System.Windows.Forms.TextBox();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.pnlLeftSide = new System.Windows.Forms.Panel();
            this.grpApplicantInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblApplicantName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPassportData = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSnils = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblParentName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPreviousInstitution = new System.Windows.Forms.Label();
            this.grpApplicationInfo = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblEducationLevel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblGradeScore = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSubmissionDate = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblLastUpdateDate = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lstSelectedPrograms = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnOpenDocument = new System.Windows.Forms.Button();
            this.lblDocumentPath = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlRightSide.SuspendLayout();
            this.grpStatusUpdate.SuspendLayout();
            this.pnlLeftSide.SuspendLayout();
            this.grpApplicantInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(825, 43);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(22, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(304, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Управление заявлением";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 486);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(825, 43);
            this.pnlFooter.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(175)))), ((int)(((byte)(105)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.btnClose.Location = new System.Drawing.Point(615, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(188, 29);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlRightSide
            // 
            this.pnlRightSide.BackColor = System.Drawing.Color.White;
            this.pnlRightSide.Controls.Add(this.grpStatusUpdate);
            this.pnlRightSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRightSide.Location = new System.Drawing.Point(600, 43);
            this.pnlRightSide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlRightSide.Name = "pnlRightSide";
            this.pnlRightSide.Padding = new System.Windows.Forms.Padding(19, 22, 19, 22);
            this.pnlRightSide.Size = new System.Drawing.Size(225, 443);
            this.pnlRightSide.TabIndex = 1;
            // 
            // grpStatusUpdate
            // 
            this.grpStatusUpdate.BackColor = System.Drawing.Color.White;
            this.grpStatusUpdate.Controls.Add(this.label15);
            this.grpStatusUpdate.Controls.Add(this.cmbStatus);
            this.grpStatusUpdate.Controls.Add(this.label16);
            this.grpStatusUpdate.Controls.Add(this.txtStatusComment);
            this.grpStatusUpdate.Controls.Add(this.btnUpdateStatus);
            this.grpStatusUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.grpStatusUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.grpStatusUpdate.Location = new System.Drawing.Point(0, 0);
            this.grpStatusUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpStatusUpdate.Name = "grpStatusUpdate";
            this.grpStatusUpdate.Padding = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.grpStatusUpdate.Size = new System.Drawing.Size(188, 188);
            this.grpStatusUpdate.TabIndex = 0;
            this.grpStatusUpdate.TabStop = false;
            this.grpStatusUpdate.Text = "Обновление статуса";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.label15.Location = new System.Drawing.Point(11, 29);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "Статус:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatus.Location = new System.Drawing.Point(11, 45);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(151, 25);
            this.cmbStatus.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.label16.Location = new System.Drawing.Point(11, 74);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(165, 19);
            this.label16.TabIndex = 2;
            this.label16.Text = "Комментарий статуса:";
            // 
            // txtStatusComment
            // 
            this.txtStatusComment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStatusComment.Location = new System.Drawing.Point(11, 90);
            this.txtStatusComment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStatusComment.Name = "txtStatusComment";
            this.txtStatusComment.Size = new System.Drawing.Size(151, 25);
            this.txtStatusComment.TabIndex = 3;
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(175)))), ((int)(((byte)(105)))));
            this.btnUpdateStatus.FlatAppearance.BorderSize = 0;
            this.btnUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdateStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.btnUpdateStatus.Location = new System.Drawing.Point(11, 126);
            this.btnUpdateStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(150, 29);
            this.btnUpdateStatus.TabIndex = 4;
            this.btnUpdateStatus.Text = "Обновить статус";
            this.btnUpdateStatus.UseVisualStyleBackColor = false;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // pnlLeftSide
            // 
            this.pnlLeftSide.AutoScroll = true;
            this.pnlLeftSide.BackColor = System.Drawing.Color.White;
            this.pnlLeftSide.Controls.Add(this.grpApplicantInfo);
            this.pnlLeftSide.Controls.Add(this.grpApplicationInfo);
            this.pnlLeftSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftSide.Location = new System.Drawing.Point(0, 43);
            this.pnlLeftSide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlLeftSide.Name = "pnlLeftSide";
            this.pnlLeftSide.Padding = new System.Windows.Forms.Padding(22, 22, 22, 22);
            this.pnlLeftSide.Size = new System.Drawing.Size(600, 443);
            this.pnlLeftSide.TabIndex = 0;
            // 
            // grpApplicantInfo
            // 
            this.grpApplicantInfo.BackColor = System.Drawing.Color.White;
            this.grpApplicantInfo.Controls.Add(this.tableLayoutPanel1);
            this.grpApplicantInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.grpApplicantInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.grpApplicantInfo.Location = new System.Drawing.Point(0, 0);
            this.grpApplicantInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpApplicantInfo.Name = "grpApplicantInfo";
            this.grpApplicantInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpApplicantInfo.Size = new System.Drawing.Size(532, 144);
            this.grpApplicantInfo.TabIndex = 0;
            this.grpApplicantInfo.TabStop = false;
            this.grpApplicantInfo.Text = "Абитуриент";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblApplicantName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPassportData, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblSnils, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblEmail, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblPhone, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblParentName, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblPreviousInstitution, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 25);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(502, 105);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО:";
            // 
            // lblApplicantName
            // 
            this.lblApplicantName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblApplicantName.AutoSize = true;
            this.lblApplicantName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblApplicantName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblApplicantName.Location = new System.Drawing.Point(227, 0);
            this.lblApplicantName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApplicantName.Name = "lblApplicantName";
            this.lblApplicantName.Size = new System.Drawing.Size(16, 15);
            this.lblApplicantName.TabIndex = 1;
            this.lblApplicantName.Text = "...";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(2, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Паспортные данные:";
            // 
            // lblPassportData
            // 
            this.lblPassportData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPassportData.AutoSize = true;
            this.lblPassportData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPassportData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblPassportData.Location = new System.Drawing.Point(227, 15);
            this.lblPassportData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassportData.Name = "lblPassportData";
            this.lblPassportData.Size = new System.Drawing.Size(16, 15);
            this.lblPassportData.TabIndex = 3;
            this.lblPassportData.Text = "...";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(2, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "СНИЛС:";
            // 
            // lblSnils
            // 
            this.lblSnils.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSnils.AutoSize = true;
            this.lblSnils.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSnils.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblSnils.Location = new System.Drawing.Point(227, 30);
            this.lblSnils.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSnils.Name = "lblSnils";
            this.lblSnils.Size = new System.Drawing.Size(16, 15);
            this.lblSnils.TabIndex = 5;
            this.lblSnils.Text = "...";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(2, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Электронная почта:";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblEmail.Location = new System.Drawing.Point(227, 45);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(16, 15);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "...";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.label5.Location = new System.Drawing.Point(2, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Телефон:";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblPhone.Location = new System.Drawing.Point(227, 60);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(16, 15);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "...";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.label6.Location = new System.Drawing.Point(2, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "ФИО родителя:";
            // 
            // lblParentName
            // 
            this.lblParentName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblParentName.AutoSize = true;
            this.lblParentName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblParentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblParentName.Location = new System.Drawing.Point(227, 75);
            this.lblParentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParentName.Name = "lblParentName";
            this.lblParentName.Size = new System.Drawing.Size(16, 15);
            this.lblParentName.TabIndex = 11;
            this.lblParentName.Text = "...";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.label7.Location = new System.Drawing.Point(2, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Учебное заведение:";
            // 
            // lblPreviousInstitution
            // 
            this.lblPreviousInstitution.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPreviousInstitution.AutoSize = true;
            this.lblPreviousInstitution.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPreviousInstitution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblPreviousInstitution.Location = new System.Drawing.Point(227, 90);
            this.lblPreviousInstitution.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreviousInstitution.Name = "lblPreviousInstitution";
            this.lblPreviousInstitution.Size = new System.Drawing.Size(16, 15);
            this.lblPreviousInstitution.TabIndex = 13;
            this.lblPreviousInstitution.Text = "...";
            // 
            // grpApplicationInfo
            // 
            this.grpApplicationInfo.BackColor = System.Drawing.Color.White;
            this.grpApplicationInfo.Controls.Add(this.label8);
            this.grpApplicationInfo.Controls.Add(this.lblEducationLevel);
            this.grpApplicationInfo.Controls.Add(this.label9);
            this.grpApplicationInfo.Controls.Add(this.lblGradeScore);
            this.grpApplicationInfo.Controls.Add(this.label10);
            this.grpApplicationInfo.Controls.Add(this.lblSubmissionDate);
            this.grpApplicationInfo.Controls.Add(this.label11);
            this.grpApplicationInfo.Controls.Add(this.lblLastUpdateDate);
            this.grpApplicationInfo.Controls.Add(this.label12);
            this.grpApplicationInfo.Controls.Add(this.lblCurrentStatus);
            this.grpApplicationInfo.Controls.Add(this.label13);
            this.grpApplicationInfo.Controls.Add(this.lstSelectedPrograms);
            this.grpApplicationInfo.Controls.Add(this.label14);
            this.grpApplicationInfo.Controls.Add(this.btnOpenDocument);
            this.grpApplicationInfo.Controls.Add(this.lblDocumentPath);
            this.grpApplicationInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.grpApplicationInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.grpApplicationInfo.Location = new System.Drawing.Point(0, 159);
            this.grpApplicationInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpApplicationInfo.Name = "grpApplicationInfo";
            this.grpApplicationInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpApplicationInfo.Size = new System.Drawing.Size(532, 260);
            this.grpApplicationInfo.TabIndex = 1;
            this.grpApplicationInfo.TabStop = false;
            this.grpApplicationInfo.Text = "Заявление";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.label8.Location = new System.Drawing.Point(15, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Уровень образования:";
            // 
            // lblEducationLevel
            // 
            this.lblEducationLevel.AutoSize = true;
            this.lblEducationLevel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEducationLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblEducationLevel.Location = new System.Drawing.Point(188, 22);
            this.lblEducationLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEducationLevel.Name = "lblEducationLevel";
            this.lblEducationLevel.Size = new System.Drawing.Size(16, 15);
            this.lblEducationLevel.TabIndex = 1;
            this.lblEducationLevel.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.label9.Location = new System.Drawing.Point(15, 40);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Оценка/Балл:";
            // 
            // lblGradeScore
            // 
            this.lblGradeScore.AutoSize = true;
            this.lblGradeScore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGradeScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblGradeScore.Location = new System.Drawing.Point(188, 40);
            this.lblGradeScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGradeScore.Name = "lblGradeScore";
            this.lblGradeScore.Size = new System.Drawing.Size(16, 15);
            this.lblGradeScore.TabIndex = 3;
            this.lblGradeScore.Text = "...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.label10.Location = new System.Drawing.Point(15, 58);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "Дата подачи:";
            // 
            // lblSubmissionDate
            // 
            this.lblSubmissionDate.AutoSize = true;
            this.lblSubmissionDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubmissionDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblSubmissionDate.Location = new System.Drawing.Point(188, 58);
            this.lblSubmissionDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubmissionDate.Name = "lblSubmissionDate";
            this.lblSubmissionDate.Size = new System.Drawing.Size(16, 15);
            this.lblSubmissionDate.TabIndex = 5;
            this.lblSubmissionDate.Text = "...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.label11.Location = new System.Drawing.Point(15, 76);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "Последнее изменение:";
            // 
            // lblLastUpdateDate
            // 
            this.lblLastUpdateDate.AutoSize = true;
            this.lblLastUpdateDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLastUpdateDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblLastUpdateDate.Location = new System.Drawing.Point(188, 76);
            this.lblLastUpdateDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastUpdateDate.Name = "lblLastUpdateDate";
            this.lblLastUpdateDate.Size = new System.Drawing.Size(16, 15);
            this.lblLastUpdateDate.TabIndex = 7;
            this.lblLastUpdateDate.Text = "...";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.label12.Location = new System.Drawing.Point(15, 94);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "Текущий статус:";
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCurrentStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.lblCurrentStatus.Location = new System.Drawing.Point(188, 94);
            this.lblCurrentStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(16, 15);
            this.lblCurrentStatus.TabIndex = 9;
            this.lblCurrentStatus.Text = "...";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.label13.Location = new System.Drawing.Point(15, 112);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 15);
            this.label13.TabIndex = 10;
            this.label13.Text = "Направления:";
            // 
            // lstSelectedPrograms
            // 
            this.lstSelectedPrograms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.lstSelectedPrograms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstSelectedPrograms.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstSelectedPrograms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.lstSelectedPrograms.FormattingEnabled = true;
            this.lstSelectedPrograms.ItemHeight = 17;
            this.lstSelectedPrograms.Location = new System.Drawing.Point(188, 112);
            this.lstSelectedPrograms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstSelectedPrograms.Name = "lstSelectedPrograms";
            this.lstSelectedPrograms.Size = new System.Drawing.Size(300, 34);
            this.lstSelectedPrograms.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.label14.Location = new System.Drawing.Point(15, 155);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 15);
            this.label14.TabIndex = 12;
            this.label14.Text = "Документ:";
            // 
            // btnOpenDocument
            // 
            this.btnOpenDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(175)))), ((int)(((byte)(105)))));
            this.btnOpenDocument.FlatAppearance.BorderSize = 0;
            this.btnOpenDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenDocument.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnOpenDocument.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.btnOpenDocument.Location = new System.Drawing.Point(188, 152);
            this.btnOpenDocument.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenDocument.Name = "btnOpenDocument";
            this.btnOpenDocument.Size = new System.Drawing.Size(90, 31);
            this.btnOpenDocument.TabIndex = 13;
            this.btnOpenDocument.Text = "Открыть";
            this.btnOpenDocument.UseVisualStyleBackColor = false;
            this.btnOpenDocument.Click += new System.EventHandler(this.btnOpenDocument_Click);
            // 
            // lblDocumentPath
            // 
            this.lblDocumentPath.AutoSize = true;
            this.lblDocumentPath.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDocumentPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.lblDocumentPath.Location = new System.Drawing.Point(285, 155);
            this.lblDocumentPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDocumentPath.Name = "lblDocumentPath";
            this.lblDocumentPath.Size = new System.Drawing.Size(18, 19);
            this.lblDocumentPath.TabIndex = 14;
            this.lblDocumentPath.Text = "...";
            // 
            // ApplicationManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(825, 529);
            this.Controls.Add(this.pnlLeftSide);
            this.Controls.Add(this.pnlRightSide);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(829, 459);
            this.Name = "ApplicationManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление заявлением";
            this.Load += new System.EventHandler(this.ApplicationManagementForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlRightSide.ResumeLayout(false);
            this.grpStatusUpdate.ResumeLayout(false);
            this.grpStatusUpdate.PerformLayout();
            this.pnlLeftSide.ResumeLayout(false);
            this.grpApplicantInfo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grpApplicationInfo.ResumeLayout(false);
            this.grpApplicationInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpApplicantInfo;
        private System.Windows.Forms.Label lblPreviousInstitution;
        private System.Windows.Forms.Label lblParentName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSnils;
        private System.Windows.Forms.Label lblPassportData;
        private System.Windows.Forms.Label lblApplicantName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpApplicationInfo;
        private System.Windows.Forms.Label lblDocumentPath;
        private System.Windows.Forms.Button btnOpenDocument;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox lstSelectedPrograms;
        private System.Windows.Forms.Label lblLastUpdateDate;
        private System.Windows.Forms.Label lblSubmissionDate;
        private System.Windows.Forms.Label lblGradeScore;
        private System.Windows.Forms.Label lblEducationLevel;
        private System.Windows.Forms.Label lblCurrentStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpStatusUpdate;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.TextBox txtStatusComment;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlRightSide;
        private System.Windows.Forms.Panel pnlLeftSide;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
namespace AdmissionVGTU
{
    partial class RegistrationForm
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblPassportData = new System.Windows.Forms.Label();
            this.txtPassportData = new System.Windows.Forms.TextBox();
            this.lblSnils = new System.Windows.Forms.Label();
            this.txtSnils = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblParentFullName = new System.Windows.Forms.Label();
            this.txtParentFullName = new System.Windows.Forms.TextBox();
            this.lblPreviousInstitution = new System.Windows.Forms.Label();
            this.txtPreviousInstitution = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Controls.Add(this.tableLayoutPanel);
            this.panelMain.Controls.Add(this.flowLayoutPanel);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(600, 640);
            this.panelMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "Регистрация абитуриента";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.lblTitle.Size = new System.Drawing.Size(600, 60);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.tableLayoutPanel.RowCount = 10;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel.Location = new System.Drawing.Point(40, 80);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Size = new System.Drawing.Size(520, 380);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Text = "Имя пользователя*:";
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.tableLayoutPanel.Controls.Add(this.lblUsername, 0, 0);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = (System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.BackColor = System.Drawing.ColorTranslator.FromHtml("#f1f2f6");
            this.tableLayoutPanel.Controls.Add(this.txtUsername, 1, 0);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Text = "Пароль*:";
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.tableLayoutPanel.Controls.Add(this.lblPassword, 0, 1);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = (System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.BackColor = System.Drawing.ColorTranslator.FromHtml("#f1f2f6");
            this.txtPassword.PasswordChar = '●';
            this.tableLayoutPanel.Controls.Add(this.txtPassword, 1, 1);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Text = "Повторите пароль*:";
            this.lblConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblConfirmPassword.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.tableLayoutPanel.Controls.Add(this.lblConfirmPassword, 0, 2);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = (System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmPassword.BackColor = System.Drawing.ColorTranslator.FromHtml("#f1f2f6");
            this.txtConfirmPassword.PasswordChar = '●';
            this.tableLayoutPanel.Controls.Add(this.txtConfirmPassword, 1, 2);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Text = "ФИО*:";
            this.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFullName.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.tableLayoutPanel.Controls.Add(this.lblFullName, 0, 3);
            // 
            // txtFullName
            // 
            this.txtFullName.Anchor = (System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFullName.BackColor = System.Drawing.ColorTranslator.FromHtml("#f1f2f6");
            this.tableLayoutPanel.Controls.Add(this.txtFullName, 1, 3);
            // 
            // lblPassportData
            // 
            this.lblPassportData.AutoSize = true;
            this.lblPassportData.Text = "Паспортные данные:";
            this.lblPassportData.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPassportData.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPassportData.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.tableLayoutPanel.Controls.Add(this.lblPassportData, 0, 4);
            // 
            // txtPassportData
            // 
            this.txtPassportData.Anchor = (System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.txtPassportData.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassportData.BackColor = System.Drawing.ColorTranslator.FromHtml("#f1f2f6");
            this.tableLayoutPanel.Controls.Add(this.txtPassportData, 1, 4);
            // 
            // lblSnils
            // 
            this.lblSnils.AutoSize = true;
            this.lblSnils.Text = "СНИЛС:";
            this.lblSnils.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSnils.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSnils.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.tableLayoutPanel.Controls.Add(this.lblSnils, 0, 5);
            // 
            // txtSnils
            // 
            this.txtSnils.Anchor = (System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.txtSnils.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSnils.BackColor = System.Drawing.ColorTranslator.FromHtml("#f1f2f6");
            this.tableLayoutPanel.Controls.Add(this.txtSnils, 1, 5);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Text = "Электронная почта*:";
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.tableLayoutPanel.Controls.Add(this.lblEmail, 0, 6);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = (System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.BackColor = System.Drawing.ColorTranslator.FromHtml("#f1f2f6");
            this.tableLayoutPanel.Controls.Add(this.txtEmail, 1, 6);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Text = "Телефон:";
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhone.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.tableLayoutPanel.Controls.Add(this.lblPhone, 0, 7);
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = (System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.BackColor = System.Drawing.ColorTranslator.FromHtml("#f1f2f6");
            this.tableLayoutPanel.Controls.Add(this.txtPhone, 1, 7);
            // 
            // lblParentFullName
            // 
            this.lblParentFullName.AutoSize = true;
            this.lblParentFullName.Text = "ФИО родителя (представителя):";
            this.lblParentFullName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblParentFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblParentFullName.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.tableLayoutPanel.Controls.Add(this.lblParentFullName, 0, 8);
            // 
            // txtParentFullName
            // 
            this.txtParentFullName.Anchor = (System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.txtParentFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtParentFullName.BackColor = System.Drawing.ColorTranslator.FromHtml("#f1f2f6");
            this.tableLayoutPanel.Controls.Add(this.txtParentFullName, 1, 8);
            // 
            // lblPreviousInstitution
            // 
            this.lblPreviousInstitution.AutoSize = true;
            this.lblPreviousInstitution.Text = "Учебное заведение, которое окончил:";
            this.lblPreviousInstitution.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPreviousInstitution.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPreviousInstitution.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.tableLayoutPanel.Controls.Add(this.lblPreviousInstitution, 0, 9);
            // 
            // txtPreviousInstitution
            // 
            this.txtPreviousInstitution.Anchor = (System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.txtPreviousInstitution.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPreviousInstitution.BackColor = System.Drawing.ColorTranslator.FromHtml("#f1f2f6");
            this.tableLayoutPanel.Controls.Add(this.txtPreviousInstitution, 1, 9);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flowLayoutPanel.Location = new System.Drawing.Point(40, 490);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(520, 60);
            this.flowLayoutPanel.TabIndex = 2;
            this.flowLayoutPanel.Controls.Add(this.btnRegister);
            this.flowLayoutPanel.Controls.Add(this.btnCancel);
            // 
            // btnRegister
            // 
            this.btnRegister.Text = "Зарегистрироваться";
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRegister.BackColor = System.Drawing.ColorTranslator.FromHtml("#d1af69");
            this.btnRegister.ForeColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Size = new System.Drawing.Size(220, 44);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(18, 8, 18, 8);
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Text = "Отмена";
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.BackColor = System.Drawing.ColorTranslator.FromHtml("#192542");
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Size = new System.Drawing.Size(120, 44);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(18, 8, 18, 8);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 640);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация абитуриента";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPassportData;
        private System.Windows.Forms.Label lblSnils;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblParentFullName;
        private System.Windows.Forms.Label lblPreviousInstitution;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPassportData;
        private System.Windows.Forms.TextBox txtSnils;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtParentFullName;
        private System.Windows.Forms.TextBox txtPreviousInstitution;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
    }
}
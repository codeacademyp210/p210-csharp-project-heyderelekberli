namespace CSharpTask.Models
{
    partial class EmployeeCRUD
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
            this.panelEmail = new System.Windows.Forms.Panel();
            this.dtpEmployeeCreate = new System.Windows.Forms.DateTimePicker();
            this.cbPositionGroup = new System.Windows.Forms.ComboBox();
            this.EmployeeDeleteBtn = new System.Windows.Forms.Button();
            this.EmployeeUpdateBtn = new System.Windows.Forms.Button();
            this.EmployeeResetBtn = new System.Windows.Forms.Button();
            this.EmployeeCreateBtn = new System.Windows.Forms.Button();
            this.EmpCRUDSalary = new System.Windows.Forms.Label();
            this.EmpCRUDStart = new System.Windows.Forms.Label();
            this.TeacherCRUDPhone = new System.Windows.Forms.Label();
            this.TeacherCRUDEmail = new System.Windows.Forms.Label();
            this.EmpCRUDPosition = new System.Windows.Forms.Label();
            this.EmpCRUDSurname = new System.Windows.Forms.Label();
            this.EmpCRUDName = new System.Windows.Forms.Label();
            this.EmployeeSalaryTxt = new System.Windows.Forms.TextBox();
            this.EmployeePhoneTxt = new System.Windows.Forms.TextBox();
            this.EmployeeEmailTxt = new System.Windows.Forms.TextBox();
            this.EmployeeSurnameTxt = new System.Windows.Forms.TextBox();
            this.EmployeeNameTxt = new System.Windows.Forms.TextBox();
            this.dgvEmployeeCreate = new System.Windows.Forms.DataGridView();
            this.ColumnEmpCRUDİd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmpCRUDName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmpCRUDSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmpCRUDEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmpCRUDPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmpCRUDStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmpCRUDSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeCreate)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEmail
            // 
            this.panelEmail.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelEmail.Controls.Add(this.dtpEmployeeCreate);
            this.panelEmail.Controls.Add(this.cbPositionGroup);
            this.panelEmail.Controls.Add(this.EmployeeDeleteBtn);
            this.panelEmail.Controls.Add(this.EmployeeUpdateBtn);
            this.panelEmail.Controls.Add(this.EmployeeResetBtn);
            this.panelEmail.Controls.Add(this.EmployeeCreateBtn);
            this.panelEmail.Controls.Add(this.EmpCRUDSalary);
            this.panelEmail.Controls.Add(this.EmpCRUDStart);
            this.panelEmail.Controls.Add(this.TeacherCRUDPhone);
            this.panelEmail.Controls.Add(this.TeacherCRUDEmail);
            this.panelEmail.Controls.Add(this.EmpCRUDPosition);
            this.panelEmail.Controls.Add(this.EmpCRUDSurname);
            this.panelEmail.Controls.Add(this.EmpCRUDName);
            this.panelEmail.Controls.Add(this.EmployeeSalaryTxt);
            this.panelEmail.Controls.Add(this.EmployeePhoneTxt);
            this.panelEmail.Controls.Add(this.EmployeeEmailTxt);
            this.panelEmail.Controls.Add(this.EmployeeSurnameTxt);
            this.panelEmail.Controls.Add(this.EmployeeNameTxt);
            this.panelEmail.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEmail.Location = new System.Drawing.Point(0, 0);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(384, 450);
            this.panelEmail.TabIndex = 24;
            // 
            // dtpEmployeeCreate
            // 
            this.dtpEmployeeCreate.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dtpEmployeeCreate.CalendarTitleBackColor = System.Drawing.Color.RosyBrown;
            this.dtpEmployeeCreate.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtpEmployeeCreate.CalendarTrailingForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dtpEmployeeCreate.Location = new System.Drawing.Point(121, 217);
            this.dtpEmployeeCreate.Name = "dtpEmployeeCreate";
            this.dtpEmployeeCreate.Size = new System.Drawing.Size(231, 20);
            this.dtpEmployeeCreate.TabIndex = 6;
            this.dtpEmployeeCreate.Value = new System.DateTime(2019, 5, 30, 22, 54, 52, 0);
            // 
            // cbPositionGroup
            // 
            this.cbPositionGroup.BackColor = System.Drawing.Color.IndianRed;
            this.cbPositionGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPositionGroup.FormattingEnabled = true;
            this.cbPositionGroup.Location = new System.Drawing.Point(121, 180);
            this.cbPositionGroup.Name = "cbPositionGroup";
            this.cbPositionGroup.Size = new System.Drawing.Size(231, 21);
            this.cbPositionGroup.TabIndex = 5;
            // 
            // EmployeeDeleteBtn
            // 
            this.EmployeeDeleteBtn.BackColor = System.Drawing.Color.Red;
            this.EmployeeDeleteBtn.FlatAppearance.BorderSize = 0;
            this.EmployeeDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeDeleteBtn.Location = new System.Drawing.Point(141, 374);
            this.EmployeeDeleteBtn.Name = "EmployeeDeleteBtn";
            this.EmployeeDeleteBtn.Size = new System.Drawing.Size(110, 34);
            this.EmployeeDeleteBtn.TabIndex = 3;
            this.EmployeeDeleteBtn.Text = "Delete";
            this.EmployeeDeleteBtn.UseVisualStyleBackColor = false;
            this.EmployeeDeleteBtn.Click += new System.EventHandler(this.EmployeeDeleteBtn_Click);
            // 
            // EmployeeUpdateBtn
            // 
            this.EmployeeUpdateBtn.BackColor = System.Drawing.Color.Yellow;
            this.EmployeeUpdateBtn.FlatAppearance.BorderSize = 0;
            this.EmployeeUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeUpdateBtn.Location = new System.Drawing.Point(41, 374);
            this.EmployeeUpdateBtn.Name = "EmployeeUpdateBtn";
            this.EmployeeUpdateBtn.Size = new System.Drawing.Size(94, 34);
            this.EmployeeUpdateBtn.TabIndex = 3;
            this.EmployeeUpdateBtn.Text = "Update";
            this.EmployeeUpdateBtn.UseVisualStyleBackColor = false;
            this.EmployeeUpdateBtn.Click += new System.EventHandler(this.EmployeeUpdateBtn_Click);
            // 
            // EmployeeResetBtn
            // 
            this.EmployeeResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmployeeResetBtn.FlatAppearance.BorderSize = 0;
            this.EmployeeResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeResetBtn.Location = new System.Drawing.Point(257, 374);
            this.EmployeeResetBtn.Name = "EmployeeResetBtn";
            this.EmployeeResetBtn.Size = new System.Drawing.Size(95, 34);
            this.EmployeeResetBtn.TabIndex = 3;
            this.EmployeeResetBtn.Text = "Reset";
            this.EmployeeResetBtn.UseVisualStyleBackColor = false;
            this.EmployeeResetBtn.Click += new System.EventHandler(this.EmployeeResetBtn_Click);
            // 
            // EmployeeCreateBtn
            // 
            this.EmployeeCreateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.EmployeeCreateBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.EmployeeCreateBtn.FlatAppearance.BorderSize = 0;
            this.EmployeeCreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeCreateBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeCreateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmployeeCreateBtn.Location = new System.Drawing.Point(41, 324);
            this.EmployeeCreateBtn.Name = "EmployeeCreateBtn";
            this.EmployeeCreateBtn.Size = new System.Drawing.Size(311, 36);
            this.EmployeeCreateBtn.TabIndex = 2;
            this.EmployeeCreateBtn.Text = "Create";
            this.EmployeeCreateBtn.UseVisualStyleBackColor = false;
            this.EmployeeCreateBtn.Click += new System.EventHandler(this.EmployeeCreateBtn_Click);
            // 
            // EmpCRUDSalary
            // 
            this.EmpCRUDSalary.AutoSize = true;
            this.EmpCRUDSalary.Location = new System.Drawing.Point(38, 262);
            this.EmpCRUDSalary.Name = "EmpCRUDSalary";
            this.EmpCRUDSalary.Size = new System.Drawing.Size(36, 13);
            this.EmpCRUDSalary.TabIndex = 1;
            this.EmpCRUDSalary.Text = "Salary";
            // 
            // EmpCRUDStart
            // 
            this.EmpCRUDStart.AutoSize = true;
            this.EmpCRUDStart.Location = new System.Drawing.Point(38, 223);
            this.EmpCRUDStart.Name = "EmpCRUDStart";
            this.EmpCRUDStart.Size = new System.Drawing.Size(55, 13);
            this.EmpCRUDStart.TabIndex = 1;
            this.EmpCRUDStart.Text = "Start Time";
            // 
            // TeacherCRUDPhone
            // 
            this.TeacherCRUDPhone.AutoSize = true;
            this.TeacherCRUDPhone.Location = new System.Drawing.Point(38, 146);
            this.TeacherCRUDPhone.Name = "TeacherCRUDPhone";
            this.TeacherCRUDPhone.Size = new System.Drawing.Size(38, 13);
            this.TeacherCRUDPhone.TabIndex = 1;
            this.TeacherCRUDPhone.Text = "Phone";
            // 
            // TeacherCRUDEmail
            // 
            this.TeacherCRUDEmail.AutoSize = true;
            this.TeacherCRUDEmail.Location = new System.Drawing.Point(38, 101);
            this.TeacherCRUDEmail.Name = "TeacherCRUDEmail";
            this.TeacherCRUDEmail.Size = new System.Drawing.Size(32, 13);
            this.TeacherCRUDEmail.TabIndex = 1;
            this.TeacherCRUDEmail.Text = "Email";
            // 
            // EmpCRUDPosition
            // 
            this.EmpCRUDPosition.AutoSize = true;
            this.EmpCRUDPosition.Location = new System.Drawing.Point(38, 183);
            this.EmpCRUDPosition.Name = "EmpCRUDPosition";
            this.EmpCRUDPosition.Size = new System.Drawing.Size(44, 13);
            this.EmpCRUDPosition.TabIndex = 1;
            this.EmpCRUDPosition.Text = "Position";
            // 
            // EmpCRUDSurname
            // 
            this.EmpCRUDSurname.AutoSize = true;
            this.EmpCRUDSurname.Location = new System.Drawing.Point(38, 64);
            this.EmpCRUDSurname.Name = "EmpCRUDSurname";
            this.EmpCRUDSurname.Size = new System.Drawing.Size(49, 13);
            this.EmpCRUDSurname.TabIndex = 1;
            this.EmpCRUDSurname.Text = "Surname";
            // 
            // EmpCRUDName
            // 
            this.EmpCRUDName.AutoSize = true;
            this.EmpCRUDName.Location = new System.Drawing.Point(38, 27);
            this.EmpCRUDName.Name = "EmpCRUDName";
            this.EmpCRUDName.Size = new System.Drawing.Size(35, 13);
            this.EmpCRUDName.TabIndex = 1;
            this.EmpCRUDName.Text = "Name";
            // 
            // EmployeeSalaryTxt
            // 
            this.EmployeeSalaryTxt.BackColor = System.Drawing.Color.IndianRed;
            this.EmployeeSalaryTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeSalaryTxt.Location = new System.Drawing.Point(121, 257);
            this.EmployeeSalaryTxt.Name = "EmployeeSalaryTxt";
            this.EmployeeSalaryTxt.Size = new System.Drawing.Size(231, 22);
            this.EmployeeSalaryTxt.TabIndex = 4;
            // 
            // EmployeePhoneTxt
            // 
            this.EmployeePhoneTxt.BackColor = System.Drawing.Color.IndianRed;
            this.EmployeePhoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeePhoneTxt.Location = new System.Drawing.Point(121, 141);
            this.EmployeePhoneTxt.Name = "EmployeePhoneTxt";
            this.EmployeePhoneTxt.Size = new System.Drawing.Size(231, 22);
            this.EmployeePhoneTxt.TabIndex = 3;
            // 
            // EmployeeEmailTxt
            // 
            this.EmployeeEmailTxt.BackColor = System.Drawing.Color.IndianRed;
            this.EmployeeEmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeEmailTxt.Location = new System.Drawing.Point(121, 101);
            this.EmployeeEmailTxt.Name = "EmployeeEmailTxt";
            this.EmployeeEmailTxt.Size = new System.Drawing.Size(231, 22);
            this.EmployeeEmailTxt.TabIndex = 3;
            // 
            // EmployeeSurnameTxt
            // 
            this.EmployeeSurnameTxt.BackColor = System.Drawing.Color.IndianRed;
            this.EmployeeSurnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeSurnameTxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.EmployeeSurnameTxt.Location = new System.Drawing.Point(121, 59);
            this.EmployeeSurnameTxt.Name = "EmployeeSurnameTxt";
            this.EmployeeSurnameTxt.Size = new System.Drawing.Size(231, 22);
            this.EmployeeSurnameTxt.TabIndex = 1;
            // 
            // EmployeeNameTxt
            // 
            this.EmployeeNameTxt.BackColor = System.Drawing.Color.IndianRed;
            this.EmployeeNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeNameTxt.Location = new System.Drawing.Point(121, 22);
            this.EmployeeNameTxt.Name = "EmployeeNameTxt";
            this.EmployeeNameTxt.Size = new System.Drawing.Size(231, 22);
            this.EmployeeNameTxt.TabIndex = 0;
            // 
            // dgvEmployeeCreate
            // 
            this.dgvEmployeeCreate.AllowUserToAddRows = false;
            this.dgvEmployeeCreate.AllowUserToDeleteRows = false;
            this.dgvEmployeeCreate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeeCreate.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            this.dgvEmployeeCreate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeCreate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnEmpCRUDİd,
            this.ColumnEmpCRUDName,
            this.ColumnEmpCRUDSurname,
            this.ColumnEmpCRUDEmail,
            this.ColumnEmpCRUDPosition,
            this.ColumnEmpCRUDStart,
            this.ColumnEmpCRUDSalary});
            this.dgvEmployeeCreate.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvEmployeeCreate.Location = new System.Drawing.Point(390, 0);
            this.dgvEmployeeCreate.Name = "dgvEmployeeCreate";
            this.dgvEmployeeCreate.Size = new System.Drawing.Size(480, 450);
            this.dgvEmployeeCreate.TabIndex = 25;
            this.dgvEmployeeCreate.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvEmployeeCreate_CellMouseDoubleClick);
            // 
            // ColumnEmpCRUDİd
            // 
            this.ColumnEmpCRUDİd.HeaderText = "İd";
            this.ColumnEmpCRUDİd.Name = "ColumnEmpCRUDİd";
            this.ColumnEmpCRUDİd.Visible = false;
            // 
            // ColumnEmpCRUDName
            // 
            this.ColumnEmpCRUDName.HeaderText = "Name";
            this.ColumnEmpCRUDName.Name = "ColumnEmpCRUDName";
            this.ColumnEmpCRUDName.ReadOnly = true;
            // 
            // ColumnEmpCRUDSurname
            // 
            this.ColumnEmpCRUDSurname.HeaderText = "Surname";
            this.ColumnEmpCRUDSurname.Name = "ColumnEmpCRUDSurname";
            this.ColumnEmpCRUDSurname.ReadOnly = true;
            // 
            // ColumnEmpCRUDEmail
            // 
            this.ColumnEmpCRUDEmail.HeaderText = "Email";
            this.ColumnEmpCRUDEmail.Name = "ColumnEmpCRUDEmail";
            this.ColumnEmpCRUDEmail.ReadOnly = true;
            // 
            // ColumnEmpCRUDPosition
            // 
            this.ColumnEmpCRUDPosition.HeaderText = "Position";
            this.ColumnEmpCRUDPosition.Name = "ColumnEmpCRUDPosition";
            this.ColumnEmpCRUDPosition.ReadOnly = true;
            // 
            // ColumnEmpCRUDStart
            // 
            this.ColumnEmpCRUDStart.HeaderText = "Start Time";
            this.ColumnEmpCRUDStart.Name = "ColumnEmpCRUDStart";
            this.ColumnEmpCRUDStart.ReadOnly = true;
            // 
            // ColumnEmpCRUDSalary
            // 
            this.ColumnEmpCRUDSalary.HeaderText = "Salary";
            this.ColumnEmpCRUDSalary.Name = "ColumnEmpCRUDSalary";
            this.ColumnEmpCRUDSalary.ReadOnly = true;
            // 
            // EmployeeCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.dgvEmployeeCreate);
            this.Controls.Add(this.panelEmail);
            this.Name = "EmployeeCRUD";
            this.Text = "EmployeeCRUD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeCRUD_FormClosed);
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeCreate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.ComboBox cbPositionGroup;
        private System.Windows.Forms.Button EmployeeDeleteBtn;
        private System.Windows.Forms.Button EmployeeUpdateBtn;
        private System.Windows.Forms.Button EmployeeResetBtn;
        private System.Windows.Forms.Button EmployeeCreateBtn;
        private System.Windows.Forms.Label TeacherCRUDPhone;
        private System.Windows.Forms.Label TeacherCRUDEmail;
        private System.Windows.Forms.Label EmpCRUDPosition;
        private System.Windows.Forms.Label EmpCRUDSurname;
        private System.Windows.Forms.Label EmpCRUDName;
        private System.Windows.Forms.TextBox EmployeePhoneTxt;
        private System.Windows.Forms.TextBox EmployeeEmailTxt;
        private System.Windows.Forms.TextBox EmployeeSurnameTxt;
        private System.Windows.Forms.TextBox EmployeeNameTxt;
        private System.Windows.Forms.DataGridView dgvEmployeeCreate;
        private System.Windows.Forms.DateTimePicker dtpEmployeeCreate;
        private System.Windows.Forms.Label EmpCRUDSalary;
        private System.Windows.Forms.Label EmpCRUDStart;
        private System.Windows.Forms.TextBox EmployeeSalaryTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmpCRUDİd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmpCRUDName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmpCRUDSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmpCRUDEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmpCRUDPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmpCRUDStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmpCRUDSalary;
    }
}
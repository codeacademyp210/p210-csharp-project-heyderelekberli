﻿namespace CSharpTask.Models
{
    partial class EmployeeSearch
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
            this.EmployeeSearchText = new System.Windows.Forms.TextBox();
            this.EmployeeSearchBtn = new System.Windows.Forms.Button();
            this.dgvEmployeeSrch = new System.Windows.Forms.DataGridView();
            this.ColumnEmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmployeeSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmployeeEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmployeePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmployeePosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmployeeStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmployeeSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryUpperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryBetweenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeSrch)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeSearchText
            // 
            this.EmployeeSearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeSearchText.Location = new System.Drawing.Point(0, 47);
            this.EmployeeSearchText.Name = "EmployeeSearchText";
            this.EmployeeSearchText.Size = new System.Drawing.Size(523, 31);
            this.EmployeeSearchText.TabIndex = 11;
            // 
            // EmployeeSearchBtn
            // 
            this.EmployeeSearchBtn.Location = new System.Drawing.Point(540, 47);
            this.EmployeeSearchBtn.Name = "EmployeeSearchBtn";
            this.EmployeeSearchBtn.Size = new System.Drawing.Size(75, 32);
            this.EmployeeSearchBtn.TabIndex = 10;
            this.EmployeeSearchBtn.Text = "Search";
            this.EmployeeSearchBtn.UseVisualStyleBackColor = true;
            this.EmployeeSearchBtn.Click += new System.EventHandler(this.EmployeeSearchBtn_Click_1);
            // 
            // dgvEmployeeSrch
            // 
            this.dgvEmployeeSrch.AllowUserToAddRows = false;
            this.dgvEmployeeSrch.AllowUserToDeleteRows = false;
            this.dgvEmployeeSrch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployeeSrch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeeSrch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeSrch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnEmployeeID,
            this.ColumnEmployeeName,
            this.ColumnEmployeeSurname,
            this.ColumnEmployeeEmail,
            this.ColumnEmployeePhone,
            this.ColumnEmployeePosition,
            this.ColumnEmployeeStartTime,
            this.ColumnEmployeeSalary});
            this.dgvEmployeeSrch.Location = new System.Drawing.Point(0, 95);
            this.dgvEmployeeSrch.Name = "dgvEmployeeSrch";
            this.dgvEmployeeSrch.Size = new System.Drawing.Size(636, 252);
            this.dgvEmployeeSrch.TabIndex = 9;
            // 
            // ColumnEmployeeID
            // 
            this.ColumnEmployeeID.HeaderText = "Id";
            this.ColumnEmployeeID.Name = "ColumnEmployeeID";
            this.ColumnEmployeeID.Visible = false;
            // 
            // ColumnEmployeeName
            // 
            this.ColumnEmployeeName.HeaderText = "Name";
            this.ColumnEmployeeName.Name = "ColumnEmployeeName";
            this.ColumnEmployeeName.ReadOnly = true;
            // 
            // ColumnEmployeeSurname
            // 
            this.ColumnEmployeeSurname.HeaderText = "Surname";
            this.ColumnEmployeeSurname.Name = "ColumnEmployeeSurname";
            this.ColumnEmployeeSurname.ReadOnly = true;
            // 
            // ColumnEmployeeEmail
            // 
            this.ColumnEmployeeEmail.HeaderText = "Email";
            this.ColumnEmployeeEmail.Name = "ColumnEmployeeEmail";
            this.ColumnEmployeeEmail.ReadOnly = true;
            // 
            // ColumnEmployeePhone
            // 
            this.ColumnEmployeePhone.HeaderText = "Phone";
            this.ColumnEmployeePhone.Name = "ColumnEmployeePhone";
            this.ColumnEmployeePhone.ReadOnly = true;
            // 
            // ColumnEmployeePosition
            // 
            this.ColumnEmployeePosition.HeaderText = "Position";
            this.ColumnEmployeePosition.Name = "ColumnEmployeePosition";
            this.ColumnEmployeePosition.ReadOnly = true;
            // 
            // ColumnEmployeeStartTime
            // 
            this.ColumnEmployeeStartTime.HeaderText = "Start Time";
            this.ColumnEmployeeStartTime.Name = "ColumnEmployeeStartTime";
            this.ColumnEmployeeStartTime.ReadOnly = true;
            // 
            // ColumnEmployeeSalary
            // 
            this.ColumnEmployeeSalary.HeaderText = "Salary";
            this.ColumnEmployeeSalary.Name = "ColumnEmployeeSalary";
            this.ColumnEmployeeSalary.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(636, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salaryUpperToolStripMenuItem,
            this.salaryBetweenToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // salaryUpperToolStripMenuItem
            // 
            this.salaryUpperToolStripMenuItem.Name = "salaryUpperToolStripMenuItem";
            this.salaryUpperToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.salaryUpperToolStripMenuItem.Text = "Salary Upper 1000";
            this.salaryUpperToolStripMenuItem.Click += new System.EventHandler(this.SalaryUpperToolStripMenuItem_Click);
            // 
            // salaryBetweenToolStripMenuItem
            // 
            this.salaryBetweenToolStripMenuItem.Name = "salaryBetweenToolStripMenuItem";
            this.salaryBetweenToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.salaryBetweenToolStripMenuItem.Text = "Salary between 1000 and 1500";
            this.salaryBetweenToolStripMenuItem.Click += new System.EventHandler(this.SalaryBetweenToolStripMenuItem_Click);
            // 
            // EmployeeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 347);
            this.Controls.Add(this.EmployeeSearchText);
            this.Controls.Add(this.EmployeeSearchBtn);
            this.Controls.Add(this.dgvEmployeeSrch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeSearch";
            this.Text = "EmployeeSearch";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeSearch_FormClosed);
            this.Load += new System.EventHandler(this.EmployeeSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeSrch)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmployeeSearchText;
        private System.Windows.Forms.Button EmployeeSearchBtn;
        private System.Windows.Forms.DataGridView dgvEmployeeSrch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmployeeSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmployeeEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmployeePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmployeePosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmployeeStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmployeeSalary;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryUpperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryBetweenToolStripMenuItem;
    }
}
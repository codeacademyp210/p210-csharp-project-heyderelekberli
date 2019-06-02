namespace CSharpTask.Models
{
    partial class StudentSearch
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
            this.StudentSearchText = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.dgvStudentSrch = new System.Windows.Forms.DataGridView();
            this.ColumnStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStudentSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStudentEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStudentPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStudentFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStudentGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterByStudentWhoHasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amountOfDeptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentSrch)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentSearchText
            // 
            this.StudentSearchText.BackColor = System.Drawing.Color.PaleGreen;
            this.StudentSearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentSearchText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StudentSearchText.Location = new System.Drawing.Point(0, 44);
            this.StudentSearchText.Name = "StudentSearchText";
            this.StudentSearchText.Size = new System.Drawing.Size(533, 31);
            this.StudentSearchText.TabIndex = 5;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Aqua;
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Location = new System.Drawing.Point(539, 44);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 32);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click_1);
            // 
            // dgvStudentSrch
            // 
            this.dgvStudentSrch.AllowUserToAddRows = false;
            this.dgvStudentSrch.AllowUserToDeleteRows = false;
            this.dgvStudentSrch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudentSrch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentSrch.BackgroundColor = System.Drawing.Color.Violet;
            this.dgvStudentSrch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentSrch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnStudentID,
            this.ColumnStudentName,
            this.ColumnStudentSurname,
            this.ColumnStudentEmail,
            this.ColumnStudentPhone,
            this.ColumnStudentFee,
            this.ColumnStudentGroup});
            this.dgvStudentSrch.Location = new System.Drawing.Point(0, 93);
            this.dgvStudentSrch.Name = "dgvStudentSrch";
            this.dgvStudentSrch.Size = new System.Drawing.Size(626, 338);
            this.dgvStudentSrch.TabIndex = 3;
            // 
            // ColumnStudentID
            // 
            this.ColumnStudentID.HeaderText = "Id";
            this.ColumnStudentID.Name = "ColumnStudentID";
            this.ColumnStudentID.Visible = false;
            // 
            // ColumnStudentName
            // 
            this.ColumnStudentName.HeaderText = "Name";
            this.ColumnStudentName.Name = "ColumnStudentName";
            this.ColumnStudentName.ReadOnly = true;
            // 
            // ColumnStudentSurname
            // 
            this.ColumnStudentSurname.HeaderText = "Surname";
            this.ColumnStudentSurname.Name = "ColumnStudentSurname";
            this.ColumnStudentSurname.ReadOnly = true;
            // 
            // ColumnStudentEmail
            // 
            this.ColumnStudentEmail.HeaderText = "Email";
            this.ColumnStudentEmail.Name = "ColumnStudentEmail";
            this.ColumnStudentEmail.ReadOnly = true;
            // 
            // ColumnStudentPhone
            // 
            this.ColumnStudentPhone.HeaderText = "Phone";
            this.ColumnStudentPhone.Name = "ColumnStudentPhone";
            this.ColumnStudentPhone.ReadOnly = true;
            // 
            // ColumnStudentFee
            // 
            this.ColumnStudentFee.HeaderText = "Fee";
            this.ColumnStudentFee.Name = "ColumnStudentFee";
            this.ColumnStudentFee.ReadOnly = true;
            // 
            // ColumnStudentGroup
            // 
            this.ColumnStudentGroup.HeaderText = "Group";
            this.ColumnStudentGroup.Name = "ColumnStudentGroup";
            this.ColumnStudentGroup.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(625, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterByStudentWhoHasToolStripMenuItem,
            this.amountOfDeptToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // filterByStudentWhoHasToolStripMenuItem
            // 
            this.filterByStudentWhoHasToolStripMenuItem.Name = "filterByStudentWhoHasToolStripMenuItem";
            this.filterByStudentWhoHasToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.filterByStudentWhoHasToolStripMenuItem.Text = "Filter by Students who have  dept";
            this.filterByStudentWhoHasToolStripMenuItem.Click += new System.EventHandler(this.FilterByStudentWhoHasToolStripMenuItem_Click);
            // 
            // amountOfDeptToolStripMenuItem
            // 
            this.amountOfDeptToolStripMenuItem.Name = "amountOfDeptToolStripMenuItem";
            this.amountOfDeptToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.amountOfDeptToolStripMenuItem.Text = "Amount of Dept";
            this.amountOfDeptToolStripMenuItem.Click += new System.EventHandler(this.AmountOfDeptToolStripMenuItem_Click);
            // 
            // StudentSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 435);
            this.Controls.Add(this.StudentSearchText);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.dgvStudentSrch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentSearch";
            this.Text = "StudentSearch";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentSearch_FormClosed_1);
            this.Load += new System.EventHandler(this.StudentSearch_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentSrch)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StudentSearchText;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.DataGridView dgvStudentSrch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentGroup;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterByStudentWhoHasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amountOfDeptToolStripMenuItem;
    }
}
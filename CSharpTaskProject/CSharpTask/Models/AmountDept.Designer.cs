namespace CSharpTask.Models
{
    partial class AmountDept
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
            this.dgvStudentSrch = new System.Windows.Forms.DataGridView();
            this.ColumnStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStudentDeptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentSrch)).BeginInit();
            this.SuspendLayout();
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
            this.ColumnStudentDeptName,
            this.ColumnDept});
            this.dgvStudentSrch.Location = new System.Drawing.Point(-3, -2);
            this.dgvStudentSrch.Name = "dgvStudentSrch";
            this.dgvStudentSrch.Size = new System.Drawing.Size(360, 430);
            this.dgvStudentSrch.TabIndex = 4;
            // 
            // ColumnStudentID
            // 
            this.ColumnStudentID.HeaderText = "Id";
            this.ColumnStudentID.Name = "ColumnStudentID";
            this.ColumnStudentID.Visible = false;
            // 
            // ColumnStudentDeptName
            // 
            this.ColumnStudentDeptName.HeaderText = "Name";
            this.ColumnStudentDeptName.Name = "ColumnStudentDeptName";
            this.ColumnStudentDeptName.ReadOnly = true;
            // 
            // ColumnDept
            // 
            this.ColumnDept.HeaderText = "Dept";
            this.ColumnDept.Name = "ColumnDept";
            this.ColumnDept.ReadOnly = true;
            // 
            // AmountDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 429);
            this.Controls.Add(this.dgvStudentSrch);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AmountDept";
            this.Text = "AmountDept";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AmountDept_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentSrch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentSrch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentDeptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDept;
    }
}
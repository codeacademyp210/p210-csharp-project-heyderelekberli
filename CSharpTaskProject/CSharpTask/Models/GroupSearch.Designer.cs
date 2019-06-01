namespace CSharpTask.Models
{
    partial class GroupSearch
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
            this.GroupSearchText = new System.Windows.Forms.TextBox();
            this.GroupSearchBtn = new System.Windows.Forms.Button();
            this.dgvGroupSrch = new System.Windows.Forms.DataGridView();
            this.ColumnGroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGroupClassroom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGroupTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGroupMentor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGroupCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGroumEducation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupSrch)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupSearchText
            // 
            this.GroupSearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupSearchText.Location = new System.Drawing.Point(12, 15);
            this.GroupSearchText.Name = "GroupSearchText";
            this.GroupSearchText.Size = new System.Drawing.Size(666, 31);
            this.GroupSearchText.TabIndex = 14;
            // 
            // GroupSearchBtn
            // 
            this.GroupSearchBtn.Location = new System.Drawing.Point(701, 14);
            this.GroupSearchBtn.Name = "GroupSearchBtn";
            this.GroupSearchBtn.Size = new System.Drawing.Size(75, 32);
            this.GroupSearchBtn.TabIndex = 13;
            this.GroupSearchBtn.Text = "Search";
            this.GroupSearchBtn.UseVisualStyleBackColor = true;
            this.GroupSearchBtn.Click += new System.EventHandler(this.GroupSearchBtn_Click_1);
            // 
            // dgvGroupSrch
            // 
            this.dgvGroupSrch.AllowUserToAddRows = false;
            this.dgvGroupSrch.AllowUserToDeleteRows = false;
            this.dgvGroupSrch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGroupSrch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGroupSrch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupSrch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnGroupID,
            this.ColumnGroupName,
            this.ColumnGroupClassroom,
            this.ColumnGroupTeacher,
            this.ColumnGroupMentor,
            this.ColumnGroupCapacity,
            this.ColumnGroumEducation});
            this.dgvGroupSrch.Location = new System.Drawing.Point(-1, 62);
            this.dgvGroupSrch.Name = "dgvGroupSrch";
            this.dgvGroupSrch.Size = new System.Drawing.Size(785, 259);
            this.dgvGroupSrch.TabIndex = 12;
            // 
            // ColumnGroupID
            // 
            this.ColumnGroupID.HeaderText = "Id";
            this.ColumnGroupID.Name = "ColumnGroupID";
            this.ColumnGroupID.Visible = false;
            // 
            // ColumnGroupName
            // 
            this.ColumnGroupName.HeaderText = "Name";
            this.ColumnGroupName.Name = "ColumnGroupName";
            this.ColumnGroupName.ReadOnly = true;
            // 
            // ColumnGroupClassroom
            // 
            this.ColumnGroupClassroom.HeaderText = "Classroom";
            this.ColumnGroupClassroom.Name = "ColumnGroupClassroom";
            this.ColumnGroupClassroom.ReadOnly = true;
            // 
            // ColumnGroupTeacher
            // 
            this.ColumnGroupTeacher.HeaderText = "Teacher";
            this.ColumnGroupTeacher.Name = "ColumnGroupTeacher";
            this.ColumnGroupTeacher.ReadOnly = true;
            // 
            // ColumnGroupMentor
            // 
            this.ColumnGroupMentor.HeaderText = "Mentor";
            this.ColumnGroupMentor.Name = "ColumnGroupMentor";
            this.ColumnGroupMentor.ReadOnly = true;
            // 
            // ColumnGroupCapacity
            // 
            this.ColumnGroupCapacity.HeaderText = "Capacity";
            this.ColumnGroupCapacity.Name = "ColumnGroupCapacity";
            this.ColumnGroupCapacity.ReadOnly = true;
            // 
            // ColumnGroumEducation
            // 
            this.ColumnGroumEducation.HeaderText = "Education Proqram";
            this.ColumnGroumEducation.Name = "ColumnGroumEducation";
            this.ColumnGroumEducation.ReadOnly = true;
            // 
            // GroupSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 322);
            this.Controls.Add(this.GroupSearchText);
            this.Controls.Add(this.GroupSearchBtn);
            this.Controls.Add(this.dgvGroupSrch);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GroupSearch";
            this.Text = "GroupSearch";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GroupSearch_FormClosed_1);
            this.Load += new System.EventHandler(this.GroupSearch_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupSrch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GroupSearchText;
        private System.Windows.Forms.Button GroupSearchBtn;
        private System.Windows.Forms.DataGridView dgvGroupSrch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGroupClassroom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGroupTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGroupMentor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGroupCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGroumEducation;
    }
}
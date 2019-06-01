namespace CSharpTask.Models
{
    partial class TeacherSearch
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
            this.TeacherSearchText = new System.Windows.Forms.TextBox();
            this.TeacherSearchBtn = new System.Windows.Forms.Button();
            this.dgvTeacherSrch = new System.Windows.Forms.DataGridView();
            this.ColumnTeacherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeacherSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeacherSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeacherEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeacherPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherSrch)).BeginInit();
            this.SuspendLayout();
            // 
            // TeacherSearchText
            // 
            this.TeacherSearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherSearchText.Location = new System.Drawing.Point(12, 19);
            this.TeacherSearchText.Name = "TeacherSearchText";
            this.TeacherSearchText.Size = new System.Drawing.Size(523, 31);
            this.TeacherSearchText.TabIndex = 8;
            // 
            // TeacherSearchBtn
            // 
            this.TeacherSearchBtn.Location = new System.Drawing.Point(552, 19);
            this.TeacherSearchBtn.Name = "TeacherSearchBtn";
            this.TeacherSearchBtn.Size = new System.Drawing.Size(75, 32);
            this.TeacherSearchBtn.TabIndex = 7;
            this.TeacherSearchBtn.Text = "Search";
            this.TeacherSearchBtn.UseVisualStyleBackColor = true;
            this.TeacherSearchBtn.Click += new System.EventHandler(this.TeacherSearchBtn_Click_1);
            // 
            // dgvTeacherSrch
            // 
            this.dgvTeacherSrch.AllowUserToAddRows = false;
            this.dgvTeacherSrch.AllowUserToDeleteRows = false;
            this.dgvTeacherSrch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeacherSrch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeacherSrch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherSrch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTeacherID,
            this.ColumnTeacherName,
            this.ColumnTeacherSurname,
            this.ColumnTeacherSpec,
            this.ColumnTeacherEmail,
            this.ColumnTeacherPhone});
            this.dgvTeacherSrch.Location = new System.Drawing.Point(0, 70);
            this.dgvTeacherSrch.Name = "dgvTeacherSrch";
            this.dgvTeacherSrch.Size = new System.Drawing.Size(656, 270);
            this.dgvTeacherSrch.TabIndex = 6;
            // 
            // ColumnTeacherID
            // 
            this.ColumnTeacherID.HeaderText = "Id";
            this.ColumnTeacherID.Name = "ColumnTeacherID";
            this.ColumnTeacherID.Visible = false;
            // 
            // ColumnTeacherName
            // 
            this.ColumnTeacherName.HeaderText = "Name";
            this.ColumnTeacherName.Name = "ColumnTeacherName";
            this.ColumnTeacherName.ReadOnly = true;
            // 
            // ColumnTeacherSurname
            // 
            this.ColumnTeacherSurname.HeaderText = "Surname";
            this.ColumnTeacherSurname.Name = "ColumnTeacherSurname";
            this.ColumnTeacherSurname.ReadOnly = true;
            // 
            // ColumnTeacherSpec
            // 
            this.ColumnTeacherSpec.HeaderText = "Speciality";
            this.ColumnTeacherSpec.Name = "ColumnTeacherSpec";
            this.ColumnTeacherSpec.ReadOnly = true;
            // 
            // ColumnTeacherEmail
            // 
            this.ColumnTeacherEmail.HeaderText = "Email";
            this.ColumnTeacherEmail.Name = "ColumnTeacherEmail";
            this.ColumnTeacherEmail.ReadOnly = true;
            // 
            // ColumnTeacherPhone
            // 
            this.ColumnTeacherPhone.HeaderText = "Phone";
            this.ColumnTeacherPhone.Name = "ColumnTeacherPhone";
            this.ColumnTeacherPhone.ReadOnly = true;
            // 
            // TeacherSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 341);
            this.Controls.Add(this.TeacherSearchText);
            this.Controls.Add(this.TeacherSearchBtn);
            this.Controls.Add(this.dgvTeacherSrch);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeacherSearch";
            this.Text = "TeacherSearch";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherSearch_FormClosed_1);
            this.Load += new System.EventHandler(this.TeacherSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherSrch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TeacherSearchText;
        private System.Windows.Forms.Button TeacherSearchBtn;
        private System.Windows.Forms.DataGridView dgvTeacherSrch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacherSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacherSpec;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacherEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacherPhone;
    }
}
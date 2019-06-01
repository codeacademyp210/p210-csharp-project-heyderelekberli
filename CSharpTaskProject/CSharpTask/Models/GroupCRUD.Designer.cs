namespace CSharpTask.Models
{
    partial class GroupCRUD
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
            this.cbGroupMentor = new System.Windows.Forms.ComboBox();
            this.cbGroupTeacher = new System.Windows.Forms.ComboBox();
            this.cbGroupClassroom = new System.Windows.Forms.ComboBox();
            this.cbGroupEducation = new System.Windows.Forms.ComboBox();
            this.GroupDeleteBtn = new System.Windows.Forms.Button();
            this.GroupUpdateBtn = new System.Windows.Forms.Button();
            this.GroupResetBtn = new System.Windows.Forms.Button();
            this.GroupCreateBtn = new System.Windows.Forms.Button();
            this.GroupCRUDEdu = new System.Windows.Forms.Label();
            this.GroupCRUDMentor = new System.Windows.Forms.Label();
            this.GroupCRUDTeacher = new System.Windows.Forms.Label();
            this.GroupCRUDCapacity = new System.Windows.Forms.Label();
            this.GroupCRUDSurname = new System.Windows.Forms.Label();
            this.GroupCRUDName = new System.Windows.Forms.Label();
            this.GroupCapacityTxt = new System.Windows.Forms.TextBox();
            this.GroupNameTxt = new System.Windows.Forms.TextBox();
            this.dgvGroupCreate = new System.Windows.Forms.DataGridView();
            this.ColumnGroupCRUDİd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGroupCRUDName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGroupCRUDSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGroupCRUDTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGroupCRUDMentor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGroupCRUDCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGroupCRUDEdu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupCreate)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEmail
            // 
            this.panelEmail.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelEmail.Controls.Add(this.cbGroupMentor);
            this.panelEmail.Controls.Add(this.cbGroupTeacher);
            this.panelEmail.Controls.Add(this.cbGroupClassroom);
            this.panelEmail.Controls.Add(this.cbGroupEducation);
            this.panelEmail.Controls.Add(this.GroupDeleteBtn);
            this.panelEmail.Controls.Add(this.GroupUpdateBtn);
            this.panelEmail.Controls.Add(this.GroupResetBtn);
            this.panelEmail.Controls.Add(this.GroupCreateBtn);
            this.panelEmail.Controls.Add(this.GroupCRUDEdu);
            this.panelEmail.Controls.Add(this.GroupCRUDMentor);
            this.panelEmail.Controls.Add(this.GroupCRUDTeacher);
            this.panelEmail.Controls.Add(this.GroupCRUDCapacity);
            this.panelEmail.Controls.Add(this.GroupCRUDSurname);
            this.panelEmail.Controls.Add(this.GroupCRUDName);
            this.panelEmail.Controls.Add(this.GroupCapacityTxt);
            this.panelEmail.Controls.Add(this.GroupNameTxt);
            this.panelEmail.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEmail.Location = new System.Drawing.Point(0, 0);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(384, 378);
            this.panelEmail.TabIndex = 25;
            // 
            // cbGroupMentor
            // 
            this.cbGroupMentor.BackColor = System.Drawing.Color.IndianRed;
            this.cbGroupMentor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGroupMentor.FormattingEnabled = true;
            this.cbGroupMentor.Location = new System.Drawing.Point(121, 138);
            this.cbGroupMentor.Name = "cbGroupMentor";
            this.cbGroupMentor.Size = new System.Drawing.Size(231, 21);
            this.cbGroupMentor.TabIndex = 3;
            // 
            // cbGroupTeacher
            // 
            this.cbGroupTeacher.BackColor = System.Drawing.Color.IndianRed;
            this.cbGroupTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGroupTeacher.FormattingEnabled = true;
            this.cbGroupTeacher.Location = new System.Drawing.Point(121, 93);
            this.cbGroupTeacher.Name = "cbGroupTeacher";
            this.cbGroupTeacher.Size = new System.Drawing.Size(231, 21);
            this.cbGroupTeacher.TabIndex = 2;
            // 
            // cbGroupClassroom
            // 
            this.cbGroupClassroom.BackColor = System.Drawing.Color.IndianRed;
            this.cbGroupClassroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGroupClassroom.FormattingEnabled = true;
            this.cbGroupClassroom.Location = new System.Drawing.Point(121, 56);
            this.cbGroupClassroom.Name = "cbGroupClassroom";
            this.cbGroupClassroom.Size = new System.Drawing.Size(231, 21);
            this.cbGroupClassroom.TabIndex = 1;
            // 
            // cbGroupEducation
            // 
            this.cbGroupEducation.BackColor = System.Drawing.Color.IndianRed;
            this.cbGroupEducation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGroupEducation.FormattingEnabled = true;
            this.cbGroupEducation.Location = new System.Drawing.Point(121, 218);
            this.cbGroupEducation.Name = "cbGroupEducation";
            this.cbGroupEducation.Size = new System.Drawing.Size(231, 21);
            this.cbGroupEducation.TabIndex = 5;
            // 
            // GroupDeleteBtn
            // 
            this.GroupDeleteBtn.BackColor = System.Drawing.Color.Red;
            this.GroupDeleteBtn.FlatAppearance.BorderSize = 0;
            this.GroupDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupDeleteBtn.Location = new System.Drawing.Point(143, 327);
            this.GroupDeleteBtn.Name = "GroupDeleteBtn";
            this.GroupDeleteBtn.Size = new System.Drawing.Size(110, 34);
            this.GroupDeleteBtn.TabIndex = 3;
            this.GroupDeleteBtn.Text = "Delete";
            this.GroupDeleteBtn.UseVisualStyleBackColor = false;
            this.GroupDeleteBtn.Click += new System.EventHandler(this.GroupDeleteBtn_Click);
            // 
            // GroupUpdateBtn
            // 
            this.GroupUpdateBtn.BackColor = System.Drawing.Color.Yellow;
            this.GroupUpdateBtn.FlatAppearance.BorderSize = 0;
            this.GroupUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupUpdateBtn.Location = new System.Drawing.Point(43, 327);
            this.GroupUpdateBtn.Name = "GroupUpdateBtn";
            this.GroupUpdateBtn.Size = new System.Drawing.Size(94, 34);
            this.GroupUpdateBtn.TabIndex = 3;
            this.GroupUpdateBtn.Text = "Update";
            this.GroupUpdateBtn.UseVisualStyleBackColor = false;
            this.GroupUpdateBtn.Click += new System.EventHandler(this.GroupUpdateBtn_Click);
            // 
            // GroupResetBtn
            // 
            this.GroupResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GroupResetBtn.FlatAppearance.BorderSize = 0;
            this.GroupResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupResetBtn.Location = new System.Drawing.Point(259, 327);
            this.GroupResetBtn.Name = "GroupResetBtn";
            this.GroupResetBtn.Size = new System.Drawing.Size(95, 34);
            this.GroupResetBtn.TabIndex = 3;
            this.GroupResetBtn.Text = "Reset";
            this.GroupResetBtn.UseVisualStyleBackColor = false;
            this.GroupResetBtn.Click += new System.EventHandler(this.GroupResetBtn_Click);
            // 
            // GroupCreateBtn
            // 
            this.GroupCreateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.GroupCreateBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.GroupCreateBtn.FlatAppearance.BorderSize = 0;
            this.GroupCreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupCreateBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupCreateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupCreateBtn.Location = new System.Drawing.Point(43, 277);
            this.GroupCreateBtn.Name = "GroupCreateBtn";
            this.GroupCreateBtn.Size = new System.Drawing.Size(311, 36);
            this.GroupCreateBtn.TabIndex = 2;
            this.GroupCreateBtn.Text = "Create";
            this.GroupCreateBtn.UseVisualStyleBackColor = false;
            this.GroupCreateBtn.Click += new System.EventHandler(this.GroupCreateBtn_Click);
            // 
            // GroupCRUDEdu
            // 
            this.GroupCRUDEdu.AutoSize = true;
            this.GroupCRUDEdu.Location = new System.Drawing.Point(12, 221);
            this.GroupCRUDEdu.Name = "GroupCRUDEdu";
            this.GroupCRUDEdu.Size = new System.Drawing.Size(97, 13);
            this.GroupCRUDEdu.TabIndex = 1;
            this.GroupCRUDEdu.Text = "Education Proqram";
            // 
            // GroupCRUDMentor
            // 
            this.GroupCRUDMentor.AutoSize = true;
            this.GroupCRUDMentor.Location = new System.Drawing.Point(12, 141);
            this.GroupCRUDMentor.Name = "GroupCRUDMentor";
            this.GroupCRUDMentor.Size = new System.Drawing.Size(40, 13);
            this.GroupCRUDMentor.TabIndex = 1;
            this.GroupCRUDMentor.Text = "Mentor";
            // 
            // GroupCRUDTeacher
            // 
            this.GroupCRUDTeacher.AutoSize = true;
            this.GroupCRUDTeacher.Location = new System.Drawing.Point(12, 96);
            this.GroupCRUDTeacher.Name = "GroupCRUDTeacher";
            this.GroupCRUDTeacher.Size = new System.Drawing.Size(47, 13);
            this.GroupCRUDTeacher.TabIndex = 1;
            this.GroupCRUDTeacher.Text = "Teacher";
            // 
            // GroupCRUDCapacity
            // 
            this.GroupCRUDCapacity.AutoSize = true;
            this.GroupCRUDCapacity.Location = new System.Drawing.Point(12, 178);
            this.GroupCRUDCapacity.Name = "GroupCRUDCapacity";
            this.GroupCRUDCapacity.Size = new System.Drawing.Size(48, 13);
            this.GroupCRUDCapacity.TabIndex = 1;
            this.GroupCRUDCapacity.Text = "Capacity";
            // 
            // GroupCRUDSurname
            // 
            this.GroupCRUDSurname.AutoSize = true;
            this.GroupCRUDSurname.Location = new System.Drawing.Point(12, 59);
            this.GroupCRUDSurname.Name = "GroupCRUDSurname";
            this.GroupCRUDSurname.Size = new System.Drawing.Size(55, 13);
            this.GroupCRUDSurname.TabIndex = 1;
            this.GroupCRUDSurname.Text = "Classroom";
            // 
            // GroupCRUDName
            // 
            this.GroupCRUDName.AutoSize = true;
            this.GroupCRUDName.Location = new System.Drawing.Point(12, 22);
            this.GroupCRUDName.Name = "GroupCRUDName";
            this.GroupCRUDName.Size = new System.Drawing.Size(35, 13);
            this.GroupCRUDName.TabIndex = 1;
            this.GroupCRUDName.Text = "Name";
            // 
            // GroupCapacityTxt
            // 
            this.GroupCapacityTxt.BackColor = System.Drawing.Color.IndianRed;
            this.GroupCapacityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupCapacityTxt.Location = new System.Drawing.Point(121, 178);
            this.GroupCapacityTxt.Name = "GroupCapacityTxt";
            this.GroupCapacityTxt.Size = new System.Drawing.Size(231, 22);
            this.GroupCapacityTxt.TabIndex = 4;
            // 
            // GroupNameTxt
            // 
            this.GroupNameTxt.BackColor = System.Drawing.Color.IndianRed;
            this.GroupNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupNameTxt.Location = new System.Drawing.Point(121, 17);
            this.GroupNameTxt.Name = "GroupNameTxt";
            this.GroupNameTxt.Size = new System.Drawing.Size(231, 22);
            this.GroupNameTxt.TabIndex = 0;
            // 
            // dgvGroupCreate
            // 
            this.dgvGroupCreate.AllowUserToAddRows = false;
            this.dgvGroupCreate.AllowUserToDeleteRows = false;
            this.dgvGroupCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGroupCreate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGroupCreate.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            this.dgvGroupCreate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupCreate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnGroupCRUDİd,
            this.ColumnGroupCRUDName,
            this.ColumnGroupCRUDSurname,
            this.ColumnGroupCRUDTeacher,
            this.ColumnGroupCRUDMentor,
            this.ColumnGroupCRUDCapacity,
            this.ColumnGroupCRUDEdu});
            this.dgvGroupCreate.Location = new System.Drawing.Point(381, 0);
            this.dgvGroupCreate.Name = "dgvGroupCreate";
            this.dgvGroupCreate.Size = new System.Drawing.Size(528, 378);
            this.dgvGroupCreate.TabIndex = 26;
            this.dgvGroupCreate.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvGroupCreate_CellMouseDoubleClick);
            // 
            // ColumnGroupCRUDİd
            // 
            this.ColumnGroupCRUDİd.HeaderText = "İd";
            this.ColumnGroupCRUDİd.Name = "ColumnGroupCRUDİd";
            this.ColumnGroupCRUDİd.Visible = false;
            // 
            // ColumnGroupCRUDName
            // 
            this.ColumnGroupCRUDName.HeaderText = "Name";
            this.ColumnGroupCRUDName.Name = "ColumnGroupCRUDName";
            this.ColumnGroupCRUDName.ReadOnly = true;
            // 
            // ColumnGroupCRUDSurname
            // 
            this.ColumnGroupCRUDSurname.HeaderText = "Classroom";
            this.ColumnGroupCRUDSurname.Name = "ColumnGroupCRUDSurname";
            this.ColumnGroupCRUDSurname.ReadOnly = true;
            // 
            // ColumnGroupCRUDTeacher
            // 
            this.ColumnGroupCRUDTeacher.HeaderText = "Teacher";
            this.ColumnGroupCRUDTeacher.Name = "ColumnGroupCRUDTeacher";
            this.ColumnGroupCRUDTeacher.ReadOnly = true;
            // 
            // ColumnGroupCRUDMentor
            // 
            this.ColumnGroupCRUDMentor.HeaderText = "Mentor";
            this.ColumnGroupCRUDMentor.Name = "ColumnGroupCRUDMentor";
            this.ColumnGroupCRUDMentor.ReadOnly = true;
            // 
            // ColumnGroupCRUDCapacity
            // 
            this.ColumnGroupCRUDCapacity.HeaderText = "Capacity";
            this.ColumnGroupCRUDCapacity.Name = "ColumnGroupCRUDCapacity";
            this.ColumnGroupCRUDCapacity.ReadOnly = true;
            // 
            // ColumnGroupCRUDEdu
            // 
            this.ColumnGroupCRUDEdu.HeaderText = "Education Proqram";
            this.ColumnGroupCRUDEdu.Name = "ColumnGroupCRUDEdu";
            this.ColumnGroupCRUDEdu.ReadOnly = true;
            // 
            // GroupCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 378);
            this.Controls.Add(this.dgvGroupCreate);
            this.Controls.Add(this.panelEmail);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GroupCRUD";
            this.Text = "GroupCRUD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GroupCRUD_FormClosed);
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupCreate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.ComboBox cbGroupEducation;
        private System.Windows.Forms.Button GroupDeleteBtn;
        private System.Windows.Forms.Button GroupUpdateBtn;
        private System.Windows.Forms.Button GroupResetBtn;
        private System.Windows.Forms.Button GroupCreateBtn;
        private System.Windows.Forms.Label GroupCRUDEdu;
        private System.Windows.Forms.Label GroupCRUDMentor;
        private System.Windows.Forms.Label GroupCRUDTeacher;
        private System.Windows.Forms.Label GroupCRUDCapacity;
        private System.Windows.Forms.Label GroupCRUDSurname;
        private System.Windows.Forms.Label GroupCRUDName;
        private System.Windows.Forms.TextBox GroupCapacityTxt;
        private System.Windows.Forms.TextBox GroupNameTxt;
        private System.Windows.Forms.DataGridView dgvGroupCreate;
        private System.Windows.Forms.ComboBox cbGroupMentor;
        private System.Windows.Forms.ComboBox cbGroupTeacher;
        private System.Windows.Forms.ComboBox cbGroupClassroom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGroupCRUDİd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGroupCRUDName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGroupCRUDSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGroupCRUDTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGroupCRUDMentor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGroupCRUDCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGroupCRUDEdu;
    }
}
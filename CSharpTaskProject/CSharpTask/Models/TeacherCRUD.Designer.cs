namespace CSharpTask.Models
{
    partial class TeacherCRUD
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
            this.dgvTeacherCreate = new System.Windows.Forms.DataGridView();
            this.ColumnTeacherCRUDİd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeacherCRUDName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeacherCRUDSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeacherCRUDSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeacherCRUDEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeacherCRUDPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.cbSpecGroup = new System.Windows.Forms.ComboBox();
            this.TeacherDeleteBtn = new System.Windows.Forms.Button();
            this.TeacherUpdateBtn = new System.Windows.Forms.Button();
            this.TeacherResetBtn = new System.Windows.Forms.Button();
            this.TeacherCreateBtn = new System.Windows.Forms.Button();
            this.TeacherCRUDPhone = new System.Windows.Forms.Label();
            this.TeacherCRUDEmail = new System.Windows.Forms.Label();
            this.TeacherCRUDSpec = new System.Windows.Forms.Label();
            this.TeacherCRUDSurname = new System.Windows.Forms.Label();
            this.TeacherCRUDName = new System.Windows.Forms.Label();
            this.TeacherPhoneTxt = new System.Windows.Forms.TextBox();
            this.TeacherEmailTxt = new System.Windows.Forms.TextBox();
            this.TeacherSurnameTxt = new System.Windows.Forms.TextBox();
            this.TeacherNameTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherCreate)).BeginInit();
            this.panelEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTeacherCreate
            // 
            this.dgvTeacherCreate.AllowUserToAddRows = false;
            this.dgvTeacherCreate.AllowUserToDeleteRows = false;
            this.dgvTeacherCreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeacherCreate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeacherCreate.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            this.dgvTeacherCreate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherCreate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTeacherCRUDİd,
            this.ColumnTeacherCRUDName,
            this.ColumnTeacherCRUDSurname,
            this.ColumnTeacherCRUDSpec,
            this.ColumnTeacherCRUDEmail,
            this.ColumnTeacherCRUDPhone});
            this.dgvTeacherCreate.Location = new System.Drawing.Point(390, 0);
            this.dgvTeacherCreate.Name = "dgvTeacherCreate";
            this.dgvTeacherCreate.Size = new System.Drawing.Size(596, 377);
            this.dgvTeacherCreate.TabIndex = 22;
            this.dgvTeacherCreate.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvTeacherCreate_CellMouseDoubleClick);
            // 
            // ColumnTeacherCRUDİd
            // 
            this.ColumnTeacherCRUDİd.HeaderText = "İd";
            this.ColumnTeacherCRUDİd.Name = "ColumnTeacherCRUDİd";
            this.ColumnTeacherCRUDİd.Visible = false;
            // 
            // ColumnTeacherCRUDName
            // 
            this.ColumnTeacherCRUDName.HeaderText = "Name";
            this.ColumnTeacherCRUDName.Name = "ColumnTeacherCRUDName";
            this.ColumnTeacherCRUDName.ReadOnly = true;
            // 
            // ColumnTeacherCRUDSurname
            // 
            this.ColumnTeacherCRUDSurname.HeaderText = "Surname";
            this.ColumnTeacherCRUDSurname.Name = "ColumnTeacherCRUDSurname";
            this.ColumnTeacherCRUDSurname.ReadOnly = true;
            // 
            // ColumnTeacherCRUDSpec
            // 
            this.ColumnTeacherCRUDSpec.HeaderText = "Speciality";
            this.ColumnTeacherCRUDSpec.Name = "ColumnTeacherCRUDSpec";
            this.ColumnTeacherCRUDSpec.ReadOnly = true;
            // 
            // ColumnTeacherCRUDEmail
            // 
            this.ColumnTeacherCRUDEmail.HeaderText = "Email";
            this.ColumnTeacherCRUDEmail.Name = "ColumnTeacherCRUDEmail";
            this.ColumnTeacherCRUDEmail.ReadOnly = true;
            // 
            // ColumnTeacherCRUDPhone
            // 
            this.ColumnTeacherCRUDPhone.HeaderText = "Phone";
            this.ColumnTeacherCRUDPhone.Name = "ColumnTeacherCRUDPhone";
            this.ColumnTeacherCRUDPhone.ReadOnly = true;
            // 
            // panelEmail
            // 
            this.panelEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelEmail.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelEmail.Controls.Add(this.cbSpecGroup);
            this.panelEmail.Controls.Add(this.TeacherDeleteBtn);
            this.panelEmail.Controls.Add(this.TeacherUpdateBtn);
            this.panelEmail.Controls.Add(this.TeacherResetBtn);
            this.panelEmail.Controls.Add(this.TeacherCreateBtn);
            this.panelEmail.Controls.Add(this.TeacherCRUDPhone);
            this.panelEmail.Controls.Add(this.TeacherCRUDEmail);
            this.panelEmail.Controls.Add(this.TeacherCRUDSpec);
            this.panelEmail.Controls.Add(this.TeacherCRUDSurname);
            this.panelEmail.Controls.Add(this.TeacherCRUDName);
            this.panelEmail.Controls.Add(this.TeacherPhoneTxt);
            this.panelEmail.Controls.Add(this.TeacherEmailTxt);
            this.panelEmail.Controls.Add(this.TeacherSurnameTxt);
            this.panelEmail.Controls.Add(this.TeacherNameTxt);
            this.panelEmail.Location = new System.Drawing.Point(0, 0);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(384, 377);
            this.panelEmail.TabIndex = 23;
            // 
            // cbSpecGroup
            // 
            this.cbSpecGroup.BackColor = System.Drawing.Color.IndianRed;
            this.cbSpecGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSpecGroup.FormattingEnabled = true;
            this.cbSpecGroup.Location = new System.Drawing.Point(121, 99);
            this.cbSpecGroup.Name = "cbSpecGroup";
            this.cbSpecGroup.Size = new System.Drawing.Size(231, 21);
            this.cbSpecGroup.TabIndex = 5;
            // 
            // TeacherDeleteBtn
            // 
            this.TeacherDeleteBtn.BackColor = System.Drawing.Color.Red;
            this.TeacherDeleteBtn.FlatAppearance.BorderSize = 0;
            this.TeacherDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeacherDeleteBtn.Location = new System.Drawing.Point(141, 307);
            this.TeacherDeleteBtn.Name = "TeacherDeleteBtn";
            this.TeacherDeleteBtn.Size = new System.Drawing.Size(110, 34);
            this.TeacherDeleteBtn.TabIndex = 3;
            this.TeacherDeleteBtn.Text = "Delete";
            this.TeacherDeleteBtn.UseVisualStyleBackColor = false;
            this.TeacherDeleteBtn.Click += new System.EventHandler(this.TeacherDeleteBtn_Click);
            // 
            // TeacherUpdateBtn
            // 
            this.TeacherUpdateBtn.BackColor = System.Drawing.Color.Yellow;
            this.TeacherUpdateBtn.FlatAppearance.BorderSize = 0;
            this.TeacherUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeacherUpdateBtn.Location = new System.Drawing.Point(41, 307);
            this.TeacherUpdateBtn.Name = "TeacherUpdateBtn";
            this.TeacherUpdateBtn.Size = new System.Drawing.Size(94, 34);
            this.TeacherUpdateBtn.TabIndex = 3;
            this.TeacherUpdateBtn.Text = "Update";
            this.TeacherUpdateBtn.UseVisualStyleBackColor = false;
            this.TeacherUpdateBtn.Click += new System.EventHandler(this.TeacherUpdateBtn_Click);
            // 
            // TeacherResetBtn
            // 
            this.TeacherResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TeacherResetBtn.FlatAppearance.BorderSize = 0;
            this.TeacherResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeacherResetBtn.Location = new System.Drawing.Point(257, 307);
            this.TeacherResetBtn.Name = "TeacherResetBtn";
            this.TeacherResetBtn.Size = new System.Drawing.Size(95, 34);
            this.TeacherResetBtn.TabIndex = 3;
            this.TeacherResetBtn.Text = "Reset";
            this.TeacherResetBtn.UseVisualStyleBackColor = false;
            this.TeacherResetBtn.Click += new System.EventHandler(this.TeacherResetBtn_Click);
            // 
            // TeacherCreateBtn
            // 
            this.TeacherCreateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TeacherCreateBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.TeacherCreateBtn.FlatAppearance.BorderSize = 0;
            this.TeacherCreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeacherCreateBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherCreateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TeacherCreateBtn.Location = new System.Drawing.Point(41, 257);
            this.TeacherCreateBtn.Name = "TeacherCreateBtn";
            this.TeacherCreateBtn.Size = new System.Drawing.Size(311, 36);
            this.TeacherCreateBtn.TabIndex = 2;
            this.TeacherCreateBtn.Text = "Create";
            this.TeacherCreateBtn.UseVisualStyleBackColor = false;
            this.TeacherCreateBtn.Click += new System.EventHandler(this.TeacherCreateBtn_Click);
            // 
            // TeacherCRUDPhone
            // 
            this.TeacherCRUDPhone.AutoSize = true;
            this.TeacherCRUDPhone.Location = new System.Drawing.Point(38, 182);
            this.TeacherCRUDPhone.Name = "TeacherCRUDPhone";
            this.TeacherCRUDPhone.Size = new System.Drawing.Size(38, 13);
            this.TeacherCRUDPhone.TabIndex = 1;
            this.TeacherCRUDPhone.Text = "Phone";
            // 
            // TeacherCRUDEmail
            // 
            this.TeacherCRUDEmail.AutoSize = true;
            this.TeacherCRUDEmail.Location = new System.Drawing.Point(38, 137);
            this.TeacherCRUDEmail.Name = "TeacherCRUDEmail";
            this.TeacherCRUDEmail.Size = new System.Drawing.Size(32, 13);
            this.TeacherCRUDEmail.TabIndex = 1;
            this.TeacherCRUDEmail.Text = "Email";
            // 
            // TeacherCRUDSpec
            // 
            this.TeacherCRUDSpec.AutoSize = true;
            this.TeacherCRUDSpec.Location = new System.Drawing.Point(38, 99);
            this.TeacherCRUDSpec.Name = "TeacherCRUDSpec";
            this.TeacherCRUDSpec.Size = new System.Drawing.Size(52, 13);
            this.TeacherCRUDSpec.TabIndex = 1;
            this.TeacherCRUDSpec.Text = "Speciality";
            // 
            // TeacherCRUDSurname
            // 
            this.TeacherCRUDSurname.AutoSize = true;
            this.TeacherCRUDSurname.Location = new System.Drawing.Point(38, 64);
            this.TeacherCRUDSurname.Name = "TeacherCRUDSurname";
            this.TeacherCRUDSurname.Size = new System.Drawing.Size(49, 13);
            this.TeacherCRUDSurname.TabIndex = 1;
            this.TeacherCRUDSurname.Text = "Surname";
            // 
            // TeacherCRUDName
            // 
            this.TeacherCRUDName.AutoSize = true;
            this.TeacherCRUDName.Location = new System.Drawing.Point(38, 27);
            this.TeacherCRUDName.Name = "TeacherCRUDName";
            this.TeacherCRUDName.Size = new System.Drawing.Size(35, 13);
            this.TeacherCRUDName.TabIndex = 1;
            this.TeacherCRUDName.Text = "Name";
            // 
            // TeacherPhoneTxt
            // 
            this.TeacherPhoneTxt.BackColor = System.Drawing.Color.IndianRed;
            this.TeacherPhoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherPhoneTxt.Location = new System.Drawing.Point(121, 177);
            this.TeacherPhoneTxt.Name = "TeacherPhoneTxt";
            this.TeacherPhoneTxt.Size = new System.Drawing.Size(231, 22);
            this.TeacherPhoneTxt.TabIndex = 4;
            // 
            // TeacherEmailTxt
            // 
            this.TeacherEmailTxt.BackColor = System.Drawing.Color.IndianRed;
            this.TeacherEmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherEmailTxt.Location = new System.Drawing.Point(121, 137);
            this.TeacherEmailTxt.Name = "TeacherEmailTxt";
            this.TeacherEmailTxt.Size = new System.Drawing.Size(231, 22);
            this.TeacherEmailTxt.TabIndex = 3;
            // 
            // TeacherSurnameTxt
            // 
            this.TeacherSurnameTxt.BackColor = System.Drawing.Color.IndianRed;
            this.TeacherSurnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherSurnameTxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TeacherSurnameTxt.Location = new System.Drawing.Point(121, 59);
            this.TeacherSurnameTxt.Name = "TeacherSurnameTxt";
            this.TeacherSurnameTxt.Size = new System.Drawing.Size(231, 22);
            this.TeacherSurnameTxt.TabIndex = 1;
            // 
            // TeacherNameTxt
            // 
            this.TeacherNameTxt.BackColor = System.Drawing.Color.IndianRed;
            this.TeacherNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherNameTxt.Location = new System.Drawing.Point(121, 22);
            this.TeacherNameTxt.Name = "TeacherNameTxt";
            this.TeacherNameTxt.Size = new System.Drawing.Size(231, 22);
            this.TeacherNameTxt.TabIndex = 0;
            // 
            // TeacherCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 377);
            this.Controls.Add(this.panelEmail);
            this.Controls.Add(this.dgvTeacherCreate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeacherCRUD";
            this.Text = "TeacherCRUD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherCRUD_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherCreate)).EndInit();
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTeacherCreate;
        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.ComboBox cbSpecGroup;
        private System.Windows.Forms.Button TeacherDeleteBtn;
        private System.Windows.Forms.Button TeacherUpdateBtn;
        private System.Windows.Forms.Button TeacherResetBtn;
        private System.Windows.Forms.Button TeacherCreateBtn;
        private System.Windows.Forms.Label TeacherCRUDPhone;
        private System.Windows.Forms.Label TeacherCRUDEmail;
        private System.Windows.Forms.Label TeacherCRUDSpec;
        private System.Windows.Forms.Label TeacherCRUDSurname;
        private System.Windows.Forms.Label TeacherCRUDName;
        private System.Windows.Forms.TextBox TeacherPhoneTxt;
        private System.Windows.Forms.TextBox TeacherEmailTxt;
        private System.Windows.Forms.TextBox TeacherSurnameTxt;
        private System.Windows.Forms.TextBox TeacherNameTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacherCRUDİd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacherCRUDName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacherCRUDSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacherCRUDSpec;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacherCRUDEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacherCRUDPhone;
    }
}
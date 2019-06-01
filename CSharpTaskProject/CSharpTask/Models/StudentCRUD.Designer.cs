namespace CSharpTask.Models
{
    partial class StudentCRUD
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
            this.cbStudentGroup = new System.Windows.Forms.ComboBox();
            this.StudentDeleteBtn = new System.Windows.Forms.Button();
            this.StudentUpdateBtn = new System.Windows.Forms.Button();
            this.StudentResetBtn = new System.Windows.Forms.Button();
            this.StudentCreateBtn = new System.Windows.Forms.Button();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelFee = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.StudentFeeTxt = new System.Windows.Forms.TextBox();
            this.StudentPhoneTxt = new System.Windows.Forms.TextBox();
            this.StudentEmailTxt = new System.Windows.Forms.TextBox();
            this.StudentSurnameTxt = new System.Windows.Forms.TextBox();
            this.StudentNameTxt = new System.Windows.Forms.TextBox();
            this.dgvStudentCreate = new System.Windows.Forms.DataGridView();
            this.Columnİd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentCreate)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEmail
            // 
            this.panelEmail.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelEmail.Controls.Add(this.cbStudentGroup);
            this.panelEmail.Controls.Add(this.StudentDeleteBtn);
            this.panelEmail.Controls.Add(this.StudentUpdateBtn);
            this.panelEmail.Controls.Add(this.StudentResetBtn);
            this.panelEmail.Controls.Add(this.StudentCreateBtn);
            this.panelEmail.Controls.Add(this.labelGroup);
            this.panelEmail.Controls.Add(this.labelFee);
            this.panelEmail.Controls.Add(this.labelPhone);
            this.panelEmail.Controls.Add(this.labelEmail);
            this.panelEmail.Controls.Add(this.labelSurname);
            this.panelEmail.Controls.Add(this.labelName);
            this.panelEmail.Controls.Add(this.StudentFeeTxt);
            this.panelEmail.Controls.Add(this.StudentPhoneTxt);
            this.panelEmail.Controls.Add(this.StudentEmailTxt);
            this.panelEmail.Controls.Add(this.StudentSurnameTxt);
            this.panelEmail.Controls.Add(this.StudentNameTxt);
            this.panelEmail.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEmail.Location = new System.Drawing.Point(0, 0);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(384, 392);
            this.panelEmail.TabIndex = 0;
            // 
            // cbStudentGroup
            // 
            this.cbStudentGroup.BackColor = System.Drawing.Color.IndianRed;
            this.cbStudentGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStudentGroup.FormattingEnabled = true;
            this.cbStudentGroup.Location = new System.Drawing.Point(121, 219);
            this.cbStudentGroup.Name = "cbStudentGroup";
            this.cbStudentGroup.Size = new System.Drawing.Size(231, 21);
            this.cbStudentGroup.TabIndex = 5;
            // 
            // StudentDeleteBtn
            // 
            this.StudentDeleteBtn.BackColor = System.Drawing.Color.Red;
            this.StudentDeleteBtn.FlatAppearance.BorderSize = 0;
            this.StudentDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentDeleteBtn.Location = new System.Drawing.Point(141, 335);
            this.StudentDeleteBtn.Name = "StudentDeleteBtn";
            this.StudentDeleteBtn.Size = new System.Drawing.Size(110, 34);
            this.StudentDeleteBtn.TabIndex = 3;
            this.StudentDeleteBtn.Text = "Delete";
            this.StudentDeleteBtn.UseVisualStyleBackColor = false;
            this.StudentDeleteBtn.Click += new System.EventHandler(this.StudentDeleteBtn_Click);
            // 
            // StudentUpdateBtn
            // 
            this.StudentUpdateBtn.BackColor = System.Drawing.Color.Yellow;
            this.StudentUpdateBtn.FlatAppearance.BorderSize = 0;
            this.StudentUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentUpdateBtn.Location = new System.Drawing.Point(41, 335);
            this.StudentUpdateBtn.Name = "StudentUpdateBtn";
            this.StudentUpdateBtn.Size = new System.Drawing.Size(94, 34);
            this.StudentUpdateBtn.TabIndex = 3;
            this.StudentUpdateBtn.Text = "Update";
            this.StudentUpdateBtn.UseVisualStyleBackColor = false;
            this.StudentUpdateBtn.Click += new System.EventHandler(this.StudentUpdateBtn_Click);
            // 
            // StudentResetBtn
            // 
            this.StudentResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StudentResetBtn.FlatAppearance.BorderSize = 0;
            this.StudentResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentResetBtn.Location = new System.Drawing.Point(257, 335);
            this.StudentResetBtn.Name = "StudentResetBtn";
            this.StudentResetBtn.Size = new System.Drawing.Size(95, 34);
            this.StudentResetBtn.TabIndex = 3;
            this.StudentResetBtn.Text = "Reset";
            this.StudentResetBtn.UseVisualStyleBackColor = false;
            this.StudentResetBtn.Click += new System.EventHandler(this.StudentResetBtn_Click);
            // 
            // StudentCreateBtn
            // 
            this.StudentCreateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.StudentCreateBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.StudentCreateBtn.FlatAppearance.BorderSize = 0;
            this.StudentCreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentCreateBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentCreateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StudentCreateBtn.Location = new System.Drawing.Point(41, 285);
            this.StudentCreateBtn.Name = "StudentCreateBtn";
            this.StudentCreateBtn.Size = new System.Drawing.Size(311, 36);
            this.StudentCreateBtn.TabIndex = 2;
            this.StudentCreateBtn.Text = "Create";
            this.StudentCreateBtn.UseVisualStyleBackColor = false;
            this.StudentCreateBtn.Click += new System.EventHandler(this.StudentCreateBtn_Click);
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(38, 222);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(36, 13);
            this.labelGroup.TabIndex = 1;
            this.labelGroup.Text = "Group";
            // 
            // labelFee
            // 
            this.labelFee.AutoSize = true;
            this.labelFee.Location = new System.Drawing.Point(38, 182);
            this.labelFee.Name = "labelFee";
            this.labelFee.Size = new System.Drawing.Size(25, 13);
            this.labelFee.TabIndex = 1;
            this.labelFee.Text = "Fee";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(38, 137);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(38, 13);
            this.labelPhone.TabIndex = 1;
            this.labelPhone.Text = "Phone";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(38, 99);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(38, 64);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(49, 13);
            this.labelSurname.TabIndex = 1;
            this.labelSurname.Text = "Surname";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(38, 27);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // StudentFeeTxt
            // 
            this.StudentFeeTxt.BackColor = System.Drawing.Color.IndianRed;
            this.StudentFeeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentFeeTxt.Location = new System.Drawing.Point(121, 177);
            this.StudentFeeTxt.Name = "StudentFeeTxt";
            this.StudentFeeTxt.Size = new System.Drawing.Size(231, 22);
            this.StudentFeeTxt.TabIndex = 4;
            // 
            // StudentPhoneTxt
            // 
            this.StudentPhoneTxt.BackColor = System.Drawing.Color.IndianRed;
            this.StudentPhoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentPhoneTxt.Location = new System.Drawing.Point(121, 137);
            this.StudentPhoneTxt.Name = "StudentPhoneTxt";
            this.StudentPhoneTxt.Size = new System.Drawing.Size(231, 22);
            this.StudentPhoneTxt.TabIndex = 3;
            // 
            // StudentEmailTxt
            // 
            this.StudentEmailTxt.BackColor = System.Drawing.Color.IndianRed;
            this.StudentEmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentEmailTxt.Location = new System.Drawing.Point(121, 99);
            this.StudentEmailTxt.Name = "StudentEmailTxt";
            this.StudentEmailTxt.Size = new System.Drawing.Size(231, 22);
            this.StudentEmailTxt.TabIndex = 2;
            // 
            // StudentSurnameTxt
            // 
            this.StudentSurnameTxt.BackColor = System.Drawing.Color.IndianRed;
            this.StudentSurnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentSurnameTxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StudentSurnameTxt.Location = new System.Drawing.Point(121, 59);
            this.StudentSurnameTxt.Name = "StudentSurnameTxt";
            this.StudentSurnameTxt.Size = new System.Drawing.Size(231, 22);
            this.StudentSurnameTxt.TabIndex = 1;
            // 
            // StudentNameTxt
            // 
            this.StudentNameTxt.BackColor = System.Drawing.Color.IndianRed;
            this.StudentNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNameTxt.Location = new System.Drawing.Point(121, 22);
            this.StudentNameTxt.Name = "StudentNameTxt";
            this.StudentNameTxt.Size = new System.Drawing.Size(231, 22);
            this.StudentNameTxt.TabIndex = 0;
            // 
            // dgvStudentCreate
            // 
            this.dgvStudentCreate.AllowUserToAddRows = false;
            this.dgvStudentCreate.AllowUserToDeleteRows = false;
            this.dgvStudentCreate.AllowUserToResizeColumns = false;
            this.dgvStudentCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudentCreate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentCreate.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            this.dgvStudentCreate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentCreate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columnİd,
            this.ColumnName,
            this.ColumnSurname,
            this.ColumnEmail,
            this.ColumnPhone,
            this.ColumnFee,
            this.ColumnGroup});
            this.dgvStudentCreate.Location = new System.Drawing.Point(384, 0);
            this.dgvStudentCreate.Name = "dgvStudentCreate";
            this.dgvStudentCreate.Size = new System.Drawing.Size(510, 392);
            this.dgvStudentCreate.TabIndex = 1;
            this.dgvStudentCreate.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvStudentCreate_CellMouseDoubleClick);
            // 
            // Columnİd
            // 
            this.Columnİd.HeaderText = "İd";
            this.Columnİd.Name = "Columnİd";
            this.Columnİd.Visible = false;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnSurname
            // 
            this.ColumnSurname.HeaderText = "Surname";
            this.ColumnSurname.Name = "ColumnSurname";
            this.ColumnSurname.ReadOnly = true;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "Email";
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.ReadOnly = true;
            // 
            // ColumnPhone
            // 
            this.ColumnPhone.HeaderText = "Phone";
            this.ColumnPhone.Name = "ColumnPhone";
            this.ColumnPhone.ReadOnly = true;
            // 
            // ColumnFee
            // 
            this.ColumnFee.HeaderText = "Fee";
            this.ColumnFee.Name = "ColumnFee";
            this.ColumnFee.ReadOnly = true;
            // 
            // ColumnGroup
            // 
            this.ColumnGroup.HeaderText = "Group";
            this.ColumnGroup.Name = "ColumnGroup";
            this.ColumnGroup.ReadOnly = true;
            // 
            // StudentCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 392);
            this.Controls.Add(this.dgvStudentCreate);
            this.Controls.Add(this.panelEmail);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentCRUD";
            this.Text = "StudentCRUD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentCRUD_FormClosed);
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentCreate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelFee;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox StudentFeeTxt;
        private System.Windows.Forms.TextBox StudentPhoneTxt;
        private System.Windows.Forms.TextBox StudentEmailTxt;
        private System.Windows.Forms.TextBox StudentSurnameTxt;
        private System.Windows.Forms.TextBox StudentNameTxt;
        private System.Windows.Forms.Button StudentDeleteBtn;
        private System.Windows.Forms.Button StudentUpdateBtn;
        private System.Windows.Forms.Button StudentResetBtn;
        private System.Windows.Forms.Button StudentCreateBtn;
        private System.Windows.Forms.DataGridView dgvStudentCreate;
        private System.Windows.Forms.ComboBox cbStudentGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnİd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGroup;
    }
}
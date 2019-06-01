namespace CSharpTask.Models
{
    partial class TaskCRUD
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
            this.cbTaskGroup = new System.Windows.Forms.ComboBox();
            this.dtpTaskCreate = new System.Windows.Forms.DateTimePicker();
            this.TaskDeleteBtn = new System.Windows.Forms.Button();
            this.TaskUpdateBtn = new System.Windows.Forms.Button();
            this.TaskResetBtn = new System.Windows.Forms.Button();
            this.TaskCreateBtn = new System.Windows.Forms.Button();
            this.TaskCRUDgroup = new System.Windows.Forms.Label();
            this.TaskCRUDDeadline = new System.Windows.Forms.Label();
            this.TaskCRUDName = new System.Windows.Forms.Label();
            this.TaskNameTxt = new System.Windows.Forms.TextBox();
            this.dgvTaskCreate = new System.Windows.Forms.DataGridView();
            this.ColumntaskCRUDİd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTaskCRUDName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTaskCRUDDeadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTaskCRUDGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskCreate)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEmail
            // 
            this.panelEmail.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelEmail.Controls.Add(this.cbTaskGroup);
            this.panelEmail.Controls.Add(this.dtpTaskCreate);
            this.panelEmail.Controls.Add(this.TaskDeleteBtn);
            this.panelEmail.Controls.Add(this.TaskUpdateBtn);
            this.panelEmail.Controls.Add(this.TaskResetBtn);
            this.panelEmail.Controls.Add(this.TaskCreateBtn);
            this.panelEmail.Controls.Add(this.TaskCRUDgroup);
            this.panelEmail.Controls.Add(this.TaskCRUDDeadline);
            this.panelEmail.Controls.Add(this.TaskCRUDName);
            this.panelEmail.Controls.Add(this.TaskNameTxt);
            this.panelEmail.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEmail.Location = new System.Drawing.Point(0, 0);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(384, 311);
            this.panelEmail.TabIndex = 25;
            // 
            // cbTaskGroup
            // 
            this.cbTaskGroup.BackColor = System.Drawing.Color.IndianRed;
            this.cbTaskGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTaskGroup.FormattingEnabled = true;
            this.cbTaskGroup.Location = new System.Drawing.Point(121, 97);
            this.cbTaskGroup.Name = "cbTaskGroup";
            this.cbTaskGroup.Size = new System.Drawing.Size(231, 21);
            this.cbTaskGroup.TabIndex = 2;
            // 
            // dtpTaskCreate
            // 
            this.dtpTaskCreate.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dtpTaskCreate.CalendarTitleBackColor = System.Drawing.Color.RosyBrown;
            this.dtpTaskCreate.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtpTaskCreate.CalendarTrailingForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dtpTaskCreate.Location = new System.Drawing.Point(121, 58);
            this.dtpTaskCreate.Name = "dtpTaskCreate";
            this.dtpTaskCreate.Size = new System.Drawing.Size(231, 20);
            this.dtpTaskCreate.TabIndex = 1;
            this.dtpTaskCreate.Value = new System.DateTime(2019, 5, 30, 22, 54, 52, 0);
            // 
            // TaskDeleteBtn
            // 
            this.TaskDeleteBtn.BackColor = System.Drawing.Color.Red;
            this.TaskDeleteBtn.FlatAppearance.BorderSize = 0;
            this.TaskDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaskDeleteBtn.Location = new System.Drawing.Point(135, 246);
            this.TaskDeleteBtn.Name = "TaskDeleteBtn";
            this.TaskDeleteBtn.Size = new System.Drawing.Size(110, 34);
            this.TaskDeleteBtn.TabIndex = 3;
            this.TaskDeleteBtn.Text = "Delete";
            this.TaskDeleteBtn.UseVisualStyleBackColor = false;
            this.TaskDeleteBtn.Click += new System.EventHandler(this.TaskDeleteBtn_Click);
            // 
            // TaskUpdateBtn
            // 
            this.TaskUpdateBtn.BackColor = System.Drawing.Color.Yellow;
            this.TaskUpdateBtn.FlatAppearance.BorderSize = 0;
            this.TaskUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaskUpdateBtn.Location = new System.Drawing.Point(35, 246);
            this.TaskUpdateBtn.Name = "TaskUpdateBtn";
            this.TaskUpdateBtn.Size = new System.Drawing.Size(94, 34);
            this.TaskUpdateBtn.TabIndex = 3;
            this.TaskUpdateBtn.Text = "Update";
            this.TaskUpdateBtn.UseVisualStyleBackColor = false;
            this.TaskUpdateBtn.Click += new System.EventHandler(this.TaskUpdateBtn_Click);
            // 
            // TaskResetBtn
            // 
            this.TaskResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TaskResetBtn.FlatAppearance.BorderSize = 0;
            this.TaskResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaskResetBtn.Location = new System.Drawing.Point(251, 246);
            this.TaskResetBtn.Name = "TaskResetBtn";
            this.TaskResetBtn.Size = new System.Drawing.Size(95, 34);
            this.TaskResetBtn.TabIndex = 3;
            this.TaskResetBtn.Text = "Reset";
            this.TaskResetBtn.UseVisualStyleBackColor = false;
            this.TaskResetBtn.Click += new System.EventHandler(this.TaskResetBtn_Click);
            // 
            // TaskCreateBtn
            // 
            this.TaskCreateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TaskCreateBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.TaskCreateBtn.FlatAppearance.BorderSize = 0;
            this.TaskCreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaskCreateBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskCreateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TaskCreateBtn.Location = new System.Drawing.Point(35, 196);
            this.TaskCreateBtn.Name = "TaskCreateBtn";
            this.TaskCreateBtn.Size = new System.Drawing.Size(311, 36);
            this.TaskCreateBtn.TabIndex = 2;
            this.TaskCreateBtn.Text = "Create";
            this.TaskCreateBtn.UseVisualStyleBackColor = false;
            this.TaskCreateBtn.Click += new System.EventHandler(this.TaskCreateBtn_Click);
            // 
            // TaskCRUDgroup
            // 
            this.TaskCRUDgroup.AutoSize = true;
            this.TaskCRUDgroup.Location = new System.Drawing.Point(37, 106);
            this.TaskCRUDgroup.Name = "TaskCRUDgroup";
            this.TaskCRUDgroup.Size = new System.Drawing.Size(36, 13);
            this.TaskCRUDgroup.TabIndex = 1;
            this.TaskCRUDgroup.Text = "Group";
            // 
            // TaskCRUDDeadline
            // 
            this.TaskCRUDDeadline.AutoSize = true;
            this.TaskCRUDDeadline.Location = new System.Drawing.Point(38, 64);
            this.TaskCRUDDeadline.Name = "TaskCRUDDeadline";
            this.TaskCRUDDeadline.Size = new System.Drawing.Size(49, 13);
            this.TaskCRUDDeadline.TabIndex = 1;
            this.TaskCRUDDeadline.Text = "Deadline";
            // 
            // TaskCRUDName
            // 
            this.TaskCRUDName.AutoSize = true;
            this.TaskCRUDName.Location = new System.Drawing.Point(38, 27);
            this.TaskCRUDName.Name = "TaskCRUDName";
            this.TaskCRUDName.Size = new System.Drawing.Size(35, 13);
            this.TaskCRUDName.TabIndex = 1;
            this.TaskCRUDName.Text = "Name";
            // 
            // TaskNameTxt
            // 
            this.TaskNameTxt.BackColor = System.Drawing.Color.IndianRed;
            this.TaskNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskNameTxt.Location = new System.Drawing.Point(121, 22);
            this.TaskNameTxt.Name = "TaskNameTxt";
            this.TaskNameTxt.Size = new System.Drawing.Size(231, 22);
            this.TaskNameTxt.TabIndex = 0;
            // 
            // dgvTaskCreate
            // 
            this.dgvTaskCreate.AllowUserToAddRows = false;
            this.dgvTaskCreate.AllowUserToDeleteRows = false;
            this.dgvTaskCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTaskCreate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaskCreate.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            this.dgvTaskCreate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaskCreate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumntaskCRUDİd,
            this.ColumnTaskCRUDName,
            this.ColumnTaskCRUDDeadline,
            this.ColumnTaskCRUDGroup});
            this.dgvTaskCreate.Location = new System.Drawing.Point(382, 0);
            this.dgvTaskCreate.Name = "dgvTaskCreate";
            this.dgvTaskCreate.Size = new System.Drawing.Size(403, 311);
            this.dgvTaskCreate.TabIndex = 26;
            this.dgvTaskCreate.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvTaskCreate_CellMouseDoubleClick);
            // 
            // ColumntaskCRUDİd
            // 
            this.ColumntaskCRUDİd.HeaderText = "İd";
            this.ColumntaskCRUDİd.Name = "ColumntaskCRUDİd";
            this.ColumntaskCRUDİd.Visible = false;
            // 
            // ColumnTaskCRUDName
            // 
            this.ColumnTaskCRUDName.HeaderText = "Name";
            this.ColumnTaskCRUDName.Name = "ColumnTaskCRUDName";
            this.ColumnTaskCRUDName.ReadOnly = true;
            // 
            // ColumnTaskCRUDDeadline
            // 
            this.ColumnTaskCRUDDeadline.HeaderText = "Deadline";
            this.ColumnTaskCRUDDeadline.Name = "ColumnTaskCRUDDeadline";
            this.ColumnTaskCRUDDeadline.ReadOnly = true;
            // 
            // ColumnTaskCRUDGroup
            // 
            this.ColumnTaskCRUDGroup.HeaderText = "Group";
            this.ColumnTaskCRUDGroup.Name = "ColumnTaskCRUDGroup";
            this.ColumnTaskCRUDGroup.ReadOnly = true;
            // 
            // TaskCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 311);
            this.Controls.Add(this.dgvTaskCreate);
            this.Controls.Add(this.panelEmail);
            this.Name = "TaskCRUD";
            this.Text = "TaskCRUD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TaskCRUD_FormClosed);
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskCreate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.DateTimePicker dtpTaskCreate;
        private System.Windows.Forms.Button TaskDeleteBtn;
        private System.Windows.Forms.Button TaskUpdateBtn;
        private System.Windows.Forms.Button TaskResetBtn;
        private System.Windows.Forms.Button TaskCreateBtn;
        private System.Windows.Forms.Label TaskCRUDgroup;
        private System.Windows.Forms.Label TaskCRUDDeadline;
        private System.Windows.Forms.Label TaskCRUDName;
        private System.Windows.Forms.TextBox TaskNameTxt;
        private System.Windows.Forms.DataGridView dgvTaskCreate;
        private System.Windows.Forms.ComboBox cbTaskGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumntaskCRUDİd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTaskCRUDName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTaskCRUDDeadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTaskCRUDGroup;
    }
}
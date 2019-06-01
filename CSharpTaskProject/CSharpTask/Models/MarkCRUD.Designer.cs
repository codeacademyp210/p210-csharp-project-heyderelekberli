namespace CSharpTask.Models
{
    partial class MarkCRUD
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
            this.cbMarkTaskID = new System.Windows.Forms.ComboBox();
            this.cbMarkStudentID = new System.Windows.Forms.ComboBox();
            this.MarkTxt = new System.Windows.Forms.TextBox();
            this.MarkDeleteBtn = new System.Windows.Forms.Button();
            this.MarkUpdateBtn = new System.Windows.Forms.Button();
            this.MarkResetBtn = new System.Windows.Forms.Button();
            this.MarkCRUDMark = new System.Windows.Forms.Label();
            this.MarkCreateBtn = new System.Windows.Forms.Button();
            this.MarkCRUDGroupID = new System.Windows.Forms.Label();
            this.MarkCRUDStudentID = new System.Windows.Forms.Label();
            this.dgvMarkCreate = new System.Windows.Forms.DataGridView();
            this.ColumnMarkCRUDİd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMarkCRUDStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMArkCRUDGroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMarkMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckedBtn = new System.Windows.Forms.Button();
            this.panelEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkCreate)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEmail
            // 
            this.panelEmail.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelEmail.Controls.Add(this.CheckedBtn);
            this.panelEmail.Controls.Add(this.cbMarkTaskID);
            this.panelEmail.Controls.Add(this.cbMarkStudentID);
            this.panelEmail.Controls.Add(this.MarkTxt);
            this.panelEmail.Controls.Add(this.MarkDeleteBtn);
            this.panelEmail.Controls.Add(this.MarkUpdateBtn);
            this.panelEmail.Controls.Add(this.MarkResetBtn);
            this.panelEmail.Controls.Add(this.MarkCRUDMark);
            this.panelEmail.Controls.Add(this.MarkCreateBtn);
            this.panelEmail.Controls.Add(this.MarkCRUDGroupID);
            this.panelEmail.Controls.Add(this.MarkCRUDStudentID);
            this.panelEmail.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEmail.Location = new System.Drawing.Point(0, 0);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(384, 368);
            this.panelEmail.TabIndex = 26;
            // 
            // cbMarkTaskID
            // 
            this.cbMarkTaskID.BackColor = System.Drawing.Color.IndianRed;
            this.cbMarkTaskID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMarkTaskID.FormattingEnabled = true;
            this.cbMarkTaskID.Location = new System.Drawing.Point(123, 90);
            this.cbMarkTaskID.Name = "cbMarkTaskID";
            this.cbMarkTaskID.Size = new System.Drawing.Size(231, 21);
            this.cbMarkTaskID.TabIndex = 6;
            // 
            // cbMarkStudentID
            // 
            this.cbMarkStudentID.BackColor = System.Drawing.Color.IndianRed;
            this.cbMarkStudentID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMarkStudentID.FormattingEnabled = true;
            this.cbMarkStudentID.Location = new System.Drawing.Point(123, 48);
            this.cbMarkStudentID.Name = "cbMarkStudentID";
            this.cbMarkStudentID.Size = new System.Drawing.Size(231, 21);
            this.cbMarkStudentID.TabIndex = 5;
            // 
            // MarkTxt
            // 
            this.MarkTxt.BackColor = System.Drawing.Color.IndianRed;
            this.MarkTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarkTxt.Location = new System.Drawing.Point(123, 133);
            this.MarkTxt.Name = "MarkTxt";
            this.MarkTxt.Size = new System.Drawing.Size(231, 22);
            this.MarkTxt.TabIndex = 7;
            // 
            // MarkDeleteBtn
            // 
            this.MarkDeleteBtn.BackColor = System.Drawing.Color.Red;
            this.MarkDeleteBtn.FlatAppearance.BorderSize = 0;
            this.MarkDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MarkDeleteBtn.Location = new System.Drawing.Point(143, 237);
            this.MarkDeleteBtn.Name = "MarkDeleteBtn";
            this.MarkDeleteBtn.Size = new System.Drawing.Size(110, 34);
            this.MarkDeleteBtn.TabIndex = 3;
            this.MarkDeleteBtn.Text = "Delete";
            this.MarkDeleteBtn.UseVisualStyleBackColor = false;
            this.MarkDeleteBtn.Click += new System.EventHandler(this.MarkDeleteBtn_Click);
            // 
            // MarkUpdateBtn
            // 
            this.MarkUpdateBtn.BackColor = System.Drawing.Color.Yellow;
            this.MarkUpdateBtn.FlatAppearance.BorderSize = 0;
            this.MarkUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MarkUpdateBtn.Location = new System.Drawing.Point(43, 237);
            this.MarkUpdateBtn.Name = "MarkUpdateBtn";
            this.MarkUpdateBtn.Size = new System.Drawing.Size(94, 34);
            this.MarkUpdateBtn.TabIndex = 3;
            this.MarkUpdateBtn.Text = "Update";
            this.MarkUpdateBtn.UseVisualStyleBackColor = false;
            this.MarkUpdateBtn.Click += new System.EventHandler(this.MarkUpdateBtn_Click);
            // 
            // MarkResetBtn
            // 
            this.MarkResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MarkResetBtn.FlatAppearance.BorderSize = 0;
            this.MarkResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MarkResetBtn.Location = new System.Drawing.Point(259, 237);
            this.MarkResetBtn.Name = "MarkResetBtn";
            this.MarkResetBtn.Size = new System.Drawing.Size(95, 34);
            this.MarkResetBtn.TabIndex = 3;
            this.MarkResetBtn.Text = "Reset";
            this.MarkResetBtn.UseVisualStyleBackColor = false;
            this.MarkResetBtn.Click += new System.EventHandler(this.MarkResetBtn_Click);
            // 
            // MarkCRUDMark
            // 
            this.MarkCRUDMark.AutoSize = true;
            this.MarkCRUDMark.Location = new System.Drawing.Point(40, 138);
            this.MarkCRUDMark.Name = "MarkCRUDMark";
            this.MarkCRUDMark.Size = new System.Drawing.Size(31, 13);
            this.MarkCRUDMark.TabIndex = 1;
            this.MarkCRUDMark.Text = "Mark";
            // 
            // MarkCreateBtn
            // 
            this.MarkCreateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MarkCreateBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.MarkCreateBtn.FlatAppearance.BorderSize = 0;
            this.MarkCreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MarkCreateBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarkCreateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MarkCreateBtn.Location = new System.Drawing.Point(43, 187);
            this.MarkCreateBtn.Name = "MarkCreateBtn";
            this.MarkCreateBtn.Size = new System.Drawing.Size(311, 36);
            this.MarkCreateBtn.TabIndex = 2;
            this.MarkCreateBtn.Text = "Create";
            this.MarkCreateBtn.UseVisualStyleBackColor = false;
            this.MarkCreateBtn.Click += new System.EventHandler(this.MarkCreateBtn_Click);
            // 
            // MarkCRUDGroupID
            // 
            this.MarkCRUDGroupID.AutoSize = true;
            this.MarkCRUDGroupID.Location = new System.Drawing.Point(40, 93);
            this.MarkCRUDGroupID.Name = "MarkCRUDGroupID";
            this.MarkCRUDGroupID.Size = new System.Drawing.Size(31, 13);
            this.MarkCRUDGroupID.TabIndex = 1;
            this.MarkCRUDGroupID.Text = "Task";
            // 
            // MarkCRUDStudentID
            // 
            this.MarkCRUDStudentID.AutoSize = true;
            this.MarkCRUDStudentID.Location = new System.Drawing.Point(40, 51);
            this.MarkCRUDStudentID.Name = "MarkCRUDStudentID";
            this.MarkCRUDStudentID.Size = new System.Drawing.Size(44, 13);
            this.MarkCRUDStudentID.TabIndex = 1;
            this.MarkCRUDStudentID.Text = "Student";
            // 
            // dgvMarkCreate
            // 
            this.dgvMarkCreate.AllowUserToAddRows = false;
            this.dgvMarkCreate.AllowUserToDeleteRows = false;
            this.dgvMarkCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMarkCreate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarkCreate.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            this.dgvMarkCreate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarkCreate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMarkCRUDİd,
            this.ColumnMarkCRUDStudentID,
            this.ColumnMArkCRUDGroupID,
            this.ColumnMarkMark});
            this.dgvMarkCreate.Location = new System.Drawing.Point(390, 0);
            this.dgvMarkCreate.Name = "dgvMarkCreate";
            this.dgvMarkCreate.Size = new System.Drawing.Size(314, 368);
            this.dgvMarkCreate.TabIndex = 27;
            this.dgvMarkCreate.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvMarkCreate_CellMouseDoubleClick);
            // 
            // ColumnMarkCRUDİd
            // 
            this.ColumnMarkCRUDİd.HeaderText = "İd";
            this.ColumnMarkCRUDİd.Name = "ColumnMarkCRUDİd";
            this.ColumnMarkCRUDİd.Visible = false;
            // 
            // ColumnMarkCRUDStudentID
            // 
            this.ColumnMarkCRUDStudentID.HeaderText = "Student";
            this.ColumnMarkCRUDStudentID.Name = "ColumnMarkCRUDStudentID";
            this.ColumnMarkCRUDStudentID.ReadOnly = true;
            // 
            // ColumnMArkCRUDGroupID
            // 
            this.ColumnMArkCRUDGroupID.HeaderText = "Task";
            this.ColumnMArkCRUDGroupID.Name = "ColumnMArkCRUDGroupID";
            this.ColumnMArkCRUDGroupID.ReadOnly = true;
            // 
            // ColumnMarkMark
            // 
            this.ColumnMarkMark.HeaderText = "Mark";
            this.ColumnMarkMark.Name = "ColumnMarkMark";
            this.ColumnMarkMark.ReadOnly = true;
            // 
            // CheckedBtn
            // 
            this.CheckedBtn.BackColor = System.Drawing.Color.Olive;
            this.CheckedBtn.FlatAppearance.BorderSize = 0;
            this.CheckedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckedBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckedBtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.CheckedBtn.Location = new System.Drawing.Point(43, 306);
            this.CheckedBtn.Name = "CheckedBtn";
            this.CheckedBtn.Size = new System.Drawing.Size(311, 37);
            this.CheckedBtn.TabIndex = 8;
            this.CheckedBtn.Text = "Checked Marks";
            this.CheckedBtn.UseVisualStyleBackColor = false;
            this.CheckedBtn.Click += new System.EventHandler(this.CheckedBtn_Click);
            // 
            // MarkCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 368);
            this.Controls.Add(this.dgvMarkCreate);
            this.Controls.Add(this.panelEmail);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MarkCRUD";
            this.Text = "Marks";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MarkCRUD_FormClosed);
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkCreate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.Button MarkDeleteBtn;
        private System.Windows.Forms.Button MarkUpdateBtn;
        private System.Windows.Forms.Button MarkResetBtn;
        private System.Windows.Forms.Button MarkCreateBtn;
        private System.Windows.Forms.Label MarkCRUDGroupID;
        private System.Windows.Forms.Label MarkCRUDStudentID;
        private System.Windows.Forms.DataGridView dgvMarkCreate;
        private System.Windows.Forms.Label MarkCRUDMark;
        private System.Windows.Forms.ComboBox cbMarkTaskID;
        private System.Windows.Forms.ComboBox cbMarkStudentID;
        private System.Windows.Forms.TextBox MarkTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMarkCRUDİd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMarkCRUDStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMArkCRUDGroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMarkMark;
        private System.Windows.Forms.Button CheckedBtn;
    }
}
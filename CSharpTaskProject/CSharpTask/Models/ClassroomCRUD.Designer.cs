namespace CSharpTask.Models
{
    partial class ClassroomCRUD
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
            this.ClassroomDeleteBtn = new System.Windows.Forms.Button();
            this.ClassroomUpdateBtn = new System.Windows.Forms.Button();
            this.ClassroomResetBtn = new System.Windows.Forms.Button();
            this.ClassroomCreateBtn = new System.Windows.Forms.Button();
            this.ClassCRUDName = new System.Windows.Forms.Label();
            this.ClassNameTxt = new System.Windows.Forms.TextBox();
            this.dgvClassCreate = new System.Windows.Forms.DataGridView();
            this.ColumnClassCRUDİd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClassCRUDName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassCreate)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEmail
            // 
            this.panelEmail.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelEmail.Controls.Add(this.ClassroomDeleteBtn);
            this.panelEmail.Controls.Add(this.ClassroomUpdateBtn);
            this.panelEmail.Controls.Add(this.ClassroomResetBtn);
            this.panelEmail.Controls.Add(this.ClassroomCreateBtn);
            this.panelEmail.Controls.Add(this.ClassCRUDName);
            this.panelEmail.Controls.Add(this.ClassNameTxt);
            this.panelEmail.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEmail.Location = new System.Drawing.Point(0, 0);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(384, 228);
            this.panelEmail.TabIndex = 26;
            // 
            // ClassroomDeleteBtn
            // 
            this.ClassroomDeleteBtn.BackColor = System.Drawing.Color.Red;
            this.ClassroomDeleteBtn.FlatAppearance.BorderSize = 0;
            this.ClassroomDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClassroomDeleteBtn.Location = new System.Drawing.Point(141, 151);
            this.ClassroomDeleteBtn.Name = "ClassroomDeleteBtn";
            this.ClassroomDeleteBtn.Size = new System.Drawing.Size(110, 34);
            this.ClassroomDeleteBtn.TabIndex = 3;
            this.ClassroomDeleteBtn.Text = "Delete";
            this.ClassroomDeleteBtn.UseVisualStyleBackColor = false;
            this.ClassroomDeleteBtn.Click += new System.EventHandler(this.ClassroomDeleteBtn_Click);
            // 
            // ClassroomUpdateBtn
            // 
            this.ClassroomUpdateBtn.BackColor = System.Drawing.Color.Yellow;
            this.ClassroomUpdateBtn.FlatAppearance.BorderSize = 0;
            this.ClassroomUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClassroomUpdateBtn.Location = new System.Drawing.Point(41, 151);
            this.ClassroomUpdateBtn.Name = "ClassroomUpdateBtn";
            this.ClassroomUpdateBtn.Size = new System.Drawing.Size(94, 34);
            this.ClassroomUpdateBtn.TabIndex = 3;
            this.ClassroomUpdateBtn.Text = "Update";
            this.ClassroomUpdateBtn.UseVisualStyleBackColor = false;
            this.ClassroomUpdateBtn.Click += new System.EventHandler(this.ClassroomUpdateBtn_Click);
            // 
            // ClassroomResetBtn
            // 
            this.ClassroomResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClassroomResetBtn.FlatAppearance.BorderSize = 0;
            this.ClassroomResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClassroomResetBtn.Location = new System.Drawing.Point(257, 151);
            this.ClassroomResetBtn.Name = "ClassroomResetBtn";
            this.ClassroomResetBtn.Size = new System.Drawing.Size(95, 34);
            this.ClassroomResetBtn.TabIndex = 3;
            this.ClassroomResetBtn.Text = "Reset";
            this.ClassroomResetBtn.UseVisualStyleBackColor = false;
            this.ClassroomResetBtn.Click += new System.EventHandler(this.ClassroomResetBtn_Click);
            // 
            // ClassroomCreateBtn
            // 
            this.ClassroomCreateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClassroomCreateBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.ClassroomCreateBtn.FlatAppearance.BorderSize = 0;
            this.ClassroomCreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClassroomCreateBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassroomCreateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClassroomCreateBtn.Location = new System.Drawing.Point(41, 101);
            this.ClassroomCreateBtn.Name = "ClassroomCreateBtn";
            this.ClassroomCreateBtn.Size = new System.Drawing.Size(311, 36);
            this.ClassroomCreateBtn.TabIndex = 2;
            this.ClassroomCreateBtn.Text = "Create";
            this.ClassroomCreateBtn.UseVisualStyleBackColor = false;
            this.ClassroomCreateBtn.Click += new System.EventHandler(this.ClassroomCreateBtn_Click);
            // 
            // ClassCRUDName
            // 
            this.ClassCRUDName.AutoSize = true;
            this.ClassCRUDName.Location = new System.Drawing.Point(38, 30);
            this.ClassCRUDName.Name = "ClassCRUDName";
            this.ClassCRUDName.Size = new System.Drawing.Size(35, 13);
            this.ClassCRUDName.TabIndex = 1;
            this.ClassCRUDName.Text = "Name";
            // 
            // ClassNameTxt
            // 
            this.ClassNameTxt.BackColor = System.Drawing.Color.IndianRed;
            this.ClassNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassNameTxt.Location = new System.Drawing.Point(121, 22);
            this.ClassNameTxt.Name = "ClassNameTxt";
            this.ClassNameTxt.Size = new System.Drawing.Size(231, 26);
            this.ClassNameTxt.TabIndex = 0;
            // 
            // dgvClassCreate
            // 
            this.dgvClassCreate.AllowUserToAddRows = false;
            this.dgvClassCreate.AllowUserToDeleteRows = false;
            this.dgvClassCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClassCreate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClassCreate.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            this.dgvClassCreate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassCreate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnClassCRUDİd,
            this.ColumnClassCRUDName});
            this.dgvClassCreate.Location = new System.Drawing.Point(390, 0);
            this.dgvClassCreate.Name = "dgvClassCreate";
            this.dgvClassCreate.Size = new System.Drawing.Size(257, 228);
            this.dgvClassCreate.TabIndex = 27;
            this.dgvClassCreate.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvClassCreate_CellMouseDoubleClick);
            // 
            // ColumnClassCRUDİd
            // 
            this.ColumnClassCRUDİd.HeaderText = "İd";
            this.ColumnClassCRUDİd.Name = "ColumnClassCRUDİd";
            this.ColumnClassCRUDİd.Visible = false;
            // 
            // ColumnClassCRUDName
            // 
            this.ColumnClassCRUDName.HeaderText = "Name";
            this.ColumnClassCRUDName.Name = "ColumnClassCRUDName";
            this.ColumnClassCRUDName.ReadOnly = true;
            // 
            // ClassroomCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 228);
            this.Controls.Add(this.dgvClassCreate);
            this.Controls.Add(this.panelEmail);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClassroomCRUD";
            this.Text = "ClassroomCRUD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClassroomCRUD_FormClosed);
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassCreate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.Button ClassroomDeleteBtn;
        private System.Windows.Forms.Button ClassroomUpdateBtn;
        private System.Windows.Forms.Button ClassroomResetBtn;
        private System.Windows.Forms.Button ClassroomCreateBtn;
        private System.Windows.Forms.Label ClassCRUDName;
        private System.Windows.Forms.TextBox ClassNameTxt;
        private System.Windows.Forms.DataGridView dgvClassCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClassCRUDİd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClassCRUDName;
    }
}
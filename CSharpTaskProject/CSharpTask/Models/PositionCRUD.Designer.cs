namespace CSharpTask.Models
{
    partial class PositionCRUD
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
            this.PositionDeleteBtn = new System.Windows.Forms.Button();
            this.PositionUpdateBtn = new System.Windows.Forms.Button();
            this.PositionResetBtn = new System.Windows.Forms.Button();
            this.PositionCreateBtn = new System.Windows.Forms.Button();
            this.PosCRUDName = new System.Windows.Forms.Label();
            this.PositionNameTxt = new System.Windows.Forms.TextBox();
            this.dgvPositionCreate = new System.Windows.Forms.DataGridView();
            this.ColumnPosCRUDİd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPosCRUDName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositionCreate)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEmail
            // 
            this.panelEmail.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelEmail.Controls.Add(this.PositionDeleteBtn);
            this.panelEmail.Controls.Add(this.PositionUpdateBtn);
            this.panelEmail.Controls.Add(this.PositionResetBtn);
            this.panelEmail.Controls.Add(this.PositionCreateBtn);
            this.panelEmail.Controls.Add(this.PosCRUDName);
            this.panelEmail.Controls.Add(this.PositionNameTxt);
            this.panelEmail.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEmail.Location = new System.Drawing.Point(0, 0);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(384, 230);
            this.panelEmail.TabIndex = 28;
            // 
            // PositionDeleteBtn
            // 
            this.PositionDeleteBtn.BackColor = System.Drawing.Color.Red;
            this.PositionDeleteBtn.FlatAppearance.BorderSize = 0;
            this.PositionDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PositionDeleteBtn.Location = new System.Drawing.Point(139, 136);
            this.PositionDeleteBtn.Name = "PositionDeleteBtn";
            this.PositionDeleteBtn.Size = new System.Drawing.Size(110, 34);
            this.PositionDeleteBtn.TabIndex = 3;
            this.PositionDeleteBtn.Text = "Delete";
            this.PositionDeleteBtn.UseVisualStyleBackColor = false;
            this.PositionDeleteBtn.Click += new System.EventHandler(this.PositionDeleteBtn_Click_1);
            // 
            // PositionUpdateBtn
            // 
            this.PositionUpdateBtn.BackColor = System.Drawing.Color.Yellow;
            this.PositionUpdateBtn.FlatAppearance.BorderSize = 0;
            this.PositionUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PositionUpdateBtn.Location = new System.Drawing.Point(39, 136);
            this.PositionUpdateBtn.Name = "PositionUpdateBtn";
            this.PositionUpdateBtn.Size = new System.Drawing.Size(94, 34);
            this.PositionUpdateBtn.TabIndex = 3;
            this.PositionUpdateBtn.Text = "Update";
            this.PositionUpdateBtn.UseVisualStyleBackColor = false;
            this.PositionUpdateBtn.Click += new System.EventHandler(this.PositionUpdateBtn_Click_1);
            // 
            // PositionResetBtn
            // 
            this.PositionResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PositionResetBtn.FlatAppearance.BorderSize = 0;
            this.PositionResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PositionResetBtn.Location = new System.Drawing.Point(255, 136);
            this.PositionResetBtn.Name = "PositionResetBtn";
            this.PositionResetBtn.Size = new System.Drawing.Size(95, 34);
            this.PositionResetBtn.TabIndex = 3;
            this.PositionResetBtn.Text = "Reset";
            this.PositionResetBtn.UseVisualStyleBackColor = false;
            this.PositionResetBtn.Click += new System.EventHandler(this.PositionResetBtn_Click_1);
            // 
            // PositionCreateBtn
            // 
            this.PositionCreateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PositionCreateBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.PositionCreateBtn.FlatAppearance.BorderSize = 0;
            this.PositionCreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PositionCreateBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionCreateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PositionCreateBtn.Location = new System.Drawing.Point(39, 94);
            this.PositionCreateBtn.Name = "PositionCreateBtn";
            this.PositionCreateBtn.Size = new System.Drawing.Size(311, 36);
            this.PositionCreateBtn.TabIndex = 2;
            this.PositionCreateBtn.Text = "Create";
            this.PositionCreateBtn.UseVisualStyleBackColor = false;
            this.PositionCreateBtn.Click += new System.EventHandler(this.PositionCreateBtn_Click_1);
            // 
            // PosCRUDName
            // 
            this.PosCRUDName.AutoSize = true;
            this.PosCRUDName.Location = new System.Drawing.Point(38, 30);
            this.PosCRUDName.Name = "PosCRUDName";
            this.PosCRUDName.Size = new System.Drawing.Size(35, 13);
            this.PosCRUDName.TabIndex = 1;
            this.PosCRUDName.Text = "Name";
            // 
            // PositionNameTxt
            // 
            this.PositionNameTxt.BackColor = System.Drawing.Color.IndianRed;
            this.PositionNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionNameTxt.Location = new System.Drawing.Point(121, 22);
            this.PositionNameTxt.Name = "PositionNameTxt";
            this.PositionNameTxt.Size = new System.Drawing.Size(231, 26);
            this.PositionNameTxt.TabIndex = 0;
            // 
            // dgvPositionCreate
            // 
            this.dgvPositionCreate.AllowUserToAddRows = false;
            this.dgvPositionCreate.AllowUserToDeleteRows = false;
            this.dgvPositionCreate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPositionCreate.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            this.dgvPositionCreate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPositionCreate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPosCRUDİd,
            this.ColumnPosCRUDName});
            this.dgvPositionCreate.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvPositionCreate.Location = new System.Drawing.Point(390, 0);
            this.dgvPositionCreate.Name = "dgvPositionCreate";
            this.dgvPositionCreate.Size = new System.Drawing.Size(235, 230);
            this.dgvPositionCreate.TabIndex = 29;
            this.dgvPositionCreate.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvPositionCreate_CellMouseDoubleClick_1);
            // 
            // ColumnPosCRUDİd
            // 
            this.ColumnPosCRUDİd.HeaderText = "İd";
            this.ColumnPosCRUDİd.Name = "ColumnPosCRUDİd";
            this.ColumnPosCRUDİd.Visible = false;
            // 
            // ColumnPosCRUDName
            // 
            this.ColumnPosCRUDName.HeaderText = "Name";
            this.ColumnPosCRUDName.Name = "ColumnPosCRUDName";
            this.ColumnPosCRUDName.ReadOnly = true;
            // 
            // PositionCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 230);
            this.Controls.Add(this.dgvPositionCreate);
            this.Controls.Add(this.panelEmail);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PositionCRUD";
            this.Text = "PositionCRUD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PositionCRUD_FormClosed_1);
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositionCreate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.Button PositionDeleteBtn;
        private System.Windows.Forms.Button PositionUpdateBtn;
        private System.Windows.Forms.Button PositionResetBtn;
        private System.Windows.Forms.Button PositionCreateBtn;
        private System.Windows.Forms.Label PosCRUDName;
        private System.Windows.Forms.TextBox PositionNameTxt;
        private System.Windows.Forms.DataGridView dgvPositionCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPosCRUDİd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPosCRUDName;
    }
}
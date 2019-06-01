namespace CSharpTask.Models
{
    partial class Education_ProqramsCRUD
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
            this.dgvEduCreate = new System.Windows.Forms.DataGridView();
            this.ColumnEduCRUDİd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEduCRUDName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEduCRUDPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EduNameTxt = new System.Windows.Forms.TextBox();
            this.EduPriceTxt = new System.Windows.Forms.TextBox();
            this.EduCRUDName = new System.Windows.Forms.Label();
            this.EduCreateBtn = new System.Windows.Forms.Button();
            this.EduResetBtn = new System.Windows.Forms.Button();
            this.EduUpdateBtn = new System.Windows.Forms.Button();
            this.EduDeleteBtn = new System.Windows.Forms.Button();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.EduCRUDPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEduCreate)).BeginInit();
            this.panelEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEduCreate
            // 
            this.dgvEduCreate.AllowUserToAddRows = false;
            this.dgvEduCreate.AllowUserToDeleteRows = false;
            this.dgvEduCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEduCreate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEduCreate.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            this.dgvEduCreate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEduCreate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnEduCRUDİd,
            this.ColumnEduCRUDName,
            this.ColumnEduCRUDPrice});
            this.dgvEduCreate.Location = new System.Drawing.Point(379, 0);
            this.dgvEduCreate.Name = "dgvEduCreate";
            this.dgvEduCreate.Size = new System.Drawing.Size(296, 260);
            this.dgvEduCreate.TabIndex = 26;
            this.dgvEduCreate.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvEduCreate_CellMouseDoubleClick);
            // 
            // ColumnEduCRUDİd
            // 
            this.ColumnEduCRUDİd.HeaderText = "İd";
            this.ColumnEduCRUDİd.Name = "ColumnEduCRUDİd";
            this.ColumnEduCRUDİd.Visible = false;
            // 
            // ColumnEduCRUDName
            // 
            this.ColumnEduCRUDName.HeaderText = "Name";
            this.ColumnEduCRUDName.Name = "ColumnEduCRUDName";
            this.ColumnEduCRUDName.ReadOnly = true;
            // 
            // ColumnEduCRUDPrice
            // 
            this.ColumnEduCRUDPrice.HeaderText = "Price";
            this.ColumnEduCRUDPrice.Name = "ColumnEduCRUDPrice";
            this.ColumnEduCRUDPrice.ReadOnly = true;
            // 
            // EduNameTxt
            // 
            this.EduNameTxt.BackColor = System.Drawing.Color.IndianRed;
            this.EduNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EduNameTxt.Location = new System.Drawing.Point(121, 22);
            this.EduNameTxt.Name = "EduNameTxt";
            this.EduNameTxt.Size = new System.Drawing.Size(231, 22);
            this.EduNameTxt.TabIndex = 0;
            // 
            // EduPriceTxt
            // 
            this.EduPriceTxt.BackColor = System.Drawing.Color.IndianRed;
            this.EduPriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EduPriceTxt.Location = new System.Drawing.Point(121, 63);
            this.EduPriceTxt.Name = "EduPriceTxt";
            this.EduPriceTxt.Size = new System.Drawing.Size(231, 22);
            this.EduPriceTxt.TabIndex = 4;
            // 
            // EduCRUDName
            // 
            this.EduCRUDName.AutoSize = true;
            this.EduCRUDName.Location = new System.Drawing.Point(38, 27);
            this.EduCRUDName.Name = "EduCRUDName";
            this.EduCRUDName.Size = new System.Drawing.Size(35, 13);
            this.EduCRUDName.TabIndex = 1;
            this.EduCRUDName.Text = "Name";
            // 
            // EduCreateBtn
            // 
            this.EduCreateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.EduCreateBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.EduCreateBtn.FlatAppearance.BorderSize = 0;
            this.EduCreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EduCreateBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EduCreateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EduCreateBtn.Location = new System.Drawing.Point(41, 142);
            this.EduCreateBtn.Name = "EduCreateBtn";
            this.EduCreateBtn.Size = new System.Drawing.Size(311, 36);
            this.EduCreateBtn.TabIndex = 2;
            this.EduCreateBtn.Text = "Create";
            this.EduCreateBtn.UseVisualStyleBackColor = false;
            this.EduCreateBtn.Click += new System.EventHandler(this.EduCreateBtn_Click);
            // 
            // EduResetBtn
            // 
            this.EduResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EduResetBtn.FlatAppearance.BorderSize = 0;
            this.EduResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EduResetBtn.Location = new System.Drawing.Point(257, 192);
            this.EduResetBtn.Name = "EduResetBtn";
            this.EduResetBtn.Size = new System.Drawing.Size(95, 34);
            this.EduResetBtn.TabIndex = 3;
            this.EduResetBtn.Text = "Reset";
            this.EduResetBtn.UseVisualStyleBackColor = false;
            this.EduResetBtn.Click += new System.EventHandler(this.EduResetBtn_Click);
            // 
            // EduUpdateBtn
            // 
            this.EduUpdateBtn.BackColor = System.Drawing.Color.Yellow;
            this.EduUpdateBtn.FlatAppearance.BorderSize = 0;
            this.EduUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EduUpdateBtn.Location = new System.Drawing.Point(41, 192);
            this.EduUpdateBtn.Name = "EduUpdateBtn";
            this.EduUpdateBtn.Size = new System.Drawing.Size(94, 34);
            this.EduUpdateBtn.TabIndex = 3;
            this.EduUpdateBtn.Text = "Update";
            this.EduUpdateBtn.UseVisualStyleBackColor = false;
            this.EduUpdateBtn.Click += new System.EventHandler(this.EduUpdateBtn_Click);
            // 
            // EduDeleteBtn
            // 
            this.EduDeleteBtn.BackColor = System.Drawing.Color.Red;
            this.EduDeleteBtn.FlatAppearance.BorderSize = 0;
            this.EduDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EduDeleteBtn.Location = new System.Drawing.Point(141, 192);
            this.EduDeleteBtn.Name = "EduDeleteBtn";
            this.EduDeleteBtn.Size = new System.Drawing.Size(110, 34);
            this.EduDeleteBtn.TabIndex = 3;
            this.EduDeleteBtn.Text = "Delete";
            this.EduDeleteBtn.UseVisualStyleBackColor = false;
            this.EduDeleteBtn.Click += new System.EventHandler(this.EduDeleteBtn_Click);
            // 
            // panelEmail
            // 
            this.panelEmail.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelEmail.Controls.Add(this.EduDeleteBtn);
            this.panelEmail.Controls.Add(this.EduUpdateBtn);
            this.panelEmail.Controls.Add(this.EduResetBtn);
            this.panelEmail.Controls.Add(this.EduCreateBtn);
            this.panelEmail.Controls.Add(this.EduCRUDPrice);
            this.panelEmail.Controls.Add(this.EduCRUDName);
            this.panelEmail.Controls.Add(this.EduPriceTxt);
            this.panelEmail.Controls.Add(this.EduNameTxt);
            this.panelEmail.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEmail.Location = new System.Drawing.Point(0, 0);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(384, 260);
            this.panelEmail.TabIndex = 25;
            // 
            // EduCRUDPrice
            // 
            this.EduCRUDPrice.AutoSize = true;
            this.EduCRUDPrice.Location = new System.Drawing.Point(38, 68);
            this.EduCRUDPrice.Name = "EduCRUDPrice";
            this.EduCRUDPrice.Size = new System.Drawing.Size(31, 13);
            this.EduCRUDPrice.TabIndex = 1;
            this.EduCRUDPrice.Text = "Price";
            // 
            // Education_ProqramsCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 260);
            this.Controls.Add(this.dgvEduCreate);
            this.Controls.Add(this.panelEmail);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Education_ProqramsCRUD";
            this.Text = "Education_ProqramsCRUD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Education_ProqramsCRUD_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEduCreate)).EndInit();
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEduCreate;
        private System.Windows.Forms.TextBox EduNameTxt;
        private System.Windows.Forms.TextBox EduPriceTxt;
        private System.Windows.Forms.Label EduCRUDName;
        private System.Windows.Forms.Button EduCreateBtn;
        private System.Windows.Forms.Button EduResetBtn;
        private System.Windows.Forms.Button EduUpdateBtn;
        private System.Windows.Forms.Button EduDeleteBtn;
        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.Label EduCRUDPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEduCRUDİd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEduCRUDName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEduCRUDPrice;
    }
}
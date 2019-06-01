namespace CSharpTask.Models
{
    partial class Education_ProqramSearch
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
            this.EducationSearchText = new System.Windows.Forms.TextBox();
            this.EducationSearchBtn = new System.Windows.Forms.Button();
            this.dgvEducationSrch = new System.Windows.Forms.DataGridView();
            this.ColumnEduID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEduName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEduPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEducationSrch)).BeginInit();
            this.SuspendLayout();
            // 
            // EducationSearchText
            // 
            this.EducationSearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EducationSearchText.Location = new System.Drawing.Point(3, 12);
            this.EducationSearchText.Name = "EducationSearchText";
            this.EducationSearchText.Size = new System.Drawing.Size(224, 31);
            this.EducationSearchText.TabIndex = 17;
            // 
            // EducationSearchBtn
            // 
            this.EducationSearchBtn.Location = new System.Drawing.Point(233, 11);
            this.EducationSearchBtn.Name = "EducationSearchBtn";
            this.EducationSearchBtn.Size = new System.Drawing.Size(75, 32);
            this.EducationSearchBtn.TabIndex = 16;
            this.EducationSearchBtn.Text = "Search";
            this.EducationSearchBtn.UseVisualStyleBackColor = true;
            this.EducationSearchBtn.Click += new System.EventHandler(this.EducationSearchBtn_Click_1);
            // 
            // dgvEducationSrch
            // 
            this.dgvEducationSrch.AllowUserToAddRows = false;
            this.dgvEducationSrch.AllowUserToDeleteRows = false;
            this.dgvEducationSrch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEducationSrch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEducationSrch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEducationSrch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnEduID,
            this.ColumnEduName,
            this.ColumnEduPrice});
            this.dgvEducationSrch.Location = new System.Drawing.Point(3, 63);
            this.dgvEducationSrch.Name = "dgvEducationSrch";
            this.dgvEducationSrch.Size = new System.Drawing.Size(321, 195);
            this.dgvEducationSrch.TabIndex = 15;
            // 
            // ColumnEduID
            // 
            this.ColumnEduID.HeaderText = "Id";
            this.ColumnEduID.Name = "ColumnEduID";
            this.ColumnEduID.Visible = false;
            // 
            // ColumnEduName
            // 
            this.ColumnEduName.HeaderText = "Name";
            this.ColumnEduName.Name = "ColumnEduName";
            this.ColumnEduName.ReadOnly = true;
            // 
            // ColumnEduPrice
            // 
            this.ColumnEduPrice.HeaderText = "Price";
            this.ColumnEduPrice.Name = "ColumnEduPrice";
            this.ColumnEduPrice.ReadOnly = true;
            // 
            // Education_ProqramSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 253);
            this.Controls.Add(this.EducationSearchText);
            this.Controls.Add(this.EducationSearchBtn);
            this.Controls.Add(this.dgvEducationSrch);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Education_ProqramSearch";
            this.Text = "Education_ProqramSearch";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Education_ProqramSearch_FormClosed);
            this.Load += new System.EventHandler(this.Education_ProqramSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEducationSrch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EducationSearchText;
        private System.Windows.Forms.Button EducationSearchBtn;
        private System.Windows.Forms.DataGridView dgvEducationSrch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEduID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEduName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEduPrice;
    }
}
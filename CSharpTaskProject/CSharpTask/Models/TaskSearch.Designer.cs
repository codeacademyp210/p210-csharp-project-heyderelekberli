namespace CSharpTask.Models
{
    partial class TaskSearch
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
            this.TaskSearchText = new System.Windows.Forms.TextBox();
            this.TaskSearchBtn = new System.Windows.Forms.Button();
            this.dgvTaskSrch = new System.Windows.Forms.DataGridView();
            this.ColumnTaskID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTaskDeadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTaskGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterByDeadlineOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterByDeadlineOnnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskSrch)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TaskSearchText
            // 
            this.TaskSearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskSearchText.Location = new System.Drawing.Point(12, 47);
            this.TaskSearchText.Name = "TaskSearchText";
            this.TaskSearchText.Size = new System.Drawing.Size(302, 31);
            this.TaskSearchText.TabIndex = 20;
            // 
            // TaskSearchBtn
            // 
            this.TaskSearchBtn.Location = new System.Drawing.Point(320, 46);
            this.TaskSearchBtn.Name = "TaskSearchBtn";
            this.TaskSearchBtn.Size = new System.Drawing.Size(75, 32);
            this.TaskSearchBtn.TabIndex = 19;
            this.TaskSearchBtn.Text = "Search";
            this.TaskSearchBtn.UseVisualStyleBackColor = true;
            this.TaskSearchBtn.Click += new System.EventHandler(this.TaskSearchBtn_Click_1);
            // 
            // dgvTaskSrch
            // 
            this.dgvTaskSrch.AllowUserToAddRows = false;
            this.dgvTaskSrch.AllowUserToDeleteRows = false;
            this.dgvTaskSrch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTaskSrch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaskSrch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaskSrch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTaskID,
            this.ColumnTaskName,
            this.ColumnTaskDeadline,
            this.ColumnTaskGroup});
            this.dgvTaskSrch.Location = new System.Drawing.Point(12, 97);
            this.dgvTaskSrch.Name = "dgvTaskSrch";
            this.dgvTaskSrch.Size = new System.Drawing.Size(383, 256);
            this.dgvTaskSrch.TabIndex = 18;
            // 
            // ColumnTaskID
            // 
            this.ColumnTaskID.HeaderText = "Id";
            this.ColumnTaskID.Name = "ColumnTaskID";
            this.ColumnTaskID.Visible = false;
            // 
            // ColumnTaskName
            // 
            this.ColumnTaskName.HeaderText = "Name";
            this.ColumnTaskName.Name = "ColumnTaskName";
            this.ColumnTaskName.ReadOnly = true;
            // 
            // ColumnTaskDeadline
            // 
            this.ColumnTaskDeadline.HeaderText = "Deadline";
            this.ColumnTaskDeadline.Name = "ColumnTaskDeadline";
            this.ColumnTaskDeadline.ReadOnly = true;
            // 
            // ColumnTaskGroup
            // 
            this.ColumnTaskGroup.HeaderText = "Group";
            this.ColumnTaskGroup.Name = "ColumnTaskGroup";
            this.ColumnTaskGroup.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(407, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterByDeadlineOffToolStripMenuItem,
            this.filterByDeadlineOnnToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // filterByDeadlineOffToolStripMenuItem
            // 
            this.filterByDeadlineOffToolStripMenuItem.Name = "filterByDeadlineOffToolStripMenuItem";
            this.filterByDeadlineOffToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.filterByDeadlineOffToolStripMenuItem.Text = "Filter by Deadline Off";
            this.filterByDeadlineOffToolStripMenuItem.Click += new System.EventHandler(this.FilterByDeadlineOffToolStripMenuItem_Click_1);
            // 
            // filterByDeadlineOnnToolStripMenuItem
            // 
            this.filterByDeadlineOnnToolStripMenuItem.Name = "filterByDeadlineOnnToolStripMenuItem";
            this.filterByDeadlineOnnToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.filterByDeadlineOnnToolStripMenuItem.Text = "Filter by Deadline Onn";
            // 
            // TaskSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 348);
            this.Controls.Add(this.TaskSearchText);
            this.Controls.Add(this.TaskSearchBtn);
            this.Controls.Add(this.dgvTaskSrch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskSearch";
            this.Text = "TaskSearch";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TaskSearch_FormClosed_1);
            this.Load += new System.EventHandler(this.TaskSearch_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskSrch)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TaskSearchText;
        private System.Windows.Forms.Button TaskSearchBtn;
        private System.Windows.Forms.DataGridView dgvTaskSrch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTaskID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTaskDeadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTaskGroup;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterByDeadlineOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterByDeadlineOnnToolStripMenuItem;
    }
}
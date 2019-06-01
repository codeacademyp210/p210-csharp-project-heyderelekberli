namespace CSharpTask.Models
{
    partial class CheckedMarkForm
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
            this.dgvMarkCreate = new System.Windows.Forms.DataGridView();
            this.cbCheckedGroup = new System.Windows.Forms.ComboBox();
            this.ChooseBtn = new System.Windows.Forms.Button();
            this.ColumnMarkCRUDİd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMarkCRUDStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMArkCRUDGroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMarkTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCheckedMarkGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMarkChecked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterByMarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upper50ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beetween50ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkCreate)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.ColumnMarkTask,
            this.ColumnCheckedMarkGroup,
            this.ColumnMarkChecked});
            this.dgvMarkCreate.Location = new System.Drawing.Point(0, 102);
            this.dgvMarkCreate.Name = "dgvMarkCreate";
            this.dgvMarkCreate.Size = new System.Drawing.Size(478, 314);
            this.dgvMarkCreate.TabIndex = 28;
            // 
            // cbCheckedGroup
            // 
            this.cbCheckedGroup.BackColor = System.Drawing.Color.IndianRed;
            this.cbCheckedGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCheckedGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCheckedGroup.FormattingEnabled = true;
            this.cbCheckedGroup.Location = new System.Drawing.Point(0, 54);
            this.cbCheckedGroup.Name = "cbCheckedGroup";
            this.cbCheckedGroup.Size = new System.Drawing.Size(349, 33);
            this.cbCheckedGroup.TabIndex = 29;
            // 
            // ChooseBtn
            // 
            this.ChooseBtn.Location = new System.Drawing.Point(366, 54);
            this.ChooseBtn.Name = "ChooseBtn";
            this.ChooseBtn.Size = new System.Drawing.Size(75, 33);
            this.ChooseBtn.TabIndex = 30;
            this.ChooseBtn.Text = "Choose";
            this.ChooseBtn.UseVisualStyleBackColor = true;
            this.ChooseBtn.Click += new System.EventHandler(this.ChooseBtn_Click);
            // 
            // ColumnMarkCRUDİd
            // 
            this.ColumnMarkCRUDİd.HeaderText = "İd";
            this.ColumnMarkCRUDİd.Name = "ColumnMarkCRUDİd";
            this.ColumnMarkCRUDİd.Visible = false;
            // 
            // ColumnMarkCRUDStudentID
            // 
            this.ColumnMarkCRUDStudentID.HeaderText = "Name";
            this.ColumnMarkCRUDStudentID.Name = "ColumnMarkCRUDStudentID";
            this.ColumnMarkCRUDStudentID.ReadOnly = true;
            // 
            // ColumnMArkCRUDGroupID
            // 
            this.ColumnMArkCRUDGroupID.HeaderText = "Surname";
            this.ColumnMArkCRUDGroupID.Name = "ColumnMArkCRUDGroupID";
            this.ColumnMArkCRUDGroupID.ReadOnly = true;
            // 
            // ColumnMarkTask
            // 
            this.ColumnMarkTask.HeaderText = "Task";
            this.ColumnMarkTask.Name = "ColumnMarkTask";
            this.ColumnMarkTask.ReadOnly = true;
            // 
            // ColumnCheckedMarkGroup
            // 
            this.ColumnCheckedMarkGroup.HeaderText = "Group";
            this.ColumnCheckedMarkGroup.Name = "ColumnCheckedMarkGroup";
            this.ColumnCheckedMarkGroup.ReadOnly = true;
            // 
            // ColumnMarkChecked
            // 
            this.ColumnMarkChecked.HeaderText = "Mark";
            this.ColumnMarkChecked.Name = "ColumnMarkChecked";
            this.ColumnMarkChecked.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(477, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterByMarkToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // filterByMarkToolStripMenuItem
            // 
            this.filterByMarkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upper50ToolStripMenuItem,
            this.beetween50ToolStripMenuItem});
            this.filterByMarkToolStripMenuItem.Name = "filterByMarkToolStripMenuItem";
            this.filterByMarkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filterByMarkToolStripMenuItem.Text = "Filter by Mark";
            // 
            // upper50ToolStripMenuItem
            // 
            this.upper50ToolStripMenuItem.Name = "upper50ToolStripMenuItem";
            this.upper50ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.upper50ToolStripMenuItem.Text = "Upper 50";
            this.upper50ToolStripMenuItem.Click += new System.EventHandler(this.Upper50ToolStripMenuItem_Click);
            // 
            // beetween50ToolStripMenuItem
            // 
            this.beetween50ToolStripMenuItem.Name = "beetween50ToolStripMenuItem";
            this.beetween50ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.beetween50ToolStripMenuItem.Text = "Beetween 50 and 80";
            this.beetween50ToolStripMenuItem.Click += new System.EventHandler(this.Beetween50ToolStripMenuItem_Click);
            // 
            // CheckedMarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 417);
            this.Controls.Add(this.ChooseBtn);
            this.Controls.Add(this.cbCheckedGroup);
            this.Controls.Add(this.dgvMarkCreate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckedMarkForm";
            this.Text = "CheckedMarkForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CheckedMarkForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkCreate)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarkCreate;
        private System.Windows.Forms.ComboBox cbCheckedGroup;
        private System.Windows.Forms.Button ChooseBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMarkCRUDİd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMarkCRUDStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMArkCRUDGroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMarkTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCheckedMarkGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMarkChecked;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterByMarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upper50ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beetween50ToolStripMenuItem;
    }
}
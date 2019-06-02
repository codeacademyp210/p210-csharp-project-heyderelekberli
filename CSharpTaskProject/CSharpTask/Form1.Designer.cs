namespace CSharpTask
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.educationProqramToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.taskToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.classroomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.educationProqramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(655, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.Color.BurlyWood;
            this.newToolStripMenuItem.Checked = true;
            this.newToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem1,
            this.teacherToolStripMenuItem1,
            this.employeeToolStripMenuItem1,
            this.groupToolStripMenuItem1,
            this.educationProqramToolStripMenuItem1,
            this.taskToolStripMenuItem1,
            this.classroomToolStripMenuItem,
            this.positionToolStripMenuItem,
            this.markToolStripMenuItem});
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.newToolStripMenuItem.Text = "Create";
            // 
            // studentToolStripMenuItem1
            // 
            this.studentToolStripMenuItem1.Name = "studentToolStripMenuItem1";
            this.studentToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.studentToolStripMenuItem1.Text = "Student";
            this.studentToolStripMenuItem1.Click += new System.EventHandler(this.StudentToolStripMenuItem1_Click);
            // 
            // teacherToolStripMenuItem1
            // 
            this.teacherToolStripMenuItem1.Name = "teacherToolStripMenuItem1";
            this.teacherToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.teacherToolStripMenuItem1.Text = "Teacher";
            this.teacherToolStripMenuItem1.Click += new System.EventHandler(this.TeacherToolStripMenuItem1_Click);
            // 
            // employeeToolStripMenuItem1
            // 
            this.employeeToolStripMenuItem1.Name = "employeeToolStripMenuItem1";
            this.employeeToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.employeeToolStripMenuItem1.Text = "Employee";
            this.employeeToolStripMenuItem1.Click += new System.EventHandler(this.EmployeeToolStripMenuItem1_Click);
            // 
            // groupToolStripMenuItem1
            // 
            this.groupToolStripMenuItem1.Name = "groupToolStripMenuItem1";
            this.groupToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.groupToolStripMenuItem1.Text = "Group";
            this.groupToolStripMenuItem1.Click += new System.EventHandler(this.GroupToolStripMenuItem1_Click);
            // 
            // educationProqramToolStripMenuItem1
            // 
            this.educationProqramToolStripMenuItem1.Name = "educationProqramToolStripMenuItem1";
            this.educationProqramToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.educationProqramToolStripMenuItem1.Text = "Education Proqram";
            this.educationProqramToolStripMenuItem1.Click += new System.EventHandler(this.EducationProqramToolStripMenuItem1_Click);
            // 
            // taskToolStripMenuItem1
            // 
            this.taskToolStripMenuItem1.Name = "taskToolStripMenuItem1";
            this.taskToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.taskToolStripMenuItem1.Text = "Task";
            this.taskToolStripMenuItem1.Click += new System.EventHandler(this.TaskToolStripMenuItem1_Click);
            // 
            // classroomToolStripMenuItem
            // 
            this.classroomToolStripMenuItem.Name = "classroomToolStripMenuItem";
            this.classroomToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.classroomToolStripMenuItem.Text = "Classroom";
            this.classroomToolStripMenuItem.Click += new System.EventHandler(this.ClassroomToolStripMenuItem_Click);
            // 
            // positionToolStripMenuItem
            // 
            this.positionToolStripMenuItem.Name = "positionToolStripMenuItem";
            this.positionToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.positionToolStripMenuItem.Text = "Position";
            this.positionToolStripMenuItem.Click += new System.EventHandler(this.PositionToolStripMenuItem_Click);
            // 
            // markToolStripMenuItem
            // 
            this.markToolStripMenuItem.Name = "markToolStripMenuItem";
            this.markToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.markToolStripMenuItem.Text = "Mark";
            this.markToolStripMenuItem.Click += new System.EventHandler(this.MarkToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.BackColor = System.Drawing.Color.BurlyWood;
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.teacherToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.groupToolStripMenuItem,
            this.educationProqramToolStripMenuItem,
            this.taskToolStripMenuItem});
            this.searchToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.StudentToolStripMenuItem_Click_1);
            // 
            // teacherToolStripMenuItem
            // 
            this.teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            this.teacherToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.teacherToolStripMenuItem.Text = "Teacher";
            this.teacherToolStripMenuItem.Click += new System.EventHandler(this.TeacherToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.EmployeeToolStripMenuItem_Click);
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.groupToolStripMenuItem.Text = "Group";
            this.groupToolStripMenuItem.Click += new System.EventHandler(this.GroupToolStripMenuItem_Click);
            // 
            // educationProqramToolStripMenuItem
            // 
            this.educationProqramToolStripMenuItem.Name = "educationProqramToolStripMenuItem";
            this.educationProqramToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.educationProqramToolStripMenuItem.Text = "Education Proqram";
            this.educationProqramToolStripMenuItem.Click += new System.EventHandler(this.EducationProqramToolStripMenuItem_Click);
            // 
            // taskToolStripMenuItem
            // 
            this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            this.taskToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.taskToolStripMenuItem.Text = "Task";
            this.taskToolStripMenuItem.Click += new System.EventHandler(this.TaskToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.BackColor = System.Drawing.Color.BurlyWood;
            this.infoToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(605, 164);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 318);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem educationProqramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem educationProqramToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem classroomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem positionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}


using CSharpTask.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StudentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            StudentSearch Stud = new StudentSearch();
            Stud.ShowDialog();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void TeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherSearch Stud = new TeacherSearch();
            Stud.ShowDialog();
        }

        private void EmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeSearch Stud = new EmployeeSearch();
            Stud.ShowDialog();
        }

        private void GroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GroupSearch Stud = new GroupSearch();
            Stud.ShowDialog();
        }

        private void EducationProqramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Education_ProqramSearch Stud = new Education_ProqramSearch();
            Stud.ShowDialog();
        }

        private void TaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TaskSearch Stud = new TaskSearch();
            Stud.ShowDialog();
        }

        private void StudentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentCRUD Stud = new StudentCRUD();
            Stud.ShowDialog();
        }

        private void TeacherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherCRUD Teach = new TeacherCRUD();
            Teach.ShowDialog();
        }

        private void EmployeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeCRUD Emp = new EmployeeCRUD();
            Emp.ShowDialog();
        }

        private void GroupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GroupCRUD Group = new GroupCRUD();
            Group.ShowDialog();
        }

        private void TaskToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TaskCRUD Task = new TaskCRUD();
            Task.ShowDialog();
        }

        private void EducationProqramToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Education_ProqramsCRUD Edu = new Education_ProqramsCRUD();
            Edu.ShowDialog();
        }

        private void ClassroomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClassroomCRUD Class = new ClassroomCRUD();
            Class.ShowDialog();
        }

        private void PositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PositionCRUD Poss = new PositionCRUD();
            Poss.ShowDialog();
        }

        private void MarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MarkCRUD Mark = new MarkCRUD();
            Mark.ShowDialog();
        }
    }
}

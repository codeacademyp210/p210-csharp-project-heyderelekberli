using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpTask.Models
{
    public partial class TaskSearch : Form
    {
        public TaskSearch()
        {
            InitializeComponent();
            SearchFromTask();
        }
        private void SearchFromTask()
        {
            dgvTaskSrch.Rows.Clear();

            using (AcademyEntities1 db = new AcademyEntities1())
            {
                List<Models.Task> Task = db.Tasks.ToList();

                foreach (var ts in Task)
                {
                    dgvTaskSrch.Rows.Add(ts.İd,
                                        ts.Name,
                                        ts.Deadline,
                                        ts.Group.Name
                                        );
                    //if (ts.Deadline > DateTime.Now)
                    //{
                    //    dgvTaskSrch.Rows[dgvTaskSrch.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;

                    //}
                }
            }
        }
        private void TaskSearch_Load_1(object sender, EventArgs e)
        {
            SearchFromTask();
        }

        private void TaskSearchBtn_Click_1(object sender, EventArgs e)
        {
            string TaskSrcTxt = TaskSearchText.Text.Trim().ToLower();
            using (AcademyEntities1 db = new AcademyEntities1())
            {
                List<Models.Task> taskList = db.Tasks.Where(tsk =>
                    tsk.Name.ToLower().Contains(TaskSrcTxt) ||
                    tsk.Deadline.ToString().Contains(TaskSrcTxt) ||
                    tsk.Group.Name.ToLower().Contains(TaskSrcTxt)
                ).ToList();

                dgvTaskSrch.Rows.Clear();

                foreach (var item in taskList)
                {
                    dgvTaskSrch.Rows.Add(item.İd,
                                          item.Name,
                                          item.Deadline,
                                          item.Group.Name
                                          );
                }
            }
        }

        private void TaskSearch_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }
        private void FilterByDeadlineOffToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            dgvTaskSrch.Rows.Clear();

            using (AcademyEntities1 db = new AcademyEntities1())
            {
                List<Models.Task> Task = db.Tasks.ToList();

                foreach (var ts in Task)
                {
                    dgvTaskSrch.Rows.Add(ts.İd,
                                        ts.Name,
                                        ts.Deadline,
                                        ts.Group.Name
                                        );
                    if (ts.Deadline > DateTime.Now)
                    {
                        dgvTaskSrch.Rows[dgvTaskSrch.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;

                    }
                    if (ts.Deadline <= DateTime.Now)
                    {
                        dgvTaskSrch.Rows[dgvTaskSrch.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Green;
                    }
                }
            }
        }
    }
}

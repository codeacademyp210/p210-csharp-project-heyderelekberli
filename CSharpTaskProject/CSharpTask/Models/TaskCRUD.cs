using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpTask.Models
{
    public partial class TaskCRUD : Form
    {
        Task TasksCRUD = new Task();
        public TaskCRUD()
        {
            InitializeComponent();
            GenerateTasks();
            FillComboBox();
        }
            private bool ValidateTaskForm()
            {
                if (TaskNameTxt.Text == "")

                {
                    MessageBox.Show("Input wouldn't be empty");
                    return true;
                }
                return false;
            }

            private void GenerateTasks()
            {
                dgvTaskCreate.Rows.Clear();

                using (AcademyEntities1 db = new AcademyEntities1())
                {

                    List<Task> tasks = db.Tasks.Where(su => su.Status == true).ToList();

                    foreach (var task in tasks)
                    {
                        dgvTaskCreate.Rows.Add(task.İd,
                                             task.Name,
                                             task.Deadline,
                                             task.Group.Name
                                             );
                    }

                }
                TaskUpdateBtn.Enabled = false;
                TaskDeleteBtn.Enabled = false;
            }

            private void FillComboBox()
            {
                using (AcademyEntities1 db = new AcademyEntities1())
                {
                    cbTaskGroup.DataSource = db.Groups.Where(g => g.Status == true).Select(g => g.Name).ToList();
                }
            }
            private bool CreateTask()
            {
                int affectedRows = 0;
                using (AcademyEntities1 db = new AcademyEntities1())
                {
                    int groupID = (db.Groups.Where(g => g.Name == cbTaskGroup.SelectedItem.ToString()).FirstOrDefault()).ID;
                    Task task = new Task
                    {
                        Name = TaskNameTxt.Text,
                        Deadline = dtpTaskCreate.Value,
                        GroupİD = groupID,
                        Status = true
                    };

                    db.Tasks.Add(task);

                    affectedRows = db.SaveChanges();

                }
                if (affectedRows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            private bool UpdateTask()
            {
                int affectedRows = 0;
                using (AcademyEntities1 db = new AcademyEntities1())
                {
                    int groupID = (db.Groups.Where(g => g.Name == cbTaskGroup.SelectedItem.ToString()).FirstOrDefault()).ID;

                    Task newTask = db.Tasks.Where(s => s.İd == TasksCRUD.İd).FirstOrDefault();

                newTask.Name = TaskNameTxt.Text;
                newTask.Deadline = Convert.ToDateTime(dtpTaskCreate.Value);
                newTask.GroupİD = groupID;

                    affectedRows = db.SaveChanges();
                }
                if (affectedRows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            private void ResetTaskForm()
            {
                TaskNameTxt.Clear();
                dtpTaskCreate.Value = DateTime.Now;
                cbTaskGroup.SelectedIndex = 0;

                TaskDeleteBtn.Enabled = false;
                TaskCreateBtn.Enabled = true;
                TaskUpdateBtn.Enabled = false;
            }

            private bool DeleteTask()
            {
                int affectedRows = 0;
                using (AcademyEntities1 db = new AcademyEntities1())
                {

                    Task newTask = db.Tasks.Where(s => s.İd == TasksCRUD.İd).FirstOrDefault();
                newTask.Status = false;
                    affectedRows = db.SaveChanges();

                }
                if (affectedRows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
  
        private void DgvTaskCreate_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int taskID = (int)dgvTaskCreate.Rows[e.RowIndex].Cells[0].Value;

            using (AcademyEntities1 db = new AcademyEntities1())
            {
                TasksCRUD = db.Tasks.Where(s => s.İd == taskID).FirstOrDefault();
                if (TasksCRUD != null)
                {
                    TaskNameTxt.Text = TasksCRUD.Name;
                    dtpTaskCreate.Value = TasksCRUD.Deadline;
                    cbTaskGroup.SelectedItem = TasksCRUD.Group.Name;
                }
            }
            TaskCreateBtn.Enabled = false;
            TaskDeleteBtn.Enabled = true;
            TaskUpdateBtn.Enabled = true;
        }

        private void TaskCreateBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateTaskForm())
            {
                if (!CreateTask())
                {
                    MessageBox.Show("Task can't created", "Error");
                    return;
                }
                MessageBox.Show("Task Created");

            }
            GenerateTasks();
            ResetTaskForm();
        }

        private void TaskUpdateBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateTaskForm())
            {
                if (!UpdateTask())
                {
                    MessageBox.Show("Task can't updated", "Error");
                    return;
                }
                MessageBox.Show("Task Updated");
            }
            GenerateTasks();
            ResetTaskForm();
        }

        private void TaskDeleteBtn_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Are you sure delete " + TasksCRUD.Name + " ?", "Task Delete", MessageBoxButtons.OKCancel);

            if (DialogResult.OK != message)
            {
                return;
            }

            if (!DeleteTask())
            {
                MessageBox.Show("Task can't delete", "Warning");
                return;
            }

            MessageBox.Show("Task Deleted");

            GenerateTasks();
            ResetTaskForm();
        }

        private void TaskResetBtn_Click(object sender, EventArgs e)
        {
             ResetTaskForm();
        }

        private void TaskCRUD_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}


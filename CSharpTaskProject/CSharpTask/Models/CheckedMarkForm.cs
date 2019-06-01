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
    public partial class CheckedMarkForm : Form
    {
        public CheckedMarkForm()
        {
            InitializeComponent();
            FillComboBox();
        }
          

        private void FillComboBox()
        {
            using (AcademyEntities1 db = new AcademyEntities1())
            {
                cbCheckedGroup.DataSource = db.Groups.Where(g => g.Status == true).Select(g => g.Name).ToList();
            }
        }
        private void MarkCRUD_FormClosed(object sender, FormClosedEventArgs e)
            {
                this.Close();
                Form1 f1 = new Form1();
                f1.Show();
            }
        private void CheckedMarkForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void ChooseBtn_Click(object sender, EventArgs e)
        {
            dgvMarkCreate.Rows.Clear();
            using (AcademyEntities1 db = new AcademyEntities1())
            {
                List<Task_Marks> tasks = db.Task_Marks.Where(d => d.Student.Group.Name == cbCheckedGroup.SelectedItem.ToString()).Where(su => su.Status == true).ToList();

                foreach (var task in tasks)
                {
                    dgvMarkCreate.Rows.Add(task.İd,
                                           task.Student.Name,
                                           task.Student.Surname,
                                           task.Task.Name,
                                           task.Student.Group.Name,
                                           task.Mark
                                           );
                }
            };
        }

        private void Upper50ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvMarkCreate.Rows.Clear();

            using (AcademyEntities1 db = new AcademyEntities1())
            {
                List<Models.Task_Marks> tasks = db.Task_Marks.Where(sa => sa.Mark > 50).ToList();

                foreach (var task in tasks)
                {
                    dgvMarkCreate.Rows.Add(task.İd,
                                        task.Student.Name,
                                        task.Student.Surname,
                                        task.Task.Name,
                                        task.Student.Group.Name,
                                        task.Mark
                                        );
                }

            }
        }

        private void Beetween50ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvMarkCreate.Rows.Clear();

            using (AcademyEntities1 db = new AcademyEntities1())
            {
                List<Models.Task_Marks> tasks = db.Task_Marks.Where(sa => sa.Mark > 50).Where(sa => sa.Mark < 80).ToList();

                foreach (var task in tasks)
                {
                    dgvMarkCreate.Rows.Add(task.İd,
                                        task.Student.Name,
                                        task.Student.Surname,
                                        task.Task.Name,
                                        task.Student.Group.Name,
                                        task.Mark
                                        );
                }

            }
        }
    }
}


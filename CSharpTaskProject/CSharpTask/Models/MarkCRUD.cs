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
    public partial class MarkCRUD : Form
    {
        Task_Marks MarksCRUD = new Task_Marks();
        public MarkCRUD()
        {
            InitializeComponent();
            GenerateMarks();
            FillComboBox();
        }
        private bool ValidateMarkForm()
        {
            if (MarkTxt.Text == "")
            {
                MessageBox.Show("Input wouldn't be empty");
                return true;
            }
            if (Convert.ToInt32(MarkTxt.Text) > 100)
            {
                MessageBox.Show("Mark would be lower or equal to 100", "Warning");
                return true;
            }
            return false;
        }

        private void GenerateMarks()
        {
            dgvMarkCreate.Rows.Clear();

            using (AcademyEntities1 db = new AcademyEntities1())
            {

                List<Task_Marks> marks = db.Task_Marks.Where(su => su.Status == true).ToList();

                foreach (var mark in marks)
                {
                    dgvMarkCreate.Rows.Add(mark.İd,
                                         mark.Student.Name,
                                         mark.Task.Name,
                                         mark.Mark
                                         );
                }
            }
            MarkUpdateBtn.Enabled = false;
            MarkDeleteBtn.Enabled = false;
        }

        private void FillComboBox()
        {
            using (AcademyEntities1 db = new AcademyEntities1())
            {
                cbMarkStudentID.DataSource = db.Students.Where(g => g.Status == true).Select(g => g.Name).ToList();
                cbMarkTaskID.DataSource = db.Tasks.Where(g => g.Status == true).Select(g => g.Name).ToList();
            }
        }
        private bool CreateMarks()
        {
            int affectedRows = 0;
            using (AcademyEntities1 db = new AcademyEntities1())
            {

                int studentID = (db.Students.Where(c => c.Name == cbMarkStudentID.SelectedItem.ToString()).FirstOrDefault()).İd;
                int taskID = (db.Tasks.Where(m => m.Name == cbMarkTaskID.SelectedItem.ToString()).FirstOrDefault()).İd;
                Task_Marks mark = new Task_Marks
                {
                    StudentİD = studentID,
                    TaskİD = taskID,
                    Mark =Convert.ToInt32(MarkTxt.Text),
                    Status = true
                };

                db.Task_Marks.Add(mark);

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

        private bool UpdateMark()
        {
            int affectedRows = 0;
            using (AcademyEntities1 db = new AcademyEntities1())
            {
                int studentID = (db.Students.Where(g => g.Name == cbMarkStudentID.SelectedItem.ToString()).FirstOrDefault()).İd;
                int taskID = (db.Tasks.Where(g => g.Name == cbMarkTaskID.SelectedItem.ToString()).FirstOrDefault()).İd;

                Task_Marks newMark = db.Task_Marks.Where(s => s.İd == MarksCRUD.İd).FirstOrDefault();
                newMark.StudentİD = studentID;
                newMark.TaskİD = taskID;
                newMark.Mark = Convert.ToInt32(MarkTxt.Text);
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
        private void ResetMarkForm()
        {
            cbMarkStudentID.SelectedIndex = 0;
            cbMarkTaskID.SelectedIndex = 0;
            MarkTxt.Text = "";

            MarkDeleteBtn.Enabled = false;
            MarkCreateBtn.Enabled = true;
            MarkUpdateBtn.Enabled = false;
        }
        private bool DeleteMark()
        {
            int affectedRows = 0;
            using (AcademyEntities1 db = new AcademyEntities1())
            {

                Task_Marks newMark = db.Task_Marks.Where(s => s.İd == MarksCRUD.İd).FirstOrDefault();
                newMark.Status = false;
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
        private void MarkCreateBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateMarkForm())
            {
                if (!CreateMarks())
                {
                    MessageBox.Show("Mark can't created", "Error");
                    return;
                }
                MessageBox.Show("Mark Created");

            }
            GenerateMarks();
            ResetMarkForm();
        }

        private void MarkUpdateBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateMarkForm())
            {
                if (!UpdateMark())
                {
                    MessageBox.Show("Mark can't updated", "Error");
                    return;
                }
                MessageBox.Show("Mark Updated");
            }
            GenerateMarks();
            ResetMarkForm();
        }

        private void MarkDeleteBtn_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Are you sure delete " + "Mark" + " ?", "Mark Delete", MessageBoxButtons.OKCancel);

            if (DialogResult.OK != message)
            {
                return;
            }

            if (!DeleteMark())
            {
                MessageBox.Show("Mark can't delete", "Warning");
                return;
            }

            MessageBox.Show("Mark Deleted");

            GenerateMarks();
            ResetMarkForm();
        }

        private void MarkResetBtn_Click(object sender, EventArgs e)
        {
            ResetMarkForm();
        }

        private void MarkCRUD_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void DgvMarkCreate_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int markID = (int)dgvMarkCreate.Rows[e.RowIndex].Cells[0].Value;
            using (AcademyEntities1 db = new AcademyEntities1())
            {
                MarksCRUD = db.Task_Marks.Where(s => s.İd == markID).FirstOrDefault();
                if (MarksCRUD != null)
                {
                    cbMarkStudentID.SelectedItem = MarksCRUD.Student.Name;
                    cbMarkTaskID.SelectedItem = MarksCRUD.Task.Name;
                    MarkTxt.Text = Convert.ToString(MarksCRUD.Mark);
                }
            }
            MarkCreateBtn.Enabled = false;
            MarkDeleteBtn.Enabled = true;
            MarkUpdateBtn.Enabled = true;
        }

        private void CheckedBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckedMarkForm check = new CheckedMarkForm();
            check.ShowDialog();
        }
    }
}


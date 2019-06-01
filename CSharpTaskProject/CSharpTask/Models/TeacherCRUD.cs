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
    
    public partial class TeacherCRUD : Form
    {
        Teacher TeachersCRUD = new Teacher();
        public TeacherCRUD()
        {
            InitializeComponent();
            GenerateTeachers();
            FillComboBox();
        }
        private bool ValidateTeacherForm()
        {
            if (TeacherNameTxt.Text == "" || TeacherSurnameTxt.Text == "" || TeacherPhoneTxt.Text == "" ||
                TeacherEmailTxt.Text == "")
            {
                MessageBox.Show("Input wouldn't be empty");
                return true;
            }
            if (!Regex.Match(TeacherNameTxt.Text, "^[\\p{L} \\.'\\-]+$").Success || !Regex.Match(TeacherSurnameTxt.Text, "^[\\p{L} \\.'\\-]+$").Success)
            {
                MessageBox.Show("Name and Surname should be only letter", "Warning");
                return true;
            }
            if (!Regex.Match(TeacherEmailTxt.Text, "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$").Success)
            {
                MessageBox.Show("Please, Enter correct Email format", "Warning");
                return true;
            }
            if (!Regex.Match(TeacherPhoneTxt.Text, @"^([\+]?[0-9]{1}[0-9]{0,2})[\s-]?[\(]?(0?[0-9]\d{0,4}[\)]?[-\s]?)([0-9][\d-\s]{5,7}[\s]?)(x[\d-]{0,4})?$").Success)
            {
                MessageBox.Show("Please, Enter correct Phone format", "Warning");
                return true;
            }
            return false;
        }

        private void GenerateTeachers()
        {
            dgvTeacherCreate.Rows.Clear();

            using (AcademyEntities1 db = new AcademyEntities1())
            {

                List<Teacher> teachers = db.Teachers.Where(su => su.Status == true).ToList();

                foreach (var teacher in teachers)
                {
                    dgvTeacherCreate.Rows.Add(teacher.İd,
                                         teacher.Name,
                                         teacher.Surname,
                                         teacher.Education_Proqrams.Name,
                                         teacher.Email,
                                         teacher.Phone
                                         );
                }

            }
            TeacherUpdateBtn.Enabled = false;
            TeacherDeleteBtn.Enabled = false;
        }

        private void FillComboBox()
        {
            using (AcademyEntities1 db = new AcademyEntities1())
            {
                cbSpecGroup.DataSource = db.Education_Proqrams.Where(g => g.Status == true).Select(g => g.Name).ToList();
            }
        }
        private bool CreateStudent()
        {
            int affectedRows = 0;
            using (AcademyEntities1 db = new AcademyEntities1())
            {

                int specID = (db.Education_Proqrams.Where(g => g.Name == cbSpecGroup.SelectedItem.ToString()).FirstOrDefault()).İd;
                Teacher teacher = new Teacher
                {
                    Name = TeacherNameTxt.Text,
                    Surname = TeacherSurnameTxt.Text,
                    SpecialityID = specID,
                    Email = TeacherEmailTxt.Text,
                    Phone = TeacherPhoneTxt.Text,
                    Status = true
                };

                db.Teachers.Add(teacher);

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

        private bool UpdateStudent()
        {
            int affectedRows = 0;
            using (AcademyEntities1 db = new AcademyEntities1())
            {
                int specID = (db.Education_Proqrams.Where(g => g.Name == cbSpecGroup.SelectedItem.ToString()).FirstOrDefault()).İd;

                Teacher newTeach = db.Teachers.Where(s => s.İd == TeachersCRUD.İd).FirstOrDefault();

                newTeach.Name = TeacherNameTxt.Text;
                newTeach.Surname = TeacherSurnameTxt.Text;
                newTeach.SpecialityID = specID;
                newTeach.Email = TeacherEmailTxt.Text;
                newTeach.Phone = TeacherPhoneTxt.Text;
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
        private void ResetStudentForm()
        {
            TeacherNameTxt.Clear();
            TeacherSurnameTxt.Clear();
            cbSpecGroup.SelectedIndex = 0;
            TeacherEmailTxt.Clear();
            TeacherPhoneTxt.Clear();
          

            TeacherDeleteBtn.Enabled = false;
            TeacherCreateBtn.Enabled = true;
            TeacherUpdateBtn.Enabled = false;
        }

        private bool DeleteStudent()
        {
            int affectedRows = 0;
            using (AcademyEntities1 db = new AcademyEntities1())
            {

                Teacher newTeach = db.Teachers.Where(s => s.İd == TeachersCRUD.İd).FirstOrDefault();
                newTeach.Status = false;
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

        private void TeacherCreateBtn_Click(object sender, EventArgs e)
        {

            if (!ValidateTeacherForm())
            {
                if (!CreateStudent())
                {
                    MessageBox.Show("Teacher can't created", "Error");
                    return;
                }
                MessageBox.Show("Teacher Created");

            }
            GenerateTeachers();
            ResetStudentForm();
        }

        private void TeacherUpdateBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateTeacherForm())
            {
                if (!UpdateStudent())
                {
                    MessageBox.Show("Teacher can't updated", "Error");
                    return;
                }
                MessageBox.Show("Teacher Updated");
            }
            GenerateTeachers();
            ResetStudentForm();
        }
        private void TeacherDeleteBtn_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Are you sure delete " + TeachersCRUD.Name + " " + TeachersCRUD.Surname + " ?", "Teacher Delete", MessageBoxButtons.OKCancel);

            if (DialogResult.OK != message)
            {
                return;
            }

            if (!DeleteStudent())
            {
                MessageBox.Show("Teacher can't delete", "Warning");
                return;
            }

            MessageBox.Show("Teacher Deleted");

            GenerateTeachers();
            ResetStudentForm();
        }
        private void TeacherResetBtn_Click(object sender, EventArgs e)
        {
            ResetStudentForm();
        }

        private void TeacherCRUD_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void DgvTeacherCreate_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int teacherID = (int)dgvTeacherCreate.Rows[e.RowIndex].Cells[0].Value;

            using (AcademyEntities1 db = new AcademyEntities1())
            {
                TeachersCRUD = db.Teachers.Where(s => s.İd == teacherID).FirstOrDefault();
                if (TeachersCRUD != null)
                {
                    TeacherNameTxt.Text = TeachersCRUD.Name;
                   TeacherSurnameTxt.Text = TeachersCRUD.Surname;
                    cbSpecGroup.SelectedItem = TeachersCRUD.Education_Proqrams.Name;
                    TeacherEmailTxt.Text = TeachersCRUD.Email;
                    TeacherPhoneTxt.Text = TeachersCRUD.Phone;
                    
                }
            }
            TeacherCreateBtn.Enabled = false;
            TeacherDeleteBtn.Enabled = true;
            TeacherUpdateBtn.Enabled = true;
        }
    }
}


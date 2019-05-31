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
    public partial class StudentCRUD : Form
    {
        Student StudentsCRUD = new Student();
     

        public StudentCRUD()
        {
            InitializeComponent();
            GenerateStudents();
            FillComboBox(); 
        }
        private bool ValidateStudentForm()
        {
            if (StudentNameTxt.Text == "" || StudentSurnameTxt.Text == "" || StudentEmailTxt.Text == "" || 
                StudentPhoneTxt.Text == "" || StudentFeeTxt.Text == "")
            {
                MessageBox.Show("Input wouldn't be empty");
                return true;
            }
            if (!Regex.Match(StudentNameTxt.Text, "^[\\p{L} \\.'\\-]+$").Success || !Regex.Match(StudentSurnameTxt.Text, "^[\\p{L} \\.'\\-]+$").Success)
            {
                MessageBox.Show("Name and Surname should be only letter","Warning");
                return true;
            }
            if (!Regex.Match(StudentEmailTxt.Text, "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$").Success)
            {
                MessageBox.Show("Please, Enter correct Email format" , "Warning");
                return true;
            }
            if (!Regex.Match(StudentPhoneTxt.Text, @"^([\+]?[0-9]{1}[0-9]{0,2})[\s-]?[\(]?(0?[0-9]\d{0,4}[\)]?[-\s]?)([0-9][\d-\s]{5,7}[\s]?)(x[\d-]{0,4})?$").Success)
            {
                MessageBox.Show("Please, Enter correct Phone format", "Warning");
                return true;
            }
            if (!Regex.Match(StudentFeeTxt.Text, "(\\d{4})").Success)
            {
                MessageBox.Show("Please, Enter correct Fee format", "Warning");
                return true;
            }
         
            return false;
        }

        private void GenerateStudents()
        {
            dgvStudentCreate.Rows.Clear();

            using (AcademyEntities1 db = new AcademyEntities1())
            {
            
                List<Student> students = db.Students.Where(su => su.Status == true).ToList();

                foreach (var student in students)
                {
                    dgvStudentCreate.Rows.Add(student.İd,
                                         student.Name,
                                         student.Surname,
                                         student.Email,
                                         student.Phone,
                                         student.Fee,
                                         student.Group.Name
                                         );
                }

            }
            StudentUpdateBtn.Enabled = false;
            StudentDeleteBtn.Enabled = false;
        }

        private void FillComboBox()
        {
            using (AcademyEntities1 db = new AcademyEntities1())
            {
                cbStudentGroup.DataSource = db.Groups.Select(g => g.Name).ToList();
            }
        }
        private void StudentCreateBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateStudentForm())
            {
                if (!CreateStudent())
                {
                    MessageBox.Show("Student can't created", "Error");
                    return;
                }
                MessageBox.Show("Student Created");
              
            }
            GenerateStudents();
            ResetStudentForm();
        }  
        private bool CreateStudent()
        {
            int affectedRows = 0;
            using (AcademyEntities1 db = new AcademyEntities1())
            {

                int groupID = (db.Groups.Where(g => g.Name == cbStudentGroup.SelectedItem.ToString()).FirstOrDefault()).ID;
                Student student = new Student
                {
                    Name = StudentNameTxt.Text,
                    Surname = StudentSurnameTxt.Text,
                    Email = StudentEmailTxt.Text,
                    Phone = StudentPhoneTxt.Text,
                    Fee = Convert.ToDouble(StudentFeeTxt.Text),
                    GroupID = groupID,
                    Status = true
                };

                db.Students.Add(student);

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
                int groupID = (db.Groups.Where(g => g.Name == cbStudentGroup.SelectedItem.ToString()).FirstOrDefault()).ID;

                Student newStu = db.Students.Where(s => s.İd == StudentsCRUD.İd).FirstOrDefault();

                newStu.Name = StudentNameTxt.Text;
                newStu.Surname = StudentSurnameTxt.Text;
                newStu.Email = StudentEmailTxt.Text;
                newStu.Phone = StudentPhoneTxt.Text;
                try
                {
                    newStu.Fee = Convert.ToDouble(StudentFeeTxt.Text);
                }
                catch (Exception)
                {

                  MessageBox.Show("Please, enter correct Fee format");
                    return false;
                }
           
                newStu.GroupID = groupID;
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
        private void StudentUpdateBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateStudentForm())
            {
                if (!UpdateStudent())
                {
                    MessageBox.Show("Student can't updated", "Error");
                    return;
                }
                MessageBox.Show("Student Updated");
            }
            GenerateStudents();
            ResetStudentForm();
        }

        private void DgvStudentCreate_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int studentID = (int)dgvStudentCreate.Rows[e.RowIndex].Cells[0].Value;

            using (AcademyEntities1 db = new AcademyEntities1())
            {
                StudentsCRUD = db.Students.Where(s => s.İd == studentID).FirstOrDefault();
                if (StudentsCRUD != null)
                {
                    StudentNameTxt.Text = StudentsCRUD.Name;
                    StudentSurnameTxt.Text = StudentsCRUD.Surname;
                    StudentEmailTxt.Text = StudentsCRUD.Email;
                    StudentPhoneTxt.Text = StudentsCRUD.Phone;
                    StudentFeeTxt.Text = Convert.ToString(StudentsCRUD.Fee);
                    cbStudentGroup.SelectedItem = StudentsCRUD.Group.Name;
                }
            }
            StudentCreateBtn.Enabled = false;
            StudentDeleteBtn.Enabled = true;
            StudentUpdateBtn.Enabled = true;
        }

        private void ResetStudentForm()
        {
            StudentNameTxt.Clear();
            StudentSurnameTxt.Clear();
            StudentEmailTxt.Clear();
            StudentPhoneTxt.Clear();
            StudentFeeTxt.Clear();
            cbStudentGroup.SelectedIndex = 0;
            StudentDeleteBtn.Enabled = false;
            StudentCreateBtn.Enabled = true;
            StudentUpdateBtn.Enabled = false;
        }

        private bool DeleteStudent()
        {
            int affectedRows = 0;
            using (AcademyEntities1 db = new AcademyEntities1())
            {

                Student newStu = db.Students.Where(s => s.İd == StudentsCRUD.İd).FirstOrDefault();
                newStu.Status = false;
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

        private void StudentResetBtn_Click(object sender, EventArgs e)
        {
            ResetStudentForm();
        }

        private void StudentDeleteBtn_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Are you sure delete " + StudentsCRUD.Name + " " + StudentsCRUD.Surname + " ?", "Student Delete", MessageBoxButtons.OKCancel);

            if (DialogResult.OK != message)
            {
                return;
            }

            if (!DeleteStudent())
            {
                MessageBox.Show("Student can't delete", "Warning");
                return;
            }

            MessageBox.Show("Student Deleted");

            GenerateStudents();
            ResetStudentForm();

        }

        private void StudentCRUD_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
                
        }

       
    }
}

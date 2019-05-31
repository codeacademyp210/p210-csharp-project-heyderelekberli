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
    public partial class ClassroomCRUD : Form
    {
        Classroom ClassCRUD = new Classroom();

        public ClassroomCRUD()
        {
            InitializeComponent();
            GenerateClass();
        }
            private bool ValidateClassForm()
            {
                if (ClassNameTxt.Text == "")
                {
                    MessageBox.Show("Input wouldn't be empty");
                    return true;
                }
                if (!Regex.Match(ClassNameTxt.Text, "^[\\p{L} \\.'\\-]+$").Success)
                {
                    MessageBox.Show("Name should be only letter", "Warning");
                    return true;
                }
                return false;
            }

            private void GenerateClass()
            {
                dgvClassCreate.Rows.Clear();

                using (AcademyEntities1 db = new AcademyEntities1())
                {

                    List<Classroom> classes = db.Classrooms.Where(su => su.Status == true).ToList();

                    foreach (var clas in classes)
                    {
                        dgvClassCreate.Rows.Add(clas.İd,
                                             clas.Name
                                             );
                    }

                }
                ClassroomUpdateBtn.Enabled = false;
                ClassroomDeleteBtn.Enabled = false;
            }

            private bool CreateClass()
            {
                int affectedRows = 0;
                using (AcademyEntities1 db = new AcademyEntities1())
                {
                    Classroom clas = new Classroom
                    {
                        Name = ClassNameTxt.Text,
                        Status = true
                    };

                    db.Classrooms.Add(clas);

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

            private bool UpdateClass()
            {
                int affectedRows = 0;
                using (AcademyEntities1 db = new AcademyEntities1())
                {
                    Classroom newClass = db.Classrooms.Where(s => s.İd == ClassCRUD.İd).FirstOrDefault();

                    newClass.Name = ClassNameTxt.Text;
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
            private void ResetClassForm()
            {
                ClassNameTxt.Clear();

                ClassroomDeleteBtn.Enabled = false;
                ClassroomCreateBtn.Enabled = true;
                ClassroomUpdateBtn.Enabled = false;
            }

            private bool DeleteClass()
            {
                int affectedRows = 0;
                using (AcademyEntities1 db = new AcademyEntities1())
                {

                    Classroom newClass = db.Classrooms.Where(s => s.İd == ClassCRUD.İd).FirstOrDefault();
                    newClass.Status = false;
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
        private void ClassroomCreateBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateClassForm())
            {
                if (!CreateClass())
                {
                    MessageBox.Show("Classroom can't created", "Error");
                    return;
                }
                MessageBox.Show("Classroom Created");

            }
            GenerateClass();
            ResetClassForm();
        }

        private void ClassroomUpdateBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateClassForm())
            {
                if (!UpdateClass())
                {
                    MessageBox.Show("Classroom can't updated", "Error");
                    return;
                }
                MessageBox.Show("Classroom Updated");
            }
            GenerateClass();
            ResetClassForm();
        }

        private void ClassroomDeleteBtn_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Are you sure delete " + ClassCRUD.Name + " ?", "Classroom Delete", MessageBoxButtons.OKCancel);

            if (DialogResult.OK != message)
            {
                return;
            }

            if (!DeleteClass())
            {
                MessageBox.Show("Classroom can't delete", "Warning");
                return;
            }

            MessageBox.Show("Classroom Deleted");

            GenerateClass();
            ResetClassForm();
        }

        private void ClassroomResetBtn_Click(object sender, EventArgs e)
        {
            ResetClassForm();
        }

        private void DgvClassCreate_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int classID = (int)dgvClassCreate.Rows[e.RowIndex].Cells[0].Value;

            using (AcademyEntities1 db = new AcademyEntities1())
            {
                ClassCRUD = db.Classrooms.Where(s => s.İd == classID).FirstOrDefault();
                if (ClassCRUD != null)
                {
                    ClassNameTxt.Text = ClassCRUD.Name;
                }
            }
            ClassroomCreateBtn.Enabled = false;
            ClassroomDeleteBtn.Enabled = true;
            ClassroomUpdateBtn.Enabled = true;
        }

        private void ClassroomCRUD_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
 

    

}


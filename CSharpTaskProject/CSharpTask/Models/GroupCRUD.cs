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
  
    public partial class GroupCRUD : Form
    {
        Group GroupsCRUD = new Group();
        public GroupCRUD()
        {
            InitializeComponent();
            GenerateGroups();
            FillComboBox();
        }


        private bool ValidateGroupForm()
        {
            if (GroupNameTxt.Text == "" || GroupCapacityTxt.Text == "")
            {
                MessageBox.Show("Input wouldn't be empty");
                return true;
            }
            if (!Regex.Match(GroupCapacityTxt.Text, "^\\d+$").Success)
            {
                MessageBox.Show("Please, Enter correct Capacity format", "Warning");
                return true;
            }
            return false;
        }

        private void GenerateGroups()
        {
            dgvGroupCreate.Rows.Clear();

            using (AcademyEntities1 db = new AcademyEntities1())
            {

                List<Group> groups = db.Groups.Where(su => su.Status == true).ToList();

                foreach (var group in groups)
                {
                    dgvGroupCreate.Rows.Add(group.ID,
                                         group.Name,
                                         group.Classroom.Name,
                                         group.Teacher.Name,
                                         group.Employee.Name,
                                         group.Capacity,
                                         group.Education_Proqrams.Name
                                         );
                }

            }
            GroupUpdateBtn.Enabled = false;
            GroupDeleteBtn.Enabled = false;
        }

        private void FillComboBox()
        {
            using (AcademyEntities1 db = new AcademyEntities1())
            {
                cbGroupClassroom.DataSource = db.Classrooms.Where(g => g.Status ==true).Select(g => g.Name).ToList();
                cbGroupTeacher.DataSource = db.Teachers.Where(g => g.Status == true).Select(g => g.Name).ToList();
                cbGroupMentor.DataSource = db.Employees.Where(g => g.Status == true).Where(ju => ju.Position.Name == "Mentor").Select(g => g.Name).ToList();
                cbGroupEducation.DataSource = db.Education_Proqrams.Where(g => g.Status == true).Select(g => g.Name).ToList();
            }
        }
        private bool CreateGroup()
        {
            int affectedRows = 0;
            using (AcademyEntities1 db = new AcademyEntities1())
            {

                int classID = (db.Classrooms.Where(c => c.Name == cbGroupClassroom.SelectedItem.ToString()).FirstOrDefault()).İd;
                int teachID = (db.Teachers.Where( t=> t.Name == cbGroupTeacher.SelectedItem.ToString()).FirstOrDefault()).İd;
                int mentID = (db.Employees.Where(m => m.Name == cbGroupMentor.SelectedItem.ToString()).FirstOrDefault()).İd;
                int eduID = (db.Education_Proqrams.Where(e => e.Name == cbGroupEducation.SelectedItem.ToString()).FirstOrDefault()).İd;
                Group group = new Group
                {
                    Name = GroupNameTxt.Text,
                    ClassroomİD = classID,
                    TeacherID = teachID,
                    MentorİD = mentID,
                    Capacity = Convert.ToInt32(GroupCapacityTxt.Text),
                    Education_ProgramİD = eduID,
                    Status = true
                };

                db.Groups.Add(group);

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

        private bool UpdateGroup()
        {
            int affectedRows = 0;
            using (AcademyEntities1 db = new AcademyEntities1())
            {
                int classID = (db.Classrooms.Where(g => g.Name == cbGroupClassroom.SelectedItem.ToString()).FirstOrDefault()).İd;
                int teachID = (db.Teachers.Where(g => g.Name == cbGroupTeacher.SelectedItem.ToString()).FirstOrDefault()).İd;
                int mentID = (db.Employees.Where(g => g.Name == cbGroupMentor.SelectedItem.ToString()).FirstOrDefault()).İd;
                int eduID = (db.Education_Proqrams.Where(g => g.Name == cbGroupEducation.SelectedItem.ToString()).FirstOrDefault()).İd;

                Group newGroup = db.Groups.Where(s => s.ID == GroupsCRUD.ID).FirstOrDefault();
                newGroup.Name = GroupNameTxt.Text;
                newGroup.ClassroomİD = classID;
                newGroup.TeacherID = teachID;
                newGroup.MentorİD = mentID;
                newGroup.Capacity = Convert.ToInt32(GroupCapacityTxt.Text);
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
        private void ResetGroupForm()
        {
            GroupNameTxt.Clear();
            cbGroupClassroom.SelectedIndex = 0;
            cbGroupTeacher.SelectedIndex = 0;
            cbGroupMentor.SelectedIndex = 0;
            GroupCapacityTxt.Clear();
            cbGroupEducation.SelectedIndex = 0;

            GroupDeleteBtn.Enabled = false;
            GroupCreateBtn.Enabled = true;
            GroupUpdateBtn.Enabled = false;
        }

        private bool DeleteGroup()
        {
            int affectedRows = 0;
            using (AcademyEntities1 db = new AcademyEntities1())
            {

                Group newGroup = db.Groups.Where(s => s.ID == GroupsCRUD.ID).FirstOrDefault();
                newGroup.Status = false;
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

        private void DgvGroupCreate_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int groupID = (int)dgvGroupCreate.Rows[e.RowIndex].Cells[0].Value;

            using (AcademyEntities1 db = new AcademyEntities1())
            {
                GroupsCRUD = db.Groups.Where(s => s.ID == groupID).FirstOrDefault();
                if (GroupsCRUD != null)
                {
                    GroupNameTxt.Text = GroupsCRUD.Name;
                    cbGroupClassroom.SelectedItem = GroupsCRUD.Classroom.Name;
                    cbGroupTeacher.SelectedItem = GroupsCRUD.Teacher.Name;
                    cbGroupEducation.SelectedItem = GroupsCRUD.Employee.Name;
                    GroupCapacityTxt.Text = Convert.ToString(GroupsCRUD.Capacity);
                    cbGroupEducation.SelectedItem = GroupsCRUD.Education_Proqrams.Name;


                }
            }
            GroupCreateBtn.Enabled = false;
            GroupDeleteBtn.Enabled = true;
            GroupUpdateBtn.Enabled = true;
        }

        private void GroupCreateBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateGroupForm())
            {
                if (!CreateGroup())
                {
                    MessageBox.Show("Group can't created", "Error");
                    return;
                }
                MessageBox.Show("Group Created");

            }
            GenerateGroups();
            ResetGroupForm();
        }

        private void GroupUpdateBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateGroupForm())
            {
                if (!UpdateGroup())
                {
                    MessageBox.Show("Group can't updated", "Error");
                    return;
                }
                MessageBox.Show("Group Updated");
            }
            GenerateGroups();
            ResetGroupForm();
        }

        private void GroupDeleteBtn_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Are you sure delete " + GroupsCRUD.Name +  " ?", "Group Delete", MessageBoxButtons.OKCancel);

            if (DialogResult.OK != message)
            {
                return;
            }

            if (!DeleteGroup())
            {
                MessageBox.Show("Group can't delete", "Warning");
                return;
            }

            MessageBox.Show("Group Deleted");

            GenerateGroups();
            ResetGroupForm();
        }

        private void GroupResetBtn_Click(object sender, EventArgs e)
        {
            ResetGroupForm();
        }

        private void GroupCRUD_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}


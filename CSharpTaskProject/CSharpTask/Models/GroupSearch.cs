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
    public partial class GroupSearch : Form
    {
        public GroupSearch()
        {
            InitializeComponent();
        }
        private void SearchFromGroup()
        {
            dgvGroupSrch.Rows.Clear();

            using (AcademyEntities1 db = new AcademyEntities1())
            {
                List<Models.Group> Group = db.Groups.ToList();

                foreach (var gr in Group)
                {
                    dgvGroupSrch.Rows.Add(gr.ID,
                                        gr.Name,
                                        gr.Classroom.Name,
                                        gr.Teacher.Name,
                                        gr.Employee.Name,
                                        gr.Capacity,
                                        gr.Education_Proqrams.Name
                                        );
                }
            }
        }
        private void GroupSearch_Load_1(object sender, EventArgs e)
        {
            SearchFromGroup();
        }

        private void GroupSearchBtn_Click_1(object sender, EventArgs e)
        {
            string GroupSrcTxt = GroupSearchText.Text.Trim().ToLower();
            using (AcademyEntities1 db = new AcademyEntities1())
            {
                List<Models.Group> employeeList = db.Groups.Where(gro =>
                    gro.Name.ToLower().Contains(GroupSrcTxt) ||
                    gro.Classroom.Name.ToLower().Contains(GroupSrcTxt) ||
                    gro.Teacher.Name.ToLower().Contains(GroupSrcTxt) ||
                    gro.Employee.Name.ToLower().Contains(GroupSrcTxt) ||
                    gro.Capacity.ToString().Contains(GroupSrcTxt) ||
                    gro.Education_Proqrams.Name.ToLower().Contains(GroupSrcTxt)

                ).ToList();

                dgvGroupSrch.Rows.Clear();

                foreach (var item in employeeList)
                {
                    dgvGroupSrch.Rows.Add(item.ID,
                                          item.Name,
                                          item.Classroom.Name,
                                          item.Teacher.Name,
                                          item.Employee.Name,
                                          item.Capacity,
                                          item.Education_Proqrams.Name
                                          );
                }

            }
        }

        private void GroupSearch_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

     
    }
}

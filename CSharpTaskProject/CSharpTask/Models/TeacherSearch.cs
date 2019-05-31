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
    public partial class TeacherSearch : Form
    {
        public TeacherSearch()
        {
            InitializeComponent();
            SearchFromTeacher();
        }
        private void SearchFromTeacher()
        {
            dgvTeacherSrch.Rows.Clear();

            using (AcademyEntities1 db = new AcademyEntities1())
            {
                List<Models.Teacher> Teach = db.Teachers.ToList();

                foreach (var t in Teach)
                {
                    dgvTeacherSrch.Rows.Add(t.İd,
                                        t.Name,
                                        t.Surname,
                                        t.Education_Proqrams.Name,
                                        t.Email,
                                        t.Phone
                                    
                                        );

                }

            }
        }
        private void TeacherSearch_Load(object sender, EventArgs e)
        {
            SearchFromTeacher();
        }

        private void TeacherSearchBtn_Click_1(object sender, EventArgs e)
        {
            string TeacherSrcTxt = TeacherSearchText.Text.Trim().ToLower();
            using (AcademyEntities1 db = new AcademyEntities1())
            {
                List<Models.Teacher> teacherList = db.Teachers.Where(c =>
                    c.Name.ToLower().Contains(TeacherSrcTxt) ||
                    c.Surname.ToLower().Contains(TeacherSrcTxt) ||
                    c.Education_Proqrams.Name.ToLower().Contains(TeacherSrcTxt) ||
                    c.Email.ToLower().Contains(TeacherSrcTxt) ||
                    c.Phone.ToLower().Contains(TeacherSrcTxt)
                ).ToList();

                dgvTeacherSrch.Rows.Clear();

                foreach (var item in teacherList)
                {
                    dgvTeacherSrch.Rows.Add(item.İd, item.Name, item.Surname, item.Education_Proqrams.Name, item.Email, item.Phone);
                }

            }
        }

        private void TeacherSearch_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}

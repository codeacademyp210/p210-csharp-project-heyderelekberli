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
    public partial class StudentSearch : Form
    {
        public StudentSearch()
        {
            InitializeComponent();
            SearchFromStudent();
        }

        private void SearchFromStudent()
        {
            dgvStudentSrch.Rows.Clear();

            using (AcademyEntities1 db = new AcademyEntities1())
            {
                List<Models.Student> Stud = db.Students.Where(su => su.Status == true).ToList();

                foreach (var c in Stud)
                {
                    dgvStudentSrch.Rows.Add(c.İd,
                                        c.Name,
                                        c.Surname,
                                        c.Email,
                                        c.Phone,
                                        c.Fee,
                                        c.Group.Name
                                        );

                }

            }
        }
        private void StudentSearch_Load_1(object sender, EventArgs e)
        {
            SearchFromStudent();
        }

        private void SearchBtn_Click_1(object sender, EventArgs e)
        {
        string searchText = StudentSearchText.Text.Trim().ToLower();
        using (AcademyEntities1 db = new AcademyEntities1())
        {
            List<Models.Student> clientsList = db.Students.Where( c =>
                c.Name.ToLower().Contains(searchText) ||
                c.Surname.ToLower().Contains(searchText) ||
                c.Email.ToLower().Contains(searchText) ||
                c.Phone.ToLower().Contains(searchText) ||
                c.Fee.ToString().Contains(searchText) ||
                c.Group.Name.ToLower().Contains(searchText)
            ).Where(c => c.Status == true).ToList();

            dgvStudentSrch.Rows.Clear();

            foreach (var item in clientsList)
            {
                dgvStudentSrch.Rows.Add(item.İd, item.Name, item.Surname, item.Email, item.Phone, item.Fee, item.Group.Name);
            }
        }
        }

        private void StudentSearch_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void FilterByStudentWhoHasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvStudentSrch.Rows.Clear();

            using (AcademyEntities1 db = new AcademyEntities1())
            {
                List<Models.Student> Task = db.Students.Where(su => su.Status == true).ToList();

                foreach (var ts in Task)
                {
                    dgvStudentSrch.Rows.Add(ts.İd,
                                        ts.Surname,
                                        ts.Email,
                                        ts.Phone,
                                        ts.Fee,
                                        ts.Group.Name
                                        );
                    if (ts.Fee < 3500)
                    {
                        dgvStudentSrch.Rows[dgvStudentSrch.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }

        private void DgvStudentSrch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

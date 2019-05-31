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
    public partial class Education_ProqramSearch : Form
    {
        public Education_ProqramSearch()
        {
            InitializeComponent();
            SearchFromEducation();
        }
        private void SearchFromEducation()
        {
            dgvEducationSrch.Rows.Clear();

            using (AcademyEntities1 db = new AcademyEntities1())
            {
                List<Models.Education_Proqrams> Educ = db.Education_Proqrams.ToList();

                foreach (var edu in Educ)
                {
                    dgvEducationSrch.Rows.Add(edu.İd,
                                        edu.Name,
                                        edu.Price
                                        );
                }
            }
        }

        private void Education_ProqramSearch_Load(object sender, EventArgs e)
        {
            SearchFromEducation();
        }

        private void EducationSearchBtn_Click_1(object sender, EventArgs e)
        {
            string EducationSrcTxt = EducationSearchText.Text.Trim().ToLower();
            using (AcademyEntities1 db = new AcademyEntities1())
            {
                List<Models.Education_Proqrams> employeeList = db.Education_Proqrams.Where(edu =>
                    edu.Name.ToLower().Contains(EducationSrcTxt) ||
                    edu.Price.ToString().Contains(EducationSrcTxt)
                ).ToList();

                dgvEducationSrch.Rows.Clear();

                foreach (var item in employeeList)
                {
                    dgvEducationSrch.Rows.Add(item.İd,
                                          item.Name,
                                          item.Price
                                          );
                }
            }
        }

        private void Education_ProqramSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}

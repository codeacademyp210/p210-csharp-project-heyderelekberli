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
    public partial class AmountDept : Form
    {
        public AmountDept()
        {
            InitializeComponent();
            FillDept();
        }
        private void FillDept()
        {
            dgvStudentSrch.Rows.Clear();

            using (AcademyEntities1 db = new AcademyEntities1())
            {
                List<Models.Student> Task = db.Students.Where(su => su.Status == true).ToList();

                foreach (var ts in Task)
                {
                    dgvStudentSrch.Rows.Add(ts.İd,
                                        (ts.Name + " " +ts.Surname),
                                         (3500 - ts.Fee)
                                        );
                  
                }
            }
        }

        private void AmountDept_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}

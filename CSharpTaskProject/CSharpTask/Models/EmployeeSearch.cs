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
    public partial class EmployeeSearch : Form
    {
        public EmployeeSearch()
        {
            InitializeComponent();
            SearchFromEmployee();
        }
        private void SearchFromEmployee()
        {
            dgvEmployeeSrch.Rows.Clear();

            using (AcademyEntities1 db = new AcademyEntities1())
            {
                List<Models.Employee> Empl = db.Employees.ToList();

                foreach (var em in Empl)
                {
                    dgvEmployeeSrch.Rows.Add(em.İd,
                                        em.Name,
                                        em.Surname,
                                        em.Email,
                                        em.Phone,
                                        em.Position.Name,
                                        em.Start_Time,
                                        em.Salary
                                        );

                }

            }
        }

        private void EmployeeSearch_Load(object sender, EventArgs e)
        {
            SearchFromEmployee();
        }
        private void EmployeeSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void EmployeeSearchBtn_Click_1(object sender, EventArgs e)
        {
            string EmployeeSrcTxt = EmployeeSearchText.Text.Trim().ToLower();
            using (AcademyEntities1 db = new AcademyEntities1())
            {
                List<Models.Employee> employeeList = db.Employees.Where(emp =>
                    emp.Name.ToLower().Contains(EmployeeSrcTxt) ||
                    emp.Surname.ToLower().Contains(EmployeeSrcTxt) ||
                    emp.Email.ToLower().Contains(EmployeeSrcTxt) ||
                    emp.Phone.ToLower().Contains(EmployeeSrcTxt) ||
                    emp.Position.Name.ToLower().Contains(EmployeeSrcTxt) ||
                    emp.Salary.ToString().Contains(EmployeeSrcTxt)

                ).ToList();

                dgvEmployeeSrch.Rows.Clear();

                foreach (var item in employeeList)
                {
                    dgvEmployeeSrch.Rows.Add(item.İd, item.Name, item.Surname, item.Email, item.Phone, item.Position.Name, item.Start_Time, item.Salary);
                }

            }
        }

      
    }
}

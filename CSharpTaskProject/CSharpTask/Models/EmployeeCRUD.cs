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
    public partial class EmployeeCRUD : Form
    {
        Employee EmployeesCRUD = new Employee();
        public EmployeeCRUD()
        {
            InitializeComponent();
            GenerateEmployees();
            FillComboBox();
        }
            private bool ValidateEmployeeForm()
            {
                if (EmployeeNameTxt.Text == "" || EmployeeSurnameTxt.Text == "" || EmployeePhoneTxt.Text == "" ||
                    EmployeeEmailTxt.Text == "")
                {
                    MessageBox.Show("Input wouldn't be empty");
                    return true;
                }
                if (!Regex.Match(EmployeeNameTxt.Text, "^[\\p{L} \\.'\\-]+$").Success || !Regex.Match(EmployeeSurnameTxt.Text, "^[\\p{L} \\.'\\-]+$").Success)
                {
                    MessageBox.Show("Name and Surname should be only letter", "Warning");
                    return true;
                }
                if (!Regex.Match(EmployeeEmailTxt.Text, "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$").Success)
                {
                    MessageBox.Show("Please, Enter correct Email format", "Warning");
                    return true;
                }
                if (!Regex.Match(EmployeePhoneTxt.Text, @"^([\+]?[0-9]{1}[0-9]{0,2})[\s-]?[\(]?(0?[0-9]\d{0,4}[\)]?[-\s]?)([0-9][\d-\s]{5,7}[\s]?)(x[\d-]{0,4})?$").Success)
                {
                    MessageBox.Show("Please, Enter correct Phone format", "Warning");
                    return true;
                }
                if (!Regex.Match(EmployeeSalaryTxt.Text, "(\\d{4})").Success)
                {
                MessageBox.Show("Please, Enter correct Salary format", "Warning");
                return true;
                }
            return false;
            }

            private void GenerateEmployees()
            {
                dgvEmployeeCreate.Rows.Clear();

                using (AcademyEntities1 db = new AcademyEntities1())
                {

                    List<Employee> employees = db.Employees.Where(su => su.Status == true).ToList();

                    foreach (var employee in employees)
                    {
                        dgvEmployeeCreate.Rows.Add(employee.İd,
                                             employee.Name,
                                             employee.Surname,
                                             employee.Email,
                                             employee.Phone,
                                             employee.Position.Name,
                                             employee.Start_Time,
                                             employee.Salary
                                             );
                    }

                }
                EmployeeUpdateBtn.Enabled = false;
                EmployeeDeleteBtn.Enabled = false;
            }

            private void FillComboBox()
            {
                using (AcademyEntities1 db = new AcademyEntities1())
                {
                    cbPositionGroup.DataSource = db.Positions.Select(g => g.Name).ToList();
                }
            }
            private bool CreateEmployee()
            {
                int affectedRows = 0;
                using (AcademyEntities1 db = new AcademyEntities1())
                {

                    int posID = (db.Positions.Where(g => g.Name == cbPositionGroup.SelectedItem.ToString()).FirstOrDefault()).İd;
                Employee employee = new Employee
                {
                    Name = EmployeeNameTxt.Text,
                    Surname = EmployeeSurnameTxt.Text,
                    Email = EmployeeEmailTxt.Text,
                    Phone = EmployeePhoneTxt.Text,
                    PositionİD = posID,
                    Start_Time = Convert.ToDateTime(dtpEmployeeCreate.Text),
                    Salary = Convert.ToDouble(EmployeeSalaryTxt.Text),
                    Status = true
                    };

                    db.Employees.Add(employee);

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

            private bool UpdateEmployee()
            {
                int affectedRows = 0;
                using (AcademyEntities1 db = new AcademyEntities1())
                {
                    int posID = (db.Positions.Where(g => g.Name == cbPositionGroup.SelectedItem.ToString()).FirstOrDefault()).İd;

                    Employee newEmp = db.Employees.Where(s => s.İd == EmployeesCRUD.İd).FirstOrDefault();

                newEmp.Name = EmployeeNameTxt.Text;
                newEmp.Surname = EmployeeSurnameTxt.Text;
                newEmp.PositionİD = posID;
                newEmp.Email = EmployeeEmailTxt.Text;
                newEmp.Phone = EmployeePhoneTxt.Text;
                newEmp.Start_Time = Convert.ToDateTime(dtpEmployeeCreate.Text);
                newEmp.Salary = Convert.ToDouble(EmployeeSalaryTxt.Text);
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
            private void ResetEmployeeForm()
            {
                EmployeeNameTxt.Clear();
                EmployeeSurnameTxt.Clear();
                EmployeeEmailTxt.Clear();
                EmployeePhoneTxt.Clear();
                cbPositionGroup.SelectedIndex = 0;
                dtpEmployeeCreate.Value = DateTime.Now;
                EmployeeSalaryTxt.Clear();

                EmployeeDeleteBtn.Enabled = false;
                EmployeeCreateBtn.Enabled = true;
                EmployeeUpdateBtn.Enabled = false;
            }

            private bool DeleteEmployee()
            {
                int affectedRows = 0;
                using (AcademyEntities1 db = new AcademyEntities1())
                {

                    Employee newEmp = db.Employees.Where(s => s.İd == EmployeesCRUD.İd).FirstOrDefault();
                    newEmp.Status = false;
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
        private void EmployeeCreateBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateEmployeeForm())
            {
                if (!CreateEmployee())
                {
                    MessageBox.Show("Employee can't created", "Error");
                    return;
                }
                MessageBox.Show("Employee Created");

            }
            GenerateEmployees();
            ResetEmployeeForm();
        }

        private void EmployeeUpdateBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateEmployeeForm())
            {
                if (!UpdateEmployee())
                {
                    MessageBox.Show("Employee can't updated", "Error");
                    return;
                }
                MessageBox.Show("Employee Updated");
            }
            GenerateEmployees();
            ResetEmployeeForm();
        }

        private void EmployeeDeleteBtn_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Are you sure delete " + EmployeesCRUD.Name + " " + EmployeesCRUD.Surname + " ?", "Employee Delete", MessageBoxButtons.OKCancel);

            if (DialogResult.OK != message)
            {
                return;
            }

            if (!DeleteEmployee())
            {
                MessageBox.Show("Employee can't delete", "Warning");
                return;
            }

            MessageBox.Show("Employee Deleted");

            GenerateEmployees();
            ResetEmployeeForm();
        }

        private void EmployeeResetBtn_Click(object sender, EventArgs e)
        {
            ResetEmployeeForm();
        }

        private void DgvEmployeeCreate_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int employeeID = (int)dgvEmployeeCreate.Rows[e.RowIndex].Cells[0].Value;

            using (AcademyEntities1 db = new AcademyEntities1())
            {
                EmployeesCRUD = db.Employees.Where(s => s.İd == employeeID).FirstOrDefault();
                if (EmployeesCRUD != null)
                {
                    EmployeeNameTxt.Text = EmployeesCRUD.Name;
                    EmployeeSurnameTxt.Text = EmployeesCRUD.Surname;
                    EmployeeEmailTxt.Text = EmployeesCRUD.Email;
                    EmployeePhoneTxt.Text = EmployeesCRUD.Phone;
                    cbPositionGroup.SelectedItem = EmployeesCRUD.Position.Name;
                    dtpEmployeeCreate.Value = EmployeesCRUD.Start_Time;
                    EmployeeSalaryTxt.Text = Convert.ToString(EmployeesCRUD.Salary);

                }
            }
            EmployeeCreateBtn.Enabled = false;
            EmployeeDeleteBtn.Enabled = true;
            EmployeeUpdateBtn.Enabled = true;
        }
        private void EmployeeCRUD_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}


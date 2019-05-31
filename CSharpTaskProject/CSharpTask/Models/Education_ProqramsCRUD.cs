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
    public partial class Education_ProqramsCRUD : Form
    {
        Education_Proqrams EdusCRUD = new Education_Proqrams();
        public Education_ProqramsCRUD()
        {
            InitializeComponent();
            GenerateEdu();
        }
            private bool ValidateEduForm()
            {
                if (EduNameTxt.Text == "" || EduPriceTxt.Text == "")
                {
                    MessageBox.Show("Input wouldn't be empty");
                    return true;
                }
                if (!Regex.Match(EduNameTxt.Text, "^[\\p{L} \\.'\\-]+$").Success)
                {
                    MessageBox.Show("Name should be only letter", "Warning");
                    return true;
                }
          
                if (!Regex.Match(EduPriceTxt.Text, "(\\d{4})").Success)
                {
                    MessageBox.Show("Please, Enter correct Price format", "Warning");
                    return true;
                }
                return false;
            }

            private void GenerateEdu()
            {
                dgvEduCreate.Rows.Clear();

                using (AcademyEntities1 db = new AcademyEntities1())
                {

                    List<Education_Proqrams> edus = db.Education_Proqrams.Where(su => su.Status == true).ToList();

                    foreach (var edu in edus)
                    {
                        dgvEduCreate.Rows.Add(edu.İd,
                                             edu.Name,
                                             edu.Price
                                             );
                    }

                }
                EduUpdateBtn.Enabled = false;
                EduDeleteBtn.Enabled = false;
            }
           
            private bool CreateEdu()
            {
                int affectedRows = 0;
                using (AcademyEntities1 db = new AcademyEntities1())
                {
                    Education_Proqrams edu = new Education_Proqrams
                    {
                        Name = EduNameTxt.Text,
                        Price = Convert.ToDouble(EduPriceTxt.Text),
                        Status = true
                    };

                    db.Education_Proqrams.Add(edu);

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

            private bool UpdateEdu()
            {
                int affectedRows = 0;
                using (AcademyEntities1 db = new AcademyEntities1())
                {
                    Education_Proqrams newEdu = db.Education_Proqrams.Where(s => s.İd == EdusCRUD.İd).FirstOrDefault();

                    newEdu.Name = EduNameTxt.Text;
                    newEdu.Price = Convert.ToDouble(EduPriceTxt.Text);
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
            private void ResetEduForm()
            {
                EduNameTxt.Clear();
                EduPriceTxt.Clear();

                EduDeleteBtn.Enabled = false;
                EduCreateBtn.Enabled = true;
                EduUpdateBtn.Enabled = false;
            }

            private bool DeleteEdu()
            {
                int affectedRows = 0;
                using (AcademyEntities1 db = new AcademyEntities1())
                {

                    Education_Proqrams newEdu = db.Education_Proqrams.Where(s => s.İd == EdusCRUD.İd).FirstOrDefault();
                    newEdu.Status = false;
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
        private void EduCreateBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateEduForm())
            {
                if (!CreateEdu())
                {
                    MessageBox.Show("Education Proqram can't created", "Error");
                    return;
                }
                MessageBox.Show("Education Proqram Created");

            }
            GenerateEdu();
            ResetEduForm();
        }

        private void EduUpdateBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateEduForm())
            {
                if (!UpdateEdu())
                {
                    MessageBox.Show("Education Proqram can't updated", "Error");
                    return;
                }
                MessageBox.Show("Education Proqram Updated");
            }
            GenerateEdu();
            ResetEduForm();
        }

        private void EduDeleteBtn_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Are you sure delete " + EdusCRUD.Name + " ?", "Education Proqram Delete", MessageBoxButtons.OKCancel);

            if (DialogResult.OK != message)
            {
                return;
            }

            if (!DeleteEdu())
            {
                MessageBox.Show("Education Proqram can't delete", "Warning");
                return;
            }

            MessageBox.Show("Education Proqram Deleted");

            GenerateEdu();
            ResetEduForm();
        }

        private void EduResetBtn_Click(object sender, EventArgs e)
        {
            ResetEduForm();
        }

        private void DgvEduCreate_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int eduID = (int)dgvEduCreate.Rows[e.RowIndex].Cells[0].Value;

            using (AcademyEntities1 db = new AcademyEntities1())
            {
                EdusCRUD = db.Education_Proqrams.Where(s => s.İd == eduID).FirstOrDefault();
                if (EdusCRUD != null)
                {
                    EduNameTxt.Text = EdusCRUD.Name;
                    EduPriceTxt.Text = Convert.ToString(EdusCRUD.Price);

                }
            }
            EduCreateBtn.Enabled = false;
            EduDeleteBtn.Enabled = true;
            EduUpdateBtn.Enabled = true;
        }

        private void Education_ProqramsCRUD_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }

}


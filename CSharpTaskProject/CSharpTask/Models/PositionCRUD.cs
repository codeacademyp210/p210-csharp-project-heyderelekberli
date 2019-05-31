using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpTask.Models
{
    public partial class PositionCRUD : Form
    {
        Position PosCRUD = new Position();
        public PositionCRUD()
        {
            InitializeComponent();
            GeneratePos();
        }

        private bool ValidatePosForm()
        {
            if (PositionNameTxt.Text == "")
            {
                MessageBox.Show("Input wouldn't be empty");
                return true;
            }
            if (!Regex.Match(PositionNameTxt.Text, "^[\\p{L} \\.'\\-]+$").Success)
            {
                MessageBox.Show("Name should be only letter", "Warning");
                return true;
            }
            return false;
        }

        private void GeneratePos()
        {
            dgvPositionCreate.Rows.Clear();

            using (AcademyEntities1 db = new AcademyEntities1())
            {

                List<Position> poss = db.Positions.Where(su => su.Status == true).ToList();

                foreach (var pos in poss)
                {
                    dgvPositionCreate.Rows.Add(pos.İd,
                                         pos.Name
                                         );
                }

            }
            PositionUpdateBtn.Enabled = false;
            PositionDeleteBtn.Enabled = false;
        }

        private bool CreatePos()
        {
            int affectedRows = 0;
            using (AcademyEntities1 db = new AcademyEntities1())
            {
                Position pos = new Position
                {
                    Name = PositionNameTxt.Text,
                    Status = true
                };

                db.Positions.Add(pos);

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

        private bool UpdatePos()
        {
            int affectedRows = 0;
            using (AcademyEntities1 db = new AcademyEntities1())
            {
                Position newPos = db.Positions.Where(s => s.İd == PosCRUD.İd).FirstOrDefault();

                newPos.Name = PositionNameTxt.Text;
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
        private void ResetPosForm()
        {
            PositionNameTxt.Clear();

            PositionDeleteBtn.Enabled = false;
            PositionCreateBtn.Enabled = true;
            PositionUpdateBtn.Enabled = false;
        }

        private bool DeleteClass()
        {
            int affectedRows = 0;
            using (AcademyEntities1 db = new AcademyEntities1())
            {

                Position newPos = db.Positions.Where(s => s.İd == PosCRUD.İd).FirstOrDefault();
                newPos.Status = false;
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
        private void PositionCreateBtn_Click_1(object sender, EventArgs e)
        {
            if (!ValidatePosForm())
            {
                if (!CreatePos())
                {
                    MessageBox.Show("Position can't created", "Error");
                    return;
                }
                MessageBox.Show("Position Created");

            }
            GeneratePos();
            ResetPosForm();
        }

        private void PositionUpdateBtn_Click_1(object sender, EventArgs e)
        {
            if (!ValidatePosForm())
            {
                if (!UpdatePos())
                {
                    MessageBox.Show("Position can't updated", "Error");
                    return;
                }
                MessageBox.Show("Position Updated");
            }
            GeneratePos();
            ResetPosForm();
        }

        private void PositionDeleteBtn_Click_1(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Are you sure delete " + PosCRUD.Name + " ?", "Position Delete", MessageBoxButtons.OKCancel);

            if (DialogResult.OK != message)
            {
                return;
            }

            if (!DeleteClass())
            {
                MessageBox.Show("Position can't delete", "Warning");
                return;
            }

            MessageBox.Show("Position Deleted");

            GeneratePos();
            ResetPosForm();
        }
        private void PositionResetBtn_Click_1(object sender, EventArgs e)
        {
            ResetPosForm();
        }
        private void DgvPositionCreate_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posID = (int)dgvPositionCreate.Rows[e.RowIndex].Cells[0].Value;

            using (AcademyEntities1 db = new AcademyEntities1())
            {
                PosCRUD = db.Positions.Where(s => s.İd == posID).FirstOrDefault();
                if (PosCRUD != null)
                {
                    PositionNameTxt.Text = PosCRUD.Name;
                }
            }
            PositionCreateBtn.Enabled = false;
            PositionDeleteBtn.Enabled = true;
            PositionUpdateBtn.Enabled = true;
        }
        private void PositionCRUD_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}

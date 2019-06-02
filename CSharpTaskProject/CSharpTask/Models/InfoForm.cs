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
    public partial class InfoForm : Form
    {
        
        public InfoForm()
        {
            InitializeComponent();
            FillInfoBox();
            GenerateClass();
        }

        private void FillInfoBox()
        {

            string text = @"Code Academy haqqında 

2015 - ci ildə fəaliyyətə başlayan Code Academy yüksək texnologiyalar sahəsində təcrübəli mütəxəssislər hazırlayan tədris müəssisəsidir.Code Academy-nin məqsədi Azərbaycanda bu sahədə karyera qurmaq istəyənlərin potensialını dəyərləndirmək, fərdi və peşəkar inkişafı üçün onları lazımi məlumatlarla və praktiki vərdişlərlə təmin etməkdir.
Code Academy-nin təhsil strategiyasının əsas məqsədlərindən biri qlobal bazarda rəqabət apara biləcək kadrlar hazırlamaqdır. Sektorun dəyişən ehtiyaclarını qiymətləndirmək üçün şirkət rəhbərləri ilə davamlı ünsiyyətdə olan Code Academy bu sahənin gözləntilərinə uyğun təcrübəli mütəxəssislər yetişdirir.
Məzunlarının uğurlu karyera qurması Code Academy-də təhsilin müasir dövrün tələblərinə tam olaraq cavab verdiyinin ən bariz nümunəsidir.Eyni zamanda, təhsillərini müvəffəqiyyətlə başa vuran tələbələr beynəlxalq sertifikatlar əldə edə bilərlər.Beləliklə, onlar yalnız Azərbaycanda deyil, onun hüdudlarından kənarda da uğurlu karyera qurmaq şansına malik olurlar.";

            InfoText.Text = text;
           
        }
            private void GenerateClass()
            {
            using (AcademyEntities1 db = new AcademyEntities1())
            {

                List<Academy> aca = db.Academies.ToList();

                foreach (var item in aca)
                {
                    AddressText.Text = ("Unvan: " + item.Street);
                    PhoneText.Text = ("Elaqe Nomresi: " + item.Phone);
                }
            }
        }
        private void InfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}

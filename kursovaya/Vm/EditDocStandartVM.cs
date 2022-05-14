using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using kursovaya.DTO;
using kursovaya.Vm;
using kursovaya;
using kursovaya.Model;
using kursovaya.Pages;
using kursovaya.Tools;
using kursovaya.Pages;
using MySql.Data.MySqlClient;

namespace kursovaya.Vm
{
    public class EditDocStandartVM : BaseVm
    {
        public DocStandart EditDocStandart { get; }

        public Command SaveEnrolle { get; set; }
        public Discipline EnrolleDiscipline
        {
            get => enrolleDiscipline;
            set
            {
                enrolleDiscipline = value;
                Signal();
            }
        }


        public List<Discipline> Disciplines { get; set; }

        private CurrentPageControl currentPageControl;
        private Discipline enrolleDiscipline;


        public EditDocStandartVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            EditDocStandart = new DocStandart();
            Init();
        }

        public EditDocStandartVM(Enrolle editEnrolle, CurrentPageControl currentPageControl, Passport editPassport, DocStandart editDocStandart, Certificate editCertificate)
        {

            EditDocStandart = editDocStandart;
            this.currentPageControl = currentPageControl;
            Init();
            EnrolleDiscipline = Disciplines.FirstOrDefault(s => s.ID == editEnrolle.Discipline_idDiscipline);
        }

        private void Init()
        {

            Disciplines = Sql.GetInstance().SelectDisciplinesRange();
            SaveEnrolle = new Command(() =>
            {
                EditDocStandart.Enrollelist_idEnrollelist = 7;

                var model = Sql.GetInstance();
                if (EditDocStandart.ID == 0)
                {
                    model.Insert(EditDocStandart);
                }
                else
                {
                    model.Update(EditDocStandart);
                }
                currentPageControl.SetPage(new Enrollelist(EnrolleDiscipline));
            });
        }
    }
}

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
using MySql.Data.MySqlClient;

namespace kursovaya.Vm
{
    public class EditOrphanEnrolleVM : BaseVm
    {
        public Enrolle EditEnrolle { get; }
        public Passport EditPassport { get; }
        public Certificate EditCertificate { get; }
        public OtherOrphan EditOtherOrphan { get; }
        public Command SaveEnrolle { get; set; }
        public Discipline EnrolleDiscipline
        {
            get => EnrolleDiscipline;
            set
            {
                EnrolleDiscipline = value;
                Signal();
            }
        }

        public List<Discipline> Disciplines { get; set; }

        private CurrentPageControl currentPageControl;
        private Discipline enrolleDiscipline;

        public EditOrphanEnrolleVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            EditEnrolle = new Enrolle();
            EditCertificate = new Certificate();
            EditPassport = new Passport();
            Init();
        }

        public EditOrphanEnrolleVM(Enrolle editEnrolle, Passport editPassport, Certificate editCertificate, OtherOrphan editOtherOrphan, CurrentPageControl currentPageControl)
        {
            EditEnrolle = editEnrolle;
            EditCertificate = editCertificate;
            EditPassport = editPassport;
            EditOtherOrphan = editOtherOrphan;
            this.currentPageControl = currentPageControl;
            Init();
            EnrolleDiscipline = Disciplines.FirstOrDefault(s => s.IDDisciplines == editEnrolle.DisciplineId);
        }

        private void Init()
        {
            Disciplines = Sql.GetInstance().SelectDisciplinesRange();
            SaveEnrolle = new Command(() => {
                EditEnrolle.DisciplineId = EnrolleDiscipline.IDDisciplines;
                var model = Sql.GetInstance();
                if (EditEnrolle.ID == 0)
                {
                    model.Insert(EditEnrolle);
                    model.Insert(EditCertificate);
                    model.Insert(EditPassport);
                    model.Insert(EditOtherOrphan);
                }
                else
                {
                    model.Update(EditEnrolle);
                    model.Update(EditCertificate);
                    model.Update(EditPassport);
                    model.Insert(EditOtherOrphan);
                }
                currentPageControl.SetPage(new Enrollelist(EnrolleDiscipline));
            });
        }
    }
}

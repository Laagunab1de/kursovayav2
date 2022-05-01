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
            Init();
        }

        public EditOrphanEnrolleVM(Enrolle editEnrolle, CurrentPageControl currentPageControl)
        {
            EditEnrolle = editEnrolle;
            this.currentPageControl = currentPageControl;
            Init();
            EnrolleDiscipline = Disciplines.FirstOrDefault(s => s.IDDisciplines == editEnrolle.DisciplineId);
        }

        private void Init()
        {
            Disciplines = Sql.GetInstance().SelectDisciplinesRange(0, 100);
            SaveEnrolle = new Command(() => {
                EditEnrolle.DisciplineId = EnrolleDiscipline.IDDisciplines;
                var model = Sql.GetInstance();
                if (EditEnrolle.ID == 0)
                    model.Insert(EditEnrolle);
                else
                    //model.Update(EditEnrolle);
                currentPageControl.SetPage(new Enrollelist(EnrolleDiscipline));
            });
        }
    }
}

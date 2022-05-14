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
    public class EditPasspotVM : BaseVm
    {
       
       
        public Passport EditPassport { get; }

        public Command EditDocStandart { get; set; }
        public Command EditOtherOrphan { get; set; }
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
       
        public EditPasspotVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
          
            EditPassport = new Passport();
           
            Init();
        }

        public EditPasspotVM(Enrolle editEnrolle, CurrentPageControl currentPageControl, Passport editPassport, DocStandart editDocStandart, Certificate editCertificate)
        {
          
            EditPassport = editPassport;
            
            this.currentPageControl = currentPageControl;
            Init();
            EnrolleDiscipline = Disciplines.FirstOrDefault(s => s.ID == editEnrolle.Discipline_idDiscipline);
            
        }

        private void Init()
        {
           
            Disciplines = Sql.GetInstance().SelectDisciplinesRange();
            EditDocStandart = new Command(() =>
            {
                var model = Sql.GetInstance();
                if (EditPassport.ID == 0)
                {                 
                    model.Insert(EditPassport);
                }
                else
                {               
                    model.Update(EditPassport);  
                }
                currentPageControl.SetPage(new EditDocStandart()); 
            });
            EditOtherOrphan = new Command(() =>
            {
                var model = Sql.GetInstance();
                if (EditPassport.ID == 0)
                {
                    model.Insert(EditPassport);
                }
                else
                {
                    model.Update(EditPassport);
                }
                currentPageControl.SetPage(new EditOthetOrphan());
            });
        }
    }
}

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
    public class EditOtherOrphanVM : BaseVm
    {
       
        public OtherOrphan EditOtherOrphan { get; }

        public Command SaveEnrolle { get; set; }
        public Enrolle EnrolleOtherOrphan
        {
            get => enrolleOtherOrphan;
            set
            {
                enrolleOtherOrphan = value;
                Signal();
            }
        }

      
        public List<Enrolle> Enrolles { get; set; }
        
        private CurrentPageControl currentPageControl;
        private Enrolle enrolleOtherOrphan;
       

        public EditOtherOrphanVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;          
            EditOtherOrphan = new OtherOrphan();
            Init();
        }

        public EditOtherOrphanVM(CurrentPageControl currentPageControl, OtherOrphan editOtherOrphan)
        {
            EditOtherOrphan = editOtherOrphan;           
            this.currentPageControl = currentPageControl;
            Init();
        }

        private void Init()
        {
            Enrolles = Sql.GetInstance().SelectEnrollesRange();
            SaveEnrolle = new Command(() =>
            {
                EditOtherOrphan.Enrollelist_idEnrollelist = EnrolleOtherOrphan.ID;
                var model = Sql.GetInstance();
                if (EditOtherOrphan.ID == 0)
                {

                    model.Insert(EditOtherOrphan);
                }
                else
                {
                    model.Update(EditOtherOrphan);
                }
                currentPageControl.SetPage(new Enrollelist(null));
            });
        } 
    }
}

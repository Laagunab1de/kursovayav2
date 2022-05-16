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
        public Enrolle EnrolleDocStandart
        {
            get => enrolleDocStandart;
            set
            {
                enrolleDocStandart = value;
                Signal();
            }
        }


        public List<Enrolle> Enrolles { get; set; }

        private CurrentPageControl currentPageControl;
        private Enrolle enrolleDocStandart;


        public EditDocStandartVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            EditDocStandart = new DocStandart();
            Init();
        }

        public EditDocStandartVM(Enrolle editEnrolle, CurrentPageControl currentPageControl, DocStandart editDocStandart)
        {

            EditDocStandart = editDocStandart;
            this.currentPageControl = currentPageControl;
            Init();
            EnrolleDocStandart = Enrolles.FirstOrDefault(s => s.ID == editDocStandart.Enrollelist_idEnrollelist);
        }

        private void Init()
        {

            Enrolles = Sql.GetInstance().SelectEnrollesRange();
            SaveEnrolle = new Command(() =>
            {
                EditDocStandart.Enrollelist_idEnrollelist = EnrolleDocStandart.ID;

                var model = Sql.GetInstance();
                if (EditDocStandart.ID == 0)
                {
                    model.Insert(EditDocStandart);
                }
                else
                {
                    model.Update(EditDocStandart);
                }
                currentPageControl.SetPage(new Enrollelist(null));
            });
        }
    }
}

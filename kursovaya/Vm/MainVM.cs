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
    public class MainVm : BaseVm
    {
        public CurrentPageControl currentPageControl;

        public Page CurrentPage
        {
            get => currentPageControl.Page;

        }

        public Command ConnectToBDCom { get; set; }
        public Command ViewDepartment { get; set; }
        public Command AddDepartment { get; set; }
        public Command ViewDiscipline { get; set; }
        public Command AddDiscipline { get; set; }
        public Command EditOrphanEnrolle { get; set; }
        public Command EditStandartEnrolle { get; set; }
        public Command ViewEnrollee { get; set; }
        public MainVm()
        {
            currentPageControl = new CurrentPageControl();
            currentPageControl.PageChanged += CurrentPageControl_PageChanged;
            ViewEnrollee = new Command(() => {
                currentPageControl.SetPage(new Enrollelist(null));
            });
            EditStandartEnrolle = new Command(() => {
                currentPageControl.SetPage(new EditStandartEnrolle(new EditStandartEnrolleVM(currentPageControl)));
            });
            EditOrphanEnrolle = new Command(() => {
                currentPageControl.SetPage(new EditOrphanEnrolle(new EditOrphanEnrolleVM(currentPageControl)));
            });
            AddDiscipline = new Command(() => {
                currentPageControl.SetPage(new EditDiscipline(null));
            });
            ViewDiscipline = new Command(() => {
                currentPageControl.SetPage(new ViewDiscipline());
            });
            ViewDepartment = new Command(() =>
            {
                currentPageControl.SetPage(new ViewDepartmentsPage(null));
            });
            AddDepartment = new Command(() => {
                currentPageControl.SetPage(new EditDepartmentsPage(null));
            });
            ConnectToBDCom = new Command(() => {
                currentPageControl.SetPage(new ConnectToBD());
            });
        }

        private void CurrentPageControl_PageChanged(object sender, EventArgs e)
        {
            Signal(nameof(CurrentPage));
        }
    }
}

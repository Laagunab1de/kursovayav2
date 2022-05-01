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
    public class EditDepartmentsVM
    {
        public Departments EditDemartment { get; set; }
        public Command SaveDemartment { get; set; }

        private CurrentPageControl currentPageControl;
        public EditDepartmentsVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            EditDemartment = new Departments();
            InitCommand();
        }
        public EditDepartmentsVM(Departments editDepartments, CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            EditDemartment = editDepartments;
            InitCommand();
        }

        private void InitCommand()
        {
            SaveDemartment = new Command(() => {
                var model = Sql.GetInstance();
                if (EditDemartment.ID == 0)
                    model.Insert(EditDemartment);
                else
                  //  model.Update(EditDemartment);
                currentPageControl.Back();
            });
        }

    }
}

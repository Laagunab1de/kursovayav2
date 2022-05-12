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
        public Department EditDepartment { get; set; }
        public Command SaveDemartment { get; set; }

        public CurrentPageControl currentPageControl;
        public EditDepartmentsVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            EditDepartment = new Department();
            InitCommand();
        }
        public EditDepartmentsVM(Department editDepartments, CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            EditDepartment = editDepartments;
            InitCommand();
        }

        private void InitCommand()
        {
            SaveDemartment = new Command(() => {
                var model = Sql.GetInstance();
                if (EditDepartment.IDDepatment == 0)
                    model.Insert(EditDepartment);
                else
                    model.Update(EditDepartment);
                currentPageControl.Back();
            });
        }

    }
}

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
    public class ViewDepartmentsVM : BaseVm
    {

        public List<Departments> Departments
        {
            get => Departments;
            set
            {
                Departments = value;
                Signal();
            }
        }
        public Enrolle SelectedEnrolle { get; set; }

        public ViewDepartmentsVM(Departments selectedDepartment)
        {
            Sql sqlModel = Sql.GetInstance();
            //Departments = sqlModel.SelectDisciplinesRange(0, 100);

        }
    }
}

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
    public class ViewEnrollelistVM : BaseVm
    {
        private Discipline selectedDiscipline;
        private List<Enrolle> enrolleBySelectedDiscipline;

        public List<Discipline> Disciplines { get; set; }
        public Discipline SelectedDiscipline
        {
            get => selectedDiscipline;
            set
            {
                selectedDiscipline = value;
                EnrollesBySelectedDiscipline = Sql.GetInstance().SelectEnrollesByDiscipline(selectedDiscipline);
                Signal();
            }
        }
        public List<Enrolle> EnrollesBySelectedDiscipline
        {
            get => enrolleBySelectedDiscipline;
            set
            {
                enrolleBySelectedDiscipline = value;
                Signal();
            }
        }
        public Enrolle SelectedEnrolle { get; set; }

        public ViewEnrollelistVM(Discipline selectedDiscipline)
        {
            Sql sqlModel = Sql.GetInstance();
            Disciplines = sqlModel.SelectDisciplinesRange();

        }
    }
}

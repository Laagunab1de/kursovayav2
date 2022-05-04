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
    public class EditDisciplineVM
    {
        public Discipline EditDiscipline { get; set; }
        public Command SaveDiscipline { get; set; }

        public CurrentPageControl currentPageControl;
        public EditDisciplineVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            EditDiscipline = new Discipline();
            InitCommand();
        }
        public EditDisciplineVM(Discipline editDiscipline, CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            EditDiscipline = editDiscipline;
            InitCommand();
        }

        private void InitCommand()
        {
            SaveDiscipline = new Command(() => {
                var model = Sql.GetInstance();
                if (EditDiscipline.IDDisciplines == 0)
                    model.Insert(EditDiscipline);
                else
                    model.Update(EditDiscipline);
                currentPageControl.Back();
            });
        }


    }
}

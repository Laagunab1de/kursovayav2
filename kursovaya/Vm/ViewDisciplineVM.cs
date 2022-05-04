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
    class ViewDisciplineVM : BaseVm
    {
        public Discipline Discipline { get; set; }
        public List<Discipline> disciplines;
        private int viewRowsCount;
        public List<Discipline> Disciplines
        {
            get => Disciplines;
            set
            {
                Disciplines = value;    
                Signal();
            }
        }
        public int ViewRowsCount
        {
            get => viewRowsCount;
            set
            {
                viewRowsCount = value;
                InitPages();
                Signal();
            }
        }

        public ViewDisciplineVM()
        {

            ViewRowsCount = 50;

            InitPages();
        }

        private void InitPages()
        {
            var sqlModel = Sql.GetInstance();
            int pageCount = (sqlModel.GetNumRows(typeof(Discipline)) / ViewRowsCount) + 1;
            
        }
    }
}

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
using kursovaya.Pages;
using kursovaya.Tools;

namespace kursovaya.Pages
{
    /// <summary>
    /// Interaction logic for Enrollelist.xaml
    /// </summary>
    public partial class Enrollelist : Page
    {
        public Enrollelist(Discipline selectedDiscipline)
        {
            InitializeComponent();
            DataContext = new ViewEnrollelistVM(selectedDiscipline);
        }
    }
}

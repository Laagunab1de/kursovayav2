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


namespace kursovaya.Pages
{
    /// <summary>
    /// Interaction logic for ViewDepartmentsPage.xaml
    /// </summary>
    public partial class ViewDepartmentsPage : Page
    {
        public ViewDepartmentsPage()
        {
            InitializeComponent();
            DataContext = new ViewDepartmentsVM();
        }
    }
}

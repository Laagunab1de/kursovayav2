﻿using System;
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
using kursovaya.Model;


namespace kursovaya.Pages
{
    /// <summary>
    /// Interaction logic for ViewDiscipline.xaml
    /// </summary>
    public partial class ViewDiscipline : Page
    {
        public ViewDiscipline()
        {
            InitializeComponent();
            DataContext = new ViewDisciplineVM();
        }
    }
}

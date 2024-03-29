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
using kursovaya;
using kursovaya.Model;
using kursovaya.Pages;
using kursovaya.Tools;
using MySql.Data.MySqlClient;

namespace kursovaya.Tools
{
    public class CurrentPageControl
    {
        Stack<Page> pages = new Stack<Page>();

        public Page Page { get; internal set; }
        public event EventHandler PageChanged;

        internal void SetPage(Page optionPage)
        {
            if (Page != null)
                pages.Push(Page);
            Page = optionPage;
            PageChanged?.Invoke(this, new EventArgs());
        }

        internal void Back()
        {
            if (pages.Count > 0)
                Page = pages.Pop();
            else
                Page = null;
            PageChanged?.Invoke(this, new EventArgs());
        }
    }
}

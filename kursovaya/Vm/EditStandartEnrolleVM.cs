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
using kursovaya.Pages;
using MySql.Data.MySqlClient;

namespace kursovaya.Vm
{
    public class EditStandartEnrolleVM : BaseVm
    {
        public Enrolle EditEnrolle { get; }
        public Command EditCertificatePage { get; set; }
        public Discipline EnrolleDiscipline 
        {        
            get => enrolleDiscipline;
            set
            {
                enrolleDiscipline = value;
                Signal();
            }
        }

        public Department EnrolleDepartment
        {
            get => enrolleDepartment;
            set
            {
                enrolleDepartment = value;
                Signal();
            }
        }
        public List<Discipline> Disciplines { get; set; }
        public List<Department> Departments { get; set; }
        private CurrentPageControl currentPageControl;
        private Discipline enrolleDiscipline;
        private Department enrolleDepartment;

        public EditStandartEnrolleVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            EditEnrolle = new Enrolle();          
            Init();
        }

        public EditStandartEnrolleVM(Enrolle editEnrolle, CurrentPageControl currentPageControl)
        {
          
            EditEnrolle = editEnrolle;
            this.currentPageControl = currentPageControl;
            Init();
            EnrolleDiscipline = Disciplines.FirstOrDefault(s => s.ID == editEnrolle.Discipline_idDiscipline);
            EnrolleDepartment = Departments.FirstOrDefault(s => s.ID == editEnrolle.Department_idDepartment);         
        }

        private void Init()
        {
            Departments = Sql.GetInstance().SelectDepartmentsRange();
            Disciplines = Sql.GetInstance().SelectDisciplinesRange();
            EditCertificatePage = new Command(() => { 
                EditEnrolle.Discipline_idDiscipline = EnrolleDiscipline.ID;
                EditEnrolle.Department_idDepartment = EnrolleDepartment.IDDepatment;
               
                
                var model = Sql.GetInstance();
                if (EditEnrolle.ID == 0)
                {
                    model.Insert(EditEnrolle);
                  
                }
                else
                {
                    model.Update(EditEnrolle);
                   
                }
                currentPageControl.SetPage(new EditCertificate(new EditCertificateVM(currentPageControl)));
            });
        }
    }
}

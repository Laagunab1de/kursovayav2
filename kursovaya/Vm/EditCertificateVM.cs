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
    public class EditCertificateVM : BaseVm
    {
       
        public Certificate EditCertificate { get; }
        public Command EditPassportPage { get; set; }
       
        public Enrolle EnrolleCertificate
        {
            get => enrolleCertificate;
            set
            {
                enrolleCertificate = value;
                Signal();
            }
        }
    
        public List<Enrolle> Enrolles { get; set; }       
        private CurrentPageControl currentPageControl;
    
        private Enrolle enrolleCertificate;

        public EditCertificateVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;         
            EditCertificate = new Certificate();          
            Init();
        }

        public EditCertificateVM(CurrentPageControl currentPageControl, Certificate editCertificate)
        {
            EditCertificate = editCertificate;          
            this.currentPageControl = currentPageControl;
            Init();            
            EnrolleCertificate = Enrolles.FirstOrDefault(s => s.ID == editCertificate.Enrollelist_idEnrollelist);
        }

        private void Init()
        {
            Enrolles = Sql.GetInstance().SelectEnrollesRange();
            EditPassportPage = new Command(() => {              
                EditCertificate.Enrollelist_idEnrollelist = EnrolleCertificate.ID;

                var model = Sql.GetInstance();
                if (EditCertificate.ID == 0)
                {              
                    model.Insert(EditCertificate);                  
                }
                else
                {                   
                    model.Update(EditCertificate);   
                }
                currentPageControl.SetPage(new EditPassport());
            });
        }
    }
}

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
using kursovaya.Pages;
using MySql.Data.MySqlClient;

namespace kursovaya.Vm
{
    public class EditCertificateVM : BaseVm
    {
       
        public Certificate EditCertificate { get; }
        public Command EditPassportPage { get; set; }
       
        public Certificate EnrolleCertificate
        {
            get => enrolleCertificate;
            set
            {
                enrolleCertificate = value;
                Signal();
            }
        }
    
        public List<Certificate> Certificates { get; set; }       
        private CurrentPageControl currentPageControl;
    
        private Certificate enrolleCertificate;

        public EditCertificateVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;         
            EditCertificate = new Certificate();          
            Init();
        }

        public EditCertificateVM(Enrolle editEnrolle, CurrentPageControl currentPageControl, Passport editPassport, DocStandart editDocStandart, Certificate editCertificate)
        {
            EditCertificate = editCertificate;          
            this.currentPageControl = currentPageControl;
            Init();            
            EnrolleCertificate = Certificates.FirstOrDefault(s => s.ID == editCertificate.Enrollelist_idEnrollelist);
        }

        private void Init()
        {

            EditPassportPage = new Command(() => {              
                EditCertificate.Enrollelist_idEnrollelist = 7;

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

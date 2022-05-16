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


namespace kursovaya.DTO
{
    [Table("otherorphan")]
    public class OtherOrphan : BaseDTO//доки для сирот 
    {
       
       
        [Column("CopyOfInsuranceCertificate")]
        public string CopyOfInsuranceCertificate { get; set; }//копия страховки
        [Column("CHIpolicy")]
        public string CopyOfTheCHIPolicy { get; set; }//что такое омс 
        [Column("BirthCertificate")]
        public string CopyBirthCertificateCitizenship { get; set; }//Копия свидетельства о рождении с гражданством
        [Column("CopyCourtDecisionConfirmingLegalStatus")]
        public string CopyCourtDecisionConfirmingLegalStatus { get; set; }//Копия решения суда, подтверждающего правовой статус
        [Column("CopyDocumentLegalRepresentative")]
        public string CopyDocumentLegalRepresentative { get; set; }//Копия документа о законном представителе
        [Column("InformationAboutPeriodStayOrphanage")]
        public string InformationAboutPeriodStayOrphanage { get; set; }//Информация о периоде пребывания в детском доме
        [Column("CertificateGuardianshipAuthoritiesStatus")]
        public string CertificateGuardianshipAuthoritiesStatus { get; set; }//Справка из органов опеки о статусе
        [Column("CopiesDocumentsHousing")]
        public string CopiesDocumentsHousing { get; set; }//Копии документов на жилье (тоже хз че к чему) 
        [Column("CertificateExtraordinaryReceiptLivingSpace")]
        public string CertificateExtraordinaryReceiptLivingSpace { get; set; }//Свидетельство о внеочередном получении жилплощади
        [Column("ResultsFluorographicExamination")]
        public string ResultsFluorographicExamination { get; set; }//флюшка 
        [Column("ContactPhoneNumbers")]
        public string ContactPhoneNumbers { get; set; }//номер телефона 
      
        [Column("Enrollelist_idEnrollelist")]
       public int Enrollelist_idEnrollelist { get; set; }
    }
}

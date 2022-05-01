using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya.DTO
{
    public class OtherOrphan//доки для сирот 
    {
        public bool ApplicationForAdmission { get; set; }//заявление 
        public bool PassportAndItsCopy { get; set; }//пасспорт 
        public bool CertificateOfEducation { get; set; }//аттестат
        public bool CopyOfInsuranceCertificate { get; set; }//копия страховки
        public bool CopyOfTheCHIPolicy { get; set; }//что такое омс 
        public bool CopyBirthCertificateCitizenship { get; set; }//Копия свидетельства о рождении с гражданством
        public bool CopyCourtDecisionConfirmingLegalStatus { get; set; }//Копия решения суда, подтверждающего правовой статус
        public bool CopyDocumentLegalRepresentative { get; set; }//Копия документа о законном представителе
        public bool InformationAboutPeriodStayOrphanage { get; set; }//Информация о периоде пребывания в детском доме
        public bool CertificateGuardianshipAuthoritiesStatus { get; set; }//Справка из органов опеки о статусе
        public bool CopiesDocumentsHousing { get; set; }//Копии документов на жилье (тоже хз че к чему) 
        public bool CertificateExtraordinaryReceiptLivingSpace { get; set; }//Свидетельство о внеочередном получении жилплощади
        public bool ResultsFluorographicExamination { get; set; }//флюшка 
        public bool ContactPhoneNumbers { get; set; }//номер телефона 

    }
}

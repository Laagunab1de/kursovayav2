using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kursovaya.Tools;

namespace kursovaya.DTO
{
    [Table("enrollelist")]
    public class OtherOrphan//доки для сирот 
    {
        [Column("idOtherOrphan")]

        public string idOtherOrphan { get; set; }
        [Column("ApplicationForAdmission")]
        public bool ApplicationForAdmission { get; set; }//заявление 
        [Column("CopyOfInsuranceCertificate")]
        public bool CopyOfInsuranceCertificate { get; set; }//копия страховки
        [Column("CHIPolicy")]
        public bool CopyOfTheCHIPolicy { get; set; }//что такое омс 
        [Column("BirthCertificate")]
        public bool CopyBirthCertificateCitizenship { get; set; }//Копия свидетельства о рождении с гражданством
        [Column("CopyCourtDecisionConfirmingLegalStatus")]
        public bool CopyCourtDecisionConfirmingLegalStatus { get; set; }//Копия решения суда, подтверждающего правовой статус
        [Column("CopyDocumentLegalRepresentative")]
        public bool CopyDocumentLegalRepresentative { get; set; }//Копия документа о законном представителе
        [Column("InformationAboutPeriodStayOrphanage")]
        public bool InformationAboutPeriodStayOrphanage { get; set; }//Информация о периоде пребывания в детском доме
        [Column("CertificateGuardianshipAuthoritiesStatus")]
        public bool CertificateGuardianshipAuthoritiesStatus { get; set; }//Справка из органов опеки о статусе
        [Column("CopiesDocumentsHousing")]
        public bool CopiesDocumentsHousing { get; set; }//Копии документов на жилье (тоже хз че к чему) 
        [Column("CertificateExtraordinaryReceiptLivingSpace")]
        public bool CertificateExtraordinaryReceiptLivingSpace { get; set; }//Свидетельство о внеочередном получении жилплощади
        [Column("ResultsFluorographicExamination")]
        public bool ResultsFluorographicExamination { get; set; }//флюшка 
        [Column("ContactPhoneNumbers")]
        public bool ContactPhoneNumbers { get; set; }//номер телефона 
        [Column("PassportDetails_idPassportDetails")]
        public int PassportDetails_idPassportDetails { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kursovaya.Tools;

namespace kursovaya.DTO
{
    [Table("otherstandart")]
    public class DocStandart//доки для обычных студентов(не сирот)
    {
        [Column("idOtherStandart")]
        public int Id { get; set; }
      
        [Column("Photo")]
        public bool Photo { get; set; } //фото
        [Column("FlurograohicExam")]
        public bool FlurograohicExam { get; set; }//флюшка
        [Column("Snils")]
        public int CopyOfSnils { get; set; }//снилс
        [Column("VaccinationCertificate")]
        public string VaccinationCertificate { get; set; }
        [Column("MedicalPalicy")]
        public bool MedicalPolicy { get; set; }//полис
        [Column("Certificate_idCertificate")]
        public int Certificate_idCertificate { get; set; }
        [Column("PassportDetails_idPassportDetails")]
        public int PassportDetails_idPassportDetails { get; set; }//пасспорт
    }
}

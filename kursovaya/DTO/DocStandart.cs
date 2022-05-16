using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kursovaya.Tools;

namespace kursovaya.DTO
{
    [Table("otherstandart")]
    public class DocStandart : BaseDTO//доки для обычных студентов(не сирот)
    {
    
        [Column("Photo")]
        public string Photo { get; set; } //фото
        [Column("FlurographicExam")]
        public string FlurograohicExam { get; set; }//флюшка
        [Column("Snils")]
        public string CopyOfSnils { get; set; }//снилс
            
        [Column("MedicalPalicy")]
        public string MedicalPolicy { get; set; }//полис

        [Column("Enrollelist_idEnrollelist")]
        public int Enrollelist_idEnrollelist { get; set; }
    }
}

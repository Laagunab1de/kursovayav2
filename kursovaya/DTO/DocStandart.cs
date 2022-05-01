using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya.DTO
{
    public class DocStandart//доки для обычных студентов(не сирот)
    {
        public bool EducationDoc { get; set; } //аттестат
        public bool Photo { get; set; } //фото
        public bool FlurograohicExam { get; set; }//флюшка
        public int CopyOfSnils { get; set; }//снилс
        public bool MedicalPolicy { get; set; }//полис
        public bool Passport { get; set; }//пасспорт
    }
}

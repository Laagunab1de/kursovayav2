using kursovaya.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya.DTO
{
    [Table("enrollelist")]
    public class Enrolle : BaseDTO
    {
       
        [Column("Surname")]
        public string Surname { get; set; }//Фамилия
        [Column("Name")]
        public string FirstName { get; set; }//Имя 
        [Column("Patronymic")]
        public string Patronymic { get; set; }//Отчество
        [Column("AvailabilityOfBenefits")]
        public string AvailabilityOfBenefits { get; set; }//Наличие льгот
        [Column("NeedHostel")]
        public bool NeedHostel { get; set; }

        [Column("DateOfAdmission")]
        public DateTime DateOfAdmission { get; set; }//Дата поступления 
        [Column("Discipline_idDiscipline")]
        public int Discipline_idDiscipline { get; set; }//Ид дисциплин      
        [Column("Department_idDepartment")]
        public int Department_idDepartment { get; set; }//Ид отделений
  
    }
}

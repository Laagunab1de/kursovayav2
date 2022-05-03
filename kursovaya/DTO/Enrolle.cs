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
        [Column("idEnrollelist")]
        public int idEnrollelist { get; set; }//Ид
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
        [Column("Discipline_DisciplineId")]
        public int DisciplineId { get; set; }//Ид дисциплин      
        [Column("Department_idDepartment")]
        public int DepartmentTd { get; set; }//Ид отделений


        //запутался в бд и переменных 
        //Ид всех доков для сирот 
        [Column("OtherOrphan_idOtherOrphan")]
        public int OtherOrphan_idOtherOrphan { get; set; }
        [Column("OtherOrphan_Certificate_idCertificate")]
        public int OtherOrphan_Certificate_idCertificate { get; set; }
        [Column("OtherOrphan_PassportDetails_idPassportDetails")]
        public int OtherOrphan_PassportDetails_idPassportDetails { get; set; }

        //Ид всех доков для всех 
        [Column("OtherStandart_idOtherOrphan")]
        public int OtherStandart_idOtherOrphan { get; set; }
        [Column("OtherStandart_Certificate_idCertificate")]
        public int OtherStandart_Certificate_idCertificate { get; set; }
        [Column("OtherStandart_PassportDetails_idPassportDetails")]
        public int OtherStandart_PassportDetails_idPassportDetails { get; set; }
    }
}

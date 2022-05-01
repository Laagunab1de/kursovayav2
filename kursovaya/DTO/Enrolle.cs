using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya.DTO
{
    public class Enrolle
    {
        public int ID { get; set; }//Ид
        public string Surname { get; set; }//Фамилия
        public string FirstName { get; set; }//Имя 
        public string Patronymic { get; set; }//Отчество
        public string AvailabilityOfBenefits { get; set; }//Наличие льгот
        public DateTime DateOfAdmission { get; set; }//Дата поступления 
        public int DisciplineId { get; set; }//Ид дисциплин
        public int CertificateId { get; set; }//Ид аттестата
        public int PassdetailsId { get; set; }//Ид пасспорта
        public int OtherOtphanId { get; set; }//ид списка документов для абитуриентов без родителей :(
        public int StandartId { get; set; }//Ид стандартных студентов
        public int DepartmentTd { get; set; }//Ид отделений
    }
}

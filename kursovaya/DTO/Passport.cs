using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya.DTO
{
    public class Passport
    {
        public string surname { get; set; }
        public string FirstName { get; set; }
        public string patronymic { get; set; }
        public DateTime Birthday { get; set; }
        public int series { get; set; }
        public int number { get; set; }
        public DateTime DateofIssued { get; set; }
        public string Issued_by { get; set; }
        public string placeofregistration { get; set; }
    }
}

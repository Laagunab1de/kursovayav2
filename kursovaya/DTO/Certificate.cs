using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kursovaya.Tools;

namespace kursovaya.DTO
{
    [Table("certificate")]  
    public class Certificate : BaseDTO
    {
        [Column("idCertificate")]
        public int ID { get; set; }
        [Column("GPA")]
        public float GPA { get; set; }
        [Column("Originality")]
        public bool Originality { get; set; }
        [Column("Enrollelist_idEnrollelist")]
        public int Enrollelist_idEnrollelist { get; set; }
    }
}

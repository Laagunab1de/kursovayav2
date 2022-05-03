using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kursovaya.Tools;

namespace kursovaya.DTO
{
    [Table("department")]
    public class Departments
    {
        [Column("idDepartment")]
        public int ID { get; set; }
        [Column("Title")]
        public string Title { get; set; }
    }
}

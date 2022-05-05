using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kursovaya.Tools;

namespace kursovaya.DTO
{
    [Table("department")]
    public class Department
    {
        [Column("idDepartment")]
        public int IDDepatment { get; set; }
        [Column("Title")]
        public string Title { get; set; }
    }
}

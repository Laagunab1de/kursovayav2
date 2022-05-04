using System;
using System.Collections.Generic;
using kursovaya.Tools;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya.DTO
{
    [Table("PassportDetails")]
    public class Passport : BaseDTO
    {
        [Column("idPassportDetails")]
        public int idPassportDetails { get; set; }
        [Column("Birthday")]
        public DateTime Birthday { get; set; }
        [Column("Series")]
        public int Series { get; set; }
        [Column("Number")]
        public int number { get; set; }
        [Column("IssuedBy")]
        public string IssuedBy { get; set; }
        
    }
}

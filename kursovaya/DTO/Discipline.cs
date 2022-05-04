using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kursovaya.Tools;

namespace kursovaya.DTO
{
    [Table("discipline")]
    public partial class Discipline : BaseDTO
    {
        [Column("IDDiscipline")]
        public int IDDisciplines { get; set; }
        [Column("Title")]
        public string Title { get; set; } = "";
        [Column("NuberOfPlaces")]
        public int NuberOfPlaces { get; set; }
    }
}

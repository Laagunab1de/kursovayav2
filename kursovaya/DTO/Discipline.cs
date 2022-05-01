using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya.DTO
{
    public partial class Discipline
    {
        public int IDDisciplines { get; set; }

        public string Title { get; set; } = "";

        public int NuberOfPlaces { get; set; }
    }
}

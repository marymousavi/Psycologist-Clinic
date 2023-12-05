using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class tbl_Visit
    {
        public int ID { get; set; }
        public string NameFamily { get; set; }
        public string Phone { get; set; }
        public int PsychologistName { get; set; }
        public int Servises { get; set; }
        public DateTime DateVisit { get; set; }
        public string TimeVisit { get; set; }

    }
}

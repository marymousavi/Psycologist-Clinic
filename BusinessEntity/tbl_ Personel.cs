using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class tbl_Personel
    {
        public int ID { get; set; }
        public string IdFile { get; set; }
        public string NameFamily { get; set; }
        public string Idcode { get; set; }
        public DateTime BirthDate { get; set; }
        public string CodePsychologist { get; set; }
        public string Job { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public bool Status { get; set; }

    }
}

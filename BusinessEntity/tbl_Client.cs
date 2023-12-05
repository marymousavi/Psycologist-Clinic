using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class tbl_Client
    {
        public int ID { get; set; }
        public string IdFile { get; set; }
        public DateTime FirstDate { get; set; }
        public string PsychologistName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdCode { get; set; }
        public DateTime BirthDate { get; set; }
        public string Education { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Emergency { get; set; }
        public List<tbl_Family_Client> Families { get; set; } = new List<tbl_Family_Client>();
        public double Reason { get; set; }
        public double Q1 { get; set; }
        public double Q2 { get; set; }
        public double Q3 { get; set; }

    }

}

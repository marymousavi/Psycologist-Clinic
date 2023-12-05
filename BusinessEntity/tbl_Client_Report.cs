using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class tbl_Client_Report
    {
        public int id { get; set; }
        public string DateOfReport { get; set; }
        public string Diagnosise { get; set; }
        public string Report { get; set; }
        public List<tbl_Client> Clients { get; set; } = new List<tbl_Client>();

    }
}

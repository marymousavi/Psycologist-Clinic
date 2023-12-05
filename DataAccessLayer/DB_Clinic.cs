using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using System.Data.Entity;


namespace DataAccessLayer
{
    public class DB_Clinic:DbContext
    {
        public DB_Clinic() : base("name=ClinicEntities") { }
        public DbSet <tbl_Personel> Personels { get; set; }
        public DbSet <tbl_Client> Clients { get; set; }
        public DbSet <tbl_Family_Client> tbl_Families { get; set; }
        public DbSet <tbl_Client_Report> Reports { get; set; }
        public DbSet <LogIn_BE> Users { get; set; }
        public DbSet <tbl_Visit> Visits { get; set; }

    }
}

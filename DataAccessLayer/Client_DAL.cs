using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using System.Data.Entity;


namespace DataAccessLayer
{
    public class Client_DAL

    {
        DB_Clinic db = new DB_Clinic();

        public string Create(tbl_Client c)
        {
            // ایجاد شی در بانک اطلاعاتی
            if (!Read(c))
            {
                if (c.IdCode.Length == 10)
                {
                    db.Clients.Add(c);
                    db.SaveChanges();
                    return "پرونده با موفقیت ثبت شد ";
                }
                else
                {
                    return "کدملی نامعتبر است";
                }
            }
            else
            {
                return "اطلاعات تکراری وارد شده است";
            }



        }

        public bool Read(tbl_Client c)
        {
            return db.Clients.Any(i => i.IdCode == c.IdCode && i.LastName == c.LastName);
        }

        public List<tbl_Client> Read()
        {
            return db.Clients.ToList();
        }
        public List<tbl_Client> SearchByIdFile(string idfile)
        {
            return db.Clients.Where(i => i.IdFile == idfile).ToList();
        }

        public List<tbl_Client> SearchByName(string idcode , string firstname , string lastname)
        {
            return db.Clients.Where(i => i.IdCode == idcode || i.FirstName == firstname && i.LastName == lastname).ToList();
        }

        public tbl_Client Read(int id)
        {
            return db.Clients.Where(i => i.ID == id).Single();
        }

    }
}

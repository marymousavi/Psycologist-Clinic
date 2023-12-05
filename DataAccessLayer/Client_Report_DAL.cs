using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using System.Data.Entity;

namespace DataAccessLayer
{
    public class Client_Report_DAL
    {
        DB_Clinic db = new DB_Clinic();

        public string Create(tbl_Client_Report cr)
        {
            // ایجاد شی در بانک اطلاعاتی
            if (!Read(cr))
            {
                if (cr.IdCode.Length == 10)
                {
                    db.Clients.Add(cr);
                    db.SaveChanges();
                    return "گزارش با موفقیت ثبت شد ";
                }
                else
                {
                    return "همه ستون ها باید تکمیل شود";
                }
            }
            else
            {
                return "اطلاعات تکراری وارد شده است";
            }



        }

        public bool Read(tbl_Client_Report cr)
        {
            return db.Clients.Any(i => i.IdCode == cr.IdCode );
        }

        public List<tbl_Client_Report> Read()
        {
            return db.Reports.ToList();
        }

        //public tbl_Client_Report Read(int id)
        //{
        //    return db.Reports.Where(i => i.Id == id).Single();
        //}


    }
}

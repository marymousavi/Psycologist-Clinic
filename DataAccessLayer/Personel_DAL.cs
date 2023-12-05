using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using System.Data.Entity;

namespace DataAccessLayer
{
    public class Personel_DAL
    {
        //CRUD:Create, Read, Update, Delete
        DB_Clinic db = new DB_Clinic();
        public string Create(tbl_Personel p)
        {
            // ایجاد شی در بانک اطلاعاتی
            if (!Read(p))
            {
                if (p.Idcode.Length == 10)
                {
                    db.Personels.Add(p);
                    db.SaveChanges();
                    return "ثبت اطلاعات با موفقیت انجام شد ";
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

        public bool Read(tbl_Personel p)
        {
            return db.Personels.Any(i => i.NameFamily == p.NameFamily && i.Idcode == p.Idcode);
        }

        public List<tbl_Personel> Read(string namefamily)
        {
            return db.Personels.Where(i => i.NameFamily.Contains(namefamily)).ToList();
        }

        public List<tbl_Personel> Read()
        {
            return db.Personels.ToList();
        }
       
        public tbl_Personel Read(int id)
        {
            return db.Personels.Where(i => i.ID == id).Single();
        }

        public string Update(int id,tbl_Personel pnew)
        {
            tbl_Personel p = new tbl_Personel();
            p = Read(id);
            p.NameFamily = pnew.NameFamily;
            p.Idcode = pnew.Idcode;
            p.BirthDate = pnew.BirthDate;
            p.CodePsychologist = pnew.CodePsychologist;
            p.Job = pnew.Job;
            p.Phone = pnew.Phone;
            p.Address = pnew.Address;
            p.UserName = pnew.UserName;
            p.PassWord = pnew.PassWord;
            p.Status = pnew.Status;
            db.SaveChanges();
            return "ویرایش اطلاعات با موفقیت انجام شد";

        }
        
        public string Delete(int id)
        {
            tbl_Personel p = Read(id);
            db.Personels.Remove(p);
            db.SaveChanges();
            return "حذف اطلاعات با موفقیت انجام شد";

        }
   
    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class Personel_BLL
    {
        Personel_DAL dal = new Personel_DAL();
        public string Create(tbl_Personel p)
        {
            return dal.Create(p);
        }
        public List<tbl_Personel> Read()
        {
            return dal.Read();
        }
        public List<tbl_Personel> Read(string namefamily)
        {
            return dal.Read(namefamily); 
        }
        public tbl_Personel Read (int id)
        {
            return dal.Read(id);
        }
        public string update(int id,tbl_Personel pnew)
        {
            return dal.Update(id, pnew);
        }
        public string Delete(int id)
        {
            return dal.Delete(id);
        }
    }
}

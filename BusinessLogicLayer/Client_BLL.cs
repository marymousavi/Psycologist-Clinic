using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class Client_BLL
    {
        Client_DAL dal = new Client_DAL();

        public string Create(tbl_Client c)
        {
            return dal.Create(c);
        }

        public List<tbl_Client> Read()
        {
            return dal.Read();
        }
        public tbl_Client Read(int id)
        {
            return dal.Read(id);
        }

    }
}

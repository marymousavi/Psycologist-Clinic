using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class LogIn_BLL
    {
        LogIn_DAL dal = new LogIn_DAL();

        public byte LogIn(string username, string password)
        {
            return dal.LogIn(username, password);
        }

        public void Register(LogIn_BE u)
        {
            dal.Register(u);
        }
    }
       
}


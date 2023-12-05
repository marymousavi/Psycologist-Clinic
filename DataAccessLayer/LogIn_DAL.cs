using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using System.Data.Entity;

namespace DataAccessLayer
{
    public class LogIn_DAL
    {
        DB_Clinic db = new DB_Clinic();
        public byte LogIn(string username, string password)
        {
            if (db.Users.Count() == 0)
            {
                return 0;
            }
            else
            {
                if (db.Users.Any(i => i.UserName == username && i.PassWord == password))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        public void Register(LogIn_BE u)
        {
            db.Users.Add(u);
            db.SaveChanges();
        }
        

    }
}

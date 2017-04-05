using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLogin
    {
        public bool CheckLogin(string userName, string password)
        {
            var user = (new Context()).Users
                .Where(x => x.UserName == userName && x.Password == password)
                .FirstOrDefault();
            return user == null ? false : true;
        }
    }
}

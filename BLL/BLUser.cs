using DAL;
using DOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLUser
    {
        private Context db = new Context();

        public User Get(int id)
        {
            return db.Users.Find(id);
        }
        public User Get(string userName)
        {
            return db.Users.Where(x => x.UserName == userName).FirstOrDefault();
        }
    }
}

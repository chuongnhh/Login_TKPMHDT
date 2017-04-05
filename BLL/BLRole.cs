using DAL;
using DOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLRole
    {
        private Context db = new Context();

        public Role Get(int id)
        {
            return db.Roles.Find(id);
        }
        public Role Get(string roleName)
        {
            return db.Roles.Where(x => x.RoleName == roleName).FirstOrDefault();
        }
    }
}

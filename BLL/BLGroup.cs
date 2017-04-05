using DAL;
using DOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public  class BLGroup
    {
        private Context db = new Context();

        public Group Get(int id)
        {
            return db.Groups.Find(id);
        }
        public Group Get(string groupName)
        {
            return db.Groups.Where(x => x.GroupName == groupName).FirstOrDefault();
        }
    }
}

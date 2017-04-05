using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DOL
{
    [Table("Groups")]
    public class Group
    {
        public Group()
        {
            Users = new List<User>();
            Roles = new List<Role>();
        }
        [Key]
        public int Id { get; set; }
        public string GroupName { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Role> Roles { get; set; }

    }
}

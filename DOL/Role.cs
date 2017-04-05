using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOL
{
    [Table("Roles")]
    public class Role
    {
        public Role()
        {
            Users = new List<User>();
            Groups = new List<Group>();
        }

        [Key]
        public int Id { get; set; }
        public string RoleName { get; set; }
        
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
    }
}

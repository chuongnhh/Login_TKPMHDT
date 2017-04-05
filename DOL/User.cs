using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOL
{
    [Table("Users")]
    public class User
    {
        public User()
        {
            Roles = new List<Role>();
        }
        [Key]
        public int Id { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }

        public virtual ICollection<Role> Roles { get; set; }

        public int GroupId { get; set; }
        [ForeignKey("GroupId")]
        public virtual Group Group { get; set; }
    }
}

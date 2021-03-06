using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1_UnitTest.Models
{
    [Table("Role")]
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string RoleName { get; set; }
        public virtual List<User_Role> User_Roles { get; set; }
    }
}

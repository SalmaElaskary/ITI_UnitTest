using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1_UnitTest.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public  string Email { get; set; }
        public string Password { get; set; }

    public virtual List<User_Role> User_Roles { get; set; }


    }
}

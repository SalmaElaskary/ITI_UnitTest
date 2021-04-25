using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1_UnitTest.Models
{
    [Table("User_Role")]
    public class User_Role
    {
        [Key]
        public int Id { get; set; }
        public int UId { get; set; }
        public int RId { get; set; }
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }

    }
}

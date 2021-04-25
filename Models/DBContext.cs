using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1_UnitTest.Models
{
    public class DBContext : DbContext
    {
       public DbSet<User> Users;
        public DbSet<Role> Roles;
        public DbSet<User_Role> User_Roles;
        //public DBContext(DbContextOptions options):base(options)
        //{

        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User {Id = 1, UserName = "Salma",Password="1234",Email="sdsdsd@asds.ccc"},
                 new User { Id = 2, UserName = "Rehab", Password = "1234",Email = "cvfg@asds.ccc" },
            new User { Id = 3, UserName = "Rawan", Password = "1234", Email = "dfdf@sds.ccc" }

                 );
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, RoleName = "Admin" },
                 new Role { Id = 2, RoleName = "user" }
                );
            modelBuilder.Entity<User_Role>().HasData(
               new User_Role { Id= 1, UId = 2, RId= 1 },
                new User_Role { Id = 2, UId = 1, RId = 2 },
                new User_Role { Id = 3, UId = 3, RId = 2 }
               );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=UserRoleDB1;trusted_connection=true");
            // base.OnConfiguring(optionsBuilder);
        }
    }
}

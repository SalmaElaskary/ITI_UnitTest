using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1_UnitTest.Models
{
    public class DBContext : DbContext
    {
        DbSet<User> Users;
        DbSet<Role> Roles;
        DbSet<User_Role> User_Roles;
        //public DBContext(DbContextOptions options):base(options)
        //{

        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User {Id = 1, UserName = "Salma" },
                 new User { Id = 2, UserName = "Rehab" }
                );
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, RoleName = "Admin" },
                 new Role { Id = 2, RoleName = "user" }
                );
            modelBuilder.Entity<User_Role>().HasData(
               new User_Role { Id= 1, UId = 2, RId= 1 },
                new User_Role { Id = 2, UId = 1, RId = 2 }
               );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=UserRoleDB;trusted_connection=true");
            // base.OnConfiguring(optionsBuilder);
        }
    }
}

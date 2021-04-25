using Lab1_UnitTest.Models;
using Repositories;
using System;
using System.Linq;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        int UserId;
        int RoleId;
        User user = new User();

        [Fact]
        public void AdminExist1()
        {
            string name = "";
            DBContext db=new DBContext();
            UserRepository userrepo = new UserRepository(db);
            var data = userrepo.GetALL();
            foreach(var item in data)
            {
                if(item.UserName=="Rehab")
                {
                    name = "Rehab";
                    UserId = item.Id;
                }
            }
            Assert.True(name == "Rehab");
        }
        [Fact]
        public void RoleAdminExist1()
        {
            string name = "";
            DBContext db = new DBContext();
           RoleRepository rolerepo = new RoleRepository(db);
            var data = rolerepo.GetALL();
            foreach (var item in data)
            {
                if (item.RoleName == "Admin")
                {
                    name = "Admin";
                    RoleId= item.Id;
                }
            }
            Assert.True(name == "Admin");
        }

        [Fact]
        public void ISADMIN()
        {
            Assert.True(UserId == RoleId);
        }


        [Fact]
        public void CanLogin()
        {
            DBContext db = new DBContext();
            UserRepository _db=new UserRepository(db);
            User u = new User() { Email="csdfd@aea.sss",Password="2653"};
            user = _db.GetALL().FirstOrDefault(c => c.Email == u.Email && c.Password == u.Password);

            Assert.True(user!=null);

        }


    }
}

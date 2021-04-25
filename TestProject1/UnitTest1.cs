using Lab1_UnitTest.Models;
using Repositories;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        int UserId;
        int RoleId;
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
    }
}

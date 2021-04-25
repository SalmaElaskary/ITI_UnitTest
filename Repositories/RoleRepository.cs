using Lab1_UnitTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
   public class RoleRepository : IRepositoryBase<Role>
    {
        public DBContext _db { get; set; }

        RoleRepository(DBContext db)
        {
            _db = db;
        }

        public Role Add(Role data)
        {
            _db.Add(data);
            _db.SaveChanges();
            return data;
            //throw new NotImplementedException();

        }

        public List<Role> GetALL()
        {
            return _db.Roles.Include(d => d.User_Roles).ToList();
        }

            public bool Delete(int id)
        {
            _db.Remove(_db.Roles.FirstOrDefault(d => d.Id == id));
            return true;
        }

        public Role Edit(Role data)
        {
            Role oldRole = _db.Roles.FirstOrDefault(d => d.Id== data.Id);
            oldRole.RoleName = data.RoleName;
            return oldRole;
        }

        public Role Getbyid(int id)
        {
            throw new NotImplementedException();
        }
    }
}

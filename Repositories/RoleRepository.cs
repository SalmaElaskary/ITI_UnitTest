using Lab1_UnitTest.Models;
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
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Role Edit(Role data)
        {
            throw new NotImplementedException();
        }

        public Role Getbyid(int id)
        {
            throw new NotImplementedException();
        }
    }
}

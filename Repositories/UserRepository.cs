using Lab1_UnitTest.Models;
using System;
using System.Collections.Generic;

namespace Repositories
{
    public class UserRepository : IRepositoryBase<Role>
    {
        public DBContext _db { get; set; }

        UserRepository(DBContext db)
        {
            _db = db;
        }

        public Role Add(Role data)
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

        public List<Role> GetALL()
        {
            throw new NotImplementedException();
        }

        public Role Getbyid(int id)
        {
            throw new NotImplementedException();
        }
    }
}

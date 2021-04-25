using Lab1_UnitTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    public class UserRepository : IRepositoryBase<User>
    {
        public DBContext _db { get; set; }

        public UserRepository(DBContext db)
        {
            _db = db;
        }
      

        public User Add(User data)
        {
            _db.Add(data);
            _db.SaveChanges();
            return data;
        }

        public bool Delete(int id)
        {
            _db.Remove(_db.Users.FirstOrDefault(d => d.Id == id));
            return true;
        }

        public User Edit(User data)
        {
            User oldUser = _db.Users.FirstOrDefault(d => d.Id == data.Id);
            oldUser.UserName = data.UserName;
            oldUser.Email = data.Email;
            return oldUser;
        }

        public List<User> GetALL()
        {
            return _db.Users.Include(d => d.User_Roles).ToList();
           
        }

        public User Getbyid(int id)
        {
            throw new NotImplementedException();
        }
    }
}

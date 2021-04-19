using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UserManagmentAPI.DataAccess.Abstract;
using UserManagmentAPI.Entities;

namespace UserManagmentAPI.DataAccess.Concrete
{
    public class UserRepository : IUserRepository
    {
        public User CreateUser(User user)
        {
            using (UserDbContext _context = new UserDbContext())
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return user;
            }
        }

        public void DeleteUser(int id)
        {
            using (UserDbContext _context = new UserDbContext())
            {
                var deletedUser =  _context.Users.Find(id);
                _context.Users.Remove(deletedUser);
                _context.SaveChanges();
            }
        }

        public List<User> GetAllUsers()
        {
            using (UserDbContext _context = new UserDbContext())
            {
                return _context.Users.ToList();
            }
        }

        public User GetUserByID(int id)
        {
            using(UserDbContext _context = new UserDbContext())
            {
                return _context.Users.Find(id);
            }
        }

        public User UpdateUser(User user)
        {
            using (UserDbContext _context = new UserDbContext())
            {
                _context.Users.Update(user);
                return user;
            }
        }
    }
}

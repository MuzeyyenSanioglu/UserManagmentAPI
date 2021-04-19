using System;
using System.Collections.Generic;
using System.Text;
using UserManagmentAPI.Entities;

namespace UserManagmentAPI.DataAccess.Abstract
{
    public interface IUserRepository
    {
       List<User> GetAllUsers();
        User GetUserByID(int id);
        User CreateUser(User user);
        User UpdateUser(User user);
        void DeleteUser(int id);
    }
}

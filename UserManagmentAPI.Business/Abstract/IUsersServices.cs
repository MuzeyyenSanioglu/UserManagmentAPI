using System;
using System.Collections.Generic;
using System.Text;
using UserManagmentAPI.Entities;

namespace UserManagmentAPI.Business.Abstract
{
    public interface IUsersServices
    {
        List<User> GetAllUsers();
        User GetUserByID(int id);
        User CreateUser(User user);
        User UpdateUser(User user);
        void DeleteUser(int id);
    }
}

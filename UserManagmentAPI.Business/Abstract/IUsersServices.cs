using System;
using System.Collections.Generic;
using System.Text;
using UserManagmentAPI.Business.Model;
using UserManagmentAPI.Entities;

namespace UserManagmentAPI.Business.Abstract
{
    public interface IUsersServices
    {
        List<User> GetAllUsers();
        User GetUserByID(int id);
        User CreateUser(UserServiceModel user);
        User UpdateUser(UserServiceModel user);
        void DeleteUser(int id);
    }
}

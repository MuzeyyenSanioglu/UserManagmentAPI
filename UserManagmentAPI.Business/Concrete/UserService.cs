using System;
using System.Collections.Generic;
using System.Text;
using UserManagmentAPI.Business.Abstract;
using UserManagmentAPI.DataAccess.Abstract;
using UserManagmentAPI.DataAccess.Concrete;
using UserManagmentAPI.Entities;

namespace UserManagmentAPI.Business.Concrete
{
    public class UserService : IUsersServices
    {
        private IUserRepository _usersRepository;
        public UserService()
        {
             _usersRepository =new UserRepository();
        }
        public User CreateUser(User user)
        {
            return _usersRepository.CreateUser(user);
        }

        public void DeleteUser(int id)
        {
             _usersRepository.DeleteUser(id);
        }

        public List<User> GetAllUsers()
        {
           return _usersRepository.GetAllUsers();
        }

        public User GetUserByID(int id)
        {
            return _usersRepository.GetUserByID(id);
        }

        public User UpdateUser(User user)
        {
            return _usersRepository.UpdateUser(user);
        }
    }
}

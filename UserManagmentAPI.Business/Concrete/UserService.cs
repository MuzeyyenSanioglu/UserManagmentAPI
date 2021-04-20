using System;
using System.Collections.Generic;
using System.Text;
using UserManagmentAPI.Business.Abstract;
using UserManagmentAPI.Business.Model;
using UserManagmentAPI.DataAccess.Abstract;
using UserManagmentAPI.DataAccess.Concrete;
using UserManagmentAPI.Entities;

namespace UserManagmentAPI.Business.Concrete
{
    public class UserService : IUsersServices
    {
        #region Field
        private IUserRepository _usersRepository;
        #endregion

        #region CTOR
        public UserService(IUserRepository usersRepository)
        {
             _usersRepository = usersRepository;
        }
        #endregion

        #region Metod
        public User CreateUser(UserServiceModel usr)
        {
            User user = new User();
            user.ID = CreateSingleID();
            user.CreationDate = DateTime.Now;
            user.LastModifiedDate = DateTime.Now;
            user.Name = usr.Name;
            user.Surname = usr.Surname;
            user.Address = usr.Address;
            user.Birthday = usr.Birthday;
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

        public User UpdateUser(UserServiceModel usr)
        {
            User user = new User();
            user.Name = usr.Name;
            user.Surname = usr.Surname;
            user.Address = usr.Address;
            user.Birthday = usr.Birthday;
            user.LastModifiedDate = DateTime.Now;
            return _usersRepository.UpdateUser(user);
        }
        #endregion

        #region Utility
        public long CreateSingleID()
        {
            Random r = new Random();
            int num= r.Next(100000000, 999999999);
            int odd = 0;
            int dble = 0;
            int md = num;
            for (int i = 1; i <= 9; i++)
            {
                int dgt = md % 10;
                md = md / 10;
                if (i % 2 == 0)
                    dble +=dgt;
                else
                    odd +=dgt;
            }
            int ten = ((odd * 7) - dble) % 10;
            int eleven = (odd + dble + ten) % 10;
            num = (num * 1000000000) + ten;
            return (num * 10000000000) + eleven;
        }

        #endregion
    }
}

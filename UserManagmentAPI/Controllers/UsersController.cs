using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagmentAPI.Business.Abstract;
using UserManagmentAPI.Business.Concrete;
using UserManagmentAPI.Entities;

namespace UserManagmentAPI.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private IUsersServices _usersServices;
        public UsersController(IUsersServices usersServices)
        {
            _usersServices = usersServices;
        }
        /// <summary>
        /// Get all users
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<User> Get()
        {
            return _usersServices.GetAllUsers();
        }
        /// <summary>
        /// Get user by ıd
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _usersServices.GetUserByID(id);
        }
        /// <summary>
        /// Create  user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public User Post([FromBody]User user)
        {
            return _usersServices.CreateUser(user);
        }
        /// <summary>
        /// Update the user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPut]
        public User Put([FromBody] User user)
        {
            return _usersServices.UpdateUser(user);
        }
        /// <summary>
        /// Delete the user
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete]
        public void Delete(int id)
        {
             _usersServices.DeleteUser(id);
        }
    }
}

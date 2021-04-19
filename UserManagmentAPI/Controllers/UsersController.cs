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
        [HttpGet]
        public List<User> Get()
        {
            return _usersServices.GetAllUsers();
        }
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _usersServices.GetUserByID(id);
        }
        [HttpPost]
        public User Post([FromBody]User user)
        {
            return _usersServices.CreateUser(user);
        }
        [HttpPut]
        public User Put([FromBody] User user)
        {
            return _usersServices.UpdateUser(user);
        }
        [HttpDelete]
        public void Delete(int id)
        {
             _usersServices.DeleteUser(id);
        }
    }
}

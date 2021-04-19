using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UserManagmentAPI.Entities;

namespace UserManagmentAPI.DataAccess
{
    public class UserDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=UserManagmentDB");
        }
        public DbSet<User> Users { get; set; }
    }
}

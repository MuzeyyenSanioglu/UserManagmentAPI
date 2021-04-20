using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserManagmentAPI.Business.Model
{
     public class UserServiceModel
     {
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
     }
}

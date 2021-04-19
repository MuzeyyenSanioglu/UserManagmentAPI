using System;
using System.ComponentModel.DataAnnotations;

namespace UserManagmentAPI.Entities
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public DateTime CreationDate { get; set; }
    }
}

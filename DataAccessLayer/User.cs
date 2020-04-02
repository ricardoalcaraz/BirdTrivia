using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer
{
    public class User
    {
        public Guid Id { get; set; }

        [Required]
        public string Username { get; set; }

        public User()
        {
            Id = Guid.NewGuid();
        }
    }
}

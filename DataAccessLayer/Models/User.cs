using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class User
    {
        public Guid Id { get; set; }

        [Required]
        public string Username { get; set; }

        public int Streak { get; set; }

        public bool IsExpert { get; set; }
    }
}

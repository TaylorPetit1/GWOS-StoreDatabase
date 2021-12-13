using System;

namespace EFDataAccessLibrary.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateDeleted { get; set; }
    }
}
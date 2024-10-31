using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wastemanagementapi.Enums;

namespace wastemanagementapi.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public required string Email { get; set; }

        public required string Password { get; set; }

        public string PhoneNumber { get; set; } = string.Empty;

        public UserType UserType { get; set; }

        public bool IsVerified { get; set; }

        public Status Status { get; set; }

        public Partner? Partner { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }





        
    }
}
﻿using Microsoft.AspNetCore.Identity;

namespace BilirkisiAspire.Shared.Models
{
    public class AppUser : IdentityUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

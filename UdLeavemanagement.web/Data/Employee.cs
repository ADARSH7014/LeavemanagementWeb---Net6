﻿using Microsoft.AspNetCore.Identity;

namespace UdLeavemanagement.web.Data
{
    public class Employee : IdentityUser
    {
        public string Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? TaxId { get; set; }
        public DateTime DateofBirth { get; set; }
        public DateTime DateJoined { get; set; }

    }
}

﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Esacco.Data
{
    public class Employee : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmpNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        [ForeignKey("StatusID")]
        public Status Status { get; set; }
        public int StatusID { get; set; }
        public DateTime DateJoined { get; set; }
    }
}

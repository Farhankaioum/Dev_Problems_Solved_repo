﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string AreaName { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}

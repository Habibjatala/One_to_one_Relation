﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_to_one_Relation
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string Email { get; set; }
        
        public string Address { get; set; } 
        public User User { get; set; }
        public int? UserId { get; set; }


    }
}

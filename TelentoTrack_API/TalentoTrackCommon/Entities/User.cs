﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelentoTrack.Common;

namespace TelentoTrack.Common.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? ContactNo { get; set; }
        public Enumerations.Role Role { get; set; }
        public DateTime CrateDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int CrateByID { get; set; }
        public int UpdatedById { get; set; }


    }

}


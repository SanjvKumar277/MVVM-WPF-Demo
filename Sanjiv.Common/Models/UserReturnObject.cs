﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sanjiv.Common.Models
{
    public class UserReturnObject
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> Roles { get; set; }
    }
}

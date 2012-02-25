using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameApp.WebRole.Models
{
    public class User
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC10PMMiracleBatch.Models
{
    public class RegistrationModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public string Accept { get; set; }
        public string Address { get; set; }
    }
}
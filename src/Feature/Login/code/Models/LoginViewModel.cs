using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreLogin.Feature.Login.Models
{
    public class LoginViewModel
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public bool IsInvalidAttempt { get; set; }

        public string LoginDate
        {
            get
            {
                return DateTime.Now.ToString();
            }
        }
    }
}
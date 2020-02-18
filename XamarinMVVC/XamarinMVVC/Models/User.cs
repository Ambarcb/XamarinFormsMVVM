using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMVVC.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RepeatedPassword { get; set; }
        public string Email { get; set; }
    }
}

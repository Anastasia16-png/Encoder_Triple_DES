using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triple_DES_cipher.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Department { get; set; }
        public string AccessLevel { get; set; }

        public User(string username, string department, string accessLevel)
        {
            Username = username;
            Department = department;
            AccessLevel = accessLevel;
        }
    }
}

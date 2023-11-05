using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_HomeWork_5
{
    public class User
    {
        public string Name;
        public string Password;
        public string Email;

        public User(string name, string password, string email)
        {
            Name = name;
            Password = password;
            Email = email;
        }

        public bool IsPasswordValid()
        {
            return Password.Length>6 && !Password.Contains(Name) && Password.Any(char.IsDigit);
        }
    }
}

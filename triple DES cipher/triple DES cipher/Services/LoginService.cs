using System;
using System.Collections.Generic;

namespace triple_DES_cipher.Services
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Department { get; set; }
    }

    public class LoginService
    {
        private readonly Dictionary<string, (string Password, string Department)> _userCredentials = new()
        {
            { "gender", ("Gender001", "Генеральний директор") },
            { "secret", ("Secret002", "Секретар") },
            { "kerviddilkadr", ("Kerviddilkadr003", "Відділ кадрів") },
            { "golbuh", ("Golbuh004", "Бухгалтерія") },
            { "goleco", ("Goleco005", "Економічний відділ") },
            { "golprotect", ("Golprotect006", "Відділ охорони") },
            { "admin", ("Admin007", "IT відділ") },
            { "managcoop", ("Managcoop008", "Відділ менеджменту") },
            { "viddilkadr1", ("viddilkadr100", "Відділ кадрів") },
            { "viddilkadr2", ("viddilkadr200", "Відділ кадрів") },
            { "buh1", ("buh100", "Бухгалтерія") },
            { "market1", ("market100", "Відділ маркетингу") },
            { "market2", ("market200", "Відділ маркетингу") },
            { "eco1", ("eco100", "Економічний відділ") },
            { "eco2", ("eco200", "Економічний відділ") },
            { "protect1", ("protect100", "Відділ охорони") },
            { "protect2", ("protect200", "Відділ охорони") },
            { "it1", ("it100", "IT відділ") },
            { "it2", ("it200", "IT відділ") },
            { "sales1", ("sales100", "Відділ продажів") },
            { "managem1", ("managem100", "Відділ менеджменту") },
            { "yur", ("Yur001", "Юридичний відділ") }
        };

        public User Authenticate(string username, string password)
        {
            if (_userCredentials.TryGetValue(username, out var userInfo) && userInfo.Password == password)
            {
                return new User
                {
                    Username = username,
                    Password = password,
                    Department = userInfo.Department
                };
            }
            return null;
        }
    }
}
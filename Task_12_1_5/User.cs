using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_1_5
{
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        public override string ToString()
        {
            return $"login {Login} with name {Name} ({(IsPremium ? "Premium" : "regular")})";
        }

    }
}

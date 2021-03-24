using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShopApp
{
    public class User
    {
        public decimal Balance { get; set; }
        public User(decimal number = 0)
        {
            Balance = number;
        }
    }
}

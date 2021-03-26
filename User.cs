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
        public string Topup(User user, decimal quantity)
        {
            if (quantity >= 0)
            {
                user.Balance += quantity;
                return Message.Topup;
            }
            else
            {
                return Message.InvalidTopup;
            }
        }
    }
}

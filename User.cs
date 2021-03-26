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
            if (quantity > 0)
            {
                user.Balance += quantity;
                return Message.Topup;
            }

            return Message.InvalidTopup;
        }
    }
}
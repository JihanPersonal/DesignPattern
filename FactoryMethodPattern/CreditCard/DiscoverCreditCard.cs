using System;
namespace FactoryPattern.CreditCard
{
    class DiscoverCreditCard : ICreditCard
    {
        public string GetCardType()
        {
            return "Discover";
        }

        public int GetCreditLimit()
        {
            return 2000;
        }

        public int GetAnualFee()
        {
            return 0;
        }
    }
}
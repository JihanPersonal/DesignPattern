using System;
namespace FactoryPattern.CreditCard
{
    class AMEXCreditCard : ICreditCard
    {
        public int GetAnualFee()
        {
            return 0;
        }

        public string GetCardType()
        {
            return "American Express";
        }

        public int GetCreditLimit()
        {
            return 12000;
        }
    }
}
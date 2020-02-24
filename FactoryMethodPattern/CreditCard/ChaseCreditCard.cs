using System;
namespace FactoryPattern.CreditCard
{
    class ChaseCreditCard : ICreditCard
    {
        public int GetAnualFee()
        {
            return 200;
        }

        public string GetCardType()
        {
            return "Chase";
        }

        public int GetCreditLimit()
        {
            return 5000;
        }
    }
}
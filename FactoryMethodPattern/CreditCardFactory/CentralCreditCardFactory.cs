using System;
using FactoryPattern.CreditCard;
namespace FactoryPattern.Factory
{
    public class ChaseCreditCardFactory : CreditCardFactory
    {
        public override ICreditCard createCreditCard()
        {
            return new ChaseCreditCard();
        }
    }
    public class DiscoverCreditCardFactory : CreditCardFactory
    {
        public override ICreditCard createCreditCard()
        {
            return new DiscoverCreditCard();
        }
    }
    public class AMEXCreditCardFactory : CreditCardFactory
    {
        public override ICreditCard createCreditCard()
        {
            return new AMEXCreditCard();
        }
    }
}
using System;
using FactoryPattern.CreditCard;
namespace FactoryPattern
{
    public abstract class CreditCardFactory
    {
        public abstract ICreditCard createCreditCard();
        public ICreditCard getCrediCard()
        {
            return this.createCreditCard();
        }
    }
}
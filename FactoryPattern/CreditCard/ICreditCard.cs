using System;

namespace FactoryPattern.CreditCard
{
    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnualFee();
    }
}
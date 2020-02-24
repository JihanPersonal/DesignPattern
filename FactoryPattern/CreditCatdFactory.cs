using System;
using FactoryPattern.CreditCard;
namespace FactoryPattern
{
    public class CreditCardFactory
    {
        public static ICreditCard getCrediCatd(string creditcarType)
        {
            ICreditCard CrediCard = null;
            if (creditcarType == "Discover")
            {
                CrediCard = new DiscoverCreditCard();
            }
            else if (creditcarType == "Chase")
            {
                CrediCard = new ChaseCreditCard();
            }
            else if (creditcarType == "AMEX")
            {
                CrediCard = new AMEXCreditCard();
            }
            return CrediCard;
        }
    }
}
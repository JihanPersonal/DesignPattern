using System;
using FactoryPattern.CreditCard;
namespace FactoryPattern
{
    ///In the Factory Design pattern, we create an object without exposing 
    ///the creation logic to the client and the client will refer 
    ///to the newly created object using a common interface.
    ///In simple words, if we have a superclass and n number of subclasses,
    /// and based on the data provided, if we have to create and return the
    /// object of one of the subclasses, then we need to use the factory 
    ///design pattern
    class Program
    {
        static void Main(string[] args)
        {
            #region Withou Factory Pattern

            string crediCard = "AMEX";
            ICreditCard CrediCard = null;

            if (crediCard == "Discover")
            {
                CrediCard = new DiscoverCreditCard();
            }
            else if (crediCard == "Chase")
            {
                CrediCard = new ChaseCreditCard();
            }
            else if (crediCard == "AMEX")
            {
                CrediCard = new AMEXCreditCard();
            }

            if (CrediCard != null)
            {
                Print(CrediCard);
            }
            #endregion Without Design Pattern

            ICreditCard creditCard = CreditCardFactory.getCrediCatd("AMEX");
            Print(creditCard);

        }

        static void Print(ICreditCard crediCard)
        {
            Console.WriteLine(crediCard.GetCardType());
            Console.WriteLine(crediCard.GetCreditLimit());
            Console.WriteLine(crediCard.GetAnualFee());
        }
    }
}

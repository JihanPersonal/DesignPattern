using System;
using FactoryPattern.CreditCard;
namespace FactoryPattern.Factory
{
    ///The Factory Method Design Pattern is used, when we need to create the
    ///object (i.e. instance of the Product class) without exposing the object 
    ///creation logic to the client. To achieve this, in the factory method 
    ///design pattern we will create an abstract class as the Factory class 
    ///which will create and return the instance of the product, but it will 
    ///let the subclasses decide which class to instantiate. 
    ///Difference between Factory and Factory Method is, it has an abstract class 
    ///which contains an abstract method to let the subclass's factory to override 
    class Program
    {
        static void Main(string[] args)
        {
            DiscoverCreditCardFactory chaseCreditCardFactory = new DiscoverCreditCardFactory();
            ICreditCard creditCard = chaseCreditCardFactory.getCrediCard();
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

using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject iphone11 = new Cellphone();
            IObserver jihan = new Customer("jihan", iphone11);
            IObserver yury = new Customer("yury", iphone11);
            IObserver amz = new Customer("amz", iphone11);
            iphone11.UpdateStatus();
        }
    }
}

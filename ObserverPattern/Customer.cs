using System;

namespace ObserverPattern
{
    public class Customer : IObserver
    {
        public Customer(string name, ISubject subject)
        {
            CustomerName = name;
            subject.RegisterObserver(this);
        }
        public string CustomerName;
        public void GetNotified()
        {
            Console.WriteLine(CustomerName + " got Notified");
        }
    }
}
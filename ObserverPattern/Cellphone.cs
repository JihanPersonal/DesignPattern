using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace ObserverPattern
{
    public class Cellphone : ISubject
    {
        private List<IObserver> customers = new List<IObserver>();
        public void NotifyObservers()
        {
            Parallel.ForEach(customers, (c) =>
             {
                 c.GetNotified();
             });
        }

        public void RegisterObserver(IObserver customer)
        {
            if (!customers.Contains(customer))
                customers.Add(customer);
            else
                Console.WriteLine("Already followed");
        }

        public void UnregisterObserver(IObserver customer)
        {
            if (!customers.Contains(customer))
                Console.WriteLine("Not followed yet");
            customers.Remove(customer);
        }

        public void UpdateStatus()
        {
            Console.WriteLine("Status Changed. Start to notify all the subscribed users!!!");
            NotifyObservers();
        }
    }
}
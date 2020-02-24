using System;

namespace DependencyInjectionPattern
{
    class Customer : ICustomer
    {
        public Customer(int id)
        {
            CustomerID = id;
        }
        private int customerId;
        public int CustomerID
        {
            get
            {
                return customerId;
            }
            set
            {
                this.customerId = value;
            }
        }
    }
}
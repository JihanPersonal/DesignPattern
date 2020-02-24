using System;
using System.Collections.Generic;
using System.Linq;
namespace DependencyInjectionPattern
{
    class Order
    {
        private DeliveryType deliveryType;
        private DeliveryMethod delieveryMethod;
        public Order(int id)
        {
            OrderId = id;
        }
        public void DisplayOrder()
        {
            Console.WriteLine("Order ID:" + OrderId);
            Console.WriteLine("Customer ID:" + OrderCustomer.CustomerID);
            Console.WriteLine("Product ID:" + Products.First().ProductID);
            Console.WriteLine("Delivery Type:" + deliveryType);
        }
        public int OrderId;
        //Order depend on Product class
        public List<Product> Products = new List<Product>();
        //Order depend on Customer class 
        public Customer OrderCustomer;
        //method depend on DelieveryMethod
        public void SetDeliveryMethod(DeliveryMethod del)
        {
            deliveryType = del.Type;
        }
    }

    ///use construction depemdemcy injection 
    class OrderV1
    {
        ///Now the class is not depend on class Product and Customer
        ///by using constructor dependency injection 
        public OrderV1(int id, List<IProduct> products)
        {
            OrderId = id;
            Products = products;
        }
        public void DisplayOrder()
        {
            Console.WriteLine("Order ID:" + OrderId);
            Console.WriteLine("Customer ID:" + OrderCustomer.CustomerID);
            Console.WriteLine("Product ID:" + Products.First().ProductID);
            Console.WriteLine("Delivery Type:" + deliveryType);
        }
        private DeliveryType deliveryType;
        public int OrderId;
        ///Order not depend on Product class by using construction 
        ///dependency injection
        public List<IProduct> Products = new List<IProduct>();
        ///Order not depend on Customer by using property 
        ///dependency injection
        public ICustomer OrderCustomer;
        ///method is not depend on DelieveryMethod anymore
        ///by using method dependency injection
        public void SetDeliveryMethod(IDeliveryMethod del)
        {
            deliveryType = del.Type;
        }
    }
}
using System;
using System.Collections.Generic;
namespace DependencyInjectionPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomer customer = new Customer(11);
            IProduct product = new Product(22);
            IDeliveryMethod deliveryMethod = new DeliveryMethod(DeliveryType.FEDX);

            ///Coupouling Version
            Order order = new Order(1234);
            order.OrderCustomer = (Customer)customer;
            order.Products.Add((Product)product);
            order.SetDeliveryMethod((DeliveryMethod)deliveryMethod);
            order.DisplayOrder();

            Console.WriteLine();
            ///Dependency Injection Version 
            OrderV1 orderv1 = new OrderV1(9999, new List<IProduct>() { product });
            ///Method Dependency Injection 
            deliveryMethod = new DeliveryMethod(DeliveryType.USPS);
            orderv1.SetDeliveryMethod(deliveryMethod);
            ///Property Dependency Injection 
            orderv1.OrderCustomer = customer;
            orderv1.DisplayOrder();

        }
    }
}

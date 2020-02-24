using System;

namespace DependencyInjectionPattern
{
    class Product : IProduct
    {
        public Product(int id)
        {
            ProductID = id;
        }
        int productID;
        public int ProductID
        {
            get
            {
                return productID;
            }
            set
            {
                productID = value;
            }
        }
    }
}
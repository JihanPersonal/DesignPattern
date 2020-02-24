using System;

namespace DependencyInjectionPattern
{
    class DeliveryMethod : IDeliveryMethod
    {
        public DeliveryMethod(DeliveryType type)
        {
            Type = type;
        }
        private DeliveryType type;
        public DeliveryType Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
    }
}
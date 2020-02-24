using System;

namespace DependencyInjectionPattern
{
    enum DeliveryType { FEDX, UPS, USPS, DHL }
    interface IDeliveryMethod
    {
        DeliveryType Type
        {
            get;
            set;
        }
    }
}
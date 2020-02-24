using System;

namespace AdapterPattern
{
    /*
    1. A class needs to be reused that does not have an interface that a 
       client requires.
    2. Allow a system to use classes of another system that is incompatible
       with it.
    3. Allow communication between a new and already existing system 
       which are independent of each other.
    4. Sometimes a toolkit or class library cannot be used because its 
       interface is incompatible with the interface required by an 
       application.
    */
    class Program
    {
        static void Main(string[] args)
        {
            string[][] employeesArray = new string[][]
            {
                new string[]{"101","John","SE","10000"},
                new string[]{"102","Smith","SE","20000"},
                new string[]{"103","Dev","SSE","30000"},
                new string[]{"104","Pam","SE","40000"},
                new string[]{"105","Sara","SSE","50000"}
            };
            //Object Adaptor
            IAdaptor adaptor = new SalayAdptorObj();
            adaptor.ProcessSalary(employeesArray);

            //Class Adptor
            IAdaptor adaptor2 = new SalayAdptorClass();
            adaptor.ProcessSalary(employeesArray);
        }
    }
}

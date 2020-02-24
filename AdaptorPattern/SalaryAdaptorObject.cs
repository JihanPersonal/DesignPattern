using System;
using System.Collections.Generic;
namespace AdapterPattern
{
    ///Object Adaptor Patter.Use it when class adptor is impossible
    class SalayAdptorObj : IAdaptor
    {
        private ThirdPartyBillingSystem billingSystem = null;
        public void ProcessSalary(string[][] employees)
        {
            List<Employee> allemployees = new List<Employee>();
            foreach (string[] employee in employees)
            {
                Employee em = new Employee(Convert.ToInt32(employee[0]), employee[1], employee[2], Convert.ToDecimal(employee[3]));
                allemployees.Add(em);
            }
            billingSystem = new ThirdPartyBillingSystem();
            billingSystem.ProcessSalary(allemployees);
        }
    }
}
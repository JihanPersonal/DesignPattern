using System;
using System.Collections.Generic;
namespace AdapterPattern
{
    ///Class Adaptor Patter
    class SalayAdptorClass : ThirdPartyBillingSystem, IAdaptor
    {
        public void ProcessSalary(string[][] employees)
        {
            List<Employee> allemployees = new List<Employee>();
            foreach (string[] employee in employees)
            {
                Employee em = new Employee(Convert.ToInt32(employee[0]), employee[1], employee[2], Convert.ToDecimal(employee[3]));
                allemployees.Add(em);
            }
            ProcessSalary(allemployees);
        }
    }
}
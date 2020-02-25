using System;
using System.Collections.Generic;
namespace CallCenter
{
    public class Program
    {
        static void Main(string[] args)
        {
            CallCenter.Employees = new List<Employee>() { new Employee(11), new Employee(12), new Employee(13) };
            CallCenter.Directors = new List<Director>() { new Director(21), new Director(22) };
            CallCenter.Managers = new List<Manager>() { new Manager(31) };
            CallCenter.Start();
        }
    }
}

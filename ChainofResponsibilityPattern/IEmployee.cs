using System;

namespace CallCenter
{
    public enum EmployeeRole { Employee, Director, Manager };
    public interface IEmployee
    {
        int EmployeeID
        { get; set; }
        EmployeeRole Role
        {
            get; set;
        }
        void ProcessCall(ICall call);
        void Esclate(ICall call);
    }
}
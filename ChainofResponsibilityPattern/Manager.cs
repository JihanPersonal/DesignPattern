using System;

namespace CallCenter
{
    public class Manager : IEmployee
    {
        public Manager(int id)
        {
            EmployeeID = id;
            Role = EmployeeRole.Manager;
        }
        public int EmployeeID
        {
            get;
            set;
        }
        public EmployeeRole Role
        {
            get; set;
        }

        public void Esclate(ICall call)
        {
        }

        public void ProcessCall(ICall call)
        {
            call.Status = CallStatus.Processing;
            Console.WriteLine($"Manager: {this.EmployeeID} is Prcessing call {call.CallID}");
            call.Status = CallStatus.Accomplished;
        }
    }
}
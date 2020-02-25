using System;

namespace CallCenter
{
    public class Employee : IEmployee
    {
        public Employee(int id)
        {
            EmployeeID = id;
            Role = EmployeeRole.Employee;
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
            CallCenter.DirCalls.Enqueue(call);
        }

        public void ProcessCall(ICall call)
        {

            call.Status = CallStatus.Processing;
            if (call.CallID < 80)
            {
                Console.WriteLine($"Employee: {this.EmployeeID} is Prcessing call {call.CallID}");
                call.Status = CallStatus.Accomplished;
            }
            else
            {
                Console.WriteLine($"Employee: {this.EmployeeID} Cannot Prcessing call {call.CallID}");
                Esclate(call);
            }
        }
    }
}
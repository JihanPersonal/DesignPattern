using System;

namespace CallCenter
{
    public class Director : IEmployee
    {
        public Director(int id)
        {
            EmployeeID = id;
            Role = EmployeeRole.Director;
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
            CallCenter.MamCalls.Enqueue(call);
        }

        public void ProcessCall(ICall call)
        {
            call.Status = CallStatus.Processing;
            if (call.CallID < 90)
            {
                Console.WriteLine($"Director: {this.EmployeeID} is Prcessing call {call.CallID}");
                call.Status = CallStatus.Accomplished;
            }
            else
            {
                Console.WriteLine($"Director: {this.EmployeeID} Cannot Prcessing call {call.CallID}");
                Esclate(call);
            }
        }
    }
}
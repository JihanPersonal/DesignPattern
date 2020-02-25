using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
namespace CallCenter
{
    public class CallCenter
    {
        public static List<Employee> Employees = new List<Employee>();
        public static List<Director> Directors = new List<Director>();
        public static List<Manager> Managers = new List<Manager>();
        public static Queue<ICall> Calls = new Queue<ICall>();
        public static Queue<ICall> DirCalls = new Queue<ICall>();
        public static Queue<ICall> MamCalls = new Queue<ICall>();
        public static void Start()
        {
            ProcessCalls();
            NewCallCalls();
        }
        public static void NewCallCalls()
        {
            int count = 0;

            Thread newcall = new Thread(() =>
              {
                  while (true)
                  {
                      count++;
                      lock (Calls)
                      {
                          Calls.Enqueue(new Call((7 + count % 3) * 10 + 5));
                          Thread.Sleep(2000);
                      }
                  }
              });
            newcall.Start();
        }
        public static void ProcessCalls()
        {
            Thread empthread = new Thread(EmployeeProcessCalls);

            Thread dirthread = new Thread(DirectorProcessCalls);

            Thread mamthread = new Thread(ManagerProcessCalls);
            empthread.Start();
            dirthread.Start();
            mamthread.Start();

        }
        public static void EmployeeProcessCalls()
        {
            while (true)
            {
                if (Calls.Count > 0)
                {
                    ICall call = Calls.Dequeue();
                    Employees.First().ProcessCall(call);
                }
                Thread.Sleep(1000);
            }
        }
        public static void DirectorProcessCalls()
        {
            while (true)
            {
                if (DirCalls.Count > 0)
                {
                    ICall call = DirCalls.Dequeue();
                    Directors.First().ProcessCall(call);
                }
            }
        }
        public static void ManagerProcessCalls()
        {
            while (true)
            {
                if (MamCalls.Count > 0)
                {
                    ICall call = MamCalls.Dequeue();
                    Managers.First().ProcessCall(call);

                }
                Thread.Sleep(1000);
            }
        }
    }
}

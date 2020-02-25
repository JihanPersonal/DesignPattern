using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading;
namespace CallCenter
{
    public class CallCenter
    {
        public static List<Employee> Employees = new List<Employee>();
        public static List<Director> Directors = new List<Director>();
        public static List<Manager> Managers = new List<Manager>();
        public static ConcurrentQueue<ICall> Calls = new ConcurrentQueue<ICall>();
        public static ConcurrentQueue<ICall> DirCalls = new ConcurrentQueue<ICall>();
        public static ConcurrentQueue<ICall> MamCalls = new ConcurrentQueue<ICall>();
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
                  while (count++ < 20)
                  {
                      Random random = new Random();
                      int id = random.Next(70, 100);
                      Console.WriteLine($"Receive new Call: {id}");
                      Calls.Enqueue(new Call(id));
                      Thread.Sleep(2000);
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
                    ICall call;
                    Calls.TryDequeue(out call);
                    if (call != null)
                    {
                        Employees.First().ProcessCall(call);
                    }
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
                    ICall call;
                    DirCalls.TryDequeue(out call);
                    if (call != null)
                    {
                        Directors.First().ProcessCall(call);
                    }
                }
            }
        }
        public static void ManagerProcessCalls()
        {
            while (true)
            {
                if (MamCalls.Count > 0)
                {
                    ICall call;
                    MamCalls.TryDequeue(out call);
                    if (call != null)
                    {
                        Managers.First().ProcessCall(call);
                    }

                }
                Thread.Sleep(1000);
            }
        }
    }
}

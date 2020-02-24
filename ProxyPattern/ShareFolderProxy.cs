using System;

namespace ProxyPattern
{
    /*
    1. Adding security access to an existing object. The proxy will determine 
       if the client can access the object of interest.
    2. Simplifying the API od complex object. The proxy can provide a simple API 
       so that the client code does not have to deal with the complexity of the 
       object of interest.
    3. Providing interfaces for remote resources such as web service or REST 
       resources.
    4. Coordinating expensive operations on remote resources by asking the 
       remote resources to start the operation as soon as possible before 
       accessing the resources.
    5. Adding a thread-safe feature to an existing class without changing the 
       existing class code.
    */
    public class ShareFolderProxy : IshareFolder
    {
        IshareFolder sharefolder;
        Employee employee;
        public ShareFolderProxy(Employee employee)
        {
            this.employee = employee;
        }
        public string GetShareResource()
        {
            if (employee.Role == "CEO" || employee.Role == "Manager")
            {
                if (sharefolder == null)
                    sharefolder = new ShareFolder();
                Console.WriteLine("Shared Folder Proxy makes call to the RealFolder 'PerformRWOperations method'");
                return sharefolder.GetShareResource();
            }
            else
            {
                Console.WriteLine("You don't have permission");
                return "You don't have permission";
            }
        }
    }
}
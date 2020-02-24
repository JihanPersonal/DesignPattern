using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client passing employee with Role Developer to folderproxy");
            Employee emp1 = new Employee("Anurag", "Anurag123", "Developer");
            ShareFolderProxy folderProxy1 = new ShareFolderProxy(emp1);
            string resource = folderProxy1.GetShareResource();
            Console.WriteLine();
            Console.WriteLine("Client passing employee with Role Manager to folderproxy");
            Employee emp2 = new Employee("Pranaya", "Pranaya123", "Manager");
            ShareFolderProxy folderProxy2 = new ShareFolderProxy(emp2);
            folderProxy2.GetShareResource();
            Console.Read();
        }
    }
}

using System;

namespace SingletonPattern
{
    /*
    1. You need to declare a constructor that should be private and parameterless. This is required because it is not allowed the class to be instantiated from outside the class. It only instantiates from within the class.
    2. The class should be declared as sealed which will ensure that it cannot be inherited. This is going to be useful when you are dealing with the nested class. We will discuss this scenario with an example in our upcoming article.
    3. You need to create a private static variable that is going to hold a reference to the single created instance of the class if any.
    4. You also need to create a public static property/method which will 
       return the single created instance of the singleton class. 
       This method or property first check if an instance of the singleton 
       class is available or not. If the singleton instance is available, 
       then it returns that singleton instance otherwise it will create 
       an instance and then return that instance.
    */
    class Program
    {
        static void Main(string[] args)
        {
            SingletonCalss singleton = SingletonCalss.GetSingletonObj();
        }
    }
}

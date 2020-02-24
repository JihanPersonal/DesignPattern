using System;
namespace SingletonPattern
{
    sealed class SingletonCalss
    {
        private static SingletonCalss singletonobj = null;
        private SingletonCalss()
        { 
            
        }
        ///This is not Thread safe. when mutli threads try to call the 
        ///GetSingletonObj, it can potentially ends up with multi instance
        public static SingletonCalss GetSingletonObj()
        {
            if (singletonobj == null)
                singletonobj = new SingletonCalss();
            return singletonobj;
        }
        ///This is Thread safe. But slows down the application 
        public static SingletonCalss ThreadSafeGetSingletonObj()
        {
            lock (singletonobj)
            {
                if (singletonobj == null)
                    singletonobj = new SingletonCalss();
                return singletonobj;
            }
        }
        ///This is Thread safe and only impacts creation 
        public static SingletonCalss ThreadSafeGetSingletonObjV2()
        {

            if (singletonobj == null)
            {
                lock (singletonobj)
                {
                    //Double check incase it got initialized while locking
                    if (singletonobj == null)
                    {
                        singletonobj = new SingletonCalss();
                    }
                }
            }
            return singletonobj;

        }
        /*
        Without Sealed Key word, the follwoing will violate singleton
        class SingletonCalssDer : SingletonCalss
        {

        }
        */
    }
    /*
    Private constructor can prevent the following
        class SingletonCalssDer : SingletonCalss
        {

        }
    */
}
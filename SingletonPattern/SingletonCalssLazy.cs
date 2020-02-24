using System;
namespace SingletonPatternLzay
{
    sealed class SingletonCalssLazy
    {
        ///This is Thread safe but it can slow down the start of the applicaiton 
        ///when the object is extremely large
        private static SingletonCalssLazy singletonobj = new SingletonCalssLazy();
        ///This is threadsafe and make sure it will only initialzie the instance
        ///when user need one.
        private static Lazy<SingletonCalssLazy> instancelock = new Lazy<SingletonCalssLazy>(() =>
         {
             return new SingletonCalssLazy();
         });
        private SingletonCalssLazy()
        {

        }
        ///This is not Thread safe. when mutli threads try to call the 
        ///GetSingletonObj, it can potentially ends up with multi instance
        public static SingletonCalssLazy GetSingletonObj()
        {
            return singletonobj;
        }
        public static SingletonCalssLazy GetSingletonObjLazy()
        {
            return instancelock.Value;
        }

    }
}

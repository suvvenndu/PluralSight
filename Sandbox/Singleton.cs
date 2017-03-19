using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class MyClass
    {
        public string someString = Singleton.someConst;
    }
    public class Singleton
    {

       // public static readonly object mutex = new object();
        private Singleton()
        {

        }

        //private static Singleton singletonInstance;
        public  const string someConst = "Hi";

        private static readonly Singleton Instance = new Singleton();
        public void DoSomething()
        {
        }

        public static Singleton SingletonInstance { get { return Instance; } }
        //{
        //    get
        //    {
        //        if (SingletonInstance == null)
        //        {
        //            lock (mutex)
        //            {
        //                if (SingletonInstance == null)
        //                {
        //                    singletonInstance = new Singleton();
        //                }
        //            }
        //        }
        //        return singletonInstance;
        //    }
        //}
    }
}

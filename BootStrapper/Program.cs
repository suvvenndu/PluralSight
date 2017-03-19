using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using GenricType.Interface;

namespace BotteStrapper
{
    class Program
    {
        static void Main(string[] args)
        {
          

            IUnityContainer _container = new UnityContainer();
            _container.LoadConfiguration("Class2");

            var instance = _container.Resolve<IGenericLib>("Class2");

            instance.DoSomething();
            Console.ReadLine();


        }
    }
}

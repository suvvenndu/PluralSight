using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.Delagate
{
    class Program
    {

        public static void DoSomeThing(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            // DelegateTestClass dClass = new DelegateTestClass(x => { Console.WriteLine(x); });
            //dClass.handler = (x) => { Console.WriteLine("Hi...."); };
            //DelegateTestClass dClass = new DelegateTestClass(DoSomeThing);
            try
            {

                DelegateTestClass dClass = new DelegateTestClass();
                dClass.DoCallBack(DoSomeThing);

                Console.ReadLine();
            }
            catch (Exception ex)
            {

                
            }
        }
    }
}

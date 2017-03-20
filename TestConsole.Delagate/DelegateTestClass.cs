using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.Delagate
{
    class DelegateTestClass
    {
        public delegate void Del(string message);

      

       // public DelegateTestClass(Del handler)
        public DelegateTestClass()
        {
           // handler("Hi Dude... This is Delegate");
          ///  handler("Under Standing Delegates....");

        }

        public void DoCallBack(Del handler)
        {
            handler("Hi Dude... This is Delegate");
        }
    }
}

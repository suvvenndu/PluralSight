using DelegateClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSubscriber
{
    public class DelSubscriber
    {
        DelegetEx del1 = new DelegetEx();

        public DelSubscriber()
        {
           
            del1.UseDelegate((x, y) => { }); 
        }
    }
}

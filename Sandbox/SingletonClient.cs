using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    
    public class SingletonClient
    {
        [Test]
        public void UseSingleton()
        {
            Singleton s1 = Singleton.SingletonInstance;
            Singleton s2 = Singleton.SingletonInstance;

            Assert.AreSame(s1, s2);
        }
    }
}

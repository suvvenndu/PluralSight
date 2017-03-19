using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class License
    {
        private readonly DateTime expiry;

        public License(DateTime expiry)
        {
            this.expiry = expiry;
        }

        public bool HasExpired
        {
            get{ return DateTime.UtcNow > expiry; }
        }
    }
}

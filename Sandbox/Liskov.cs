using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Liskov
    {
        public virtual string FormatPoint(Point point)
        {
             return FormatPoint(point.X,point.Y);
            //return String.Format("X: {0} Y:{1}", point.X, point.Y);
        }

        public virtual string FormatPoint(int x, int y)
        {
            return String.Format("X: {0} Y:{1}", x, y);
           // return FormatPoint(new Sandbox.Point { X = x, Y = y });

        }

    }

    public class Leakage:Liskov
    {
        public override string FormatPoint(int x, int y)
        {
            return base.FormatPoint(x, y) + "<=====";
        }

    }
}

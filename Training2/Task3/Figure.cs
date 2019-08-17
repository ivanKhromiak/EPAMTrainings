using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2.Task3
{
    class Figure
    {
        public virtual void Draw() => Console.WriteLine("Figure");
        public int X{ get; }
        public int Y{ get; }
        public Figure(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2.Task2
{
    abstract class Figure
    {
        public abstract void Draw();
        public int X{ get; }
        public int Y{ get; }
        public Figure(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}

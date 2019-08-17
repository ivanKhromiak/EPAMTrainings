using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2.Task2
{
    class Rectangle: Figure
    {
        public override void Draw() => Console.WriteLine("Rectangle");
        public Rectangle(int x, int y) : base(x, y) { }
    }
}

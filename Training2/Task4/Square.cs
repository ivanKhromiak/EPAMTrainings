using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2.Task4
{
    public class Square : Figure, IDrawable
    {
        public Square(int x, int y) : base(x, y) { }

        public override void Draw() => Console.WriteLine(this.GetType().Name);
    }
}

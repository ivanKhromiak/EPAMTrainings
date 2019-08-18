using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2.Task4
{
    public class Figure : IDrawable
    {
        public Figure(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; }

        public int Y { get; }

        public static void DrawAll(params IDrawable[] array)
        {
            foreach (var item in array)
            {
                item.Draw();
            }
        }

        public virtual void Draw() => Console.WriteLine(this.GetType().Name);
    }
}

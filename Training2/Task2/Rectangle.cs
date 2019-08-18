﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2.Task2
{
    public class Rectangle : Figure
    {
        public Rectangle(int x, int y) : base(x, y) { }

        public override void Draw() => Console.WriteLine(this.GetType().Name);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2.Task3
{
    public class Square: Figure
    {
        public override void Draw() => Console.WriteLine(this.GetType().Name);
        public Square(int x, int y) : base(x, y) { }
    }
}

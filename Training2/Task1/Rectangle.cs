﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2.Task1
{
    public class Rectangle: Figure
    {
        public override void Draw() => Console.WriteLine(this.GetType().Name);
    }
}

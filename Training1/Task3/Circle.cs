using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Circle
    {
        private const double PI = 3.14;
        public double Circumference { get; private set; }
        public double Area { get; private set; }
        public Circle(double radius)
        {
            Circumference = 2 * PI * radius;
            Area = PI * radius * radius;
        }
    }
}

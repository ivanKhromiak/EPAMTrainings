using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training1.Task4
{
    public static class Circle
    {
        public static double Circumference(double radius)
        {
            const double PI = 3.14;
            double circumference = 2 * PI * radius;
            return circumference;
        }

        public static double Area(double radius)
        {
            const double PI = 3.14;
            double area = PI * radius * radius;
            return area;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public static class Regtangle
    {
        public static int Perimeter(int leftUpperX, int leftUpperY, int rightLowerX, int rightLowerY)
        {
            int length = leftUpperX - rightLowerX;
            int width = leftUpperY - rightLowerY;
            int perimeter = (2 * length) + (2 * width);
            return perimeter;
        }
        public static int Area(int leftUpperX, int leftUpperY, int rightLowerX, int rightLowerY)
        {
            int length = rightLowerX - leftUpperX;
            int width = leftUpperY - rightLowerY;
            int area = length * width;
            return area;
        }
    }
}

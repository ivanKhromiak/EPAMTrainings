using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Rectangle
    {
        private int lenght;
        private int width;

        public int Perimeter
        {
            get { return (2 * lenght) + (2 * width); }
        }
        public int Area
        {
            get { return lenght * width; }
        }

        public Rectangle(int leftUpperX, int leftUpperY, int rightLowerX, int rightLowerY)
        {
            int length = rightLowerX - leftUpperX;
            int width = leftUpperY - rightLowerY;
        }
    }
}

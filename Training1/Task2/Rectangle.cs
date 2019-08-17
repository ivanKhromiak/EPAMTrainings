using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training1.Task2
{
    class Rectangle
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
            int length = leftUpperX - rightLowerX;
            int width = leftUpperY - rightLowerY;
        }
    }
}

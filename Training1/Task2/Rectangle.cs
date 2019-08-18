using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training1.Task2
{
    public class Rectangle
    {
        private int length;
        private int width;

        public Rectangle(int leftUpperX, int leftUpperY, int rightLowerX, int rightLowerY)
        {
            length = rightLowerX - leftUpperX;
            width = leftUpperY - rightLowerY;
        }

        public int Perimeter
        {
            get { return (2 * length) + (2 * width); }
        }

        public int Area
        {
            get { return length * width; }
        }
    }
}

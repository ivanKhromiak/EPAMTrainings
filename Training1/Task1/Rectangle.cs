using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training1.Task1
{
    public class Rectangle
    {
        public Rectangle(int leftUpperX, int leftUpperY, int rightLowerX, int rightLowerY)
        {
            int length = rightLowerX - leftUpperX;
            int width = leftUpperY - rightLowerY;
            Perimeter = CalcPerimeter(length, width);
            Area = CalcArea(length, width);
        }

        public int Perimeter { get; private set; }

        public int Area { get; private set; }

        private int CalcPerimeter(int lenght, int width) => (2 * lenght) + (2 * width);

        private int CalcArea(int lenght, int width) => lenght * width;
    }
}

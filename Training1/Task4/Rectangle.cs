﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training1.Task4
{
    public static class Rectangle
    {
        public static int Perimeter(int leftUpperX, int leftUpperY, int rightLowerX, int rightLowerY)
        {
            int length = rightLowerX - leftUpperX;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training1
{
    public static class Validation
    {
        public static bool ValidateRectangle(int leftUpperX, int leftUpperY, int rightLowerX, int rightLowerY)
        {
            if (leftUpperX >= rightLowerX || leftUpperY <= rightLowerY) return false;
            return true;
        }

        public static bool ValidateCircle(double radius)
        {
            if (radius <= 0.0) return false;
            return true;
        }
    }
}

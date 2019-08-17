using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training1;

namespace Menu
{
    static class DoTraining1
    {
        static void ChooseTask()
        {
            while (true)
            {
                int choise;
                Console.WriteLine("Input number of task you want to test or zero to exit");
                int.TryParse(Console.ReadLine(), out choise);
                int upperLeftX;
                int upperLeftY;
                int lowerRightX;
                int lowerRightY;
                int radius;
                switch (choise)
                {
                    case 1:
                        Console.WriteLine("Enter X coordinate of upper-left corner");
                        int.TryParse(Console.ReadLine(), out upperLeftX);
                        Console.WriteLine("Enter Y coordinate of upper-left corner");
                        int.TryParse(Console.ReadLine(), out upperLeftY);
                        Console.WriteLine("Enter X coordinate of lower-right corner");
                        int.TryParse(Console.ReadLine(), out lowerRightX);
                        Console.WriteLine("Enter Y coordinate of lower-right corner");
                        int.TryParse(Console.ReadLine(), out lowerRightY);
                        var rectangle1 = new Task1.Rectangle(upperLeftX, upperLeftY, lowerRightX, lowerRightY);
                        Console.WriteLine($"The perimeter of regtangle {rectangle1.Perimeter}");
                        Console.WriteLine($"The area of regtangle {rectangle1.Area}");
                        break;
                    case 2:
                        Console.WriteLine("Enter X coordinate of upper-left corner");
                        int.TryParse(Console.ReadLine(), out upperLeftX);
                        Console.WriteLine("Enter Y coordinate of upper-left corner");
                        int.TryParse(Console.ReadLine(), out upperLeftY);
                        Console.WriteLine("Enter X coordinate of lower-right corner");
                        int.TryParse(Console.ReadLine(), out lowerRightX);
                        Console.WriteLine("Enter Y coordinate of lower-right corner");
                        int.TryParse(Console.ReadLine(), out lowerRightY);
                        var rectangle2 = new Task2.Rectangle(upperLeftX, upperLeftY, lowerRightX, lowerRightY);
                        Console.WriteLine($"The perimeter of regtangle {rectangle2.Perimeter}");
                        Console.WriteLine($"The area of regtangle {rectangle2.Area}");
                        break;
                    case 3:
                        Console.WriteLine("Enter radius of circle:");
                        int.TryParse(Console.ReadLine(), out radius);
                        var circle1 = new Task3.Circle(radius);
                        Console.WriteLine($"The Circumference of circle is {circle1.Circumference}");
                        Console.WriteLine($"The Area of circle is {circle1.Area}");
                        break;
                    case 4:
                        Console.WriteLine("Enter X coordinate of upper-left corner");
                        int.TryParse(Console.ReadLine(), out upperLeftX);
                        Console.WriteLine("Enter Y coordinate of upper-left corner");
                        int.TryParse(Console.ReadLine(), out upperLeftY);
                        Console.WriteLine("Enter X coordinate of lower-right corner");
                        int.TryParse(Console.ReadLine(), out lowerRightX);
                        Console.WriteLine("Enter Y coordinate of lower-right corner");
                        int.TryParse(Console.ReadLine(), out lowerRightY);
                        Task4.Regtangle.Perimeter(upperLeftX, upperLeftY, lowerRightX, lowerRightY);
                        Task4.Regtangle.Area(upperLeftX, upperLeftY, lowerRightX, lowerRightY);
                        Console.WriteLine("Enter radius of circle:");
                        int.TryParse(Console.ReadLine(), out radius);
                        Task4.Circle.Circumference(radius);
                        Task4.Circle.Area(radius);
                        break;
                    case 5:
                        break;
                    case 0:
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}

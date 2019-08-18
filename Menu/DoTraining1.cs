using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    static class DoTraining1
    {
        public static void ChooseTask()
        {
            while (true)
            {
                int choice;
                Console.WriteLine("Input number of task you want to test or zero to exit");
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input, try agian");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        DoTask1();
                        break;
                    case 2:
                        DoTask2();
                        break;
                    case 3:
                        DoTask3();
                        break;
                    case 4:
                        DoTask4();
                        break;
                    case 5:
                        DoTask5();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("No such task, try again");
                        break;
                }
            }
        }

        static private void DoTask1()
        {
            int upperLeftX;
            int upperLeftY;
            int lowerRightX;
            int lowerRightY;
            Console.WriteLine("Enter X coordinate of upper-left corner");
            upperLeftX = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y coordinate of upper-left corner");
            upperLeftY = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter X coordinate of lower-right corner");
            lowerRightX = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y coordinate of lower-right corner");
            lowerRightY = int.Parse(Console.ReadLine());
            var rectangle = new Training1.Task1.Rectangle(upperLeftX, upperLeftY, lowerRightX, lowerRightY);
            Console.WriteLine($"The perimeter of regtangle {rectangle.Perimeter}");
            Console.WriteLine($"The area of regtangle {rectangle.Area}");
        }
        static private void DoTask2()
        {
            int upperLeftX;
            int upperLeftY;
            int lowerRightX;
            int lowerRightY;
            Console.WriteLine("Enter X coordinate of upper-left corner");
            upperLeftX = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y coordinate of upper-left corner");
            upperLeftY = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter X coordinate of lower-right corner");
            lowerRightX = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y coordinate of lower-right corner");
            lowerRightY = int.Parse(Console.ReadLine());
            var rectangle = new Training1.Task2.Rectangle(upperLeftX, upperLeftY, lowerRightX, lowerRightY);
            Console.WriteLine($"The perimeter of regtangle {rectangle.Perimeter}");
            Console.WriteLine($"The area of regtangle {rectangle.Area}");
        }
        static private void DoTask3()
        {
            int radius;
            Console.WriteLine("Enter radius of circle:");
            radius = int.Parse(Console.ReadLine());
            var circle1 = new Training1.Task3.Circle(radius);
            Console.WriteLine($"The Circumference of circle is {circle1.Circumference}");
            Console.WriteLine($"The Area of circle is {circle1.Area}");
        }
        static private void DoTask4()
        {
            int upperLeftX;
            int upperLeftY;
            int lowerRightX;
            int lowerRightY;
            int radius;
            Console.WriteLine("Enter X coordinate of upper-left corner");
            upperLeftX = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y coordinate of upper-left corner");
            upperLeftY = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter X coordinate of lower-right corner");
            lowerRightX = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y coordinate of lower-right corner");
            lowerRightY = int.Parse(Console.ReadLine());
            Training1.Task4.Regtangle.Perimeter(upperLeftX, upperLeftY, lowerRightX, lowerRightY);
            Training1.Task4.Regtangle.Area(upperLeftX, upperLeftY, lowerRightX, lowerRightY);
            Console.WriteLine("Enter radius of circle:");
            int.TryParse(Console.ReadLine(), out radius);
            Training1.Task4.Circle.Circumference(radius);
            Training1.Task4.Circle.Area(radius);
        }
        static private void DoTask5()
        {
            double firstRealNumnber;
            double firstImanginaryNumber;
            double secondRealNumber;
            double seconImaginaryNumber;
            Console.WriteLine("Enter a real part of first complex number:");
            firstRealNumnber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a imaginary part of first complex number:");
            firstImanginaryNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a real part of second complex number:");
            secondRealNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a imaginary part of second complex number:");
            seconImaginaryNumber = double.Parse(Console.ReadLine());
            var firstComplexNumber = new Training1.Task5.ComplexNumber(firstRealNumnber, firstImanginaryNumber);
            var secondComplexNumber = new Training1.Task5.ComplexNumber(secondRealNumber, seconImaginaryNumber);
            Training1.Task5.ComplexNumber result = firstComplexNumber * secondComplexNumber;
            Console.WriteLine($"Result of multiplication: {result.ToString()}");
            result = firstComplexNumber / secondComplexNumber;
            Console.WriteLine($"Result of division: {result.ToString()}");
        }

    }
}

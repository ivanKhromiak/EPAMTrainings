using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal static class DoTraining2
    {
        public static void ChooseTask()
        {
            int choice;
            while (true)
            {
                Console.WriteLine("Enter the number of task you want to test");
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input, try again");
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
                    case 0:
                        return;
                    default:
                        Console.WriteLine("No such task, try again");
                        break;
                }
            }
        }

        private static void DoTask1()
        {
            var rectangle = new Training2.Task1.Rectangle();
            rectangle.Draw();
            var square = new Training2.Task1.Square();
            square.Draw();
        }

        private static void DoTask2()
        {
            var regtangle = new Training2.Task2.Rectangle(22, 20);
            var square = new Training2.Task2.Square(1, 4);
            Console.WriteLine($"X of rectangle is {regtangle.X}");
            Console.WriteLine($"Y of rectangle is {regtangle.Y}");
            regtangle.Draw();
            Console.WriteLine($"X of square is {square.X}");
            Console.WriteLine($"Y of square is {square.Y}");
            square.Draw();
        }

        private static void DoTask3()
        {
            var figure = new Training2.Task3.Figure(5, 10);
            var rectangle = new Training2.Task3.Rectangle(4, 9);
            var square = new Training2.Task3.Square(6, 11);
            figure.Draw();
            rectangle.Draw();
            square.Draw();
        }

        private static void DoTask4()
        {
            var figure = new Training2.Task4.Figure(5, 10);
            var rectangle = new Training2.Task4.Rectangle(4, 9);
            var square = new Training2.Task4.Square(6, 11);
            Training2.Task4.Figure.DrawAll(figure, rectangle, square);
        }
    }
}

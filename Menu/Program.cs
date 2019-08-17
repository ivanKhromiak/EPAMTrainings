using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            while (true)
            {
                Console.WriteLine("Enter the number of training you want to test or zero to exit:");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:

                        break;
                    case 2:
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}

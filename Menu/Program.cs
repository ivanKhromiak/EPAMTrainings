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
                if(!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input, try agian");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        DoTraining1.ChooseTask();
                        break;
                    case 2:
                        DoTraining2.ChooseTask();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("No such training, try again");
                        break;
                }
            }
        }
    }
}

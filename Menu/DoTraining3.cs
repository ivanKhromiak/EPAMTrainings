using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training3;

namespace Menu
{
    internal class DoTraining3
    {
        internal static void ChooseTask()
        {
            while (true)
            {
                Console.WriteLine("Enter 1 if you want to test tasks 1 and 2");
                Console.WriteLine("Enter 3 if you want to test tasks 3, enter 0 if you want to exit");
                int choice;
                if(!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid inout, try again");
                    break;
                }

                switch (choice)
                {
                    case 1:
                        DoTask1AndTask2();
                        break;
                    case 3:
                        DoTask3();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("No such task, try again");
                        break;
                }
            }
        }

        private static void DoTask1AndTask2()
        {
            List<Person> persons = Task1.GetListPersons();
            foreach (var person in persons)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
            Task2.AddRangePersons(ref persons);
            foreach (var person in persons)
            {
                Console.Write("Numbers: ");
                foreach (var number in person.PhoneNumbers)
                {
                    Console.Write(number + "  ");
                }
                Console.WriteLine();
            }
        }

        private static void DoTask3()
        {
            List<string> list = Task3.GenerateList();
            Console.WriteLine("Amount before changes: " + list.Count);
            Task3.DeleteSame(ref list);
            Task3.DeleteStartsWithZ(ref list);
            Task3.Sort(ref list);
            Console.WriteLine("Amount after changes: " + list.Count);
            Console.WriteLine("Enter number of page:");
            int page;
            if (!int.TryParse(Console.ReadLine(), out page))
            {
                Environment.Exit(0);
            }
            Task3.DisplayPage(ref list, page);
        }
    }
}

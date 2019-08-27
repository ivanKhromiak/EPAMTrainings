using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training3
{
    public class Task3
    {
        public static string GenerateString(Random random)
        {
            const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = "";
            for (int j = 0; j < 4; j++)
            {
                result += alphabet[random.Next(0, alphabet.Length)];
            }

            return result;
        }

        public static void DeleteSameInSortedList(ref List<string >ListOfStrings)
        {
            for (int i = 0; i < ListOfStrings.Count - 1; i++)
            {
                for (int j = i + 1; j < ListOfStrings.Count; j++)
                {
                    if (ListOfStrings[i] == ListOfStrings[j])
                    {
                        ListOfStrings.RemoveAt(j);
                        j--;
                    }
                }
            }
        }

        public static void DeleteStartsWithZ(ref List<string> ListOfStrings)
        {
            for(int i = 0; i < ListOfStrings.Count; i++)
            {
                if (ListOfStrings[i].StartsWith("Z"))
                {
                    ListOfStrings.RemoveAt(i);
                    i--;
                }
            }
        }

        public static void Sort(ref List<string> ListOfStrings)
        {
            ListOfStrings.Sort();
            ListOfStrings.Reverse();
        }

        public static void DisplayPage(ref List<string> ListOfStrings, int pageNumber)
        {
            int beginPage = (pageNumber * 5) - 5;
            if(beginPage >= ListOfStrings.Count)
            {
                Console.WriteLine("No such page"); 
            }

            for (int i = 0; i < 5; i++)
            {
                if (beginPage + i < ListOfStrings.Count)
                {
                    Console.WriteLine(ListOfStrings[beginPage + i]);
                }
            }
        }
    }
}

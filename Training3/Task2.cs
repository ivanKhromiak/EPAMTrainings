using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training3
{
    public class Task2
    {
        public static void AddRangePersons(ref List<Person> persons)
        {
            if(persons == null)
            {
                return;
            }

            var phoneNumbers1 = new List<string>() { "+380 44 258 45 67", "+380 67 123 56 67", "+380 89 456 78 99" };
            var phoneNumbers2 = new List<string>() { "+380 78 528 45 67", "+380 30 123 99 67", "+380 12 456 66 22" };
            var listOfTwoPersons = new List<Person>();
            listOfTwoPersons.Add(new Person() { Name = "Oleksii", Age = 47, PhoneNumbers = phoneNumbers1 });
            listOfTwoPersons.Add(new Person() { Name = "Roman", Age = 23, PhoneNumbers = phoneNumbers2 });
            persons.AddRange(listOfTwoPersons);
        }
    }
}

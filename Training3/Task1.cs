using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training3
{
    public class Task1
    {
        public static List<Person> GetListPersons()
        {
            var phoneNumbers1 = new List<string>() { "+380 44 123 45 67", "+380 67 123 45 67", "+380 55 456 78 99" };
            var phoneNumbers2 = new List<string>() { "+380 44 528 45 67", "+380 44 123 99 67", "+380 12 478 66 22" };
            var phoneNumbers3 = new List<string>() { "+380 21 123 45 67", "+380 55 123 99 67", "+380 12 134 65 99" };
            var phoneNumbers4 = new List<string>() { "+380 55 447 99 67", "+380 44 123 99 22", "+380 01 223 45 96" };
            var phoneNumbers5 = new List<string>() { "+380 36 123 99 67", "+380 48 123 23 67", "+380 00 225 78 64" };
            var phoneNumbers6 = new List<string>() { "+380 55 447 99 85", "+380 55 447 99 79", "+380 42 537 45 95" };
            var Persons = new List<Person>();
            Persons.Add(new Person() { Name = "Ivan", Age = 45, PhoneNumbers = phoneNumbers1 });
            Persons.Add(new Person() { Name = "Taras", Age = 28, PhoneNumbers = phoneNumbers2 });
            Persons.Add(new Person() { Name = "Victoria", Age = 79, PhoneNumbers = phoneNumbers3 });
            Persons.Add(new Person() { Name = "Serhii", Age = 22, PhoneNumbers = phoneNumbers4 });
            Persons.Add(new Person() { Name = "Nazar", Age = 34, PhoneNumbers = phoneNumbers5 });
            Persons.Add(new Person() { Name = "Andriy", Age = 19, PhoneNumbers = phoneNumbers6 });
            return Persons;
        }
    }
}

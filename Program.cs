using System;
using HashTable.Models;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var thirdHashTable = new ThirdHashTable<Person>(100);
            var person1 = new Person() { Name = "John", Age = 12, Gender = 0 };
            var person2 = new Person() { Name = "Smith", Age = 19, Gender = 0 };
            var person3 = new Person() { Name = "Peter", Age = 29, Gender = 0 };
            var person4 = new Person() { Name = "Max", Age = 30, Gender = 0 };

            thirdHashTable.Add(person1);
            thirdHashTable.Add(person2);
            thirdHashTable.Add(person3);

            Console.WriteLine(thirdHashTable.Search(person1));
            Console.WriteLine(thirdHashTable.Search(person2));
            Console.WriteLine(thirdHashTable.Search(person3));
            Console.WriteLine(thirdHashTable.Search(person4));

            Console.ReadLine();


            var secondHashTable = new SecondHashTable<int, string>(100);
            secondHashTable.Add(4, "May");
            secondHashTable.Add(34, "World");
            secondHashTable.Add(12, "Space");
            secondHashTable.Add(12, "Sun");

            Console.WriteLine(secondHashTable.Search(4, "May"));
            Console.WriteLine(secondHashTable.Search(34, "World"));
            Console.WriteLine(secondHashTable.Search(34, "Grass"));
            Console.WriteLine(secondHashTable.Search(12, "Space"));
            Console.WriteLine(secondHashTable.Search(12, "Sun"));

            Console.ReadLine();

            var firstHashTable = new HashTable<int>(100);
            firstHashTable.Add(5);
            firstHashTable.Add(34);
            firstHashTable.Add(786);

            Console.WriteLine(firstHashTable.Search(6));
            Console.WriteLine(firstHashTable.Search(34));

            Console.ReadLine();

        }
    }
}

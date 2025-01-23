using System;
using Oop_3_3.boxer;

namespace Program
{
    class Program
    {
        static void Main()
        {
            Boxer[] boxers = 
            {
                new Boxer("hasnboy", "Dosmatov", 30, 45),
                new Boxer("vali", "Soli", 40, 70),
                new Boxer("Michael", "Tyson", 25, 110)
            };

            foreach (Boxer item in boxers)
            {
                Console.WriteLine($"{item.LastName} {item.FirstName}, Age: {item.Age}, Weight: {item.Weight}, Category: {item.BoxerCategory}");
            }
        }
    }
}

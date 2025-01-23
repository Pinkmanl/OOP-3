using System;

namespace Oop_3_3.boxer
{
    public class Boxer
    {
        // Auto-implemented Weight property.
        public int Weight { get; set; }

        // Category property based on Weight.
        public Category BoxerCategory
        {
            get
            {
                return Weight < 50 ? Category.FLY_WEIGHT : Weight < 90 ? Category.MEDIUM : Category.HEAVY;
            }
        }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public Guid Id { get; set; }

        // Constructor for Boxer class.
        public Boxer(string firstName, string lastName, int age, int weight)
        {
            Id = Guid.NewGuid(); // Generates a unique ID
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Weight = weight;
        }
    }
}
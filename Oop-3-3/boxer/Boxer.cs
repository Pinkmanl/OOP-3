using System;

namespace Oop_3_3.boxer
{
    public class Boxer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public BoxerCategory Category
        {
            get
            {
                return Weight < 50
                ? BoxerCategory.EASY
                : Weight < 90
                    ? BoxerCategory.MEDIUM
                    : BoxerCategory.HEAVY;
            }


        }
        public Boxer(string firstName, string lastName, int age, int weight)
        {

            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Weight = weight;
        }
    }
}
namespace Oop_3_1.Student
{
    public class Student
    {
        public Guid id { get; private set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Sinf { get; set; }
        public Bahosi Bahosi { get; set; }

        public Student(int sinf, string lastName, string firstName, Bahosi bahosi)
        {
            id = Guid.NewGuid();
            Sinf = sinf;
            LastName = lastName;
            FirstName = firstName;
            Bahosi = bahosi; 
        }
    }
}

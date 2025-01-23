using System;
using Oop_3_1.Student;

namespace program
{
    class Program
    {
        static void Main()
        {
            Student[] students =
            {
                new Student(7, "Ali"     , "Aliyev"  , Bahosi.S),
                new Student(8, "Vali"    , "Valiyev" , Bahosi.A),
                new Student(7, "Eshmamat", "Ergashov", Bahosi.B),
                new Student(11, "Soli"   , "Soliyev" , Bahosi.C),
                new Student(9, "Eshmat"  , "Eshmatov", Bahosi.S),
            };
        
            Console.WriteLine("Bahoni kiriting: namuna S,A,B,C");
            string input = (Console.ReadLine() ?? "").Trim().ToUpper();

          
            if (Enum.TryParse(input, out Bahosi baho))
            {
                foreach (Student student in students)
                {
                    if (baho.Equals(student.Bahosi))
                    {
                        Console.WriteLine("{3}-sinf, {1} {2} {0}", student.id, student.LastName, student.FirstName, student.Sinf);
                    }
                }
            }
            else
            {
                Console.WriteLine("Noto'g'ri baho kiritildi.");
            }
        }
    }
}

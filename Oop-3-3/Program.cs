using System;
using Oop_3_3.boxer;

namespace Program
{
    class Program
    {
        static void Main()
        {
            Boxer[] boxers =
            [
                new("Hasanboy"  ,"Dosmatov",30,70),
                new("ali"       ,"Aliyev"  ,40,60),
                new("sali"       ,"sAliyev"  ,40,49),
                new("Vali"      ,"Valiyev" ,25,100),
          ];
            System.Console.WriteLine("qay turdagi bokschilar kerak");
            System.Console.WriteLine("1.yengil, \n2.o'rta, \n3.og'ir");
            int input = Convert.ToInt32(Console.ReadLine());

            foreach (Boxer item in boxers)
            {
                if ((int)item.Category == input)
                    System.Console.WriteLine("{0} {1} {2} {3} {4} {5}",
                        item.Id,                item.LastName,
                        item.FirstName,         item.Age,
                        item.Weight,            item.Category
                    );
            }
        }
    }
}

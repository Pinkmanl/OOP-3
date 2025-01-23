using System;
using Oop_3_2.Class;
namespace progarm
{
    class Program
    {
        static void Main()
        {
            Car[] cars =
            [
                 new("BMW"       ,"BMW E46 M3"  ,70_000),
                 new("daewoo"    ,"nexia"       , 3_700),
                 new("daewoo"    ,"nexia 2"     , 5_000),
                 new("toyota"    , "camry"      ,30_000),
                 new("chevrolet" ,"lacetti 2"   ,13_000),
];
            System.Console.WriteLine("minimal narxni kiriting");
            int minPrice = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("maxsimal narxni kiriting");
            int maxPrice = Convert.ToInt32(Console.ReadLine());
            foreach (Car car in cars)
            {
                if (car.Price >= minPrice && car.Price <= maxPrice)
                    System.Console.WriteLine($"markasi: {car.Brand}, modeli, {car.Model},narxi: {car.Price}");
            }

        }
    }
}
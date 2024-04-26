using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример1 использования класса Triangle
            Triangle<int> intTriangle = new Triangle<int>(3, 4, 5);
            Console.WriteLine("Информация о целочисленном треугольнике:");
            intTriangle.DisplayInfo();
            Console.WriteLine($"Площадь треугольника: {intTriangle.CalculateArea()}");

            // Пример2 использования класса Segment
            Segment<double> doubleSegment = new Segment<double>(1.0, 2.0, 3.0, 4.0);
            Console.WriteLine("\nИнформация о отрезке с плавающей точкой:");
            doubleSegment.DisplayInfo();
            Console.WriteLine($"Длина отрезка: {doubleSegment.CalculateLength()}");
            Console.ReadKey();
        }
    }
}

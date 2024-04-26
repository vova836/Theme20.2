using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    /// <summary>
    /// Создаем обобщенный класс Треугольник
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Triangle<T>
    {
        private T sideA;
        private T sideB;
        private T sideC;
        /// <summary>
        /// Конструктор с параметрамми 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public Triangle(T a, T b, T c)
        {
            sideA = a;
            sideB = b;
            sideC = c;
        }

        /// <summary>
        /// Создаем свойства с дополнительной логикой
        /// </summary>
        public T SideA { get; set; }
        public T SideB { get; set; }
        public T SideC { get; set; }

        /// <summary>
        /// Метод вывода информации о треугольнике
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"Стороны треугольника: {sideA}, {sideB}, {sideC}");
        }

        /// <summary>
        /// Метод, возвращающий площадь треугольника
        /// </summary>
        /// <returns></returns>
        public double CalculateArea()
        {
            dynamic a = sideA;
            dynamic b = sideB;
            dynamic c = sideC;

            dynamic s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
}

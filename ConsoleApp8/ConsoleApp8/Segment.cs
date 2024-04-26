using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    /// <summary>
    /// Создаем обобщенный класс Сегмент
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Segment<T>
    {
        private T X1;
        private T Y1;
        private T X2;
        private T Y2;

        /// <summary>
        /// Конструктор с параметрамми
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        public Segment(T x1, T y1, T x2, T y2)
        {
            this.X1 = x1;
            this.Y1 = y1;
            this.X2 = x2;
            this.Y2 = y2;
        }

        /// <summary>
        /// Метод вывода информации об отрезке
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"Начальная точка: ({X1}, {Y1}), Конечная точка: ({X2}, {Y2})");
        }

        /// <summary>
        /// Метод, возвращающий длину отрезка
        /// </summary>
        /// <returns></returns>
        public double CalculateLength()
        {
            dynamic x1 = X1;
            dynamic y1 = Y1;
            dynamic x2 = X2;
            dynamic y2 = Y2;

            dynamic dx = x2 - x1;
            dynamic dy = y2 - y1;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}

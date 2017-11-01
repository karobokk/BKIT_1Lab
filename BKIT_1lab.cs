using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double d, x1, x2;
            double a, b, c;

            bool ConvertResult;
            do
            {
                Console.WriteLine("Введите значение a:");
                ConvertResult = double.TryParse(Console.ReadLine(), out a);
            } while (ConvertResult != true);

            do
            {
                Console.WriteLine("Введите значение b:");
                ConvertResult = double.TryParse(Console.ReadLine(), out b);
            } while (ConvertResult != true);

            do
            {
                Console.WriteLine("Введите значение c:");
                ConvertResult = double.TryParse(Console.ReadLine(), out c);
            } while (ConvertResult != true);

            d = b * b - 4 * a * c;
            if (d >= 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Дискриминант: " + d);
                Console.Write("Корни квадратного уравнения: " + x1 + ", " + x2);
            }
            else Console.Write("Квадратное уравнение не имеет решений");

            Console.ReadLine();
        }
    }
}

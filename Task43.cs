using System;

namespace HomeworkSeminar10072023
{
    /*
     * Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
     * заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
     * значения b1, k1, b2 и k2 задаются пользователем.
     * b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
     */
    internal class Task43
    {
        internal static void InterestionDot()
        {
            (double k, double b) GetData(string numberVar)
            {
                Console.WriteLine("Введите k и b " + numberVar + " прямой");
                Console.Write("k = ");
                if (!double.TryParse(Console.ReadLine(), out var k))
                    throw new Exception("Данное значение введено неккоректно!");
                Console.Write("b = ");
                if (!double.TryParse(Console.ReadLine(), out var b))
                    throw new Exception("Данное значение введено неккоректно!");
                return (k, b);
            }
            var first = GetData("первой");
            var second = GetData("второй");

            var x = (second.b - first.b) / (first.k - second.k);
            var y = first.k * x + first.b;
            Console.WriteLine("Координаты точки пересечения двух прямых: ({0}; {1})", x, y);
        }
    }
}

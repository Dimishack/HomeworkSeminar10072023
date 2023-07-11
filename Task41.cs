using System;
using System.Collections.Generic;

namespace HomeworkSeminar10072023
{
    /*
     * Задача 41: Пользователь вводит с клавиатуры M чисел. 
     * Посчитайте, сколько чисел больше 0 ввёл пользователь.
     * 0, 7, 8, -2, -2 -> 2
     * 1, -7, 567, 89, 223-> 3
     */
    internal class Task41
    {
        internal static void MoreZero()
        {
            int[] array;
            List<int> evenNums = new();

            Console.Write("Введите количество целых чисел, которые вы будете вводить: ");
            if (UInt32.TryParse(Console.ReadLine(), out var lenght))
                array = new int[lenght];
            else throw new Exception("Значение введено неккоректно!");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Введите целое число: ");
                if (!Int32.TryParse(Console.ReadLine(), out array[i]))
                    throw new Exception("Значение введено неккоректно!");
                if (array[i] > 0)
                    evenNums.Add(array[i]);
            }
            Console.WriteLine("Количество чисел больше 0: " + evenNums.Count);
            Console.WriteLine("Числа больше 0: ");
            foreach (int i in evenNums)
                Console.Write(i + " ");
        }
    }
}

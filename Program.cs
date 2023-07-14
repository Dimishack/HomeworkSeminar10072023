using System;

namespace HomeworkSeminar10072023
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Задача №43");
                Task43.InterestionDot();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("\nНажмите любую клавишу для выхода из программы...");
                Console.ReadKey(true);
            }
        }
    }
}
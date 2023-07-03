using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 0;

        while (n == 0)
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine();

            if (!Int32.TryParse(input, out n) || n == 0)
            {
                Console.WriteLine("Ошибка: введено некорректное значение.");
                n = 0;
            }
        }
        Console.WriteLine();
        Console.Write(n + " → ");

        for (int i = 1; i <= n; i++)
        {
            Console.Write(Math.Pow(i, 3));

            if (i != n)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}
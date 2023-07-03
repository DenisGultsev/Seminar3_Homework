using System;

class Program
{
    static void Main(string[] args)
    {
        int ax, ay, az, bx, by, bz;

        // ввод координат первой точки
        while (true)
        {
            Console.Write("Введите координаты точки A через пробел: ");
            string[] input = Console.ReadLine().Split(' ');
            ax = Convert.ToInt32(input[0]);
            ay = Convert.ToInt32(input[1]);
            az = Convert.ToInt32(input[2]);

            if (ax == 0 || ay == 0 || az == 0)
            {
                Console.WriteLine("Ошибка: координаты не могут быть равны 0. Попробуйте еще раз.");
            }
            else
            {
                break;
            }
        }

        // ввод координат второй точки
        while (true)
        {
            Console.Write("Введите координаты точки B через пробел: ");
            string[] input = Console.ReadLine().Split(' ');
            bx = Convert.ToInt32(input[0]);
            by = Convert.ToInt32(input[1]);
            bz = Convert.ToInt32(input[2]);

            if (bx == 0 || by == 0 || bz == 0)
            {
                Console.WriteLine("Ошибка: координаты не могут быть равны 0. Попробуйте еще раз.");
            }
            else
            {
                break;
            }
        }

        // вычисление расстояния между точками
        double distance = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));

        Console.WriteLine();

        // вывод результата
        Console.WriteLine("A ({0},{1},{2}); B ({3},{4},{5}) → {6:f2}",
            ax, ay, az, bx, by, bz, distance);
    }
}

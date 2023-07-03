while (true)
{
    Console.Write("Введите пятизначное число: ");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out int number) || input.Length != 5)
    {
        Console.WriteLine("Ошибка ввода: Это число не является пятизначным!");
    }
    else
    {
        int temp = number;
        int reverseNumber = 0;
        while (temp > 0)
        {
            int remainder = temp % 10;
            reverseNumber = (reverseNumber * 10) + remainder;
            temp = temp / 10;
        }

        if (number == reverseNumber)
        {
            Console.WriteLine($"{number} -> да, это число является полиндромом.");
        }
        else
        {
            Console.WriteLine($"{number} -> нет, это число не является полиндромом.");
        }

        break;
    }
}

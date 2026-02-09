using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число, оканчивающееся на 5: ");
        string input = Console.ReadLine().Trim();

        if (!long.TryParse(input, out long A) || A % 10 != 5)
        {
            Console.WriteLine("ERROR: число должно оканчиваться на 5 и быть натуральным.");
            return;
        }

        long baseNum = A / 10;
        long nextNum = baseNum + 1;

        long result = baseNum * nextNum;

        Console.WriteLine(result.ToString() + "25");
    }
}
using System;
class Task2
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int sum = 0;

        if (N >= 1)
        {
            sum = N * (N + 1) / 2;
        }
        else
        {
            for (int i = N; i <= 1; i++)
            {
                sum += i;
            }
        }

        Console.WriteLine(sum);
    }
}
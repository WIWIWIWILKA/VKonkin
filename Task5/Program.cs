using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        int N = int.Parse(Console.ReadLine()!);
        
        // Считываем массив чисел
        string[] parts = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] days = Array.ConvertAll(parts, int.Parse);

        List<int> threes = new List<int>();  // нечетные дни → тройки
        List<int> fours = new List<int>();   // четные дни → четверки

        foreach (int day in days)
        {
            if (day % 2 == 0)
                fours.Add(day);
            else
                threes.Add(day);
        }
        
        Console.WriteLine(string.Join(" ", threes));
        Console.WriteLine(string.Join(" ", fours));
        Console.WriteLine(fours.Count >= threes.Count ? "YES" : "NO");
    }
}
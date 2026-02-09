using System;

class Program
{
    static void Main()
    {

        string[] parts = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int A = int.Parse(parts[0]);
        int B = int.Parse(parts[1]);
        int C = int.Parse(parts[2]);


        Console.WriteLine(A * B == C ? "YES" : "NO");
    }
}
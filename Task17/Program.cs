using System;
using System.Linq;

class Task17
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        
        int L = N - 1;
        int[] a = new int[L];
        Array.Copy(arr, a, L);
        
        int[] pi = new int[L];
        int j = 0;

        for (int i = 1; i < L; i++)
        {
            while (j > 0 && a[i] != a[j])
                j = pi[j - 1];

            if (a[i] == a[j])
                j++;

            pi[i] = j;
        }

        int result = L - pi[L - 1];
        Console.WriteLine(result);
    }
}
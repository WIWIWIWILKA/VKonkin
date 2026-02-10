using System;

class Program
{
    static void Main()
    {
        string start = Console.ReadLine();
        string end = Console.ReadLine();

        int startSec = ToSeconds(start);
        int endSec = ToSeconds(end);

        long[] count = new long[10];

        for (int t = startSec; t <= endSec; t++)
        {
            string time = FromSeconds(t);

            foreach (char c in time)
            {
                if (char.IsDigit(c))
                    count[c - '0']++;
            }
        }

        for (int i = 0; i < 10; i++)
            Console.WriteLine(count[i]);
    }

    static int ToSeconds(string time)
    {
        int h = int.Parse(time.Substring(0, 2));
        int m = int.Parse(time.Substring(3, 2));
        int s = int.Parse(time.Substring(6, 2));
        return h * 3600 + m * 60 + s;
    }

    static string FromSeconds(int total)
    {
        int h = total / 3600;
        int m = (total % 3600) / 60;
        int s = total % 60;

        return $"{h:D2}:{m:D2}:{s:D2}";
    }
}
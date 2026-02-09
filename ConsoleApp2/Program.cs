using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите задачу (1–10):");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: Task1(); break;
            case 2: Task2(); break;
            case 3: Task3(); break;
            case 4: Task4(); break;
            case 5: Task5(); break;
            case 6: Task6(); break;
            case 7: Task7(); break;
            case 8: Task8(); break;
            case 9: Task9(); break;
            case 10: Task10(); break;
            default: Console.WriteLine("Нет такой задачи"); break;
        }
    }

    // 1
    static void Task1()
    {
        Console.WriteLine("Введите три числа:");
        for (int i = 0; i < 3; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double result = x >= 0 ? Math.Pow(x, 2) : Math.Pow(x, 4);
            Console.WriteLine(result);
        }
    }

    // 2
    static void Task2()
    {
        Console.WriteLine("Введите координату первой точки (x):");
        double x1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите координату первой точки (y):");
        double y1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите координату второй точки (x):");
        double x2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите координату второй точки (y):");
        double y2 = double.Parse(Console.ReadLine());

        double d1 = Math.Sqrt(x1 * x1 + y1 * y1);
        double d2 = Math.Sqrt(x2 * x2 + y2 * y2);

        Console.WriteLine(d1 < d2 ? "Первая точка ближе" : "Вторая точка ближе");
    }

    // 3
    static void Task3()
    {
        Console.WriteLine("Введите два угла:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = 180 - a - b;

        if (c <= 0)
            Console.WriteLine("Треугольник не существует");
        else if (a == 90 || b == 90 || c == 90)
            Console.WriteLine("Треугольник прямоугольный");
        else
            Console.WriteLine("Треугольник существует, но не прямоугольный");
    }

    // 4
    static void Task4()
    {
        Console.WriteLine("Введите два разных числа:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        double min = Math.Min(a, b);
        double max = Math.Max(a, b);

        min = (a + b) / 2;
        max = 2 * a * b;

        Console.WriteLine($"Меньшее: {min}, Большее: {max}");
    }

    // 5
    static void Task5()
    {
        Console.WriteLine("Введите координаты точки:");
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        if (x == 0 && y == 0) Console.WriteLine("Начало координат");
        else if (x == 0) Console.WriteLine("На оси Y");
        else if (y == 0) Console.WriteLine("На оси X");
        else if (x > 0 && y > 0) Console.WriteLine("I четверть");
        else if (x < 0 && y > 0) Console.WriteLine("II четверть");
        else if (x < 0 && y < 0) Console.WriteLine("III четверть");
        else Console.WriteLine("IV четверть");
    }

    // 6
    static void Task6()
    {
        Console.WriteLine("Введите дату (день месяц):");
        int d = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        bool correct = d >= 1 && d <= 31 && m >= 1 && m <= 12;
        Console.WriteLine(correct ? "Дата корректна" : "Дата некорректна");
    }

    // 7
    static void Task7()
    {
        Console.WriteLine("Введите три числа:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double sum = Math.Min(a, Math.Min(b, c)) + Math.Max(a, Math.Max(b, c));
        Console.WriteLine(sum);
    }

    // 8
    static void Task8()
    {
        Console.WriteLine("Введите координаты точки:");
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите радиус:");
        double r = double.Parse(Console.ReadLine());

        bool inside = x * x + y * y <= r * r;
        Console.WriteLine(inside ? "Точка внутри окружности" : "Точка вне окружности");
    }

    // 9
    static void Task9()
    {
        const double Ax = 0, Ay = 0;
        const double Bx = 4, By = 0;
        const double Cx = 0, Cy = 3;

        Console.WriteLine("Введите координаты точки D:");
        double Dx = double.Parse(Console.ReadLine());
        double Dy = double.Parse(Console.ReadLine());

        double S(double x1, double y1, double x2, double y2, double x3, double y3)
            => Math.Abs((x1*(y2-y3)+x2*(y3-y1)+x3*(y1-y2))/2);

        double ABC = S(Ax, Ay, Bx, By, Cx, Cy);
        double ABD = S(Ax, Ay, Bx, By, Dx, Dy);
        double ADC = S(Ax, Ay, Dx, Dy, Cx, Cy);
        double BDC = S(Bx, By, Dx, Dy, Cx, Cy);

        Console.WriteLine(ABC >= ABD + ADC + BDC
            ? "Точка внутри треугольника"
            : "Точка вне треугольника");
    }

    // 10
    static void Task10()
    {
        Console.WriteLine("Введите три стороны:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a + b <= c || a + c <= b || b + c <= a)
        {
            Console.WriteLine("Треугольник не существует");
            return;
        }

        double a2 = a * a, b2 = b * b, c2 = c * c;
        bool acute = a2 + b2 > c2 && a2 + c2 > b2 && b2 + c2 > a2;

        Console.WriteLine(acute ? "Треугольник остроугольный" : "Треугольник не остроугольный");
    }
}

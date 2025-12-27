using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Introduceti b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Introduceti n: ");
        int n = int.Parse(Console.ReadLine());

        int count = 0;

        for (int i = a; i <= b; i++)
        {
            if (i % n == 0)
                count++;
        }

        Console.WriteLine("Numere divizibile cu " + n + ": " + count);
    }
}


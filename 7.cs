using System;

class Program
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());

        int c = a;
        a = b;
        b = c;

        Console.WriteLine("Valorile inversate:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("a = " + a + ", b = " + b);
    }
}

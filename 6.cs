using System;

class Program
{
    static void Main()
    {
        Console.Write("a = ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("b = ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("c = ");
        int c = Convert.ToInt32(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
            Console.WriteLine("Se poate forma un triunghi.");
        else
            Console.WriteLine("Nu se poate forma un triunghi.");
    }
}

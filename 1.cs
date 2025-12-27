using System;

class Program
{
    static void Main()
    {
        Console.Write("Introdu a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introdu b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        if (a != 0)
        {
            double x = -b / a;
            Console.WriteLine("Solutia este x = " + x);
        }
        else
        {
            Console.WriteLine("Nu se poate calcula (a este 0).");
        }
    }
}

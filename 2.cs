using System;

class Program
{
    static void Main()
    {
        Console.Write("a = "); double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b = "); double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("c = "); double c = Convert.ToDouble(Console.ReadLine());

        double D = b * b - 4 * a * c; 

        if (D > 0)
        {
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);
            Console.WriteLine("Doua solutii: x1 = " + x1 + ", x2 = " + x2);
        }
        else if (D == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("O singura solutie: x = " + x);
        }
        else
        {
            Console.WriteLine("Nu exista solutii reale.");
        }
    }
}

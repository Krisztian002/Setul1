using System;

class Program
{
    static void Main()
    {
        Console.Write("Introdu n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introdu k: ");
        int k = Convert.ToInt32(Console.ReadLine());

        if (k == 0)
        {
            Console.WriteLine("Nu se poate împărți la 0!");
        }
        else if (n % k == 0) 
        {
            Console.WriteLine(n + " se împarte exact la " + k);
        }
        else
        {
            Console.WriteLine(n + " NU se împarte exact la " + k);
        }
    }
}

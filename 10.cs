using System;

class Program
{
    static void Main()
    {
        Console.Write("Introdu un numar: ");
        int n = int.Parse(Console.ReadLine());
        bool prim = true;

        if (n <= 1)
        {
            prim = false; 
        }
        else
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    prim = false; 
                    break; 
                }
            }
        }

        if (prim)
        {
            Console.WriteLine(n + " este prim.");
        }
        else
        {
            Console.WriteLine(n + " nu este prim.");
        }
    }
}

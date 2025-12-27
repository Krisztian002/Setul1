using System;

class Program
{
    static void Main()
    {
        Console.Write("Introdu un numar: ");
        int n = int.Parse(Console.ReadLine());

        int original = n;
        int invers = 0;

        while (n > 0)
        {
            int cifra = n % 10;       
            invers = invers * 10 + cifra; 
            n = n / 10;              
        }

        if (original == invers)
            Console.WriteLine("Numarul este palindrom.");
        else
            Console.WriteLine("Numarul NU este palindrom.");
    }
}

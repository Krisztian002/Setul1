using System;

class Program
{
    static void Main()
    {
        Console.Write("Numarul: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Pozitia k: ");
        int k = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < k; i++)
            n = n / 10;   

        int cifra = n % 10; 

        Console.WriteLine("Cifra este: " + cifra);
    }
}

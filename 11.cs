using System;

class Program
{
    static void Main()
    {
        Console.Write("Introdu un număr: ");
        int n = int.Parse(Console.ReadLine());

        while (n > 0)
        {
            int cifra = n % 10; 
            Console.Write(cifra);
            n = n / 10;         
        }
    }
}

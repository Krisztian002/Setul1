using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti un numar: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Divizorii lui " + n + " sunt:");
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                Console.WriteLine(i);
        }
    }
}

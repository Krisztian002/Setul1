using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti n: ");
        int n = int.Parse(Console.ReadLine());

        int d = 2;

        while (n > 1)
        {
            int putere = 0;

            while (n % d == 0)
            {
                n = n / d;
                putere++;
            }

            if (putere > 0)
            {
                Console.Write(d + "^" + putere + " ");
            }

            d++;
        }
    }
}

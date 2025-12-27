using System;

class Program
{
    static void Main()
    {
        Console.Write("Numarul 1: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Numarul 2: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Numarul 3: ");
        int c = int.Parse(Console.ReadLine());

        Console.Write("Numarul 4: ");
        int d = int.Parse(Console.ReadLine());

        Console.Write("Numarul 5: ");
        int e = int.Parse(Console.ReadLine());

        int temp;

        if (a > b) { temp = a; a = b; b = temp; }
        if (a > c) { temp = a; a = c; c = temp; }
        if (a > d) { temp = a; a = d; d = temp; }
        if (a > e) { temp = a; a = e; e = temp; }

        if (b > c) { temp = b; b = c; c = temp; }
        if (b > d) { temp = b; b = d; d = temp; }
        if (b > e) { temp = b; b = e; e = temp; }

        if (c > d) { temp = c; c = d; d = temp; }
        if (c > e) { temp = c; c = e; e = temp; }

        if (d > e) { temp = d; d = e; e = temp; }

        Console.WriteLine("Ordinea crescatoare este: " 
            + a + ", " + b + ", " + c + ", " + d + ", " + e);
    }
}

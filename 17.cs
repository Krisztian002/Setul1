using System;

class Program
{
    static void Main()
    {
        Console.Write("Introdu primul numar: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Introdu al doilea numar: ");
        int b = int.Parse(Console.ReadLine());

        int cmmdc = GCD(a, b);  
        int cmmmc = (a * b) / cmmdc; 

        Console.WriteLine("Cel mai mare divizor comun (CMMD): " + cmmdc);
        Console.WriteLine("Cel mai mic multiplu comun (CMMMC): " + cmmmc);
    }

    static int GCD(int x, int y)
    {
        while (y != 0)
        {
            int temp = y;
            y = x % y;
            x = temp;
        }
        return x;
    }
}

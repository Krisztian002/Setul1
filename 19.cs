using System;

class Program
{
    static void Main()
    {
        Console.Write("Introdu numarul: ");
        int n = int.Parse(Console.ReadLine());

        int a = -1; 
        int b = -1; 
        bool eValid = true;

        while (n > 0)
        {
            int cifra = n % 10; 
            n = n / 10;         
            if (a == -1)
                a = cifra;       
            else if (cifra != a && b == -1)
                b = cifra;      
            else if (cifra != a && cifra != b)
            {
                eValid = false;  
                break;
            }
        }

        if (eValid)
            Console.WriteLine("DA");
        else
            Console.WriteLine("NU");
    }
}

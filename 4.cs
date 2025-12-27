using System;

class Program
{
    static void Main()
    {
        Console.Write("Introdu anul: ");
        int y = Convert.ToInt32(Console.ReadLine());

        if (y % 400 == 0)
            Console.WriteLine("An bisect");
        else if (y % 4 == 0 && y % 100 != 0)
            Console.WriteLine("An bisect");
        else
            Console.WriteLine("Nu este an bisect");
    }
}

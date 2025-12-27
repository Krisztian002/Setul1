using System;

class Program
{
    static void Main()
    {
        int min = 1;
        int max = 1024;

        while (min < max)
        {
            int mid = (min + max + 1) / 2;
            Console.WriteLine(mid);
            int raspuns = int.Parse(Console.ReadLine());

            if (raspuns == 1)
                min = mid;
            else
                max = mid - 1;
        }

        Console.WriteLine(min);
    }
}

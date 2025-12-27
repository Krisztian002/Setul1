using System;

class Program
{
    static void Main()
    {
        int y1 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());

        int cnt = 0;

        for (int y = y1; y <= y2; y++)
        {
            if ( (y % 4 == 0 && y % 100 != 0) || (y % 400 == 0) )
            {
                cnt++;
            }
        }

        Console.WriteLine(cnt);
    }
}



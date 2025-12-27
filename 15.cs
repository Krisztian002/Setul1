  using System;

  class Program
  {
      static void Main()
      {
          Console.Write("Introdu primul numar: ");
          int a = int.Parse(Console.ReadLine());

         Console.Write("Introdu al doilea numar: ");
         int b = int.Parse(Console.ReadLine());

         Console.Write("Introdu al treilea numar: ");
         int c = int.Parse(Console.ReadLine());

         int temp;

         if (a > b)
         {
             temp = a;
             a = b;
             b = temp;
         }

         if (a > c)
         {
             temp = a;
             a = c;
             c = temp;
         }

         if (b > c)
         {
             temp = b;
             b = c;
             c = temp;
         }

         Console.WriteLine("Numerele in ordine crescatoare sunt: " + a + ", " + b + ", " + c);
     }
 }

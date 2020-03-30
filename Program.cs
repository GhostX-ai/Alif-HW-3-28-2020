using System;

namespace FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a bottle of rum!(GhostX)");
            //#1
            int a = 1, b = 10, res = 0;
            for (int i = a + 1; i < b; i++)
            {
                res += i;
            }
            System.Console.WriteLine(res);
            for (int i = a + 1; i < b; i++)
            {
                if (i % 2 != 0)
                {
                    System.Console.WriteLine(i);
                }
            }
            //#2
            for (int i = 0; i <= 10; i++)
            {
                for (int x = 0; x <= 30; x++)
                {
                    Console.Write("*");
                }
                System.Console.WriteLine();
            }
            for (int i = 0; i <= 10; i++)
            {
                for (int x = 0; x <= i; x++)
                {
                    Console.Write("* ");
                }
                System.Console.WriteLine();
            }
            int z = 0, o = 10;
            for (int i = o; i >= 0; i--)
            {
                z++;
                for (int x = o; x >= 0; x--)
                {
                    Console.Write(" ");
                }
                o--;
                for (int y = 0; y < z; y++)
                {
                    Console.Write("* ");
                }
                System.Console.WriteLine();
            }
            o = 5;
            z = 0;
            for (int i = o; i >= 0; i--)
            {
                z++;
                for (int x = o; x >= 0; x--)
                {
                    Console.Write(" ");
                }
                o--;
                for (int y = 0; y < z; y++)
                {
                    Console.Write("* ");
                }
                System.Console.WriteLine();
            }
            o = 5;
            z = 0;
            for (int i = 0; i <= 5; i++)
            {
                z++;
                for (int x = 0; x <= z; x++)
                {
                    Console.Write(" ");
                }
                o--;
                for (int y = o; y >= 0; y--)
                {
                    Console.Write("* ");
                }
                System.Console.WriteLine();
            }
            //#3
            double v = 1000, p = 5, r = 0;
            for (double i = v; v < 1100;)
            {
                r++;
                v += v * p / 100;
                System.Console.WriteLine(v);
            }
            System.Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}

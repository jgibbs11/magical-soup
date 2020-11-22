using System;

namespace praticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
                int n = Convert.ToInt16(Console.ReadLine());
            int m = 1;
            char ch = 'a';
            int e = 0;
            int g = 0;
            int b = 1;
            int c = 1;
            int total = 0;
            int j = n;

            while (m <= n)
             {
                 Console.WriteLine(m);
                 m++;
             }
            Console.WriteLine("Press Enter");
            Console.ReadLine();

             while (j >= 1)
             {
                 Console.WriteLine(j);
                 j--;
             }
            Console.WriteLine("Press Enter");
            Console.ReadLine();

            while (ch <= 'z')
             {
                 Console.WriteLine(ch);
                 ch++;
             }
            Console.WriteLine("Press Enter");
            Console.ReadLine();

            while (e <= 98)
            {
                e++;
                e++;
                Console.WriteLine(e);
                
            }
            Console.WriteLine("Press Enter");
            Console.ReadLine();

            while (c <= 100)
            {
                Console.WriteLine(c);
                c++;
                c++;
            }
            Console.WriteLine("Press Enter");
            Console.ReadLine();

            while (g <= n)
            {
                total += g;
                g++;
            }

            Console.WriteLine(total);
            Console.WriteLine("Press Enter");
            Console.ReadLine();
            
            while (b <= n)
            {  
                Console.WriteLine($"{n} * {b} = {n*b}");
                b++;
            }

            Console.ReadLine();
        }
    }
}

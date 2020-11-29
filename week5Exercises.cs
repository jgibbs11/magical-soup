using System;
using System.Threading;

namespace week5PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//exercise 1
             Console.WriteLine("Please enter in a number.");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n;)
                {
                Console.WriteLine(n);
                n--;
                }
            
            //exercise 2
            for (int practice2 = 0; practice2 <= 100;)
            {
                Console.WriteLine(practice2);
                practice2++; practice2++;
                Thread.Sleep(100);
            }
            //exercise 3
            int noOfRows = 5;
            for (int row = 1; row <= noOfRows; row++)
            {
                for (int col=1; col <=row; col++) 
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
            //exercise 4
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < 10; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }*/
            //exercise5
            int i, j, remainder;
            for (i = 1; i <= 8; i++)
            {
                if (i % 2 == 0) 
                { remainder = 1; }
                else 
                { remainder = 0; }
                for (j = 1; j <= 8; j++)
                {
                    if (j % 2 == remainder)
                    { Console.Write("O"); }
                    else { Console.Write("X"); }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Press ENTER to exit.");
            Console.ReadLine();
        }
    }
}

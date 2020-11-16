using System;

namespace MiniTrivia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a Trivia category (A)Sports, (B)Science, or (C)History");
            string category = Console.ReadLine();

            switch (category.ToUpper())
            {
                case "A":
                    {
                        Console.WriteLine("What sport involves a puck? (A) Lacrosse (B) Hockey (C) Golf");
                        string answer1A = Console.ReadLine();

                        switch (answer1A.ToUpper())
                        {
                            case "B":

                                Console.WriteLine("Correct!");
                                break;

                            default:
                                Console.WriteLine("Incorrect.");
                                break;
                        }
                    }
                    break;


                case "B":
                    Console.WriteLine("What is the molecular symbol for water? (A) H2O (B) O2 (C) CO2");
                    string answer1B = Console.ReadLine();

                    switch (answer1B.ToUpper())
                    {
                        case "A":

                            Console.WriteLine("Correct!");
                            break;

                        default:
                            Console.WriteLine("Incorrect.");
                            break;
                    }
                    break;
                case "C":
                    Console.WriteLine("Who was the first President of the U.S.A.? (A) Lincoln (B) Taft (C) Washington");
                    string answer1C = Console.ReadLine();

                    switch (answer1C.ToUpper())
                    {
                        case "C":

                            Console.WriteLine("Correct!");
                            break;

                        default:
                            Console.WriteLine("Incorrect.");
                            break;
                    }
                    break;
            }
            Console.WriteLine("Press ENTER to Exit.")
            Console.ReadLine();
        }
    }
}

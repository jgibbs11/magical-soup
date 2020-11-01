using System;

namespace VacationBudgetPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;

            userName = "John";

            string des1;

                des1 = "Mexico";

            string des2;

                des2 = "Jamaica";

            Console.WriteLine("Thank you for choosing this application please enter you user name " + userName + ".");

            Console.WriteLine("Welcome to Your Vacation Budget Planner " + userName + "!");

            Console.WriteLine("Would you like to go to " + des1 + " or " + des2 + "?");

            Console.ReadLine();

        }
    }
}

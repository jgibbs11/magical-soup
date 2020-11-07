using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace VacationBudgetPlanner
{
    class Program
    {
        static void Main(string[] args)
        {

            string des1;

                des1 = "Mexico";

            string des2;

                des2 = "Jamaica";

            Console.WriteLine("Thank you for choosing this application please enter your name ");
            string userName = Console.ReadLine();

            Console.WriteLine("Welcome to Your Vacation Budget Planner " + userName + "!");

            Console.WriteLine("Would you like to go to " + des1 + " or " + des2 + "?");

            Console.WriteLine(des2 + " is a great choice! How many days are you planning on staying?");
            double lengthOS = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How much spending money are you planning on bringing?");
            double spendingMoney = Convert.ToDouble(Console.ReadLine());

            double moneyPerDay = (spendingMoney / lengthOS);
            Console.WriteLine($"Hey {userName} you are going to {des2} for {lengthOS} days, with {String.Format("{0:C}", spendingMoney)}. You can spend {String.Format("{0:C}", moneyPerDay)} per day!");

            Console.WriteLine("Press ENTER to exit.");
            Console.ReadLine();

        }
    }
}

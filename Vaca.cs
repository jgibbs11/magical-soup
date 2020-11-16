using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace VacationBudgetPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your name ");
            string userName = Console.ReadLine();
            {
                Console.WriteLine("Welcome to Your Vacation Budget Planner " + userName + "!");

                Console.WriteLine($"Would you like to go Mexico or Jamaica?");
                string des = (Console.ReadLine());
                switch (des)
                {
                    case "Mexico":

                        Console.WriteLine($"{des} is a great choice {userName}!");
                        Console.WriteLine("*************");

                        Console.WriteLine("How many days are you planning on staying?");
                        double lengthOS = Convert.ToDouble(Console.ReadLine());
                        double lengthHr = lengthOS * 24;
                        double lengthMin = lengthHr * 60;
                        Console.WriteLine($"{lengthOS} days, {lengthHr} hours, or {lengthMin} minutes!");

                        Console.WriteLine("How much spending money are you planning on bringing?");
                        double spendingMoney = Convert.ToDouble(Console.ReadLine());
                        double pesos = spendingMoney * 20.41;
                        double pesosPerDay = pesos / lengthOS;
                        double moneyPerDay = (spendingMoney / lengthOS);

                        Console.WriteLine($"{String.Format("{0:C}", spendingMoney)} is {String.Format("{0:C}", pesos)} Pesos!");
                        Console.WriteLine($"Hey {userName} you are going to Mexico for {lengthOS} days, with {String.Format("{0:C}", spendingMoney)} or {String.Format("{0:C}", pesos)} Pesos. You can spend {String.Format("{0:C}", pesosPerDay)} Pesos per day!");
                        break;

                    case "Jamaica":

                        Console.WriteLine($"{des} is a great choice {userName}!");

                        Console.WriteLine("How many days are you planning on staying?");
                        double lengthOS1 = Convert.ToDouble(Console.ReadLine());
                        double lengthHr1 = lengthOS1 * 24;
                        double lengthMin1 = lengthHr1 * 60;
                        Console.WriteLine($"{lengthOS1} days, {lengthHr1} hours, or {lengthMin1} minutes!");

                        Console.WriteLine("How much spending money are you planning on bringing?");
                        double spendingMoney1 = Convert.ToDouble(Console.ReadLine());
                        double jmoney = spendingMoney1 * 148.14;
                        double jmoneyPerDay = jmoney / lengthOS1;
                        double moneyPerDay1 = (spendingMoney1 / lengthOS1);

                        Console.WriteLine($"Hey {userName} you are going to Jamaica for {lengthOS1} days, with {String.Format("{0:C}", spendingMoney1)} USD or {String.Format("{0:C}", jmoney)} Jamaican. You can spend {String.Format("{0:C}", moneyPerDay1)} USD, Or {String.Format("{0:C}", jmoneyPerDay)} Jamaican per day!");

                        break;
                    default:
                        Console.WriteLine("Please enter either a valid answer");
                        break;
                }
            }
            Console.WriteLine("Press ENTER to exit.");
            Console.ReadLine();

        }
    }
}

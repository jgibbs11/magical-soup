using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace VacationBudgetPlanner
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool keepGoing = true;
            int hrsPD = 24;
            int minsPD = 60;
            int count = 1;
            int tries = 3;

            Console.WriteLine("Please Create a Username.");
                string userName = Console.ReadLine();

            Console.WriteLine("Please Create a Password, Your password will be case sensitive.");
            string password = Console.ReadLine();
            string pw = password;
                {
                    Console.WriteLine($"Welcome to Your Vacation Budget Planner {userName}!");
                do
                {
                    count++;
                    Console.WriteLine($"Please enter your password, you have {tries--} tries left");
                    pw = Console.ReadLine();                  
                } while (pw != password && count<4);

                if (count>3)
                    {
                    keepGoing = false; 
                }

                while (keepGoing) 
                {
                    Console.WriteLine($"Would you like to go Mexico or Jamaica?");
                    string des = (Console.ReadLine().ToLower());
                    switch (des)
                   {
                        case "mexico":
                            Console.WriteLine($"Mexico is a great choice {userName}!");

                            Console.WriteLine("How many days are you planning on staying?");
                            double lengthOS = Convert.ToDouble(Console.ReadLine());
                            double lengthHr = lengthOS * hrsPD;
                            double lengthMin = lengthHr * minsPD;

                            Console.WriteLine($"{lengthOS} days, {lengthHr} hours, or {lengthMin} minutes!");
                            Console.WriteLine("How much spending money are you planning on bringing?");
                            double spendingMoney = Convert.ToDouble(Console.ReadLine());
                            double pesos = spendingMoney * 20.41;
                            double pesosPerDay = pesos / lengthOS;
                            double moneyPerDay = (spendingMoney / lengthOS);

                            Console.WriteLine($"{String.Format("{0:C}", spendingMoney)} is {String.Format("{0:C}", pesos)} Pesos!");
                            Console.WriteLine($"{userName} you are going to Mexico for {lengthOS} days," +
                                $" with {String.Format("{0:C}", spendingMoney)} or {String.Format("{0:C}", pesos)} Pesos." +
                                $" You can spend {String.Format("{0:C}", moneyPerDay)} per day or {String.Format("{0:C}", pesosPerDay)} Pesos per day!");
                            break;

                        case "jamaica":
                            Console.WriteLine($"Jamaica is a great choice {userName}!");
                            Console.WriteLine("How many days are you planning on staying?");
                            double lengthOS1 = Convert.ToDouble(Console.ReadLine());
                            double lengthHr1 = lengthOS1 * hrsPD;
                            double lengthMin1 = lengthHr1 * minsPD;

                            Console.WriteLine($"{lengthOS1} days, {lengthHr1} hours, or {lengthMin1} minutes!");
                            Console.WriteLine("How much spending money are you planning on bringing?");
                            double spendingMoney1 = Convert.ToDouble(Console.ReadLine());
                            double jmoney = spendingMoney1 * 148.14;
                            double jmoneyPerDay = jmoney / lengthOS1;
                            double moneyPerDay1 = (spendingMoney1 / lengthOS1);

                            Console.WriteLine($"{userName} you are going to Jamaica for {lengthOS1} days," +
                                $" with {String.Format("{0:C}", spendingMoney1)} USD or {String.Format("{0:C}", jmoney)} Jamaican." +
                                $" You can spend {String.Format("{0:C}", moneyPerDay1)} USD, Or {String.Format("{0:C}", jmoneyPerDay)} Jamaican per day!");
                            break;
                        default:
                            Console.WriteLine("Please enter either a valid answer");
                            break;
                    }
                Console.WriteLine("would you like to run the application again? y or n");
                string answer = Console.ReadLine().ToLower();
                    if (answer == "n")
                    {
                        keepGoing = false;
                    }
                }
                }

            Console.WriteLine("Press ENTER to exit.");
            Console.ReadLine();

        }
    }
}

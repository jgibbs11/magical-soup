using System;
using System.Transactions;

namespace calculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Temp
            Console.WriteLine("Please enter the the Tempurature in Fahrenheit");
            int temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(temp + " degrees Fahrenheit is " + (((temp - 32) * 5) / 9) + " degrees Celsius!");
            Console.WriteLine("Press Enter to proceed");
            Console.ReadLine();
            
            //Total
            Console.WriteLine("Please enter the price for the item you wish to purchase.");
            double p1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the sales tax amount for said item.");
            double t1 = Convert.ToDouble(Console.ReadLine());
            double tot = p1 + t1;
            Console.WriteLine("Your Total purchase will be " + String.Format("{0:C}", tot));
            Console.WriteLine("Press Enter to proceed");
            Console.ReadLine();

            //Tip
            Console.WriteLine("Enter your total bill");
            Double bill = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the % you would like to tip");
            Double per = Convert.ToDouble(Console.ReadLine());
            Double tip = (per / 100);
            Double tipMoney = Math.Round((bill*tip), 2);
            Console.WriteLine("Your " + per + "% tip equals $" + tipMoney);
            Console.WriteLine("Press Enter to proceed");
            Console.ReadLine();

            //Divide
            Console.WriteLine("Enter you total bill");
            double total2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many people are in your party?");
            double party = Convert.ToDouble(Console.ReadLine());
            double pay = (total2 / party);
            Console.WriteLine("Each person should contribute " + String.Format("{0:C}", pay));

            Console.WriteLine("PRESS ENTER to EXIT");
            Console.ReadLine();
        }
    }
}
